namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Tema ObterTema()
        {
            int id = Convert.ToInt32(txtId.Text);

            string nome = txtTema.Text;

            decimal valor = Math.Round(Convert.ToDecimal(txtValor.Text), 2);

            Tema tema = new(nome, valor);

            if (id > 0)
                tema.Id = id;

            return tema;
        }

        public void ConfigurarForm(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.Id.ToString();
            txtTema.Text = temaSelecionado.Nome;
            mtbValor.Text = temaSelecionado.ValorTotal.ToString();
        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}
