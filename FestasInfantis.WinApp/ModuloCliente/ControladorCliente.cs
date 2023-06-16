using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    internal class ControladorCliente : ControladorBase
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private TabelaClienteControl _tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente)
        {
            this._repositorioCliente = repositorioCliente;
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

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
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
    }
}
