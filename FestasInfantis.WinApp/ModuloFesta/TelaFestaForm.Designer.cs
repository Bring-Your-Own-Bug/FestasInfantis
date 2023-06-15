namespace FestasInfantis.WinApp.ModuloFesta
{
    partial class TelaFestaForm
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
            btnCancelar = new Button();
            btnGravar = new Button();
            cmbTema = new ComboBox();
            label2 = new Label();
            dtpInicio = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            dtpFinal = new DateTimePicker();
            groupBox1 = new GroupBox();
            txtEstado = new TextBox();
            label9 = new Label();
            txtCidade = new TextBox();
            label8 = new Label();
            txtNumero = new TextBox();
            label7 = new Label();
            txtBairro = new TextBox();
            label6 = new Label();
            txtRua = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(46, 28);
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
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(310, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(89, 45);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(215, 396);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(89, 45);
            btnGravar.TabIndex = 23;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // cmbTema
            // 
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.FormattingEnabled = true;
            cmbTema.Location = new Point(46, 104);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(325, 23);
            cmbTema.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 86);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 26;
            label2.Text = "Selecione um Tema";
            // 
            // dtpInicio
            // 
            dtpInicio.CustomFormat = "HH:mm";
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(22, 173);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.ShowUpDown = true;
            dtpInicio.Size = new Size(148, 23);
            dtpInicio.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 155);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 28;
            label3.Text = "Horario inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(285, 155);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 29;
            label4.Text = "Horario Final";
            // 
            // dtpFinal
            // 
            dtpFinal.CustomFormat = "HH:mm";
            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.Location = new Point(244, 173);
            dtpFinal.Name = "dtpFinal";
            dtpFinal.ShowUpDown = true;
            dtpFinal.Size = new Size(148, 23);
            dtpFinal.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(22, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 162);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(57, 120);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(292, 23);
            txtEstado.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 125);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 8;
            label9.Text = "Estado";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(57, 91);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(292, 23);
            txtCidade.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 94);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 6;
            label8.Text = "Cidade";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(275, 29);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(74, 23);
            txtNumero.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(248, 32);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 4;
            label7.Text = "N°";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(57, 61);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(292, 23);
            txtBairro.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 64);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 2;
            label6.Text = "Bairro";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(57, 29);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(185, 23);
            txtRua.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 32);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 0;
            label5.Text = "Rua";
            // 
            // TelaFestaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 453);
            Controls.Add(groupBox1);
            Controls.Add(dtpFinal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpInicio);
            Controls.Add(label2);
            Controls.Add(cmbTema);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "TelaFestaForm";
            Text = "Cadastro de Festa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Button btnCancelar;
        private Button btnGravar;
        private ComboBox cmbTema;
        private Label label2;
        private DateTimePicker dtpInicio;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpFinal;
        private GroupBox groupBox1;
        private TextBox txtEstado;
        private Label label9;
        private TextBox txtCidade;
        private Label label8;
        private TextBox txtNumero;
        private Label label7;
        private TextBox txtBairro;
        private Label label6;
        private TextBox txtRua;
        private Label label5;
    }
}