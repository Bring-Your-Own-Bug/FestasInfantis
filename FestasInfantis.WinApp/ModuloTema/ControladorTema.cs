using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private readonly IRepositorio<Tema> _repositorioTema;
        private readonly IRepositorio<Festa> _repositorioFesta;
        private TabelaTemaControl _tabelaTema;
        public ControladorTema(IRepositorio<Tema> repositorioTema, IRepositorio<Festa> repositorioFesta)
        {
            _repositorioTema = repositorioTema;
            _repositorioFesta = repositorioFesta;
        }

        public override string ToolTipInserir => "Inserir Novo Tema";
        public override string ToolTipEditar => "Editar Tema Existente";
        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override string ToolTipAdicionarItem => "Adicionar Itens no Tema";
        public override string ToolTipMarcarItem => "Marcar/Desmarcar Itens no Tema";

        public override bool EhAdicionarItemHabilitado => true;
        public override bool EhMarcarItemHabilitado => true;

        public override void Inserir()
        {
            TelaTemaForm telaTema = new();

            if (telaTema.ShowDialog() == DialogResult.OK)
                _repositorioTema.Inserir(telaTema.ObterTema());

            CarregarTemas();
        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            TelaTemaForm telaTema = new();
            telaTema.ConfigurarForm(temaSelecionado);

            if (telaTema.ShowDialog() == DialogResult.OK)
                _repositorioTema.Editar(telaTema.ObterTema().Id, telaTema.ObterTema());

            CarregarTemas();
        }

        public override void Excluir()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            List<Festa> festas = _repositorioFesta.SelecionarTodos();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (TemaTemFesta(temaSelecionado, festas))
            {
                string? nomeFestaSelecionada = festas.FirstOrDefault(festa => festa.Tema != null && festa.Tema == temaSelecionado)?.Nome;

                MessageBox.Show($"O tema \"{temaSelecionado.Nome}\" faz parte da festa \"{nomeFestaSelecionada}\"!\nExclua a festa" +
                    $" \"{nomeFestaSelecionada}\" antes de excluir o tema \"{temaSelecionado.Nome}\"",
                    "Exclusão de Temas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Deseja excluir o tema {temaSelecionado.Nome}?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _repositorioTema.Excluir(temaSelecionado);

            CarregarTemas();
        }

        public override void AdicionarItem()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Itens do Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            TelaItemTemaForm telaItemTema = new(temaSelecionado);

            if (telaItemTema.ShowDialog() == DialogResult.OK)
            {
                List<ItemTema> itensParaAdd = telaItemTema.ObterItemRegistrado();

                foreach (ItemTema item in itensParaAdd)
                {
                    temaSelecionado.AdicionarItem(item);
                    temaSelecionado.ValorTotal += item.Valor;
                }

                _repositorioTema.Editar(temaSelecionado.Id, temaSelecionado);
            }

            CarregarTemas();
        }

        public override void EscolherItens()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show("Selecione um tema primeiro!",
                    "Itens do Tema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            TelaAtualizarItensForm telaAtualizarItens = new(temaSelecionado);

            if (telaAtualizarItens.ShowDialog() == DialogResult.OK)
            {
                List<ItemTema> itensMarcados = telaAtualizarItens.ObterItensMarcados();
                List<ItemTema> itensDesmarcados = telaAtualizarItens.ObterItensDesmarcados();

                Dictionary<ItemTema, bool> estadosAnteriores = temaSelecionado.Itens.ToDictionary(item => item, item => item.Marcado);

                foreach (ItemTema item in itensMarcados)
                {
                    if (!estadosAnteriores[item])
                    {
                        temaSelecionado.MarcarItem(item);
                        temaSelecionado.ValorTotal += item.Valor;
                    }
                }

                foreach (ItemTema item in itensDesmarcados)
                {
                    if (estadosAnteriores[item])
                    {
                        temaSelecionado.DesmarcarItem(item);
                        temaSelecionado.ValorTotal -= item.Valor;
                    }
                }

                _repositorioTema.Editar(temaSelecionado.Id, temaSelecionado);
            }

            CarregarTemas();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tema";
        }

        public override UserControl ObterUserControl()
        {
            _tabelaTema ??= new TabelaTemaControl();
            CarregarTemas();
            return _tabelaTema;
        }

        public void CarregarTemas()
        {
            List<Tema> temas = _repositorioTema.SelecionarTodos();
            _tabelaTema.AtualizarRegistros(temas);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {temas.Count} tema(s)");
        }

        private Tema ObterTemaSelecionado()
        {
            return _repositorioTema.SelecionarPorId(_tabelaTema.ObterIdSelecionado());
        }

        private static bool TemaTemFesta(Tema temaSelecionado, List<Festa> festas)
        {
            return festas.Exists(festa => festa.Tema != null && festa.Tema == temaSelecionado);
        }
    }
}
