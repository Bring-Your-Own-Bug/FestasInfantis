namespace FestasInfantis.WinApp.ModuloTema
{
    public class ItemTema
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public ItemTema()
        {
            
        }

        public ItemTema(string nome, decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public override bool Equals(object? obj)
        {
            return obj is ItemTema tema &&
                   Nome == tema.Nome &&
                   Valor == tema.Valor;
        }
    }
}
