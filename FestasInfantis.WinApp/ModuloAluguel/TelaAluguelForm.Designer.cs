namespace FestasInfantis.WinApp.ModuloAluguel
{
    partial class TelaAluguelForm
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
            cmbCliente = new ComboBox();
            label3 = new Label();
            cmbFesta = new ComboBox();
            label4 = new Label();
            txtValor = new TextBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            label5 = new Label();
            cmbStatus = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(52, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 24;
            txtId.TabStop = false;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 37);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 23;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 89);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 28;
            label2.Text = "Selecione um Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(52, 107);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(325, 23);
            cmbCliente.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(157, 141);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 30;
            label3.Text = "Selecione uma Festa";
            // 
            // cmbFesta
            // 
            cmbFesta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFesta.FormattingEnabled = true;
            cmbFesta.Location = new Point(52, 159);
            cmbFesta.Name = "cmbFesta";
            cmbFesta.Size = new Size(325, 23);
            cmbFesta.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 205);
            label4.Name = "label4";
            label4.Size = new Size(206, 15);
            label4.TabIndex = 31;
            label4.Text = "Valor do Aluguel (Sem contar o Tema)";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(156, 223);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(118, 23);
            txtValor.TabIndex = 3;
            txtValor.Text = "0";
            txtValor.KeyPress += txtValor_KeyPress;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(331, 280);
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
            btnGravar.Location = new Point(236, 280);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(89, 45);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(136, 227);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 35;
            label5.Text = "R$";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(35, 292);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 274);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 37;
            label6.Text = "Status do Pagamento";
            // 
            // TelaAluguelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 337);
            Controls.Add(label6);
            Controls.Add(cmbStatus);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbFesta);
            Controls.Add(label2);
            Controls.Add(cmbCliente);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaAluguelForm";
            Text = "Cadastro de Aluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private ComboBox cmbCliente;
        private Label label3;
        private ComboBox cmbFesta;
        private Label label4;
        private TextBox txtValor;
        private Button btnCancelar;
        private Button btnGravar;
        private Label label5;
        private ComboBox cmbStatus;
        private Label label6;
    }
}