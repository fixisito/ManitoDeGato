namespace ManitoDeGato
{
    partial class FormAgendamientos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelFormulario   = new System.Windows.Forms.Panel();
            this.lblTitulo         = new System.Windows.Forms.Label();
            this.lblNombreCliente  = new System.Windows.Forms.Label();
            this.txtNombreCliente  = new System.Windows.Forms.TextBox();
            this.lblRutEstilista   = new System.Windows.Forms.Label();
            this.txtRutEstilista   = new System.Windows.Forms.TextBox();
            this.lblIdServicio     = new System.Windows.Forms.Label();
            this.txtIdServicio     = new System.Windows.Forms.TextBox();
            this.lblFecha          = new System.Windows.Forms.Label();
            this.dtpFecha          = new System.Windows.Forms.DateTimePicker();
            this.lblEstado         = new System.Windows.Forms.Label();
            this.cmbEstado         = new System.Windows.Forms.ComboBox();
            this.btnAgregar        = new System.Windows.Forms.Button();
            this.btnModificar      = new System.Windows.Forms.Button();
            this.btnEliminar       = new System.Windows.Forms.Button();
            this.panelLista        = new System.Windows.Forms.Panel();
            this.listAgendamientos = new System.Windows.Forms.ListView();

            this.panelFormulario.SuspendLayout();
            this.panelLista.SuspendLayout();
            this.SuspendLayout();

            this.panelFormulario.Controls.Add(this.btnEliminar);
            this.panelFormulario.Controls.Add(this.btnModificar);
            this.panelFormulario.Controls.Add(this.btnAgregar);
            this.panelFormulario.Controls.Add(this.cmbEstado);
            this.panelFormulario.Controls.Add(this.lblEstado);
            this.panelFormulario.Controls.Add(this.dtpFecha);
            this.panelFormulario.Controls.Add(this.lblFecha);
            this.panelFormulario.Controls.Add(this.txtIdServicio);
            this.panelFormulario.Controls.Add(this.lblIdServicio);
            this.panelFormulario.Controls.Add(this.txtRutEstilista);
            this.panelFormulario.Controls.Add(this.lblRutEstilista);
            this.panelFormulario.Controls.Add(this.txtNombreCliente);
            this.panelFormulario.Controls.Add(this.lblNombreCliente);
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
            this.lblTitulo.Text      = "Agendamientos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNombreCliente.Location = new System.Drawing.Point(15, 65);
            this.lblNombreCliente.Name     = "lblNombreCliente";
            this.lblNombreCliente.TabIndex = 1;
            this.lblNombreCliente.Text     = "Nombre del cliente:";

            this.txtNombreCliente.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombreCliente.Location = new System.Drawing.Point(15, 83);
            this.txtNombreCliente.Name     = "txtNombreCliente";
            this.txtNombreCliente.Size     = new System.Drawing.Size(258, 25);
            this.txtNombreCliente.TabIndex = 2;

            this.lblRutEstilista.AutoSize = true;
            this.lblRutEstilista.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRutEstilista.Location = new System.Drawing.Point(15, 122);
            this.lblRutEstilista.Name     = "lblRutEstilista";
            this.lblRutEstilista.TabIndex = 3;
            this.lblRutEstilista.Text     = "RUT del estilista:";

            this.txtRutEstilista.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRutEstilista.Location = new System.Drawing.Point(15, 140);
            this.txtRutEstilista.Name     = "txtRutEstilista";
            this.txtRutEstilista.Size     = new System.Drawing.Size(258, 25);
            this.txtRutEstilista.TabIndex = 4;

            this.lblIdServicio.AutoSize = true;
            this.lblIdServicio.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblIdServicio.Location = new System.Drawing.Point(15, 179);
            this.lblIdServicio.Name     = "lblIdServicio";
            this.lblIdServicio.TabIndex = 5;
            this.lblIdServicio.Text     = "ID del servicio:";

            this.txtIdServicio.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIdServicio.Location = new System.Drawing.Point(15, 197);
            this.txtIdServicio.Name     = "txtIdServicio";
            this.txtIdServicio.Size     = new System.Drawing.Size(140, 25);
            this.txtIdServicio.TabIndex = 6;

            this.lblFecha.AutoSize = true;
            this.lblFecha.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblFecha.Location = new System.Drawing.Point(15, 238);
            this.lblFecha.Name     = "lblFecha";
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text     = "Fecha y hora:";

            this.dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFecha.Format       = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location     = new System.Drawing.Point(15, 257);
            this.dtpFecha.Name         = "dtpFecha";
            this.dtpFecha.Size         = new System.Drawing.Size(258, 25);
            this.dtpFecha.TabIndex     = 8;

            this.lblEstado.AutoSize = true;
            this.lblEstado.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblEstado.Location = new System.Drawing.Point(15, 300);
            this.lblEstado.Name     = "lblEstado";
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text     = "Estado:";

            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.Items.AddRange(new object[] { "Pendiente", "Completado", "Cancelado" });
            this.cmbEstado.Location      = new System.Drawing.Point(15, 318);
            this.cmbEstado.Name          = "cmbEstado";
            this.cmbEstado.Size          = new System.Drawing.Size(258, 25);
            this.cmbEstado.TabIndex      = 10;
            this.cmbEstado.SelectedIndex = 0;

            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.Location                  = new System.Drawing.Point(15, 375);
            this.btnAgregar.Name                      = "btnAgregar";
            this.btnAgregar.Size                      = new System.Drawing.Size(258, 42);
            this.btnAgregar.TabIndex                  = 11;
            this.btnAgregar.Text                      = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor   = true;
            this.btnAgregar.Click                    += new System.EventHandler(this.btnAgregar_Click);

            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnModificar.Location                  = new System.Drawing.Point(15, 428);
            this.btnModificar.Name                      = "btnModificar";
            this.btnModificar.Size                      = new System.Drawing.Size(258, 42);
            this.btnModificar.TabIndex                  = 12;
            this.btnModificar.Text                      = "Modificar";
            this.btnModificar.UseVisualStyleBackColor   = true;
            this.btnModificar.Click                    += new System.EventHandler(this.btnModificar_Click);

            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.Location                  = new System.Drawing.Point(15, 481);
            this.btnEliminar.Name                      = "btnEliminar";
            this.btnEliminar.Size                      = new System.Drawing.Size(258, 42);
            this.btnEliminar.TabIndex                  = 13;
            this.btnEliminar.Text                      = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor   = true;
            this.btnEliminar.Click                    += new System.EventHandler(this.btnEliminar_Click);

            this.panelLista.Controls.Add(this.listAgendamientos);
            this.panelLista.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panelLista.Name     = "panelLista";
            this.panelLista.Padding  = new System.Windows.Forms.Padding(10);
            this.panelLista.TabIndex = 1;

            this.listAgendamientos.Dock                            = System.Windows.Forms.DockStyle.Fill;
            this.listAgendamientos.FullRowSelect                   = true;
            this.listAgendamientos.GridLines                       = true;
            this.listAgendamientos.Name                            = "listAgendamientos";
            this.listAgendamientos.TabIndex                        = 0;
            this.listAgendamientos.UseCompatibleStateImageBehavior = false;
            this.listAgendamientos.View                            = System.Windows.Forms.View.Details;
            this.listAgendamientos.SelectedIndexChanged           += new System.EventHandler(this.listAgendamientos_SelectedIndexChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panelFormulario);
            this.Name = "FormAgendamientos";
            this.Text = "Agendamientos";

            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            this.panelLista.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel           panelFormulario;
        private System.Windows.Forms.Label           lblTitulo;
        private System.Windows.Forms.Label           lblNombreCliente;
        private System.Windows.Forms.TextBox         txtNombreCliente;
        private System.Windows.Forms.Label           lblRutEstilista;
        private System.Windows.Forms.TextBox         txtRutEstilista;
        private System.Windows.Forms.Label           lblIdServicio;
        private System.Windows.Forms.TextBox         txtIdServicio;
        private System.Windows.Forms.Label           lblFecha;
        private System.Windows.Forms.DateTimePicker  dtpFecha;
        private System.Windows.Forms.Label           lblEstado;
        private System.Windows.Forms.ComboBox        cmbEstado;
        private System.Windows.Forms.Button          btnAgregar;
        private System.Windows.Forms.Button          btnModificar;
        private System.Windows.Forms.Button          btnEliminar;
        private System.Windows.Forms.Panel           panelLista;
        private System.Windows.Forms.ListView        listAgendamientos;
    }
}
