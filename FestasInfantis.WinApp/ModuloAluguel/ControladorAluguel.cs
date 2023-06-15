using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        List<Cliente> clientesTeste = new List<Cliente>();
        private readonly IRepositorioAluguel _repositorioAluguel;
        private readonly IRepositorioFesta _repositorioFesta;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioFesta repositorioFesta)
        {
            _repositorioAluguel = repositorioAluguel;
            _repositorioFesta = repositorioFesta;
            Cliente cliente1 = new Cliente("Rafael", "(51) 99661-6240", true);
            Cliente cliente2 = new Cliente("Agatha", "(51) 99999-9999", false);
            clientesTeste.Add(cliente1);
            clientesTeste.Add(cliente2);
        }

        public override string ToolTipInserir => "Inserir Novo Aluguel";
        public override string ToolTipEditar => "Editar Aluguel Existente";
        public override string ToolTipExcluir => "Excluir Aluguel Existente";

        public override void Inserir()
        {
            List<Festa> festas = _repositorioFesta.SelecionarTodos();
            List<Cliente> clientes = clientesTeste;
            TelaAluguelForm telaAluguel = new(festas, clientes);

            if (telaAluguel.ShowDialog() == DialogResult.OK)
                _repositorioAluguel.Inserir(telaAluguel.ObterAluguel());

            CarregarAlugueis();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override string ObterTipoCadastro()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterUserControl()
        {
            throw new NotImplementedException();
        }

        public void CarregarFestas()
        {
            List<Aluguel> alugueis = _repositorioAluguel.SelecionarTodos();
            _tabelaAluguel.AtualizarRegistros(alugueis);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} festa(s)");
        }
    }
}
