namespace FestasInfantis.Dominio.ModuloCliente
{
    public interface IRepositorioCliente
    {
        void Inserir(Cliente cliente);
        void Editar(int id, Cliente cliente);
        void Excluir(Cliente cliente);
        Cliente SelecionarPorId(int id);
        List<Cliente> SelecionarTodos();
    }
}
