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
    public partial class ConsultaClientes : Form
    {
        Clientes cliente = new Clientes(); 

        public ConsultaClientes()
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
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            ClientedataGridView.DataSource = ClientesBLL.GetList();
        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                ClientedataGridView.DataSource = ClientesBLL.GetListClienteId(Utilidades.ToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                ClientedataGridView.DataSource = ClientesBLL.GetListNombres(FiltrotextBox.Text);
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (FiltrocomboBox.SelectedIndex == 1 && ClientesBLL.GetListNombres(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro" + "\n" + "\n" + "Intente con otro campo");
                return false;
            }
            if (FiltrocomboBox.SelectedIndex == 0 && ClientesBLL.GetListClienteId(Utilidades.ToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro" + "\n" + "\n" + "Intente con otro campo");
                return false;
            }
            BuscarerrorProvider.Clear();
            return true;
        }

        private void ConsultaClientes_Load(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
