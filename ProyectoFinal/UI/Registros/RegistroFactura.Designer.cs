namespace ProyectoFinal.UI.Registros
{
    partial class RegistroFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroFactura));
            this.ClientegroupBox = new System.Windows.Forms.GroupBox();
            this.SeleccionarClientecomboBox = new System.Windows.Forms.ComboBox();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FacturaFechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FacturadataGridView = new System.Windows.Forms.DataGridView();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.FacturaIdtextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FacturagroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiciocomboBox = new System.Windows.Forms.ComboBox();
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.ArticuloscomboBox = new System.Windows.Forms.ComboBox();
            this.ClientegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).BeginInit();
            this.FacturagroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientegroupBox
            // 
            this.ClientegroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ClientegroupBox.Controls.Add(this.SeleccionarClientecomboBox);
            this.ClientegroupBox.Controls.Add(this.TelefonotextBox);
            this.ClientegroupBox.Controls.Add(this.DirecciontextBox);
            this.ClientegroupBox.Controls.Add(this.Buscarbutton);
            this.ClientegroupBox.Controls.Add(this.label7);
            this.ClientegroupBox.Controls.Add(this.label8);
            this.ClientegroupBox.Controls.Add(this.label6);
            this.ClientegroupBox.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientegroupBox.Location = new System.Drawing.Point(12, 100);
            this.ClientegroupBox.Name = "ClientegroupBox";
            this.ClientegroupBox.Size = new System.Drawing.Size(1086, 180);
            this.ClientegroupBox.TabIndex = 6;
            this.ClientegroupBox.TabStop = false;
            this.ClientegroupBox.Text = "Clientes ";
            // 
            // SeleccionarClientecomboBox
            // 
            this.SeleccionarClientecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SeleccionarClientecomboBox.FormattingEnabled = true;
            this.SeleccionarClientecomboBox.Location = new System.Drawing.Point(182, 31);
            this.SeleccionarClientecomboBox.Name = "SeleccionarClientecomboBox";
            this.SeleccionarClientecomboBox.Size = new System.Drawing.Size(712, 30);
            this.SeleccionarClientecomboBox.TabIndex = 14;
            this.SeleccionarClientecomboBox.SelectedIndexChanged += new System.EventHandler(this.SeleccionarClientecomboBox_SelectedIndexChanged);
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TelefonotextBox.Enabled = false;
            this.TelefonotextBox.Location = new System.Drawing.Point(182, 121);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(712, 29);
            this.TelefonotextBox.TabIndex = 14;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirecciontextBox.Enabled = false;
            this.DirecciontextBox.Location = new System.Drawing.Point(182, 79);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(712, 29);
            this.DirecciontextBox.TabIndex = 13;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(946, 17);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(134, 40);
            this.Buscarbutton.TabIndex = 12;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Seleccionar Cliente:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(90, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Direccion:";
            // 
            // FacturaFechadateTimePicker
            // 
            this.FacturaFechadateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacturaFechadateTimePicker.Location = new System.Drawing.Point(777, 33);
            this.FacturaFechadateTimePicker.Name = "FacturaFechadateTimePicker";
            this.FacturaFechadateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.FacturaFechadateTimePicker.TabIndex = 7;
            // 
            // FacturadataGridView
            // 
            this.FacturadataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacturadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturadataGridView.Location = new System.Drawing.Point(6, 124);
            this.FacturadataGridView.Name = "FacturadataGridView";
            this.FacturadataGridView.RowTemplate.Height = 24;
            this.FacturadataGridView.Size = new System.Drawing.Size(1074, 149);
            this.FacturadataGridView.TabIndex = 8;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nuevobutton.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(208, 671);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(129, 50);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Guardarbutton.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(471, 671);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(150, 50);
            this.Guardarbutton.TabIndex = 10;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Eliminarbutton.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(748, 671);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(144, 50);
            this.Eliminarbutton.TabIndex = 11;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Agregarbutton.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(883, 56);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(129, 44);
            this.Agregarbutton.TabIndex = 13;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // FacturaIdtextBox
            // 
            this.FacturaIdtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FacturaIdtextBox.Location = new System.Drawing.Point(884, 8);
            this.FacturaIdtextBox.Name = "FacturaIdtextBox";
            this.FacturaIdtextBox.Size = new System.Drawing.Size(158, 22);
            this.FacturaIdtextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(785, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "FacturaId:";
            // 
            // FacturagroupBox
            // 
            this.FacturagroupBox.BackColor = System.Drawing.Color.Transparent;
            this.FacturagroupBox.Controls.Add(this.label4);
            this.FacturagroupBox.Controls.Add(this.label3);
            this.FacturagroupBox.Controls.Add(this.label2);
            this.FacturagroupBox.Controls.Add(this.ServiciocomboBox);
            this.FacturagroupBox.Controls.Add(this.CantidadtextBox);
            this.FacturagroupBox.Controls.Add(this.ArticuloscomboBox);
            this.FacturagroupBox.Controls.Add(this.Agregarbutton);
            this.FacturagroupBox.Controls.Add(this.FacturadataGridView);
            this.FacturagroupBox.Location = new System.Drawing.Point(12, 352);
            this.FacturagroupBox.Name = "FacturagroupBox";
            this.FacturagroupBox.Size = new System.Drawing.Size(1086, 291);
            this.FacturagroupBox.TabIndex = 14;
            this.FacturagroupBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Articulo ";
            // 
            // ServiciocomboBox
            // 
            this.ServiciocomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiciocomboBox.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciocomboBox.FormattingEnabled = true;
            this.ServiciocomboBox.Location = new System.Drawing.Point(665, 68);
            this.ServiciocomboBox.Name = "ServiciocomboBox";
            this.ServiciocomboBox.Size = new System.Drawing.Size(179, 29);
            this.ServiciocomboBox.TabIndex = 16;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CantidadtextBox.Enabled = false;
            this.CantidadtextBox.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadtextBox.Location = new System.Drawing.Point(383, 68);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.Size = new System.Drawing.Size(142, 28);
            this.CantidadtextBox.TabIndex = 15;
            // 
            // ArticuloscomboBox
            // 
            this.ArticuloscomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArticuloscomboBox.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticuloscomboBox.FormattingEnabled = true;
            this.ArticuloscomboBox.Location = new System.Drawing.Point(38, 68);
            this.ArticuloscomboBox.Name = "ArticuloscomboBox";
            this.ArticuloscomboBox.Size = new System.Drawing.Size(179, 29);
            this.ArticuloscomboBox.TabIndex = 15;
            // 
            // RegistroFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1110, 733);
            this.Controls.Add(this.FacturagroupBox);
            this.Controls.Add(this.FacturaIdtextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FacturaFechadateTimePicker);
            this.Controls.Add(this.ClientegroupBox);
            this.Name = "RegistroFactura";
            this.Text = "RegistroFactura";
            this.ClientegroupBox.ResumeLayout(false);
            this.ClientegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).EndInit();
            this.FacturagroupBox.ResumeLayout(false);
            this.FacturagroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox ClientegroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FacturaFechadateTimePicker;
        private System.Windows.Forms.DataGridView FacturadataGridView;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FacturaIdtextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SeleccionarClientecomboBox;
        private System.Windows.Forms.GroupBox FacturagroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServiciocomboBox;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.ComboBox ArticuloscomboBox;
    }
}