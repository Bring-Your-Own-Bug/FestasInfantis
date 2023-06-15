using FestasInfantis.Dominio.ModuloCliente;
using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {
        public Festa Festa { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Valor { get; set; }
        public StatusPagamento Status { get; set; }

        public Aluguel()
        {
            
        }

        public Aluguel(Festa festa, Cliente cliente, decimal valor, StatusPagamento status)
        {
            Festa = festa;
            Cliente = cliente;
            Valor = valor;
            Status = status;
        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            Festa = registroAtualizado.Festa;
            Cliente = registroAtualizado.Cliente;
            Valor = registroAtualizado.Valor;
            Status = registroAtualizado.Status;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
