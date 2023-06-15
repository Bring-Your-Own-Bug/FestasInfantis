namespace FestasInfantis.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool EhAntigo { get; set; }

        public Cliente()
        {
            
        }

        public Cliente(string nome, string telefone, bool ehAntigo)
        {
            Nome = nome;
            Telefone = telefone;
            EhAntigo = ehAntigo;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
