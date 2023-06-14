namespace FestasInfantis.WinApp.ModuloTema
{
    public partial class TabelaTemaControl : UserControl
    {
        public TabelaTemaControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
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
                    Name = "nome",
                    HeaderText = "Tema"
                },
                new()
                {
                    Name = "valor",
                    HeaderText = "Valor Total do Tema"
                }
            };

            grid.Columns.AddRange(colunas);
        }
    }
}
