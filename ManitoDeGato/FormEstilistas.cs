using System.Windows.Forms;
using ManitoDeGato.Modelos;
using ManitoDeGato.Repositorios;

namespace ManitoDeGato
{
    public partial class FormEstilistas : Form
    {
        private readonly RepositorioEstilistas repositorio = new();
        private int idSeleccionado = -1;

        public FormEstilistas()
        {
            InitializeComponent();
            ConfigurarLista();
            CargarDatos();
        }

        private void ConfigurarLista()
        {
            listEstilistas.View          = View.Details;
            listEstilistas.FullRowSelect = true;
            listEstilistas.GridLines     = true;
            listEstilistas.Columns.Add("ID",           55);
            listEstilistas.Columns.Add("Nombre",      175);
            listEstilistas.Columns.Add("RUT",         120);
            listEstilistas.Columns.Add("Especialidad", 160);
            listEstilistas.Columns.Add("Teléfono",    120);
        }

        private void CargarDatos()
        {
            listEstilistas.Items.Clear();
            foreach (var e in repositorio.ObtenerTodos())
            {
                string[] fila = { e.Id.ToString(), e.Nombre, e.Rut, e.Especialidad, e.Telefono };
                listEstilistas.Items.Add(new ListViewItem(fila));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtRut.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (repositorio.ExisteRut(txtRut.Text.Trim()))
            {
                MessageBox.Show("Ya existe un estilista registrado con ese RUT.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            repositorio.Agregar(new Estilista
            {
                Nombre       = txtNombre.Text.Trim(),
                Rut          = txtRut.Text.Trim(),
                Especialidad = txtEspecialidad.Text.Trim(),
                Telefono     = txtTelefono.Text.Trim()
            });
            LimpiarCampos();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un estilista de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este estilista?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            repositorio.Eliminar(idSeleccionado);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un estilista de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtRut.Text) ||
                string.IsNullOrWhiteSpace(txtEspecialidad.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var actual = repositorio.ObtenerPorId(idSeleccionado);
            if (actual != null && !actual.Rut.Equals(txtRut.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("No se puede modificar el RUT del estilista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRut.Text = actual.Rut;
                return;
            }

            repositorio.Modificar(new Estilista
            {
                Id           = idSeleccionado,
                Nombre       = txtNombre.Text.Trim(),
                Rut          = txtRut.Text.Trim(),
                Especialidad = txtEspecialidad.Text.Trim(),
                Telefono     = txtTelefono.Text.Trim()
            });
            MessageBox.Show("Estilista modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void listEstilistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listEstilistas.SelectedItems.Count > 0)
            {
                idSeleccionado = int.Parse(listEstilistas.SelectedItems[0].SubItems[0].Text);
                var estilista  = repositorio.ObtenerPorId(idSeleccionado);
                if (estilista == null) return;
                txtNombre.Text       = estilista.Nombre;
                txtRut.Text          = estilista.Rut;
                txtEspecialidad.Text = estilista.Especialidad;
                txtTelefono.Text     = estilista.Telefono;
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtRut.Clear();
            txtEspecialidad.Clear();
            txtTelefono.Clear();
        }
    }
}
