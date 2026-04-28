namespace ManitoDeGato
{
    partial class FormEstilistas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFormulario  = new System.Windows.Forms.Panel();
            this.lblTitulo        = new System.Windows.Forms.Label();
            this.lblNombre        = new System.Windows.Forms.Label();
            this.txtNombre        = new System.Windows.Forms.TextBox();
            this.lblRut           = new System.Windows.Forms.Label();
            this.txtRut           = new System.Windows.Forms.TextBox();
            this.lblEspecialidad  = new System.Windows.Forms.Label();
            this.cmbEspecialidad  = new System.Windows.Forms.ComboBox();
            this.lblTelefono      = new System.Windows.Forms.Label();
            this.txtTelefono      = new System.Windows.Forms.TextBox();
            this.btnAgregar       = new System.Windows.Forms.Button();
            this.btnModificar     = new System.Windows.Forms.Button();
            this.btnEliminar      = new System.Windows.Forms.Button();
            this.panelLista       = new System.Windows.Forms.Panel();
            this.listEstilistas   = new System.Windows.Forms.ListView();

            this.panelFormulario.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.SuspendLayout();

            this.panelFormulario.Controls.Add(this.btnEliminar);
            this.panelFormulario.Controls.Add(this.btnModificar);
            this.panelFormulario.Controls.Add(this.btnAgregar);
            this.panelFormulario.Controls.Add(this.txtTelefono);
            this.panelFormulario.Controls.Add(this.lblTelefono);
            this.panelFormulario.Controls.Add(this.cmbEspecialidad);
            this.panelFormulario.Controls.Add(this.lblEspecialidad);
            this.panelFormulario.Controls.Add(this.txtRut);
            this.panelFormulario.Controls.Add(this.lblRut);
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
            this.lblTitulo.Text      = "Estilistas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNombre.AutoSize = true;
            this.lblNombre.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombre.Location = new System.Drawing.Point(15, 68);
            this.lblNombre.Name     = "lblNombre";
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text     = "Nombre completo:";

            this.txtNombre.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Location = new System.Drawing.Point(15, 88);
            this.txtNombre.Name     = "txtNombre";
            this.txtNombre.Size     = new System.Drawing.Size(258, 25);
            this.txtNombre.TabIndex = 2;

            this.lblRut.AutoSize = true;
            this.lblRut.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRut.Location = new System.Drawing.Point(15, 130);
            this.lblRut.Name     = "lblRut";
            this.lblRut.TabIndex = 3;
            this.lblRut.Text     = "RUT:";

            this.txtRut.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRut.Location = new System.Drawing.Point(15, 150);
            this.txtRut.Name     = "txtRut";
            this.txtRut.Size     = new System.Drawing.Size(258, 25);
            this.txtRut.TabIndex = 4;

            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEspecialidad.Location = new System.Drawing.Point(15, 192);
            this.lblEspecialidad.Name     = "lblEspecialidad";
            this.lblEspecialidad.TabIndex = 5;
            this.lblEspecialidad.Text     = "Especialidad:";

            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEspecialidad.Location      = new System.Drawing.Point(15, 212);
            this.cmbEspecialidad.Name          = "cmbEspecialidad";
            this.cmbEspecialidad.Size          = new System.Drawing.Size(258, 26);
            this.cmbEspecialidad.TabIndex      = 6;
            this.cmbEspecialidad.Items.AddRange(new string[] {
                "Colorista",
                "Estilista General",
                "Especialista en Unas",
                "Maquilladora",
                "Barberia",
                "Tratamientos Capilares",
                "Depilacion",
                "Cejas y Pestanas"
            });

            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTelefono.Location = new System.Drawing.Point(15, 255);
            this.lblTelefono.Name     = "lblTelefono";
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text     = "Teléfono:";

            this.txtTelefono.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTelefono.Location = new System.Drawing.Point(15, 275);
            this.txtTelefono.Name     = "txtTelefono";
            this.txtTelefono.Size     = new System.Drawing.Size(258, 25);
            this.txtTelefono.TabIndex = 8;

            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location                  = new System.Drawing.Point(15, 340);
            this.btnAgregar.Name                      = "btnAgregar";
            this.btnAgregar.Size                      = new System.Drawing.Size(258, 42);
            this.btnAgregar.TabIndex                  = 9;
            this.btnAgregar.Text                      = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor   = true;
            this.btnAgregar.Click                    += new System.EventHandler(this.btnAgregar_Click);

            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location                  = new System.Drawing.Point(15, 393);
            this.btnModificar.Name                      = "btnModificar";
            this.btnModificar.Size                      = new System.Drawing.Size(258, 42);
            this.btnModificar.TabIndex                  = 10;
            this.btnModificar.Text                      = "Modificar";
            this.btnModificar.UseVisualStyleBackColor   = true;
            this.btnModificar.Click                    += new System.EventHandler(this.btnModificar_Click);

            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location                  = new System.Drawing.Point(15, 446);
            this.btnEliminar.Name                      = "btnEliminar";
            this.btnEliminar.Size                      = new System.Drawing.Size(258, 42);
            this.btnEliminar.TabIndex                  = 11;
            this.btnEliminar.Text                      = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor   = true;
            this.btnEliminar.Click                    += new System.EventHandler(this.btnEliminar_Click);

            this.panelLista.Controls.Add(this.listEstilistas);
            this.panelLista.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panelLista.Name     = "panelLista";
            this.panelLista.Padding  = new System.Windows.Forms.Padding(10);
            this.panelLista.TabIndex = 1;

            this.listEstilistas.Dock                            = System.Windows.Forms.DockStyle.Fill;
            this.listEstilistas.FullRowSelect                   = true;
            this.listEstilistas.GridLines                       = true;
            this.listEstilistas.Name                            = "listEstilistas";
            this.listEstilistas.TabIndex                        = 0;
            this.listEstilistas.UseCompatibleStateImageBehavior = false;
            this.listEstilistas.View                            = System.Windows.Forms.View.Details;
            this.listEstilistas.SelectedIndexChanged           += new System.EventHandler(this.listEstilistas_SelectedIndexChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormEstilistas";
            this.Text = "Estilistas";

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelLista.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel    panelFormulario;
        private System.Windows.Forms.Label    lblTitulo;
        private System.Windows.Forms.Label    lblNombre;
        private System.Windows.Forms.TextBox  txtNombre;
        private System.Windows.Forms.Label    lblRut;
        private System.Windows.Forms.TextBox  txtRut;
        private System.Windows.Forms.Label    lblEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label    lblTelefono;
        private System.Windows.Forms.TextBox  txtTelefono;
        private System.Windows.Forms.Button   btnAgregar;
        private System.Windows.Forms.Button   btnModificar;
        private System.Windows.Forms.Button   btnEliminar;
        private System.Windows.Forms.Panel    panelLista;
        private System.Windows.Forms.ListView listEstilistas;
    }
}
