using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {

        public TelaClienteForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtNome.Text;

            string telefone = mtbTelefone.Text;

            Cliente cliente = new(nome, telefone);

            if (id > 0)
                cliente.Id = id;

            return cliente;
        }

        public void ConfigurarForm(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.Id.ToString();
            txtNome.Text = clienteSelecionado.Nome;
            mtbTelefone.Text = clienteSelecionado.Telefone.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            List<string> erros = cliente.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
