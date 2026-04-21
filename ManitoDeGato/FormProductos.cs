using System.Windows.Forms;
using ManitoDeGato.Modelos;
using ManitoDeGato.Repositorios;

namespace ManitoDeGato
{
    public partial class FormProductos : Form
    {
        private readonly RepositorioProductos repositorio = new();
        private int idSeleccionado = -1;

        public FormProductos()
        {
            InitializeComponent();
            ConfigurarLista();
            CargarDatos();
        }

        private void ConfigurarLista()
        {
            listProductos.View          = View.Details;
            listProductos.FullRowSelect = true;
            listProductos.GridLines     = true;
            listProductos.Columns.Add("ID",            55);
            listProductos.Columns.Add("Nombre",       190);
            listProductos.Columns.Add("Categoría",    140);
            listProductos.Columns.Add("Stock",         80);
            listProductos.Columns.Add("Precio Unit.", 110);
        }

        private void CargarDatos()
        {
            listProductos.Items.Clear();
            foreach (var p in repositorio.ObtenerTodos())
            {
                string[] fila = { p.Id.ToString(), p.Nombre, p.Categoria, p.StockActual.ToString(), p.PrecioUnitario.ToString("N0") };
                var item = new ListViewItem(fila);
                if (p.StockActual <= 5) item.ForeColor = System.Drawing.Color.OrangeRed;
                listProductos.Items.Add(item);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text)  || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero mayor o igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor o igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repositorio.Agregar(new Producto { Nombre = txtNombre.Text.Trim(), Categoria = txtCategoria.Text.Trim(), StockActual = stock, PrecioUnitario = precio });

            if (stock <= 5)
                MessageBox.Show($"Producto agregado. Stock bajo (≤ 5 unidades) — considera reabastecer pronto.", "Aviso de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            LimpiarCampos();
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            repositorio.Eliminar(idSeleccionado);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == -1)
            {
                MessageBox.Show("Selecciona un producto de la lista para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text)  || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor completa todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero mayor o igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor o igual a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            repositorio.Modificar(new Producto { Id = idSeleccionado, Nombre = txtNombre.Text.Trim(), Categoria = txtCategoria.Text.Trim(), StockActual = stock, PrecioUnitario = precio });
            MessageBox.Show("Producto modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            idSeleccionado = -1;
            LimpiarCampos();
            CargarDatos();
        }

        private void listProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listProductos.SelectedItems.Count > 0)
            {
                idSeleccionado = int.Parse(listProductos.SelectedItems[0].SubItems[0].Text);
                var producto   = repositorio.ObtenerPorId(idSeleccionado);
                if (producto == null) return;
                txtNombre.Text   = producto.Nombre;
                txtCategoria.Text = producto.Categoria;
                txtStock.Text    = producto.StockActual.ToString();
                txtPrecio.Text   = producto.PrecioUnitario.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
        }
    }
}
