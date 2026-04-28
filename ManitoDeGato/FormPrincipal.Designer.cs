namespace ManitoDeGato
{
    partial class FormPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMenuLateral = new Panel();
            btnProductos = new Button();
            btnAgendamientos = new Button();
            btnEstilistas = new Button();
            btnServicios = new Button();
            panelLogo = new Panel();
            lblLogo = new Label();
            panelCabecera = new Panel();
            btnCerrarSesion = new Button();
            btnAlternarTema = new Button();
            lblTituloPrincipal = new Label();
            panelEscritorio = new Panel();
            lblBienvenida = new Label();
            btnSalir = new Button();
            panelMenuLateral.SuspendLayout();
            panelLogo.SuspendLayout();
            panelCabecera.SuspendLayout();
            panelEscritorio.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.Controls.Add(btnProductos);
            panelMenuLateral.Controls.Add(btnAgendamientos);
            panelMenuLateral.Controls.Add(btnEstilistas);
            panelMenuLateral.Controls.Add(btnServicios);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(3, 4, 3, 4);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(251, 827);
            panelMenuLateral.TabIndex = 0;
            // 
            // btnProductos
            // 
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 10F);
            btnProductos.Location = new Point(0, 353);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Padding = new Padding(23, 0, 0, 0);
            btnProductos.Size = new Size(251, 80);
            btnProductos.TabIndex = 4;
            btnProductos.Text = "📦  Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnAgendamientos
            // 
            btnAgendamientos.Dock = DockStyle.Top;
            btnAgendamientos.FlatAppearance.BorderSize = 0;
            btnAgendamientos.FlatStyle = FlatStyle.Flat;
            btnAgendamientos.Font = new Font("Segoe UI", 10F);
            btnAgendamientos.Location = new Point(0, 273);
            btnAgendamientos.Margin = new Padding(3, 4, 3, 4);
            btnAgendamientos.Name = "btnAgendamientos";
            btnAgendamientos.Padding = new Padding(23, 0, 0, 0);
            btnAgendamientos.Size = new Size(251, 80);
            btnAgendamientos.TabIndex = 3;
            btnAgendamientos.Text = "📅  Agendamientos";
            btnAgendamientos.TextAlign = ContentAlignment.MiddleLeft;
            btnAgendamientos.UseVisualStyleBackColor = true;
            btnAgendamientos.Click += btnAgendamientos_Click;
            // 
            // btnEstilistas
            // 
            btnEstilistas.Dock = DockStyle.Top;
            btnEstilistas.FlatAppearance.BorderSize = 0;
            btnEstilistas.FlatStyle = FlatStyle.Flat;
            btnEstilistas.Font = new Font("Segoe UI", 10F);
            btnEstilistas.Location = new Point(0, 193);
            btnEstilistas.Margin = new Padding(3, 4, 3, 4);
            btnEstilistas.Name = "btnEstilistas";
            btnEstilistas.Padding = new Padding(23, 0, 0, 0);
            btnEstilistas.Size = new Size(251, 80);
            btnEstilistas.TabIndex = 2;
            btnEstilistas.Text = "💇  Estilistas";
            btnEstilistas.TextAlign = ContentAlignment.MiddleLeft;
            btnEstilistas.UseVisualStyleBackColor = true;
            btnEstilistas.Click += btnEstilistas_Click;
            // 
            // btnServicios
            // 
            btnServicios.Dock = DockStyle.Top;
            btnServicios.FlatAppearance.BorderSize = 0;
            btnServicios.FlatStyle = FlatStyle.Flat;
            btnServicios.Font = new Font("Segoe UI", 10F);
            btnServicios.Location = new Point(0, 113);
            btnServicios.Margin = new Padding(3, 4, 3, 4);
            btnServicios.Name = "btnServicios";
            btnServicios.Padding = new Padding(23, 0, 0, 0);
            btnServicios.Size = new Size(251, 80);
            btnServicios.TabIndex = 1;
            btnServicios.Text = "🛎  Servicios";
            btnServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(lblLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 4, 3, 4);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(251, 113);
            panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.Dock = DockStyle.Fill;
            lblLogo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLogo.Location = new Point(0, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(251, 113);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "✂ MANITO DE GATO";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelCabecera
            // 
            panelCabecera.Controls.Add(btnSalir);
            panelCabecera.Controls.Add(btnCerrarSesion);
            panelCabecera.Controls.Add(btnAlternarTema);
            panelCabecera.Controls.Add(lblTituloPrincipal);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(251, 0);
            panelCabecera.Margin = new Padding(3, 4, 3, 4);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(949, 113);
            panelCabecera.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(6, 12);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(106, 42);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnAlternarTema
            // 
            btnAlternarTema.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAlternarTema.FlatAppearance.BorderSize = 0;
            btnAlternarTema.FlatStyle = FlatStyle.Flat;
            btnAlternarTema.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAlternarTema.Location = new Point(749, 29);
            btnAlternarTema.Margin = new Padding(3, 4, 3, 4);
            btnAlternarTema.Name = "btnAlternarTema";
            btnAlternarTema.Size = new Size(177, 53);
            btnAlternarTema.TabIndex = 1;
            btnAlternarTema.Text = "Modo Oscuro";
            btnAlternarTema.UseVisualStyleBackColor = true;
            btnAlternarTema.Click += btnAlternarTema_Click;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.Anchor = AnchorStyles.None;
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloPrincipal.Location = new Point(411, 40);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(90, 32);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "INICIO";
            // 
            // panelEscritorio
            // 
            panelEscritorio.Controls.Add(lblBienvenida);
            panelEscritorio.Dock = DockStyle.Fill;
            panelEscritorio.Location = new Point(251, 113);
            panelEscritorio.Margin = new Padding(3, 4, 3, 4);
            panelEscritorio.Name = "panelEscritorio";
            panelEscritorio.Size = new Size(949, 714);
            panelEscritorio.TabIndex = 2;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Dock = DockStyle.Fill;
            lblBienvenida.Font = new Font("Segoe UI", 22F);
            lblBienvenida.Location = new Point(0, 0);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(949, 714);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido a Manito de Gato 🌸";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(6, 71);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(106, 35);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 827);
            Controls.Add(panelEscritorio);
            Controls.Add(panelCabecera);
            Controls.Add(panelMenuLateral);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 651);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manito de Gato — Salón de Belleza & Spa";
            panelMenuLateral.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelEscritorio.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel  panelMenuLateral;
        private System.Windows.Forms.Panel  panelLogo;
        private System.Windows.Forms.Label  lblLogo;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnEstilistas;
        private System.Windows.Forms.Button btnAgendamientos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel  panelCabecera;
        private System.Windows.Forms.Label  lblTituloPrincipal;
        private System.Windows.Forms.Button btnAlternarTema;
        private System.Windows.Forms.Panel  panelEscritorio;
        private System.Windows.Forms.Label  lblBienvenida;
        private Button btnCerrarSesion;
        private Button btnSalir;
    }
}
