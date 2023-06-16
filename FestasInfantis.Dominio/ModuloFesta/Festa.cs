using FestasInfantis.Dominio.ModuloTema;

namespace FestasInfantis.Dominio.ModuloFesta
{
    public class Festa : EntidadeBase<Festa>
    {
        public string Nome { get; set; }
        public Tema Tema { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HorarioInicio { get; set; }
        public TimeSpan HorarioFinal { get; set; }
        public Endereco Endereco { get; set; }

        public Festa()
        {
            
        }

        public Festa(string nome, Tema tema, DateTime data, TimeSpan horarioInicio, TimeSpan horarioFinal, Endereco endereco)
        {
            Nome = nome;
            Tema = tema;
            Data = data;
            HorarioInicio = horarioInicio;
            HorarioFinal = horarioFinal;
            Endereco = endereco;
        }

        public override string ToString()
        {
            return Nome;
        }

        public override void AtualizarInformacoes(Festa registroAtualizado)
        {
            Id = registroAtualizado.Id;
            Nome = registroAtualizado.Nome;
            Data = registroAtualizado.Data;
            HorarioInicio = registroAtualizado.HorarioInicio;
            HorarioFinal = registroAtualizado.HorarioFinal;
            Endereco = registroAtualizado.Endereco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new();

            TimeSpan diferencaHorario = HorarioFinal - HorarioInicio;

            if (string.IsNullOrWhiteSpace(Nome))
                erros.Add("O campo 'titulo da festa' não pode estar vazio");

            if (Data < DateTime.Today)
                erros.Add("A data da festa não pode ser no passado");

            if (HorarioInicio >= HorarioFinal)
                erros.Add("Horário de início deve ser menor que o horário final");
            else if (diferencaHorario.TotalMinutes < 15)
                erros.Add("A diferença entre o horário de início e o horário de término deve ser de pelo menos 15 minutos");

            return erros;
        }
    }
}
