using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            _controlador = new ControladorTema(_repositorioTema);

            ConfigurarTelaPrincipal(_controlador);
        }

        public void AtualizarRodape(string texto)
        {
            lblRodape.Text = texto;
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            lblTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolbar(controladorBase);
        }

        private void ConfigurarToolbar(ControladorBase controladorBase)
        {
            toolbar.Enabled = true;

            //ConfigurarToolTips(controladorBase);

            //SetButtonStatus(controladorBase);
        }

        private void ConfigurarToolTips(ControladorBase controladorBase)
        {
            btnInserir.ToolTipText = controladorBase.ToolTipInserir;
            btnEditar.ToolTipText = controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = controladorBase.ToolTipExcluir;
        }
    }
}