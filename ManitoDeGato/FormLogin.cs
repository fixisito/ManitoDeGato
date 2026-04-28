using ManitoDeGato.Modelos;
using ManitoDeGato.Repositorios;
using System.Drawing;
using System.Windows.Forms;

namespace ManitoDeGato
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            AplicarEstilo();
        }

        private void AplicarEstilo()
        {
            Color acento     = GestorTema.EsModoOscuro ? GestorTema.AcentoOscuro : GestorTema.AcentoClaro;
            Color fondoForm  = GestorTema.EsModoOscuro ? GestorTema.FondoOscuro  : GestorTema.FondoClaro;
            Color fondoCard  = GestorTema.EsModoOscuro ? GestorTema.PanelOscuro  : GestorTema.PanelClaro;
            Color colorTexto = GestorTema.EsModoOscuro ? GestorTema.TextoOscuro  : GestorTema.TextoClaro;
            Color fondoCampo = GestorTema.EsModoOscuro ? Color.FromArgb(55, 38, 65) : Color.White;
            Color textoCampo = GestorTema.EsModoOscuro ? Color.White : Color.Black;

            // Formulario
            BackColor = fondoForm;

            // Panel fondo
            panelFondo.BackColor = fondoForm;

            // Centrar panelCard dentro del formulario al cargar
            panelCard.Left      = (ClientSize.Width  - panelCard.Width)  / 2;
            panelCard.Top       = (ClientSize.Height - panelCard.Height) / 2;
            panelCard.BackColor = fondoCard;

            // Labels
            lblTitulo.ForeColor    = acento;
            lblTitulo.BackColor    = Color.Transparent;
            lblSubtitulo.ForeColor = colorTexto;
            lblSubtitulo.BackColor = Color.Transparent;
            lblNombre.ForeColor    = colorTexto;
            lblNombre.BackColor    = Color.Transparent;
            lblContrasena.ForeColor = colorTexto;
            lblContrasena.BackColor = Color.Transparent;
            chkMostrar.ForeColor   = colorTexto;
            chkMostrar.BackColor   = Color.Transparent;

            // Campos
            txtNombre.BackColor     = fondoCampo;
            txtNombre.ForeColor     = textoCampo;
            txtContrasena.BackColor = fondoCampo;
            txtContrasena.ForeColor = textoCampo;

            // Botón principal
            btnIniciar.BackColor = acento;
            btnIniciar.ForeColor = Color.White;

            // Botón salir
            btnSalir.BackColor = fondoCard;
            btnSalir.ForeColor = colorTexto;
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
                MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
