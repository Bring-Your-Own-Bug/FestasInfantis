﻿using FestasInfantis.Dominio.ModuloCliente;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public partial class TabelaClienteControl : UserControl
    {
        public TabelaClienteControl()
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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                }
            };

            grid.Columns.AddRange(colunas);

            grid.Columns["id"].Width = 15;
        }

        public void AtualizarRegistros(List<Cliente> clientes)
        {
            grid.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                if (cliente != null)
                {
                    grid.Rows.Add(cliente.Id, cliente.Nome, cliente.Telefone);
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
