using System.Windows.Forms;
using ManitoDeGato.Modelos;
using ManitoDeGato.Repositorios;

namespace ManitoDeGato
{
    public partial class FormAgendamientos : Form
    {
        private readonly RepositorioAgendamientos repositorioAgendamientos = new();
        private readonly RepositorioEstilistas repositorioEstilistas = new();
        private readonly RepositorioServicios repositorioServicios = new();
        private int idSeleccionado = -1;
        private Usuario usuarioActual;

        public FormAgendamientos(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
            ConfigurarPermisos();
            ConfigurarLista();
            CargarDatos();
        }

        private void ConfigurarLista()
        {
            listAgendamientos.View = View.Details;
            listAgendamientos.FullRowSelect = true;
            listAgendamientos.GridLines = true;
            listAgendamientos.Columns.Add("ID", 50);
            listAgendamientos.Columns.Add("Cliente", 150);
            listAgendamientos.Columns.Add("Estilista", 140);
            listAgendamientos.Columns.Add("Servicio", 160);
            listAgendamientos.Columns.Add("Fecha", 140);
            listAgendamientos.Columns.Add("Estado", 100);
        }

        private void CargarDatos()
        {
            listAgendamientos.Items.Clear();
            foreach (var a in repositorioAgendamientos.ObtenerTodos())
            {
                var estilista = repositorioEstilistas.ObtenerPorRut(a.RutEstilista);
                var servicio = repositorioServicios.ObtenerPorId(a.IdServicio);
                string[] fila =
                {
                    a.Id.ToString(),
                    a.NombreCliente,
                    estilista?.Nombre ?? a.RutEstilista,
                    servicio?.Nombre  ?? $"ID {a.IdServicio}",
                    a.Fecha.ToString("dd/MM/yyyy HH:mm"),
                    a.Estado
                };
                var item = new ListViewItem(fila);
                if (a.Estado == "Cancelado") item.ForeColor = System.Drawing.Color.OrangeRed;
                if (a.Estado == "Completado") item.ForeColor = System.Drawing.Color.SeaGreen;
                listAgendamientos.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtRutEstilista.Text) ||
                string.IsNullOrWhiteSpace(txtIdServicio.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!repositorioEstilistas.ExisteRut(txtRutEstilista.Text.Trim()))
            {
                MessageBox.Show("El RUT ingresado no corresponde a ningún estilista registrado.\nRegistra primero al estilista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdServicio.Text, out int idServicio) || repositorioServicios.ObtenerPorId(idServicio) == null)
            {
                MessageBox.Show("El ID de servicio ingresado no existe.\nRevisa la lista de Servicios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repositorioAgendamientos.Agregar(new Agendamiento
            {
                NombreCliente = txtNombreCliente.Text.Trim(),
                RutEstilista = txtRutEstilista.Text.Trim(),
                IdServicio = idServicio,
                Fecha = dtpFecha.Value,
                Estado = cmbEstado.SelectedItem?.ToString() ?? "Pendiente"
            });
            LimpiarCampos();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un agendamiento de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este agendamiento?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            repositorioAgendamientos.Eliminar(idSeleccionado);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un agendamiento de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text) || string.IsNullOrWhiteSpace(txtRutEstilista.Text) ||
                string.IsNullOrWhiteSpace(txtIdServicio.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!repositorioEstilistas.ExisteRut(txtRutEstilista.Text.Trim()))
            {
                MessageBox.Show("El RUT ingresado no corresponde a ningún estilista registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdServicio.Text, out int idServicio) || repositorioServicios.ObtenerPorId(idServicio) == null)
            {
                MessageBox.Show("El ID de servicio ingresado no existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repositorioAgendamientos.Modificar(new Agendamiento
            {
                Id = idSeleccionado,
                NombreCliente = txtNombreCliente.Text.Trim(),
                RutEstilista = txtRutEstilista.Text.Trim(),
                IdServicio = idServicio,
                Fecha = dtpFecha.Value,
                Estado = cmbEstado.SelectedItem?.ToString() ?? "Pendiente"
            });
            MessageBox.Show("Agendamiento modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void listAgendamientos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAgendamientos.SelectedItems.Count > 0)
            {
                idSeleccionado = int.Parse(listAgendamientos.SelectedItems[0].SubItems[0].Text);
                var agendamiento = repositorioAgendamientos.ObtenerPorId(idSeleccionado);
                if (agendamiento == null) return;
                txtNombreCliente.Text = agendamiento.NombreCliente;
                txtRutEstilista.Text = agendamiento.RutEstilista;
                txtIdServicio.Text = agendamiento.IdServicio.ToString();
                dtpFecha.Value = agendamiento.Fecha;
                cmbEstado.SelectedItem = agendamiento.Estado;
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Clear();
            txtRutEstilista.Clear();
            txtIdServicio.Clear();
            dtpFecha.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;
        }

        private void ConfigurarPermisos()
        {
            if (usuarioActual.rol == "Usuario")
            {
                btnEliminar.Visible = false;
            }
        }

    }
}
