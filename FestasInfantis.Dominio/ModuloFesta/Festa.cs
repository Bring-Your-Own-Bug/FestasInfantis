using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public Tema Tema { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFinal { get; set; }
        public Endereco Endereco { get; set; }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            Id = registroAtualizado.Id;
            Data = registroAtualizado.Data;
            HorarioInicio = registroAtualizado.HorarioInicio;
            HorarioFinal = registroAtualizado.HorarioFinal;
            Endereco = registroAtualizado.Endereco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new();

            TimeSpan diferencaHorario = HorarioFinal - HorarioInicio;

            if (diferencaHorario.TotalMinutes < 15)
                erros.Add("A diferença entre o horário de início e o horário de término deve ser de pelo menos 15 minutos");

            if (HorarioInicio >= HorarioFinal)
                erros.Add("Horário de início deve ser menor que o horário final");

            return erros;
        }
    }
}
