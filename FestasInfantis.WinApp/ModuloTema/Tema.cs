namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase<Tema>
    {
        public string Nome { get; set; }

        public List<ItemTema> Itens { get; set; }

        public decimal ValorTotal { get; set; }

        public Tema()
        {
            
        }

        public Tema(string nome, decimal valor)
        {
            Nome = nome;
            Itens = new List<ItemTema>();
            ValorTotal = valor;
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            Id = registroAtualizado.Id;
            Nome = registroAtualizado.Nome;
        }

        public override List<string> Validar()
        {
            List<string> erros = new();

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("O campo 'nome' é obrigatório");

            return erros;
        }
    }
}
