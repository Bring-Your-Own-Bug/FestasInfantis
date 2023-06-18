using FestasInfantis.Dominio.ModuloAluguel;
using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    internal class ControladorCliente : ControladorBase
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioAluguel _repositorioAluguel;
        private TabelaClienteControl _tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente, IRepositorioAluguel repositorioAluguel)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioAluguel = repositorioAluguel;
        }

        public override string ToolTipInserir => "Inserir Novo Cliente";
        public override string ToolTipEditar => "Editar Cliente Existente";
        public override string ToolTipExcluir => "Excluir Cliente Existente";

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new();

            if (telaCliente.ShowDialog() == DialogResult.OK)
                _repositorioCliente.Inserir(telaCliente.ObterCliente());

            CarregarClientes();
        }

        public override void Editar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            TelaClienteForm telaCliente = new();
            telaCliente.ConfigurarForm(clienteSelecionado);

            if (telaCliente.ShowDialog() == DialogResult.OK)
                _repositorioCliente.Editar(telaCliente.ObterCliente().Id, telaCliente.ObterCliente());

            CarregarClientes();
        }

        public override void Excluir()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            List<Aluguel> alugueis = _repositorioAluguel.SelecionarTodos();

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            if (ClienteTemAluguel(clienteSelecionado, alugueis))
            {
                MessageBox.Show($"O cliente \"{clienteSelecionado.Nome}\" tem um aluguel reservado!\n" +
                    $"Delete o aluguel do cliente \"{clienteSelecionado.Nome}\" antes de excluí-lo",
                    "Exclusão de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Deseja excluir o cliente {clienteSelecionado.Nome}?", "Exclusão de Clientes",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                _repositorioCliente.Excluir(clienteSelecionado);

            CarregarClientes();
        }

        public override UserControl ObterUserControl()
        {
            _tabelaCliente ??= new TabelaClienteControl();
            CarregarClientes();
            return _tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Cliente";
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = _repositorioCliente.SelecionarTodos();
            _tabelaCliente.AtualizarRegistros(clientes);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {clientes.Count} cliente(s)");
        }

        private Cliente ObterClienteSelecionado()
        {
            return _repositorioCliente.SelecionarPorId(_tabelaCliente.ObterIdSelecionado());
        }

        private static bool ClienteTemAluguel(Cliente clienteSelecionado, List<Aluguel> alugueis)
        {
            return alugueis.Exists(aluguel => aluguel.Cliente != null && aluguel.Cliente == clienteSelecionado);
        }
    }
}
