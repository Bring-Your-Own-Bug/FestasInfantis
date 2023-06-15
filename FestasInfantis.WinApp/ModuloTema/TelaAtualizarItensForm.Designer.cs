namespace FestasInfantis.WinApp.ModuloTema
{
    partial class TelaAtualizarItensForm
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
            txtTema = new TextBox();
            label2 = new Label();
            txtId = new TextBox();
            label1 = new Label();
            checkedListBox = new CheckedListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            SuspendLayout();
            // 
            // txtTema
            // 
            txtTema.Location = new Point(59, 82);
            txtTema.Name = "txtTema";
            txtTema.ReadOnly = true;
            txtTema.Size = new Size(406, 23);
            txtTema.TabIndex = 34;
            txtTema.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 85);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 33;
            label2.Text = "Tema";
            // 
            // txtId
            // 
            txtId.Location = new Point(59, 42);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 32;
            txtId.TabStop = false;
            txtId.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 45);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 31;
            label1.Text = "ID";
            // 
            // checkedListBox
            // 
            checkedListBox.CheckOnClick = true;
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Location = new Point(22, 160);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(443, 220);
            checkedListBox.TabIndex = 35;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(384, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 45);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(289, 426);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(89, 45);
            btnGravar.TabIndex = 36;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // TelaAtualizarItensForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 483);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(checkedListBox);
            Controls.Add(txtTema);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaAtualizarItensForm";
            Text = "TelaAtualizarItensForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTema;
        private Label label2;
        private TextBox txtId;
        private Label label1;
        private CheckedListBox checkedListBox;
        private Button btnCancelar;
        private Button btnGravar;
    }
}