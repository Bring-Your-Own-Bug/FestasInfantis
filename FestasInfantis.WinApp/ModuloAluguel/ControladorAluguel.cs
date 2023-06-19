using FestasInfantis.Dominio.Compartilhado;
using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private readonly IRepositorio<Aluguel> _repositorioAluguel;
        private readonly IRepositorio<Festa> _repositorioFesta;
        private readonly IRepositorio<Cliente> _repositorioCliente;
        private TabelaAluguelControl _tabelaAluguel;

        public ControladorAluguel(IRepositorio<Aluguel> repositorioAluguel, IRepositorio<Festa> repositorioFesta, IRepositorio<Cliente> repositorioCliente)
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
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                if (_repositorioAluguel.SelecionarTodos().Any(a => string.Equals(a.Cliente.Nome, aluguel.Cliente.Nome, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Este cliente já tem um aluguel reservado!",
                        "Cadastro de Aluguel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                if (_repositorioAluguel.SelecionarTodos().Any(a => string.Equals(a.Festa.Nome, aluguel.Festa.Nome, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Esta festa já está em um aluguel reservado!",
                        "Cadastro de Aluguel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _repositorioAluguel.Inserir(aluguel);
            }

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
