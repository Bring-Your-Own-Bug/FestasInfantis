using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.Infra.Dados.Memoria.ModuloCliente
{
    public class RepositorioClienteEmMemoria : RepositorioBaseEmMemoria<Cliente>
    {
        public RepositorioClienteEmMemoria(List<Cliente> clientes)
        {
            this.listaRegistros = clientes;
        }
    }
}
