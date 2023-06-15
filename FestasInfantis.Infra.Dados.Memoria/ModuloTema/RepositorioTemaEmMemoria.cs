using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class RepositorioTemaEmMemoria : RepositorioBaseEmMemoria<Tema>, IRepositorioTema
    {
        public RepositorioTemaEmMemoria(List<Tema> temas)
        {
            listaRegistros = temas;
        }
    }
}
