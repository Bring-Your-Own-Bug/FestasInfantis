using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Festa Festa { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorAluguel { get; set; }
        public StatusPagamento Status { get; set; }
        public DateTime DataQuitacao { get; set; }

        public Aluguel()
        {
            
        }

        public Aluguel(Festa festa, Cliente cliente, decimal valorAluguel, decimal valorTotal, StatusPagamento status, DateTime dataQuitacao)
        {
            Festa = festa;
            Cliente = cliente;
            ValorAluguel = valorAluguel;
            ValorTotal = valorTotal;
            Status = status;
            DataQuitacao = dataQuitacao;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            Festa = registroAtualizado.Festa;
            Cliente = registroAtualizado.Cliente;
            ValorAluguel = registroAtualizado.ValorAluguel;
            ValorTotal = registroAtualizado.ValorTotal;
            Status = registroAtualizado.Status;
            DataQuitacao = registroAtualizado.DataQuitacao;
        }

        public override List<string> Validar()
        {
            List<string> erros = new();

            if (ValorAluguel < 0)
                erros.Add("O campo 'valor do aluguel' não pode ser negativo");

            return erros;
        }
    }
}
