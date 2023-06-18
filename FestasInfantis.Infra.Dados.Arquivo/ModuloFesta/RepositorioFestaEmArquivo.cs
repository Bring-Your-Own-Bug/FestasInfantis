using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloFesta
{
    public class RepositorioFestaEmArquivo : RepositorioBaseEmArquivo<Festa>, IRepositorio<Festa>
    {
        public RepositorioFestaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Festa> ObterRegistros()
        {
            return contextoDados.festas;
        }
    }
}
