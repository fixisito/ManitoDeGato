using System.Windows.Forms;
using ManitoDeGato.Modelos;
using ManitoDeGato.Repositorios;

namespace ManitoDeGato
{
    public partial class FormServicios : Form
    {
        private readonly RepositorioServicios repositorio = new();
        private int idSeleccionado = -1;
        private Usuario usuarioActual;

        public FormServicios(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarPermisos();
            ConfigurarLista();
            CargarDatos();
        }

        private void ConfigurarLista()
        {
            listServicios.View          = View.Details;
            listServicios.FullRowSelect = true;
            listServicios.GridLines     = true;
            listServicios.Columns.Add("ID",             55);
            listServicios.Columns.Add("Nombre",        200);
            listServicios.Columns.Add("Categoría",     140);
            listServicios.Columns.Add("Precio ($)",    110);
            listServicios.Columns.Add("Duración (min)", 120);
        }

        private void CargarDatos()
        {
            listServicios.Items.Clear();
            foreach (var s in repositorio.ObtenerTodos())
            {
                string[] fila = { s.Id.ToString(), s.Nombre, s.Categoria, s.Precio.ToString("N0"), s.DuracionMinutos.ToString() };
                listServicios.Items.Add(new ListViewItem(fila));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtDuracion.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor o igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDuracion.Text, out int duracion) || duracion <= 0)
            {
                MessageBox.Show("La duración debe ser un número entero mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repositorio.Agregar(new Servicio { Nombre = txtNombre.Text.Trim(), Categoria = txtCategoria.Text.Trim(), Precio = precio, DuracionMinutos = duracion });
            LimpiarCampos();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un servicio de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este servicio?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            repositorio.Eliminar(idSeleccionado);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un servicio de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtDuracion.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor o igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDuracion.Text, out int duracion) || duracion <= 0)
            {
                MessageBox.Show("La duración debe ser un número entero mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repositorio.Modificar(new Servicio { Id = idSeleccionado, Nombre = txtNombre.Text.Trim(), Categoria = txtCategoria.Text.Trim(), Precio = precio, DuracionMinutos = duracion });
            MessageBox.Show("Servicio modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void listServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listServicios.SelectedItems.Count > 0)
            {
                idSeleccionado = int.Parse(listServicios.SelectedItems[0].SubItems[0].Text);
                var servicio   = repositorio.ObtenerPorId(idSeleccionado);
                if (servicio == null) return;
                txtNombre.Text   = servicio.Nombre;
                txtCategoria.Text = servicio.Categoria;
                txtPrecio.Text   = servicio.Precio.ToString();
                txtDuracion.Text = servicio.DuracionMinutos.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtPrecio.Clear();
            txtDuracion.Clear();
        }

        private void ConfigurarPermisos()
        {
            if (usuarioActual.rol != "Admin")
            {
                btnAgregar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;

                txtNombre.Enabled = false;
                txtCategoria.Enabled = false;
                txtPrecio.Enabled = false;
                txtDuracion.Enabled = false;
            }
        }

    }
}
