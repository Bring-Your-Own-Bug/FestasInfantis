using FestasInfantis.Dominio.Compartilhado;

namespace FestasInfantis.Infra.Dados.Arquivo.Compartilhado
{
    public abstract class RepositorioBaseEmArquivo<T> where T : EntidadeBase<T>
    {
        protected int contador;
        protected ContextoDados contextoDados;

        public RepositorioBaseEmArquivo(ContextoDados contextoDados)
        {
            this.contextoDados = contextoDados;
        }

        public void Inserir(T registro)
        {
            List<T> registros = ObterRegistros();

            contador++;

            registro.Id = contador;

            registros.Add(registro);

            contextoDados.EnviarRegistrosParaArquivoJson();
        }

        public void Editar(int id, T registro)
        {
            SelecionarPorId(id).AtualizarInformacoes(registro);

            contextoDados.EnviarRegistrosParaArquivoJson();
        }

        public void Excluir(T registro)
        {
            ObterRegistros().Remove(registro);

            contextoDados.EnviarRegistrosParaArquivoJson();
        }

        public T SelecionarPorId(int id)
        {
            return ObterRegistros().FirstOrDefault(x => x.Id == id);
        }

        public List<T> SelecionarTodos()
        {
            return ObterRegistros();
        }

        private void AtualizarContador()
        {
            if (ObterRegistros().Count > 0)
                contador = ObterRegistros().Max(x => x.Id);
        }

        protected abstract List<T> ObterRegistros();
    }
}
