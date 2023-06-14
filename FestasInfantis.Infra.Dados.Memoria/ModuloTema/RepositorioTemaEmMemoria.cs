using FestasInfantis.Dominio.ModuloTema;
using FestasInfantis.Infra.Dados.Memoria.Compartilhado;

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
