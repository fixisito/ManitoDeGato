namespace ManitoDeGato
{
    partial class FormProductos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFormulario = new System.Windows.Forms.Panel();
            this.lblTitulo       = new System.Windows.Forms.Label();
            this.lblNombre       = new System.Windows.Forms.Label();
            this.txtNombre       = new System.Windows.Forms.TextBox();
            this.lblCategoria    = new System.Windows.Forms.Label();
            this.cmbCategoria    = new System.Windows.Forms.ComboBox();
            this.lblStock        = new System.Windows.Forms.Label();
            this.txtStock        = new System.Windows.Forms.TextBox();
            this.lblPrecio       = new System.Windows.Forms.Label();
            this.txtPrecio       = new System.Windows.Forms.TextBox();
            this.lblAlertaStock  = new System.Windows.Forms.Label();
            this.btnAgregar      = new System.Windows.Forms.Button();
            this.btnModificar    = new System.Windows.Forms.Button();
            this.btnEliminar     = new System.Windows.Forms.Button();
            this.panelLista      = new System.Windows.Forms.Panel();
            this.listProductos   = new System.Windows.Forms.ListView();

            this.panelFormulario.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.SuspendLayout();

            this.panelFormulario.Controls.Add(this.btnEliminar);
            this.panelFormulario.Controls.Add(this.btnModificar);
            this.panelFormulario.Controls.Add(this.btnAgregar);
            this.panelFormulario.Controls.Add(this.lblAlertaStock);
            this.panelFormulario.Controls.Add(this.txtPrecio);
            this.panelFormulario.Controls.Add(this.lblPrecio);
            this.panelFormulario.Controls.Add(this.txtStock);
            this.panelFormulario.Controls.Add(this.lblStock);
            this.panelFormulario.Controls.Add(this.cmbCategoria);
            this.panelFormulario.Controls.Add(this.lblCategoria);
            this.panelFormulario.Controls.Add(this.txtNombre);
            this.panelFormulario.Controls.Add(this.lblNombre);
            this.panelFormulario.Controls.Add(this.lblTitulo);
            this.panelFormulario.Dock     = System.Windows.Forms.DockStyle.Left;
            this.panelFormulario.Name     = "panelFormulario";
            this.panelFormulario.Size     = new System.Drawing.Size(295, 600);
            this.panelFormulario.TabIndex = 0;

            this.lblTitulo.AutoSize  = false;
            this.lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location  = new System.Drawing.Point(10, 18);
            this.lblTitulo.Name      = "lblTitulo";
            this.lblTitulo.Size      = new System.Drawing.Size(270, 30);
            this.lblTitulo.TabIndex  = 0;
            this.lblTitulo.Text      = "Productos / Stock";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNombre.AutoSize = true;
            this.lblNombre.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.Location = new System.Drawing.Point(15, 68);
            this.lblNombre.Name     = "lblNombre";
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text     = "Nombre del producto:";

            this.txtNombre.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(15, 88);
            this.txtNombre.Name     = "txtNombre";
            this.txtNombre.Size     = new System.Drawing.Size(258, 25);
            this.txtNombre.TabIndex = 2;

            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblCategoria.Location = new System.Drawing.Point(15, 130);
            this.lblCategoria.Name     = "lblCategoria";
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text     = "Categoría:";

            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategoria.Location      = new System.Drawing.Point(15, 150);
            this.cmbCategoria.Name          = "cmbCategoria";
            this.cmbCategoria.Size          = new System.Drawing.Size(258, 26);
            this.cmbCategoria.TabIndex      = 4;
            this.cmbCategoria.Items.AddRange(new string[] {
                "Shampoo y Acondicionador",
                "Tintes y Coloracion",
                "Tratamiento Capilar",
                "Herramientas y Equipos",
                "Esmaltes y Unas",
                "Maquillaje",
                "Cremas y Mascaras",
                "Aceites y Serums",
                "Depilacion",
                "Accesorios"
            });

            this.lblStock.AutoSize = true;
            this.lblStock.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStock.Location = new System.Drawing.Point(15, 192);
            this.lblStock.Name     = "lblStock";
            this.lblStock.TabIndex = 5;
            this.lblStock.Text     = "Stock actual (unidades):";

            this.txtStock.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStock.Location = new System.Drawing.Point(15, 212);
            this.txtStock.Name     = "txtStock";
            this.txtStock.Size     = new System.Drawing.Size(140, 25);
            this.txtStock.TabIndex = 6;

            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPrecio.Location = new System.Drawing.Point(15, 255);
            this.lblPrecio.Name     = "lblPrecio";
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text     = "Precio unitario ($):";

            this.txtPrecio.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrecio.Location = new System.Drawing.Point(15, 275);
            this.txtPrecio.Name     = "txtPrecio";
            this.txtPrecio.Size     = new System.Drawing.Size(140, 25);
            this.txtPrecio.TabIndex = 8;

            this.lblAlertaStock.AutoSize  = false;
            this.lblAlertaStock.Font      = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblAlertaStock.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAlertaStock.Location  = new System.Drawing.Point(15, 308);
            this.lblAlertaStock.Name      = "lblAlertaStock";
            this.lblAlertaStock.Size      = new System.Drawing.Size(258, 18);
            this.lblAlertaStock.TabIndex  = 9;
            this.lblAlertaStock.Text      = "⚠ Stock ≤ 5 se marca en rojo en la lista";

            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location                  = new System.Drawing.Point(15, 348);
            this.btnAgregar.Name                      = "btnAgregar";
            this.btnAgregar.Size                      = new System.Drawing.Size(258, 42);
            this.btnAgregar.TabIndex                  = 10;
            this.btnAgregar.Text                      = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor   = true;
            this.btnAgregar.Click                    += new System.EventHandler(this.btnAgregar_Click);

            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location                  = new System.Drawing.Point(15, 401);
            this.btnModificar.Name                      = "btnModificar";
            this.btnModificar.Size                      = new System.Drawing.Size(258, 42);
            this.btnModificar.TabIndex                  = 11;
            this.btnModificar.Text                      = "Modificar";
            this.btnModificar.UseVisualStyleBackColor   = true;
            this.btnModificar.Click                    += new System.EventHandler(this.btnModificar_Click);

            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location                  = new System.Drawing.Point(15, 454);
            this.btnEliminar.Name                      = "btnEliminar";
            this.btnEliminar.Size                      = new System.Drawing.Size(258, 42);
            this.btnEliminar.TabIndex                  = 12;
            this.btnEliminar.Text                      = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor   = true;
            this.btnEliminar.Click                    += new System.EventHandler(this.btnEliminar_Click);

            this.panelLista.Controls.Add(this.listProductos);
            this.panelLista.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panelLista.Name     = "panelLista";
            this.panelLista.Padding  = new System.Windows.Forms.Padding(10);
            this.panelLista.TabIndex = 1;

            this.listProductos.Dock                            = System.Windows.Forms.DockStyle.Fill;
            this.listProductos.FullRowSelect                   = true;
            this.listProductos.GridLines                       = true;
            this.listProductos.Name                            = "listProductos";
            this.listProductos.TabIndex                        = 0;
            this.listProductos.UseCompatibleStateImageBehavior = false;
            this.listProductos.View                            = System.Windows.Forms.View.Details;
            this.listProductos.SelectedIndexChanged           += new System.EventHandler(this.listProductos_SelectedIndexChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormProductos";
            this.Text = "Productos";

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelLista.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel    panelFormulario;
        private System.Windows.Forms.Label    lblTitulo;
        private System.Windows.Forms.Label    lblNombre;
        private System.Windows.Forms.TextBox  txtNombre;
        private System.Windows.Forms.Label    lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label    lblStock;
        private System.Windows.Forms.TextBox  txtStock;
        private System.Windows.Forms.Label    lblPrecio;
        private System.Windows.Forms.TextBox  txtPrecio;
        private System.Windows.Forms.Label    lblAlertaStock;
        private System.Windows.Forms.Button   btnAgregar;
        private System.Windows.Forms.Button   btnModificar;
        private System.Windows.Forms.Button   btnEliminar;
        private System.Windows.Forms.Panel    panelLista;
        private System.Windows.Forms.ListView listProductos;
    }
}
