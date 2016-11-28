namespace ProyectoFinal.UI.Consultas
{
    partial class ConsultaFacturas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFacturas));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicke = new System.Windows.Forms.DateTimePicker();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FacturadataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 69;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 68;
            this.label2.Text = "Hasta";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(402, 87);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(148, 26);
            this.HastadateTimePicker.TabIndex = 67;
            // 
            // DesdeDateTimePicke
            // 
            this.DesdeDateTimePicke.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicke.Location = new System.Drawing.Point(153, 87);
            this.DesdeDateTimePicke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DesdeDateTimePicke.Name = "DesdeDateTimePicke";
            this.DesdeDateTimePicke.Size = new System.Drawing.Size(151, 26);
            this.DesdeDateTimePicke.TabIndex = 66;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltrotextBox.Location = new System.Drawing.Point(154, 42);
            this.FiltrotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(396, 22);
            this.FiltrotextBox.TabIndex = 62;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(602, 42);
            this.FiltrocomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(227, 24);
            this.FiltrocomboBox.TabIndex = 63;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(837, 35);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(66, 55);
            this.Buscarbutton.TabIndex = 64;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Filtrar ";
            // 
            // FacturadataGridView
            // 
            this.FacturadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturadataGridView.Location = new System.Drawing.Point(95, 215);
            this.FacturadataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FacturadataGridView.Name = "FacturadataGridView";
            this.FacturadataGridView.RowTemplate.Height = 24;
            this.FacturadataGridView.Size = new System.Drawing.Size(833, 292);
            this.FacturadataGridView.TabIndex = 70;
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // ConsultaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1049, 570);
            this.Controls.Add(this.FacturadataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicke);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaFacturas";
            this.Text = "ConsultaFacturas";
            this.Load += new System.EventHandler(this.ConsultaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicke;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView FacturadataGridView;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
    }
}