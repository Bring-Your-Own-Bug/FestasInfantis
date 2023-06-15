using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        private readonly IRepositorioFesta _repositorioFesta;

        public ControladorFesta(IRepositorioFesta repositorioFesta)
        {
            _repositorioFesta = repositorioFesta;
        }

        public override string ToolTipInserir => throw new NotImplementedException();
        public override string ToolTipEditar => throw new NotImplementedException();
        public override string ToolTipExcluir => throw new NotImplementedException();

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterUserControl()
        {
            throw new NotImplementedException();
        }
    }
}
