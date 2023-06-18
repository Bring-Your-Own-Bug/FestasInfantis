namespace FestasInfantis.Dominio.ModuloFesta
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco()
        {
           
        }

        public Endereco(string rua, int numero, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        public List<string> ValidarEndereco()
        {
            List<string> erros = new();

            if (string.IsNullOrWhiteSpace(Rua))
                erros.Add("O campo 'rua' é obrigatório");

            if (Numero < 0)
                erros.Add("O campo 'N°' não pode ser negativo");
            else if (Numero == 0)
                erros.Add("O campo 'N°' é obrigatório");

            if (string.IsNullOrWhiteSpace(Bairro))
                erros.Add("O campo 'bairro' é obrigatório");

            if (string.IsNullOrWhiteSpace(Cidade))
                erros.Add("O campo 'cidade' é obrigatório");

            if (string.IsNullOrWhiteSpace(Estado))
                erros.Add("O campo 'estado' é obrigatório");

            return erros;
        }

        public override string ToString()
        {
            return $"{Rua}, {Numero}, {Bairro}, {Cidade}";
        }
    }
}
