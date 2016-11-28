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

        public void Validar()
        {
            Utilidades ut = new Utilidades(ClienteIdtextBox, "N");
            Utilidades ut1 = new Utilidades(NombrestextBox,"L");
            Utilidades ut2 = new Utilidades(DirecciontextBox, "LN");           
        }

        public Clientes LlenarCampos()
        {
            var cliente = new Clientes();
            cliente.Nombres = NombrestextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;
            cliente.Telefono = TelefonomaskedTextBox.Text;
            return cliente;
        }

        public void Limpiar()
        {
            ClienteIdtextBox.Clear();
            NombrestextBox.Clear();
            DirecciontextBox.Clear();
            TelefonomaskedTextBox.Clear();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(ClienteIdtextBox.Text);
            var cliente = ClientesBLL.Buscar(Id);
            if (cliente != null)
            {
                NombrestextBox.Text = cliente.Nombres;
                DirecciontextBox.Text = cliente.Direccion;
                TelefonomaskedTextBox.Text = cliente.Telefono;
            }
            else
            {
                MessageBox.Show("Cliente No Registrado");
            }
        }

        public static int ToInt(string texto)
        {
            int numero;
            int.TryParse(texto, out numero);

            return numero;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var cliente = ClientesBLL.Buscar(ToInt(ClienteIdtextBox.Text));
            if (cliente != null)
            {
                if (ClientesBLL.Eliminar(cliente))
                    MessageBox.Show("La factoria ha sido eliminada");                
            }

            //int Id = Convert.ToInt32(ClienteIdtextBox.Text);            
            //if (ClientesBLL.Eliminar(Id))
            //{
            //    MessageBox.Show("Cliente Eliminado");
            //    Limpiar();
            //}
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            Limpiar();           
        }

        private void RegistroClientes_Load(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
