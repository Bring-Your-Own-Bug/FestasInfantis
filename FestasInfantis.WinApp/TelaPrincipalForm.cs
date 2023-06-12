namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm _telaPrincipal;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            _telaPrincipal = this;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                return _telaPrincipal ??= new TelaPrincipalForm();
            }
        }
    }
}