using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Validar();
            if (ValidarLogin() == DialogResult.OK)
            {
                this.Visible = false;
                FormularioPrincipal fp = new FormularioPrincipal();
                fp.Show();
            }
        }

        public bool ValidarUsuario()
        {
            if (UsuariosBLL.GetListNombreUsuarios(NombretextBox.Text).Count() > 0)
            {
                MessageBox.Show("Usuario incorrecto o no registrado");
                return false;
            }
            return true;
        }

        public bool ValidarClave()
        {
            if (UsuariosBLL.GetListClave(ClavetextBox.Text).Count() > 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }
            return true;
        }

        public DialogResult ValidarLogin()
        {
            if (ValidarUsuario() == true && ValidarClave() == true)
            {
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }

        public void Validar()
        {
            if (ClavetextBox.Text == string.Empty && NombretextBox.Text == string.Empty)
            {
                NombreerrorProvider.SetError(NombretextBox, "Debe insertar el Nombre");
                ClaveerrorProvider.SetError(ClavetextBox, "Debe insertar la Clave");
            }
        }

        public void Limpiar()
        {
            NombretextBox.Clear();
            ClavetextBox.Clear();
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearUsuariolinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
            Registros.RegistroUsuarios ru = new Registros.RegistroUsuarios();
            ru.Show();
        }
    }
}
