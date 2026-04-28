using ManitoDeGato.Modelos;
using ManitoDeGato.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ManitoDeGato
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            RepositorioUsuarios repositorio = new RepositorioUsuarios();

            var usuario = repositorio.Validar(
                txtNombre.Text.Trim(),
                txtContrasena.Text.Trim()
            );

            if (usuario == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }

            FormPrincipal oform = new FormPrincipal(usuario);
            oform.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrar.Checked;
        }
    }
}
