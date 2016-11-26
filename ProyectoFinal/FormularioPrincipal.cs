using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void registroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroClientes rc = new UI.Registros.RegistroClientes();
            rc.Show();
        }

        private void regustroDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroFactura rf = new UI.Registros.RegistroFactura();
            rf.Show();
        }

        private void registroDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.Registros.RegistroArticulos ra = new UI.Registros.RegistroArticulos();
            ra.Show();
        }
    }
}
