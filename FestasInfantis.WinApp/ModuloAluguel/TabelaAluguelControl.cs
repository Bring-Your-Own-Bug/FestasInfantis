﻿using FestasInfantis.Dominio.ModuloAluguel;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
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
                    Name = "festa",
                    HeaderText = "Festa"
                },
                new()
                {
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                new()
                {
                    Name = "endereco",
                    HeaderText = "Endereço da Festa"
                },
                new()
                {
                    Name = "valor",
                    HeaderText = "Valor do Aluguel"
                },
                new()
                {
                    Name = "status",
                    HeaderText = "Status do Pagamento"
                },
                new()
                {
                    Name = "dataQuitacao",
                    HeaderText = "Data de Quitação"
                }
            };
            
            grid.Columns.AddRange(colunas);

            grid.Columns["id"].Width = 15;
            grid.Columns["cliente"].Width = 50;
            grid.Columns["endereco"].Width = 60;
            grid.Columns["valor"].Width = 25;
            grid.Columns["status"].Width = 25;
            grid.Columns["dataQuitacao"].Width = 45;
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                if (aluguel != null)
                {
                    grid.Rows.Add(aluguel.Id, aluguel.Festa.Nome, aluguel.Cliente.Nome,
                        aluguel.Festa.Endereco, $"R$ {aluguel.ValorTotal:F2}", aluguel.Status,
                        aluguel.Status == StatusPagamento.Pago ? aluguel.DataQuitacao.ToString("dd/MM/yyyy") : "Pagamento em Aberto");
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
