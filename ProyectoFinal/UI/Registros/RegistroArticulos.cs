using BLL;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroArticulos : Form
    {
        List<ServiciosArticulos> sa = new List<ServiciosArticulos>();
        //List<Articulos> a = new List<Articulos>();

        public RegistroArticulos()
        {
            InitializeComponent();
            sa = new List<ServiciosArticulos>();
            //a = new List<Articulos>();
            AgregarArticulo();
        }

        public void AgregarArticulo()
        {

            //ServicioscomboBox.Items.Add("Lavado");
            //ServicioscomboBox.Items.Add("Planchado");
            //ServicioscomboBox.Items.Add("Lavado y Planchado");
            var articulos = new Servicios("Lavado");
            var articulos1 = new Servicios("Planchado");
            var articulos2 = new Servicios("Lavado y Planchado");

            ServiciosBLL.Insertar(articulos);
            ServiciosBLL.Insertar(articulos1);
            ServiciosBLL.Insertar(articulos2);

            ServicioscomboBox.DataSource = ServiciosBLL.GetList();
            ServicioscomboBox.ValueMember = "ServicioId";
            ServicioscomboBox.DisplayMember = "Nombre";
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(ArticuloIdtextBox.Text, out Id);
            ServiciosArticulosBLL.Insertar(sa);
            ArticulosBLL.Insertar(new Articulos(Id, NombreArticulotextBox.Text));
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            ArticuloIdtextBox.Clear();
            NombreArticulotextBox.Clear();
            ServicioscomboBox.SelectedValue = 1;
            PreciotextBox.Clear();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            ArticulosdataGridView.DataSource = null;
            sa.Add(new ServiciosArticulos((int)ServicioscomboBox.SelectedValue, Convert.ToDouble(PreciotextBox.Text)));
            //a.Add(ArticulosBLL.Buscar((int)ServicioscomboBox.SelectedValue));
            ArticulosdataGridView.DataSource = sa;
        }

      
    }
}
