namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema _repositorioTema;
        private TabelaTemaControl _tabelaTema;
        public ControladorTema(IRepositorioTema repositorioTema)
        {
            _repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir Novo Tema";

        public override string ToolTipEditar => "Editar Tema Existente";

        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override void Inserir()
        {
            TelaTemaForm telaTema = new();

            DialogResult dialogResult = telaTema.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                _repositorioTema.Inserir(tema);

                CarregarTemas();
            }
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void AdicionarItem()
        {
            base.AdicionarItem();
        }

        public override void DefinirValor()
        {
            base.DefinirValor();
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

            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {temas.Count} tarefa(s)");
        }
    }
}
