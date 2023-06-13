namespace FestasInfantis.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }

        public virtual bool EhInserirHabilitado => true;
        public virtual bool EhEditarHabilitado => true;
        public virtual bool EhExcluirHabilitado => true;

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract string ObterTipoCadastro();
    }
}
