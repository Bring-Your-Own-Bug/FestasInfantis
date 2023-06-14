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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            btnCancelar = new Button();
            btnGravar = new Button();
            btnDeletar = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(54, 29);
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
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 76);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 23;
            label2.Text = "Tema";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 23);
            textBox1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(392, 117);
            button1.Name = "button1";
            button1.Size = new Size(108, 25);
            button1.TabIndex = 25;
            button1.Text = "Adicionar Item";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 170);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(482, 214);
            listBox1.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(405, 432);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 45);
            btnCancelar.TabIndex = 28;
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
            btnGravar.TabIndex = 27;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeletar.DialogResult = DialogResult.OK;
            btnDeletar.Location = new Point(12, 432);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(89, 45);
            btnDeletar.TabIndex = 29;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(54, 73);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(332, 23);
            textBox2.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 120);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 31;
            label3.Text = "Item";
            // 
            // TelaItemTemaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 489);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(btnDeletar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button btnCancelar;
        private Button btnGravar;
        private Button btnDeletar;
        private TextBox textBox2;
        private Label label3;
    }
}