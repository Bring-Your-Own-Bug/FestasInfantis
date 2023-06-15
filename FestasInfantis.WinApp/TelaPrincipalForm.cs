using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.Infra.Dados.Arquivo.Compartilhado;
using FestasInfantis.Infra.Dados.Arquivo.ModuloFesta;
using FestasInfantis.Infra.Dados.Arquivo.ModuloTema;
using FestasInfantis.WinApp.ModuloFesta;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        private ControladorBase _controlador;

        private static ContextoDados _contextoDados = new(carregarDados: true);

        private readonly IRepositorioTema _repositorioTema = new RepositorioTemaEmArquivo(_contextoDados);
        private readonly IRepositorioFesta _repositorioFesta = new RepositorioFestaEmArquivo(_contextoDados);

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
            _controlador = new ControladorFesta(_repositorioFesta, _repositorioTema);

            ConfigurarTelaPrincipal(_controlador);
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

            ConfigurarToolTips(controladorBase);

            ConfigurarStatusBotoes(controladorBase);

            ConfigurarUserControl(controladorBase);
        }

        private void ConfigurarUserControl(ControladorBase controladorBase)
        {
            UserControl userControl = controladorBase.ObterUserControl();

            userControl.Dock = DockStyle.Fill;

            painelRegistros.Controls.Clear();

            painelRegistros.Controls.Add(userControl);
        }

        private void ConfigurarToolTips(ControladorBase controladorBase)
        {
            btnInserir.ToolTipText = controladorBase.ToolTipInserir;
            btnEditar.ToolTipText = controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = controladorBase.ToolTipExcluir;
            btnAdicionarItem.ToolTipText = controladorBase.ToolTipAdicionarItem;
            btnMarcarItem.ToolTipText = controladorBase.ToolTipMarcarItem;
        }

        private void ConfigurarStatusBotoes(ControladorBase controladorBase)
        {
            btnInserir.Enabled = controladorBase.EhInserirHabilitado;
            btnEditar.Enabled = controladorBase.EhEditarHabilitado;
            btnExcluir.Enabled = controladorBase.EhExcluirHabilitado;
            btnAdicionarItem.Enabled = controladorBase.EhAdicionarItemHabilitado;
            btnMarcarItem.Enabled = controladorBase.EhMarcarItemHabilitado;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            _controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _controlador.Excluir();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            _controlador.AdicionarItem();
        }

        private void btnDefinirValor_Click(object sender, EventArgs e)
        {
            _controlador.EscolherItens();
        }
    }
}