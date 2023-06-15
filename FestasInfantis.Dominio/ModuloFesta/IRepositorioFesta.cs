namespace FestasInfantis.Dominio.ModuloFesta
{
    public interface IRepositorioFesta
    {
        void Inserir(Festa festa);
        void Editar(int id, Festa festa);
        void Excluir(Festa festa);
        Festa SelecionarPorId(int id);
        List<Festa> SelecionarTodos();
    }
}
