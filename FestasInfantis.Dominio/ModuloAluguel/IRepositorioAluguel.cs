namespace FestasInfantis.Dominio.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Inserir(Aluguel aluguel);
        void Editar(int id, Aluguel aluguel);
        void Excluir(Aluguel aluguel);
        Aluguel SelecionarPorId(int id);
        List<Aluguel> SelecionarTodos();
    }
}
