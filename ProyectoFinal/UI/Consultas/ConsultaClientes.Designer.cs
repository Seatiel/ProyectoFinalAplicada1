namespace ProyectoFinal.UI.Consultas
{
    partial class ConsultaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaClientes));
            this.ClientedataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientedataGridView
            // 
            this.ClientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientedataGridView.Location = new System.Drawing.Point(69, 155);
            this.ClientedataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientedataGridView.Name = "ClientedataGridView";
            this.ClientedataGridView.RowTemplate.Height = 24;
            this.ClientedataGridView.Size = new System.Drawing.Size(833, 292);
            this.ClientedataGridView.TabIndex = 79;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltrotextBox.Location = new System.Drawing.Point(138, 65);
            this.FiltrotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(396, 22);
            this.FiltrotextBox.TabIndex = 71;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(586, 63);
            this.FiltrocomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(227, 24);
            this.FiltrocomboBox.TabIndex = 72;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(838, 63);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 46);
            this.Buscarbutton.TabIndex = 73;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 74;
            this.label1.Text = "Filtrar ";
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 524);
            this.Controls.Add(this.ClientedataGridView);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaClientes";
            this.Text = "ConsultaClientes";
            this.Load += new System.EventHandler(this.ConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientedataGridView;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
    }
}