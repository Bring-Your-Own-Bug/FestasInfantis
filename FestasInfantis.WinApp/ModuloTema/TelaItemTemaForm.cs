using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaItemTemaForm : Form
    {
        public TelaItemTemaForm(Tema tema)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarForm(tema);
        }

        private void ConfigurarForm(Tema tema)
        {
            txtId.Text = tema.Id.ToString();
            txtTema.Text = tema.Nome;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Adicione pelo menos um nome ao item!", "Adição de itens",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtItem.Text;

            if (string.IsNullOrWhiteSpace(txtValor.Text))
                txtValor.Text = "0";

            decimal valor = Convert.ToDecimal(txtValor.Text);

            ItemTema itemTema = new(nome, valor);

            if (listaItens.Items.Contains(itemTema))
            {
                TelaPrincipalForm.Instancia.AtualizarRodape("Não é possível adicionar itens iguais");
                return;
            }

            listaItens.Items.Add(itemTema);

            txtItem.Text = "";
            txtValor.Text = "";
            txtItem.Focus();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.FormatarTxtNumericaDecimal(sender, e);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listaItens.SelectedItem != null)
                listaItens.Items.Remove(listaItens.SelectedItem);

            txtItem.Text = "";
            txtValor.Text = "";
        }

        public List<ItemTema> ObterItemRegistrado()
        {
            return listaItens.Items.Cast<ItemTema>().ToList();
        }
    }
}
