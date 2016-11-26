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
        List<ServiciosArticulos> lista = new List<ServiciosArticulos>();


        public RegistroArticulos()
        {
            InitializeComponent();
            AgregarArticulo();

        }

        public void AgregarArticulo()
        {
            var articulos = new Servicios("Lavadp");
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
            

            /*if (ServiciosBLL.)
            {

            }*/
            

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

            lista.Add(new ServiciosArticulos((int)ServicioscomboBox.SelectedValue, Convert.ToDouble(PreciotextBox.Text)));
        }
    }
}
