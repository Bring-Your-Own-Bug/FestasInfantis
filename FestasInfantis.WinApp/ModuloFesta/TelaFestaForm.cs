using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        public TelaFestaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Festa ObterFesta()
        {
            return new Festa(
                cmbTema.SelectedItem as Tema,
                dtpInicio.Value,
                dtpInicio.Value.TimeOfDay,
                dtpFinal.Value.TimeOfDay,
                ObterEndereco())
            {
                Id = string.IsNullOrWhiteSpace(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text)
            };
        }

        private Endereco ObterEndereco()
        {
            return new Endereco(txtRua.Text,
                string.IsNullOrWhiteSpace(txtNumero.Text) ? 0 : Convert.ToInt32(txtNumero.Text),
                txtBairro.Text,
                txtCidade.Text,
                txtEstado.Text);
        }
    }
}
