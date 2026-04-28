using ManitoDeGato.Modelos;
using System.Drawing;
using System.Windows.Forms;

namespace ManitoDeGato
{
    public partial class FormPrincipal : Form
    {
        private Button? botonActual;
        private Form? formularioActivo;
        private Usuario usuarioActual;

        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            AplicarTemaActual();
            ConfigurarPermisos();
        }

        private void AplicarTemaActual()
        {
            GestorTema.AplicarTema(this);

            if (GestorTema.EsModoOscuro)
            {
                panelMenuLateral.BackColor = GestorTema.PanelOscuro;
                panelLogo.BackColor = GestorTema.FondoOscuro;
                panelCabecera.BackColor = GestorTema.PanelOscuro;
                btnAlternarTema.Text = "Modo Claro";
                btnAlternarTema.BackColor = GestorTema.AcentoOscuro;
                btnAlternarTema.ForeColor = Color.White;
            }
            else
            {
                panelMenuLateral.BackColor = Color.White;
                panelLogo.BackColor = GestorTema.FondoClaro;
                panelCabecera.BackColor = Color.White;
                btnAlternarTema.Text = "Modo Oscuro";
                btnAlternarTema.BackColor = GestorTema.AcentoClaro;
                btnAlternarTema.ForeColor = Color.White;
            }

            if (formularioActivo != null)
            {
                GestorTema.AplicarTema(formularioActivo);
                formularioActivo.BackColor = GestorTema.EsModoOscuro ? GestorTema.FondoOscuro : GestorTema.FondoClaro;
            }
        }

        private void btnAlternarTema_Click(object sender, EventArgs e)
        {
            GestorTema.EsModoOscuro = !GestorTema.EsModoOscuro;
            AplicarTemaActual();
        }

        private void ActivarBoton(object btnSender)
        {
            if (btnSender is Button boton && botonActual != boton)
            {
                DesactivarBoton();
                Color acento = GestorTema.EsModoOscuro ? GestorTema.AcentoOscuro : GestorTema.AcentoClaro;
                botonActual = boton;
                botonActual.BackColor = acento;
                botonActual.ForeColor = Color.White;
                botonActual.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            }
        }

        private void DesactivarBoton()
        {
            foreach (Control ctrl in panelMenuLateral.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = GestorTema.EsModoOscuro ? GestorTema.PanelOscuro : Color.White;
                    btn.ForeColor = GestorTema.EsModoOscuro ? Color.White : GestorTema.TextoClaro;
                    btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void AbrirFormularioHijo(Form formularioHijo, object btnSender)
        {
            formularioActivo?.Close();
            ActivarBoton(btnSender);
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formularioHijo);
            panelEscritorio.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
            lblTituloPrincipal.Text = formularioHijo.Text;
            GestorTema.AplicarTema(formularioHijo);
            formularioHijo.BackColor = GestorTema.EsModoOscuro ? GestorTema.FondoOscuro : GestorTema.FondoClaro;
        }

        private void btnServicios_Click(object sender, EventArgs e) => AbrirFormularioHijo(new FormServicios(usuarioActual), sender);
        private void btnEstilistas_Click(object sender, EventArgs e) => AbrirFormularioHijo(new FormEstilistas(usuarioActual), sender);
        private void btnAgendamientos_Click(object sender, EventArgs e) => AbrirFormularioHijo(new FormAgendamientos(usuarioActual), sender);
        private void btnProductos_Click(object sender, EventArgs e) => AbrirFormularioHijo(new FormProductos(usuarioActual), sender);

        private void ConfigurarPermisos()
        {
            if (usuarioActual.rol == "Admin")
            {
                btnServicios.Enabled = true;
                btnEstilistas.Enabled = true;
                btnAgendamientos.Enabled = true;
                btnProductos.Enabled = true;
            }
            else
            {
                btnServicios.Enabled = true;
                btnEstilistas.Enabled = true;
                btnAgendamientos.Enabled = true;

                btnProductos.Enabled = false;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormLogin ologin = new FormLogin();
            ologin.Show();

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
