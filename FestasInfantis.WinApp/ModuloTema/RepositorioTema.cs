namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTema : RepositorioBase<Tema>, IRepositorioTema
    {
        public RepositorioTema(List<Tema> temas)
        {
            listaRegistros = temas;
        }
    }
}
