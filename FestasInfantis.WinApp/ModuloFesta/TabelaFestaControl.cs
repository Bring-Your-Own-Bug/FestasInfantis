using FestasInfantis.Dominio.ModuloFesta;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public partial class TabelaFestaControl : UserControl
    {
        public TabelaFestaControl()
        {
            InitializeComponent();

            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();

            ConfigurarColunas();
        }

        private void ConfigurarColunas()
        {
            DataGridViewTextBoxColumn[] colunas = new DataGridViewTextBoxColumn[]
            {
                new()
                {
                    Name = "id",
                    HeaderText = "ID"
                },
                new()
                {
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new()
                {
                    Name = "horaInicio",
                    HeaderText = "Horario Inicio"
                },
                new()
                {
                    Name = "horaFinal",
                    HeaderText = "Horario Final"
                }
            };

            grid.Columns.AddRange(colunas);

            grid.Columns["id"].Width = 15;
        }

        public void AtualizarRegistros(List<Festa> festas)
        {
            grid.Rows.Clear();

            foreach (Festa festa in festas)
            {
                if (festa != null)
                {
                    grid.Rows.Add(festa.Id, festa.Nome, festa.Tema.Nome,
                        festa.Data.ToString("dd/MM/yyyy"),
                        festa.HorarioInicio.ToString(@"hh\:mm"),
                        festa.HorarioFinal.ToString(@"hh\:mm"));
                }
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
