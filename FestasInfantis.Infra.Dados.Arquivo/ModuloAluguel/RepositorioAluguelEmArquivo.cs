using FestasInfantis.Dominio.ModuloAluguel;

namespace FestasInfantis.Infra.Dados.Arquivo.ModuloAluguel
{
    public class RepositorioAluguelEmArquivo : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public RepositorioAluguelEmArquivo(ContextoDados contextoDados) : base(contextoDados)
        {
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contextoDados.alugueis;
        }
    }
}
