
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
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var usuario = new Usuarios();

            if (!Validar())
            {
                MessageBox.Show("Completar todos los datos");
                return;
            }
            usuario = LlenarCampos();

            if (ClavetextBox.Text == ConfirmarClavetextBox.Text)
            {
                if (UsuariosBLL.Insertar(usuario))
                {
                    MessageBox.Show("El usuario ha sido Creado");
                }
            }
            else
            {
                MessageBox.Show("La Contraseña esta incorrecta");
            }
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Debe introducir el Nombre del usuario");

                if (string.IsNullOrEmpty(ClavetextBox.Text))
                {
                    ClaveerrorProvider.SetError(ClavetextBox, "Debe introducir la Clave del usuario");
                    if (string.IsNullOrEmpty(ConfirmarClavetextBox.Text))
                    {
                        ConfirmarClaveerrorProvider.SetError(ConfirmarClavetextBox, "Debe introducir la Clave de confirmar del usuario");
                    }
                }
                retorno = false;
            }
            return retorno;
        }       
                       
        private Usuarios LlenarCampos()
        {
            var usuario = new Usuarios();
            usuario.Nombre = NombretextBox.Text;
            usuario.Clave = ClavetextBox.Text;
            return usuario;
        }        

        private void Cancelarbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
