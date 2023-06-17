using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm(List<Festa> festas, List<Cliente> clientes)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarFestas(festas);
            CarregarClientes(clientes);
            CarregarStatusPagamento();
        }

        public Aluguel ObterAluguel()
        {
            int id = Convert.ToInt32(txtId.Text);

            Festa festa = cmbFesta.SelectedItem as Festa;

            Cliente cliente = cmbCliente.SelectedItem as Cliente;

            if (string.IsNullOrWhiteSpace(txtValor.Text))
                txtValor.Text = "0";

            decimal valorAluguel = Math.Round(Convert.ToDecimal(txtValor.Text), 2);

            decimal valorTotal = 0;

            DateTime data = DateTime.Now;

            if (festa != null)
            {
                valorTotal = valorAluguel + festa.Tema.ValorTotal;
                data = festa.Data;
            }

            StatusPagamento? status;

            if (cmbStatus.SelectedItem != null)
                status = (StatusPagamento?)cmbStatus.SelectedItem;
            else status = null;

            Aluguel aluguel = new(festa, cliente, valorAluguel, valorTotal, status, data);

            if (id > 0)
                aluguel.Id = id;

            return aluguel;
        }

        public void ConfigurarForm(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.Id.ToString();
            cmbFesta.SelectedItem = aluguelSelecionado.Festa;
            cmbCliente.SelectedItem = aluguelSelecionado.Cliente;
            txtValor.Text = aluguelSelecionado.ValorAluguel.ToString();
            cmbStatus.SelectedItem = aluguelSelecionado.Status;
        }

        private void CarregarClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cmbCliente.Items.Add(cliente);
            }
        }

        private void CarregarFestas(List<Festa> festas)
        {
            foreach (Festa festa in festas)
            {
                cmbFesta.Items.Add(festa);
            }
        }

        private void CarregarStatusPagamento()
        {
            StatusPagamento[] statusPagamentos = Enum.GetValues<StatusPagamento>();

            foreach (StatusPagamento status in statusPagamentos)
            {
                cmbStatus.Items.Add(status);
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.FormatarTxtNumerica(sender, e);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<string> erros = new();

            erros.AddRange(ObterAluguel().Validar());

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
