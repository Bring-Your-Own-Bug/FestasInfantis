using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class TelaFestaForm : Form
    {
        public TelaFestaForm(List<Tema> temas)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarTemas(temas);
        }

        public Festa ObterFesta()
        {
            int id = Convert.ToInt32(txtId.Text);

            Tema tema = cmbTema.SelectedItem as Tema;

            DateTime data = dtpInicio.Value;

            TimeSpan horarioInicio = dtpInicio.Value.TimeOfDay;

            TimeSpan horarioFinal = dtpFinal.Value.TimeOfDay;

            Endereco endereco = ObterEndereco();

            Festa festa = new(tema, data, horarioInicio, horarioFinal, endereco);

            if (id > 0)
                festa.Id = id;

            return festa;
        }

        public void ConfigurarForm(Festa festaSelecionada)
        {
            txtId.Text = festaSelecionada.Id.ToString();
            dtpInicio.Value = DateTime.Now.Date.Add(festaSelecionada.HorarioInicio);
            dtpFinal.Value = DateTime.Now.Date.Add(festaSelecionada.HorarioFinal);
            txtRua.Text = festaSelecionada.Endereco.Rua;
            txtNumero.Text = festaSelecionada.Endereco.Numero.ToString();
            txtBairro.Text = festaSelecionada.Endereco.Bairro;
            txtCidade.Text = festaSelecionada.Endereco.Cidade;
            txtEstado.Text = festaSelecionada.Endereco.Estado;

            if (festaSelecionada.Tema != null)
                cmbTema.SelectedItem = festaSelecionada.Tema;
        }

        private void CarregarTemas(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                cmbTema.Items.Add(tema);
            }
        }

        private Endereco ObterEndereco()
        {
            return new Endereco(txtRua.Text,
                string.IsNullOrWhiteSpace(txtNumero.Text) ? 0 : Convert.ToInt32(txtNumero.Text),
                txtBairro.Text,
                txtCidade.Text,
                txtEstado.Text);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Festa festa = ObterFesta();

            List<string> erros = festa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
