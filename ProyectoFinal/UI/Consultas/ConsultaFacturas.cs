using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Consultas
{
    public partial class ConsultaFacturas : Form
    {
        Clientes cliente = new Clientes(); 

        public ConsultaFacturas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar() == true)
                BuscarSeleccion();
        }

        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Nombre");
            FiltrocomboBox.Items.Insert(2, "Fecha de ingreso");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            FacturadataGridView.DataSource = FacturasBLL.GetList();

        }

        public int StringToInt(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                FacturadataGridView.DataSource = FacturasBLL.GetListId(StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                FacturadataGridView.DataSource = FacturasBLL.GetListClienteId(StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 2)
                FacturadataGridView.DataSource = FacturasBLL.GetListFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
        }

        private bool validar()
        {

            if (FiltrocomboBox.SelectedIndex == 3)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor colocar un intervalo entre las dos fechas");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrocomboBox.SelectedIndex == 1 && FacturasBLL.GetListClienteId(StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro" + "\n" + "\n" + "Intente con otro campo");
                return false;
            }
            if (FiltrocomboBox.SelectedIndex == 0 && FacturasBLL.GetListId(StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro" + "\n" + "\n" + "Intente con otro campo");
                return false;
            }
            BuscarerrorProvider.Clear();
            return true;
        }

        private void ConsultaFacturas_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
