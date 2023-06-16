namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class ListaClienteControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCliente = new ListBox();
            SuspendLayout();
            // 
            // listCliente
            // 
            listCliente.Dock = DockStyle.Fill;
            listCliente.FormattingEnabled = true;
            listCliente.ItemHeight = 15;
            listCliente.Location = new Point(0, 0);
            listCliente.Name = "listCliente";
            listCliente.Size = new Size(816, 489);
            listCliente.TabIndex = 0;
            // 
            // ListaClienteControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(listCliente);
            Name = "ListaClienteControl";
            Size = new Size(816, 489);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listCliente;
    }
}
