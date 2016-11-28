using Entidades;
using BLL;
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
    public partial class RegistroFactura : Form
    {
        private List<FacturasArticulos> fa;

        public RegistroFactura()
        {
            InitializeComponent();
            LlenarClientes();
            LlenarArticulos();
            LlenarServicios();
            fa = new List<FacturasArticulos>();
        }

        public void LlenarClientes()
        {
            var lista = ClientesBLL.GetList();
            if (lista.Count <= 0)
            {
                var cliente = new Clientes("Juan Perez");

                ClientesBLL.Insertar(cliente);
            }
            SeleccionarClientecomboBox.ValueMember = "ClienteId";
            SeleccionarClientecomboBox.DisplayMember = "Nombres";
            SeleccionarClientecomboBox.DataSource = lista;
        }

        public void LlenarArticulos()
        {
            var lista = ArticulosBLL.GetList();
            if (lista.Count <= 0)
            {
                var articulo = new Articulos("Pantalon");
                var articulo2 = new Articulos("Camisa");
                var articulo3 = new Articulos("Sueter");
                var articulo4 = new Articulos("Blusa");
                var articulo5 = new Articulos("Corcha");
                var articulo6 = new Articulos("Corbata");
                var articulo7 = new Articulos("Corcha");


                ArticulosBLL.Insertar(articulo);
                ArticulosBLL.Insertar(articulo2);
                ArticulosBLL.Insertar(articulo3);
                ArticulosBLL.Insertar(articulo4);
                ArticulosBLL.Insertar(articulo5);
                ArticulosBLL.Insertar(articulo6);
                ArticulosBLL.Insertar(articulo7);
            }
            ArticuloscomboBox.ValueMember = "ArticuloId";
            ArticuloscomboBox.DisplayMember = "Nombre";
            ArticuloscomboBox.DataSource = lista;
        }

        public void LlenarServicios()
        {
            var lista = ServiciosBLL.GetList();
            if (lista.Count <= 0)
            {
                var servicios = new Servicios("Lavado");
                var servicios2 = new Servicios("Planchado");
                var servicios3 = new Servicios("Lavado y Planchado");


                ServiciosBLL.Insertar(servicios);
                ServiciosBLL.Insertar(servicios2);
                ServiciosBLL.Insertar(servicios3);

            }
            ServiciocomboBox.ValueMember = "ServicioId";
            ServiciocomboBox.DisplayMember = "Nombre";
            ServiciocomboBox.DataSource = lista;
        }

        public void LlenarCampos(FacturasArticulos fa)
        {
            CantidadtextBox.Text = fa.CantidadArticulos.ToString();
            ArticuloscomboBox.SelectedValue = fa.ArticuloId;
            ServiciocomboBox.SelectedValue = fa.ServicioId;
        }

        private Facturas LlenarCampos()
        {
            Facturas f = new Facturas();
            f.Fecha = FacturaFechadateTimePicker.Value;
            f.FacturaId = Convert.ToInt32(FacturaIdtextBox.Text);
            return f;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }



        private void Agregarbutton_Click(object sender, EventArgs e)
        {


            fa.Add(new FacturasArticulos((int)ArticuloscomboBox.SelectedValue, Convert.ToInt32(CantidadtextBox.Text), (int)ServiciocomboBox.SelectedValue));
            FacturadataGridView.DataSource = null;
            FacturadataGridView.DataSource = fa;

            //if (!string.IsNullOrEmpty(ArticuloscomboBox.Text))
            //{
            //    if (!string.IsNullOrEmpty(CantidadtextBox.Text))
            //    {
            //        if (!string.IsNullOrEmpty(ServiciocomboBox.Text))
            //        {
            //            var fa = new FacturasArticulos(ArticuloscomboBox.Text, ToInt(CantidadtextBox.Text), ServiciocomboBox.Text);
            //            if (!string.IsNullOrEmpty(PropietariotextBox.Text))
            //                fa.Propietario = PropietariotextBox.Text;
            //            lista.Add(finca);
            //            FincasdataGridView.DataSource = null;
            //            FincasdataGridView.DataSource = lista;

            //        }
            //        else { }
            //    }
            //    else { }
            //}
            //else { }
        }



        private int ToInt(string texto)
        {
            int entero;
            int.TryParse(texto, out entero);
            return entero;
        }

        private void Limpiar()
        {
            FacturaIdtextBox.Clear();
            SeleccionarClientecomboBox.SelectedIndex = 0;
            DirecciontextBox.Clear();
            TelefonotextBox.Clear();
            ArticuloscomboBox.SelectedIndex = 0;
            CantidadtextBox.Clear();
            ServiciocomboBox.SelectedIndex = 0;
            FacturaFechadateTimePicker.Value = DateTime.Today;
            FacturadataGridView.DataSource = null;
        }

        private void SeleccionarClientecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cliente = ClientesBLL.Buscar((int)SeleccionarClientecomboBox.SelectedValue);
            if (cliente != null)
            {
                DirecciontextBox.Text = cliente.Direccion;
                TelefonotextBox.Text = cliente.Telefono;
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
