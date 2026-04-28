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
            panelFormulario = new Panel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            cmbEstado = new ComboBox();
            lblEstado = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            txtIdServicio = new TextBox();
            lblIdServicio = new Label();
            txtRutEstilista = new TextBox();
            lblRutEstilista = new Label();
            txtNombreCliente = new TextBox();
            lblNombreCliente = new Label();
            lblTitulo = new Label();
            panelLista = new Panel();
            listAgendamientos = new ListView();
            panelFormulario.SuspendLayout();
            panelLista.SuspendLayout();
            SuspendLayout();
            // 
            // panelFormulario
            // 
            panelFormulario.Controls.Add(btnEliminar);
            panelFormulario.Controls.Add(btnModificar);
            panelFormulario.Controls.Add(btnAgregar);
            panelFormulario.Controls.Add(cmbEstado);
            panelFormulario.Controls.Add(lblEstado);
            panelFormulario.Controls.Add(dtpFecha);
            panelFormulario.Controls.Add(lblFecha);
            panelFormulario.Controls.Add(txtIdServicio);
            panelFormulario.Controls.Add(lblIdServicio);
            panelFormulario.Controls.Add(txtRutEstilista);
            panelFormulario.Controls.Add(lblRutEstilista);
            panelFormulario.Controls.Add(txtNombreCliente);
            panelFormulario.Controls.Add(lblNombreCliente);
            panelFormulario.Controls.Add(lblTitulo);
            panelFormulario.Dock = DockStyle.Left;
            panelFormulario.Location = new Point(0, 0);
            panelFormulario.Margin = new Padding(3, 4, 3, 4);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(337, 800);
            panelFormulario.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.Location = new Point(17, 641);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(295, 56);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.Location = new Point(17, 571);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(295, 56);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.Location = new Point(17, 500);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(295, 56);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.Font = new Font("Segoe UI", 10F);
            cmbEstado.Items.AddRange(new object[] { "Pendiente", "Completado", "Cancelado" });
            cmbEstado.Location = new Point(17, 424);
            cmbEstado.Margin = new Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(294, 31);
            cmbEstado.TabIndex = 10;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.5F);
            lblEstado.Location = new Point(17, 400);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(59, 21);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Estado:";
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(17, 343);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(294, 27);
            dtpFecha.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.5F);
            lblFecha.Location = new Point(17, 317);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(101, 21);
            lblFecha.TabIndex = 7;
            lblFecha.Text = "Fecha y hora:";
            // 
            // txtIdServicio
            // 
            txtIdServicio.Font = new Font("Segoe UI", 10F);
            txtIdServicio.Location = new Point(17, 263);
            txtIdServicio.Margin = new Padding(3, 4, 3, 4);
            txtIdServicio.Name = "txtIdServicio";
            txtIdServicio.Size = new Size(159, 30);
            txtIdServicio.TabIndex = 6;
            // 
            // lblIdServicio
            // 
            lblIdServicio.AutoSize = true;
            lblIdServicio.Font = new Font("Segoe UI", 9.5F);
            lblIdServicio.Location = new Point(17, 239);
            lblIdServicio.Name = "lblIdServicio";
            lblIdServicio.Size = new Size(110, 21);
            lblIdServicio.TabIndex = 5;
            lblIdServicio.Text = "ID del servicio:";
            // 
            // txtRutEstilista
            // 
            txtRutEstilista.Font = new Font("Segoe UI", 10F);
            txtRutEstilista.Location = new Point(17, 187);
            txtRutEstilista.Margin = new Padding(3, 4, 3, 4);
            txtRutEstilista.Name = "txtRutEstilista";
            txtRutEstilista.Size = new Size(294, 30);
            txtRutEstilista.TabIndex = 4;
            // 
            // lblRutEstilista
            // 
            lblRutEstilista.AutoSize = true;
            lblRutEstilista.Font = new Font("Segoe UI", 9.5F);
            lblRutEstilista.Location = new Point(17, 163);
            lblRutEstilista.Name = "lblRutEstilista";
            lblRutEstilista.Size = new Size(123, 21);
            lblRutEstilista.TabIndex = 3;
            lblRutEstilista.Text = "RUT del estilista:";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Segoe UI", 10F);
            txtNombreCliente.Location = new Point(17, 111);
            txtNombreCliente.Margin = new Padding(3, 4, 3, 4);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(294, 30);
            txtNombreCliente.TabIndex = 2;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Segoe UI", 9.5F);
            lblNombreCliente.Location = new Point(17, 87);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(145, 21);
            lblNombreCliente.TabIndex = 1;
            lblNombreCliente.Text = "Nombre del cliente:";
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.Location = new Point(11, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(309, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agendamientos";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLista
            // 
            panelLista.Controls.Add(listAgendamientos);
            panelLista.Dock = DockStyle.Fill;
            panelLista.Location = new Point(337, 0);
            panelLista.Margin = new Padding(3, 4, 3, 4);
            panelLista.Name = "panelLista";
            panelLista.Padding = new Padding(11, 13, 11, 13);
            panelLista.Size = new Size(634, 800);
            panelLista.TabIndex = 1;
            // 
            // listAgendamientos
            // 
            listAgendamientos.Dock = DockStyle.Fill;
            listAgendamientos.FullRowSelect = true;
            listAgendamientos.GridLines = true;
            listAgendamientos.Location = new Point(11, 13);
            listAgendamientos.Margin = new Padding(3, 4, 3, 4);
            listAgendamientos.Name = "listAgendamientos";
            listAgendamientos.Size = new Size(612, 774);
            listAgendamientos.TabIndex = 0;
            listAgendamientos.UseCompatibleStateImageBehavior = false;
            listAgendamientos.View = View.Details;
            listAgendamientos.SelectedIndexChanged += listAgendamientos_SelectedIndexChanged;
            // 
            // FormAgendamientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 800);
            Controls.Add(panelLista);
            Controls.Add(panelFormulario);
            Margin = new Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Label           lblEstado;
        private System.Windows.Forms.ComboBox        cmbEstado;
        private System.Windows.Forms.Button          btnAgregar;
        private System.Windows.Forms.Button          btnModificar;
        private System.Windows.Forms.Button          btnEliminar;
        private System.Windows.Forms.Panel           panelLista;
        private System.Windows.Forms.ListView        listAgendamientos;
    }
}
