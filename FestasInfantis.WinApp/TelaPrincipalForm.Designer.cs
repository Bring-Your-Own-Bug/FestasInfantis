namespace FestasInfantis.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosMenuItem = new ToolStripMenuItem();
            clienteMenuItem = new ToolStripMenuItem();
            festaMenuItem = new ToolStripMenuItem();
            aluguelMenuItem = new ToolStripMenuItem();
            temaMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblRodape = new ToolStripStatusLabel();
            toolbar = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnExcluir = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnAdicionarItem = new ToolStripButton();
            btnDefinirValor = new ToolStripButton();
            lblTipoCadastro = new ToolStripLabel();
            painelRegistros = new Panel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolbar.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosMenuItem
            // 
            cadastrosMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clienteMenuItem, festaMenuItem, aluguelMenuItem, temaMenuItem });
            cadastrosMenuItem.Name = "cadastrosMenuItem";
            cadastrosMenuItem.Size = new Size(71, 20);
            cadastrosMenuItem.Text = "Cadastros";
            // 
            // clienteMenuItem
            // 
            clienteMenuItem.Name = "clienteMenuItem";
            clienteMenuItem.Size = new Size(115, 22);
            clienteMenuItem.Text = "Cliente";
            clienteMenuItem.Click += clienteMenuItem_Click;
            // 
            // festaMenuItem
            // 
            festaMenuItem.Name = "festaMenuItem";
            festaMenuItem.Size = new Size(115, 22);
            festaMenuItem.Text = "Festa";
            festaMenuItem.Click += festaMenuItem_Click;
            // 
            // aluguelMenuItem
            // 
            aluguelMenuItem.Name = "aluguelMenuItem";
            aluguelMenuItem.Size = new Size(115, 22);
            aluguelMenuItem.Text = "Aluguel";
            aluguelMenuItem.Click += aluguelMenuItem_Click;
            // 
            // temaMenuItem
            // 
            temaMenuItem.Name = "temaMenuItem";
            temaMenuItem.Size = new Size(115, 22);
            temaMenuItem.Text = "Tema";
            temaMenuItem.Click += temaMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblRodape });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblRodape
            // 
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(60, 17);
            lblRodape.Text = "lblRodape";
            // 
            // toolbar
            // 
            toolbar.Enabled = false;
            toolbar.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnExcluir, toolStripSeparator1, btnAdicionarItem, btnDefinirValor, lblTipoCadastro });
            toolbar.Location = new Point(0, 24);
            toolbar.Name = "toolbar";
            toolbar.Size = new Size(800, 45);
            toolbar.TabIndex = 2;
            toolbar.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.add_circle_FILL0_wght400_GRAD0_opsz24;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "Inserir";
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit_FILL0_wght400_GRAD0_opsz24;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Image = Properties.Resources.delete_FILL0_wght400_GRAD0_opsz24;
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.ImageTransparentColor = Color.Magenta;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(7);
            btnExcluir.Size = new Size(42, 42);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // btnAdicionarItem
            // 
            btnAdicionarItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionarItem.Image = Properties.Resources.category_FILL0_wght400_GRAD0_opsz24;
            btnAdicionarItem.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionarItem.ImageTransparentColor = Color.Magenta;
            btnAdicionarItem.Name = "btnAdicionarItem";
            btnAdicionarItem.Padding = new Padding(7);
            btnAdicionarItem.Size = new Size(42, 42);
            btnAdicionarItem.Click += btnAdicionarItem_Click;
            // 
            // btnDefinirValor
            // 
            btnDefinirValor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDefinirValor.Image = Properties.Resources.attach_money_FILL0_wght400_GRAD0_opsz24;
            btnDefinirValor.ImageScaling = ToolStripItemImageScaling.None;
            btnDefinirValor.ImageTransparentColor = Color.Magenta;
            btnDefinirValor.Name = "btnDefinirValor";
            btnDefinirValor.Padding = new Padding(7);
            btnDefinirValor.Size = new Size(42, 42);
            btnDefinirValor.Click += btnDefinirValor_Click;
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(90, 42);
            lblTipoCadastro.Text = "lblTipoCadastro";
            // 
            // painelRegistros
            // 
            painelRegistros.Dock = DockStyle.Fill;
            painelRegistros.Location = new Point(0, 69);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(800, 359);
            painelRegistros.TabIndex = 3;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(painelRegistros);
            Controls.Add(toolbar);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(816, 489);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Festas Infantis";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrosMenuItem;
        private ToolStripMenuItem clienteMenuItem;
        private ToolStripMenuItem festaMenuItem;
        private ToolStripMenuItem aluguelMenuItem;
        private ToolStripMenuItem temaMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblRodape;
        private ToolStrip toolbar;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnExcluir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnAdicionarItem;
        private ToolStripButton btnDefinirValor;
        private Panel painelRegistros;
    }
}