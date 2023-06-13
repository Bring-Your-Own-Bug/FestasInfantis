namespace FestasInfantis.WinApp.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public int Id { get; set; }

        public abstract void AtualizarInformacoes(T registroAtualizado);

        public abstract List<string> Validar();
    }
}
