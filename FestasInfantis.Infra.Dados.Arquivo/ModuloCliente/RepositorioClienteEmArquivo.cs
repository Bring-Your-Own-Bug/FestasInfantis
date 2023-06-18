using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloCliente
{
    public class RepositorioClienteEmArquivo : RepositorioBaseEmArquivo<Cliente>, IRepositorio<Cliente>
    {
        public RepositorioClienteEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contextoDados.clientes;
        }
    }
}
