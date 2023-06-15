using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TelaAtualizarItensForm : Form
    {
        public TelaAtualizarItensForm(Tema tema)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            ConfigurarForm(tema);
        }

        private void ConfigurarForm(Tema tema)
        {
            txtId.Text = tema.Id.ToString();
            txtTema.Text = tema.Nome;

            int i = 0;
            foreach (ItemTema item in tema.Itens)
            {
                checkedListBox.Items.Add(item);

                if (item.Marcado)
                    checkedListBox.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTema> ObterItensMarcados()
        {
            return checkedListBox.CheckedItems.Cast<ItemTema>().ToList();
        }

        public List<ItemTema> ObterItensDesmarcados()
        {
            return checkedListBox.Items.Cast<ItemTema>().Except(ObterItensMarcados()).ToList();
        }
    }
}
