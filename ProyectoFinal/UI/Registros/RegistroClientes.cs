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

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes();
            cliente = LlenarCampos();
            if (ClientesBLL.Insertar(cliente))
            {
                Limpiar();
                MessageBox.Show("Cliente Guardado");
            }
        }

        public Clientes LlenarCampos()
        {
            var cliente = new Clientes();
            cliente.Nombres = NombrestextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonotextBox.Text;
            return cliente;
        }

        public void Limpiar()
        {
            NombrestextBox.Text = DirecciontextBox.Text = TelefonotextBox.Text = "";
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(ClienteIdtextBox.Text);
            var cliente = ClientesBLL.Buscar(Id);
            if (cliente != null)
            {
                NombrestextBox.Text = cliente.Nombres;
                DirecciontextBox.Text = cliente.Direccion;
                TelefonotextBox.Text = cliente.Telefono;
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(ClienteIdtextBox.Text);            
            if (ClientesBLL.Eliminar(Id))
            {
                MessageBox.Show("Cliente eliminado");
                Limpiar();
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            /*int Id = Convert.ToInt32(ClienteIdtextBox.Text);
            var cliente = new Clientes();
            
            if (ClientesBLL.Buscar(Id))
            {
                
                MessageBox.Show("Cliente Guardado");
            }*/
        }
    }
}
