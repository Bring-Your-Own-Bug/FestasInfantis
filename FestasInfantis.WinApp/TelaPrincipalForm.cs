using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase _controlador;

        private readonly IRepositorioTema _repositorioTema = new RepositorioTema(new List<Tema>());

        private static TelaPrincipalForm _telaPrincipal;
        public TelaPrincipalForm()
        {
            InitializeComponent();

            lblTipoCadastro.Text = "";

            lblRodape.Text = "Bem-Vindo(a) ao Controle de Festas";

            _telaPrincipal = this;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                return _telaPrincipal ??= new TelaPrincipalForm();
            }
        }

        private void clienteMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void festaMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aluguelMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temaMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}