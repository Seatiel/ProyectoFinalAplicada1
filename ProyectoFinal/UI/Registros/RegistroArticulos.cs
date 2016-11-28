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
        private List<ServiciosArticulos> sa;

        public RegistroArticulos()
        {
            InitializeComponent();

            LlenarArticulo();            
            sa = new List<ServiciosArticulos>();
        }

        public void LlenarArticulo()
        {
            var lista = ServiciosBLL.GetList();
            if (lista.Count <= 0)
            {
                var servicios = new Servicios("Lavado");
                var servicios1 = new Servicios("Planchado");
                var servicios2 = new Servicios("Lavado y Planchado");

                ServiciosBLL.Insertar(servicios);
                ServiciosBLL.Insertar(servicios1);
                ServiciosBLL.Insertar(servicios2);
            }         
                ServicioscomboBox.DataSource = lista;
                ServicioscomboBox.ValueMember = "ServicioId";
                ServicioscomboBox.DisplayMember = "Nombre";                   
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            int Id;
            int.TryParse(ArticuloIdtextBox.Text, out Id);
            ValidarServicio(sa);
            if (ServiciosArticulosBLL.Insertar(sa))
            {
                ArticulosBLL.Insertar(new Articulos(Id, NombreArticulotextBox.Text));
                Limpiar();
                MessageBox.Show("Guardado");
            }
        }

        private bool CamposLlenos()
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(ArticuloIdtextBox.Text))
                if (!string.IsNullOrEmpty(NombreArticulotextBox.Text))
                    if (!string.IsNullOrEmpty(ServicioscomboBox.Text))
                        if (!string.IsNullOrEmpty(PreciotextBox.Text))
                            retorno = true;
            return retorno;
        }

        private void LlenarCampos(ServiciosArticulos servicios)
        {
            ArticuloIdtextBox.Text = servicios.ArticuloId.ToString();
            PreciotextBox.Text = servicios.Precio.ToString();

        }

        private void LlenarCamposArticulos(Articulos articulo)
        {
            //ArticuloIdtextBox.Text = articulo.ArticuloId;
            NombreArticulotextBox.Text = articulo.Nombre;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            ArticuloIdtextBox.Clear();
            NombreArticulotextBox.Clear();
            ServicioscomboBox.SelectedValue = 1;
            PreciotextBox.Clear();
            sa = new List<ServiciosArticulos>();
            ArticulosdataGridView.DataSource = null;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            sa.Add(new ServiciosArticulos((int)ServicioscomboBox.SelectedValue, Convert.ToDouble(PreciotextBox.Text)));
            ArticulosdataGridView.DataSource = null;
            ArticulosdataGridView.DataSource = sa;
        }

        private int ToInt(string texto)
        {
            int entero;
            int.TryParse(texto, out entero);
            return entero;
        }

        private bool ValidarBuscar()
        {
            if (ServiciosArticulosBLL.Buscar(ToInt(ArticuloIdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;
            }
            return true;
        }

        private void ValidarServicio(List<ServiciosArticulos> sa)
        {
            foreach (var servicio in sa)
            {
                servicio.ArticuloId = ToInt(ArticuloIdtextBox.Text);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var articulo = ArticulosBLL.Buscar(ToInt(ArticuloIdtextBox.Text));
            var sa = ServiciosArticulosBLL.Buscar(ToInt(ArticuloIdtextBox.Text));
            ValidarServicio(sa);
            if (articulo != null)
            {
                NombreArticulotextBox.Text = articulo.Nombre;
                ArticulosdataGridView.DataSource = null;
                ArticulosdataGridView.DataSource = sa;
            }
        }
    }
}

