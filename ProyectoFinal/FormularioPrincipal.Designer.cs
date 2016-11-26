namespace ProyectoFinal
{
    partial class FormularioPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regustroDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClientesToolStripMenuItem,
            this.regustroDeFacturaToolStripMenuItem,
            this.regToolStripMenuItem,
            this.registroDeArticuloToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            this.registrosToolStripMenuItem.Text = "&Registros";
            // 
            // registroClientesToolStripMenuItem
            // 
            this.registroClientesToolStripMenuItem.Name = "registroClientesToolStripMenuItem";
            this.registroClientesToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registroClientesToolStripMenuItem.Text = "&Registro Clientes";
            this.registroClientesToolStripMenuItem.Click += new System.EventHandler(this.registroClientesToolStripMenuItem_Click);
            // 
            // regustroDeFacturaToolStripMenuItem
            // 
            this.regustroDeFacturaToolStripMenuItem.Name = "regustroDeFacturaToolStripMenuItem";
            this.regustroDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.regustroDeFacturaToolStripMenuItem.Text = "&Registro de Factura";
            this.regustroDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.regustroDeFacturaToolStripMenuItem_Click);
            // 
            // regToolStripMenuItem
            // 
            this.regToolStripMenuItem.Name = "regToolStripMenuItem";
            this.regToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.regToolStripMenuItem.Text = "&Registro de Cobro";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaClientesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(95, 25);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            // 
            // consultaClientesToolStripMenuItem
            // 
            this.consultaClientesToolStripMenuItem.Name = "consultaClientesToolStripMenuItem";
            this.consultaClientesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.consultaClientesToolStripMenuItem.Text = "&Consulta Clientes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.ayudaToolStripMenuItem.Text = "&Ayuda";
            // 
            // registroDeArticuloToolStripMenuItem
            // 
            this.registroDeArticuloToolStripMenuItem.Name = "registroDeArticuloToolStripMenuItem";
            this.registroDeArticuloToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.registroDeArticuloToolStripMenuItem.Text = "&Registro de articulo";
            this.registroDeArticuloToolStripMenuItem.Click += new System.EventHandler(this.registroDeArticuloToolStripMenuItem_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1402, 663);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lavanderia ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regustroDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeArticuloToolStripMenuItem;
    }
}

