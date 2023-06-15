using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloFesta
{
    public class RepositorioFestaEmArquivo : RepositorioBaseEmArquivo<Festa>
    {
        public RepositorioFestaEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Festa> ObterRegistros()
        {
            throw new NotImplementedException();
        }
    }
}
