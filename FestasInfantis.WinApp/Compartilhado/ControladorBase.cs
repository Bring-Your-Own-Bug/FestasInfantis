namespace FestasInfantis.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }
        public virtual string ToolTipAdicionarItem { get; }
        public virtual string ToolTipMarcarItem { get; }

        public virtual bool EhInserirHabilitado => true;
        public virtual bool EhEditarHabilitado => true;
        public virtual bool EhExcluirHabilitado => true;

        public virtual bool EhAdicionarItem => false;
        public virtual bool EhMarcarItem => false;

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void AdicionarItem()
        {
        }

        public virtual void EscolherItens()
        {
        }

        public abstract UserControl ObterUserControl();

        public abstract string ObterTipoCadastro();
    }
}
