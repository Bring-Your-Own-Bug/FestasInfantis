using FestasInfantis.Dominio.ModuloTema;

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

            if (string.IsNullOrWhiteSpace(txtValor.Text))
                txtValor.Text = "0";

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
            txtValor.Text = temaSelecionado.ValorTotal.ToString();
        }

        private void txtValor_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Utils.FormatarTxtNumerica(sender, e);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            List<string> erros = new();

            erros.AddRange(ObterTema().Validar());

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
    }
}
