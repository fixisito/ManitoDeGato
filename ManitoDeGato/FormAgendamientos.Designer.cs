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
            panelFormulario   = new System.Windows.Forms.Panel();
            lblTitulo         = new System.Windows.Forms.Label();
            lblNombreCliente  = new System.Windows.Forms.Label();
            txtNombreCliente  = new System.Windows.Forms.TextBox();
            lblRutEstilista   = new System.Windows.Forms.Label();
            txtRutEstilista   = new System.Windows.Forms.TextBox();
            lblIdServicio     = new System.Windows.Forms.Label();
            txtIdServicio     = new System.Windows.Forms.TextBox();
            lblFecha          = new System.Windows.Forms.Label();
            dtpFecha          = new System.Windows.Forms.DateTimePicker();
            lblHora           = new System.Windows.Forms.Label();
            dtpHora           = new System.Windows.Forms.DateTimePicker();
            lblEstado         = new System.Windows.Forms.Label();
            cmbEstado         = new System.Windows.Forms.ComboBox();
            btnAgregar        = new System.Windows.Forms.Button();
            btnModificar      = new System.Windows.Forms.Button();
            btnEliminar       = new System.Windows.Forms.Button();
            panelLista        = new System.Windows.Forms.Panel();
            listAgendamientos = new System.Windows.Forms.ListView();

            panelFormulario.SuspendLayout();
            panelLista.SuspendLayout();
            SuspendLayout();

            // panelFormulario
            panelFormulario.Controls.Add(btnEliminar);
            panelFormulario.Controls.Add(btnModificar);
            panelFormulario.Controls.Add(btnAgregar);
            panelFormulario.Controls.Add(cmbEstado);
            panelFormulario.Controls.Add(lblEstado);
            panelFormulario.Controls.Add(dtpHora);
            panelFormulario.Controls.Add(lblHora);
            panelFormulario.Controls.Add(dtpFecha);
            panelFormulario.Controls.Add(lblFecha);
            panelFormulario.Controls.Add(txtIdServicio);
            panelFormulario.Controls.Add(lblIdServicio);
            panelFormulario.Controls.Add(txtRutEstilista);
            panelFormulario.Controls.Add(lblRutEstilista);
            panelFormulario.Controls.Add(txtNombreCliente);
            panelFormulario.Controls.Add(lblNombreCliente);
            panelFormulario.Controls.Add(lblTitulo);
            panelFormulario.Dock     = System.Windows.Forms.DockStyle.Left;
            panelFormulario.Name     = "panelFormulario";
            panelFormulario.Size     = new System.Drawing.Size(310, 800);
            panelFormulario.TabIndex = 0;

            // lblTitulo
            lblTitulo.AutoSize  = false;
            lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location  = new System.Drawing.Point(10, 18);
            lblTitulo.Name      = "lblTitulo";
            lblTitulo.Size      = new System.Drawing.Size(280, 30);
            lblTitulo.TabIndex  = 0;
            lblTitulo.Text      = "Agendamientos";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNombreCliente
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            lblNombreCliente.Location = new System.Drawing.Point(15, 68);
            lblNombreCliente.Name     = "lblNombreCliente";
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text     = "Nombre del cliente:";

            // txtNombreCliente
            txtNombreCliente.Font     = new System.Drawing.Font("Segoe UI", 10F);
            txtNombreCliente.Location = new System.Drawing.Point(15, 88);
            txtNombreCliente.Name     = "txtNombreCliente";
            txtNombreCliente.Size     = new System.Drawing.Size(274, 26);
            txtNombreCliente.TabIndex = 2;

            // lblRutEstilista
            lblRutEstilista.AutoSize = true;
            lblRutEstilista.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            lblRutEstilista.Location = new System.Drawing.Point(15, 130);
            lblRutEstilista.Name     = "lblRutEstilista";
            lblRutEstilista.TabIndex = 3;
            lblRutEstilista.Text     = "RUT del estilista:";

            // txtRutEstilista
            txtRutEstilista.Font     = new System.Drawing.Font("Segoe UI", 10F);
            txtRutEstilista.Location = new System.Drawing.Point(15, 150);
            txtRutEstilista.Name     = "txtRutEstilista";
            txtRutEstilista.Size     = new System.Drawing.Size(274, 26);
            txtRutEstilista.TabIndex = 4;

            // lblIdServicio
            lblIdServicio.AutoSize = true;
            lblIdServicio.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            lblIdServicio.Location = new System.Drawing.Point(15, 192);
            lblIdServicio.Name     = "lblIdServicio";
            lblIdServicio.TabIndex = 5;
            lblIdServicio.Text     = "ID del servicio:";

            // txtIdServicio
            txtIdServicio.Font     = new System.Drawing.Font("Segoe UI", 10F);
            txtIdServicio.Location = new System.Drawing.Point(15, 212);
            txtIdServicio.Name     = "txtIdServicio";
            txtIdServicio.Size     = new System.Drawing.Size(140, 26);
            txtIdServicio.TabIndex = 6;

            // lblFecha
            lblFecha.AutoSize = true;
            lblFecha.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            lblFecha.Location = new System.Drawing.Point(15, 255);
            lblFecha.Name     = "lblFecha";
            lblFecha.TabIndex = 7;
            lblFecha.Text     = "Fecha:";

            // dtpFecha — solo fecha, con calendario desplegable
            dtpFecha.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFecha.Location = new System.Drawing.Point(15, 275);
            dtpFecha.Name     = "dtpFecha";
            dtpFecha.Size     = new System.Drawing.Size(162, 26);
            dtpFecha.TabIndex = 8;

            // lblHora
            lblHora.AutoSize = true;
            lblHora.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            lblHora.Location = new System.Drawing.Point(15, 316);
            lblHora.Name     = "lblHora";
            lblHora.TabIndex = 9;
            lblHora.Text     = "Hora:";

            // dtpHora — solo hora, con flechas para ajustar h/min
            dtpHora.Format       = System.Windows.Forms.DateTimePickerFormat.Time;
            dtpHora.ShowUpDown   = true;
            dtpHora.Location     = new System.Drawing.Point(15, 336);
            dtpHora.Name         = "dtpHora";
            dtpHora.Size         = new System.Drawing.Size(162, 26);
            dtpHora.TabIndex     = 10;

            // lblEstado
            lblEstado.AutoSize = true;
            lblEstado.Font     = new System.Drawing.Font("Segoe UI", 9.5F);
            lblEstado.Location = new System.Drawing.Point(15, 378);
            lblEstado.Name     = "lblEstado";
            lblEstado.TabIndex = 11;
            lblEstado.Text     = "Estado:";

            // cmbEstado
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstado.Font          = new System.Drawing.Font("Segoe UI", 10F);
            cmbEstado.Items.AddRange(new string[] { "Pendiente", "Completado", "Cancelado" });
            cmbEstado.Location      = new System.Drawing.Point(15, 398);
            cmbEstado.Name          = "cmbEstado";
            cmbEstado.Size          = new System.Drawing.Size(274, 26);
            cmbEstado.TabIndex      = 12;

            // btnAgregar
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            btnAgregar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAgregar.Location                  = new System.Drawing.Point(15, 460);
            btnAgregar.Name                      = "btnAgregar";
            btnAgregar.Size                      = new System.Drawing.Size(274, 42);
            btnAgregar.TabIndex                  = 13;
            btnAgregar.Text                      = "Agregar";
            btnAgregar.UseVisualStyleBackColor   = true;
            btnAgregar.Click                    += new System.EventHandler(this.btnAgregar_Click);

            // btnModificar
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            btnModificar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnModificar.Location                  = new System.Drawing.Point(15, 513);
            btnModificar.Name                      = "btnModificar";
            btnModificar.Size                      = new System.Drawing.Size(274, 42);
            btnModificar.TabIndex                  = 14;
            btnModificar.Text                      = "Modificar";
            btnModificar.UseVisualStyleBackColor   = true;
            btnModificar.Click                    += new System.EventHandler(this.btnModificar_Click);

            // btnEliminar
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            btnEliminar.Font                      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnEliminar.Location                  = new System.Drawing.Point(15, 566);
            btnEliminar.Name                      = "btnEliminar";
            btnEliminar.Size                      = new System.Drawing.Size(274, 42);
            btnEliminar.TabIndex                  = 15;
            btnEliminar.Text                      = "Eliminar";
            btnEliminar.UseVisualStyleBackColor   = true;
            btnEliminar.Click                    += new System.EventHandler(this.btnEliminar_Click);

            // panelLista
            panelLista.Controls.Add(listAgendamientos);
            panelLista.Dock     = System.Windows.Forms.DockStyle.Fill;
            panelLista.Name     = "panelLista";
            panelLista.Padding  = new System.Windows.Forms.Padding(10);
            panelLista.TabIndex = 1;

            // listAgendamientos
            listAgendamientos.Dock                            = System.Windows.Forms.DockStyle.Fill;
            listAgendamientos.FullRowSelect                   = true;
            listAgendamientos.GridLines                       = true;
            listAgendamientos.Name                            = "listAgendamientos";
            listAgendamientos.TabIndex                        = 0;
            listAgendamientos.UseCompatibleStateImageBehavior = false;
            listAgendamientos.View                            = System.Windows.Forms.View.Details;
            listAgendamientos.SelectedIndexChanged           += new System.EventHandler(this.listAgendamientos_SelectedIndexChanged);

            // FormAgendamientos
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize          = new System.Drawing.Size(971, 800);
            Controls.Add(panelLista);
            Controls.Add(panelFormulario);
            Name = "FormAgendamientos";
            Text = "Agendamientos";

            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            panelLista.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Label           lblHora;
        private System.Windows.Forms.DateTimePicker  dtpHora;
        private System.Windows.Forms.Label           lblEstado;
        private System.Windows.Forms.ComboBox        cmbEstado;
        private System.Windows.Forms.Button          btnAgregar;
        private System.Windows.Forms.Button          btnModificar;
        private System.Windows.Forms.Button          btnEliminar;
        private System.Windows.Forms.Panel           panelLista;
        private System.Windows.Forms.ListView        listAgendamientos;
    }
}
