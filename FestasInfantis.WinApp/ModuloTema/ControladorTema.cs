using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private readonly IRepositorioTema _repositorioTema;
        private TabelaTemaControl _tabelaTema;
        public ControladorTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir Novo Tema";
        public override string ToolTipEditar => "Editar Tema Existente";
        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override string ToolTipAdicionarItem => "Adicionar Itens no Tema";
        public override string ToolTipMarcarItem => "Marcar/Desmarcar Itens no Tema";

        public override bool EhAdicionarItem => true;
        public override bool EhMarcarItem => true;

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

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
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

                decimal varAux = 0;

                foreach (ItemTema item in itensMarcados)
                {
                    if (!estadosAnteriores[item])
                    {
                        temaSelecionado.MarcarItem(item);
                        varAux += item.Valor;
                    }
                }

                foreach (ItemTema item in itensDesmarcados)
                {
                    if (estadosAnteriores[item])
                    {
                        temaSelecionado.DesmarcarItem(item);
                        varAux -= item.Valor;
                    }
                }

                temaSelecionado.ValorTotal += varAux;

                _repositorioTema.Editar(temaSelecionado.Id, temaSelecionado);
            }

            CarregarTemas();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tema";
        }

        private Tema ObterTemaSelecionado()
        {
            return _repositorioTema.SelecionarPorId(_tabelaTema.ObterIdSelecionado());
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
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {temas.Count} tarefa(s)");
        }
    }
}
