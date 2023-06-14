namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioTema _repositorioTema;
        public ControladorTema(IRepositorioTema repositorioTema)
        {

            _repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir Novo Tema";

        public override string ToolTipEditar => "Editar Tema Existente";

        public override string ToolTipExcluir => "Excluir Tema Existente";

        public override void Inserir()
        {
            throw new NotImplementedException();
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
            return "Cadastro de Tema";
        }

        public override UserControl ObterGrid()
        {
            throw new NotImplementedException();
        }
    }
}
