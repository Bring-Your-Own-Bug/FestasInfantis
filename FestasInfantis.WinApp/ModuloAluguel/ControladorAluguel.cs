using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;
using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.WinApp.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        List<Cliente> clientesTeste = new List<Cliente>();
        private readonly IRepositorioAluguel _repositorioAluguel;
        private readonly IRepositorioFesta _repositorioFesta;
        private TabelaAluguelControl _tabelaAluguel;

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
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Edição de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            List<Festa> festas = _repositorioFesta.SelecionarTodos();
            List<Cliente> clientes = clientesTeste;
            TelaAluguelForm telaAluguel = new(festas, clientes);
            telaAluguel.ConfigurarForm(aluguelSelecionado);

            if (telaAluguel.ShowDialog() == DialogResult.OK)
                _repositorioAluguel.Editar(telaAluguel.ObterAluguel().Id, telaAluguel.ObterAluguel());

            CarregarAlugueis();
        }

        public override void Excluir()
        {
            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                MessageBox.Show($"Selecione um aluguel primeiro!",
                    "Exclusão de Alugueis",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show($"Deseja excluir o aluguel do cliente {aluguelSelecionado.Cliente.Nome}?",
                "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _repositorioAluguel.Excluir(aluguelSelecionado);

            CarregarAlugueis();
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Alugueis";
        }

        public override UserControl ObterUserControl()
        {
            _tabelaAluguel ??= new TabelaAluguelControl();
            CarregarAlugueis();
            return _tabelaAluguel;
        }

        public void CarregarAlugueis()
        {
            List<Aluguel> alugueis = _repositorioAluguel.SelecionarTodos();
            _tabelaAluguel.AtualizarRegistros(alugueis);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} aluguel(s)");
        }

        private Aluguel ObterAluguelSelecionado()
        {
            return _repositorioAluguel.SelecionarPorId(_tabelaAluguel.ObterIdSelecionado());
        }
    }
}
