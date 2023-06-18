using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        private readonly IRepositorio<Festa> _repositorioFesta;
        private readonly IRepositorio<Tema> _repositorioTema;
        private readonly IRepositorio<Aluguel> _repositorioAluguel;
        private TabelaFestaControl _tabelaFesta;

        public ControladorFesta(IRepositorio<Festa> repositorioFesta, IRepositorio<Tema> repositorioTema, IRepositorio<Aluguel> repositorioAluguel)
        {
            _repositorioFesta = repositorioFesta;
            _repositorioTema = repositorioTema;
            _repositorioAluguel = repositorioAluguel;
        }

        public override string ToolTipInserir => "Inserir Nova Festa";
        public override string ToolTipEditar => "Editar Festa Existente";
        public override string ToolTipExcluir => "Excluir Festa Existente";

        public override void Inserir()
        {
            List<Tema> temas = _repositorioTema.SelecionarTodos();
            TelaFestaForm telaFesta = new(temas);

            if (telaFesta.ShowDialog() == DialogResult.OK)
                _repositorioFesta.Inserir(telaFesta.ObterFesta());

            CarregarFestas();
        }

        public override void Editar()
        {
            Festa festaSelecionada = ObterFestaSelecionada();

            if (festaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma festa primeiro!",
                    "Edição de Festas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            List<Tema> temas = _repositorioTema.SelecionarTodos();
            TelaFestaForm telaFesta = new(temas);
            telaFesta.ConfigurarForm(festaSelecionada);

            if (telaFesta.ShowDialog() == DialogResult.OK)
                _repositorioFesta.Editar(telaFesta.ObterFesta().Id, telaFesta.ObterFesta());

            CarregarFestas();
        }

        public override void Excluir()
        {
            Festa festaSelecionada = ObterFestaSelecionada();

            List<Aluguel> alugueis = _repositorioAluguel.SelecionarTodos();

            if (festaSelecionada == null)
            {
                MessageBox.Show($"Selecione uma festa primeiro!",
                    "Exclusão de Festas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (FestaTemAluguel(festaSelecionada, alugueis))
            {
                MessageBox.Show($"A festa \"{festaSelecionada.Nome}\" tem um aluguel reservado!\n" +
                    $"Delete o aluguel da festa \"{festaSelecionada.Nome}\" antes de excluí-la",
                    "Exclusão de Festas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show($"Deseja excluir a festa {festaSelecionada.Tema.Nome}?", "Exclusão de Festas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _repositorioFesta.Excluir(festaSelecionada);

            CarregarFestas();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Festa";
        }

        public override UserControl ObterUserControl()
        {
            _tabelaFesta ??= new TabelaFestaControl();
            CarregarFestas();
            return _tabelaFesta;
        }

        public void CarregarFestas()
        {
            List<Festa> festas = _repositorioFesta.SelecionarTodos();
            _tabelaFesta.AtualizarRegistros(festas);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {festas.Count} festa(s)");
        }

        private Festa ObterFestaSelecionada()
        {
            return _repositorioFesta.SelecionarPorId(_tabelaFesta.ObterIdSelecionado());
        }

        private static bool FestaTemAluguel(Festa festaSelecionada, List<Aluguel> alugueis)
        {
            return alugueis.Exists(aluguel => aluguel.Festa != null && aluguel.Festa == festaSelecionada);
        }
    }
}
