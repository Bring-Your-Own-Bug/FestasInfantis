namespace FestasInfantis.Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : EntidadeBase<T>
    {
        void Inserir(T entidade);
        void Editar(int id, T entidade);
        void Excluir(T entidade);
        T SelecionarPorId(int id);
        List<T> SelecionarTodos();
    }
}
