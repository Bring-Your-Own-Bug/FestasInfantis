using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        private readonly IRepositorioFesta _repositorioFesta;
        private readonly IRepositorioTema _repositorioTema;
        private TabelaFestaControl _tabelaFesta;

        public ControladorFesta(IRepositorioFesta repositorioFesta, IRepositorioTema repositorioTema)
        {
            _repositorioFesta = repositorioFesta;
            _repositorioTema = repositorioTema;
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
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
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
    }
}
