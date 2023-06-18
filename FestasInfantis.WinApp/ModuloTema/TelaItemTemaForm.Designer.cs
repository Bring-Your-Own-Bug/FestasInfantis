namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaItemTemaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtItem = new TextBox();
            btnAdicionar = new Button();
            listaItens = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            btnDeletar = new Button();
            txtTema = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtValor = new TextBox();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(72, 29);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 22;
            txtId.TabStop = false;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 23;
            label2.Text = "Tema";
            // 
            // txtItem
            // 
            txtItem.Location = new Point(72, 109);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(314, 23);
            txtItem.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(392, 109);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(108, 63);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar Item";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listaItens
            // 
            listaItens.FormattingEnabled = true;
            listaItens.ItemHeight = 15;
            listaItens.Location = new Point(12, 200);
            listaItens.Name = "listaItens";
            listaItens.Size = new Size(482, 184);
            listaItens.TabIndex = 26;
            listaItens.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(405, 432);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 45);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(310, 432);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(89, 45);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeletar.Location = new Point(12, 432);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(89, 45);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtTema
            // 
            txtTema.Location = new Point(72, 69);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(314, 23);
            txtTema.TabIndex = 30;
            txtTema.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 112);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 31;
            label3.Text = "Item";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 152);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 32;
            label4.Text = "Valor (R$)";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(72, 149);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(314, 23);
            txtValor.TabIndex = 2;
            txtValor.Text = "0";
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // TelaItemTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 489);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTema);
            Controls.Add(btnDeletar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listaItens);
            Controls.Add(btnAdicionar);
            Controls.Add(txtItem);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaItemTemaForm";
            Text = "Cadastro de Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtItem;
        private Button btnAdicionar;
        private ListBox listaItens;
        private Button btnCancelar;
        private Button btnGravar;
        private Button btnDeletar;
        private TextBox txtTema;
        private Label label3;
        private Label label4;
        private TextBox txtValor;
    }
}