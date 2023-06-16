using System.Text.RegularExpressions;

namespace FestasInfantis.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            Nome = registroAtualizado.Nome;
            Telefone = registroAtualizado.Telefone;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            bool ehTelefoneValido = Regex.IsMatch(Telefone, @"^\(\d{2}\) \d{5}-\d{4}$");

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("O campo 'nome' é obrigatório");

            if (Telefone == "(  )      -")
                erros.Add("O campo 'telefone' é obrigatório");
            else if (!ehTelefoneValido)
                erros.Add("O campo 'telefone' está inválido");

            return erros;
        }
    }
}
