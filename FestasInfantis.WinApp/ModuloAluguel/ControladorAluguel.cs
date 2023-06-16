using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private readonly IRepositorioAluguel _repositorioAluguel;
        private readonly IRepositorioFesta _repositorioFesta;
        private readonly IRepositorioCliente _repositorioCliente;
        private TabelaAluguelControl _tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioFesta repositorioFesta, IRepositorioCliente repositorioCliente)
        {
            _repositorioAluguel = repositorioAluguel;
            _repositorioFesta = repositorioFesta;
            _repositorioCliente = repositorioCliente;
        }

        public override string ToolTipInserir => "Inserir Novo Aluguel";
        public override string ToolTipEditar => "Editar Aluguel Existente";
        public override string ToolTipExcluir => "Excluir Aluguel Existente";

        public override void Inserir()
        {
            List<Festa> festas = _repositorioFesta.SelecionarTodos();
            List<Cliente> clientes = _repositorioCliente.SelecionarTodos();
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
            List<Cliente> clientes = _repositorioCliente.SelecionarTodos();
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
