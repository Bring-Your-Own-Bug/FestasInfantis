using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm(List<Festa> festas, List<Cliente> clientes)
        {
            InitializeComponent();
        }
    }
}
