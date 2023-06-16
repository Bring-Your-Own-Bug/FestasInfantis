using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class ListaClienteControl : UserControl
    {
        public ListaClienteControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            listCliente.Items.Clear();

            listCliente.Items.AddRange(clientes.ToArray());
        }

        public Cliente ObterClienteSelecionado()
        {
            return listCliente.SelectedItem as Cliente;
        }
    }
}
