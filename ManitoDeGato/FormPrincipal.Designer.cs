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
            this.panelMenuLateral  = new System.Windows.Forms.Panel();
            this.panelLogo         = new System.Windows.Forms.Panel();
            this.lblLogo           = new System.Windows.Forms.Label();
            this.btnServicios      = new System.Windows.Forms.Button();
            this.btnEstilistas     = new System.Windows.Forms.Button();
            this.btnAgendamientos  = new System.Windows.Forms.Button();
            this.btnProductos      = new System.Windows.Forms.Button();
            this.panelCabecera     = new System.Windows.Forms.Panel();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnAlternarTema   = new System.Windows.Forms.Button();
            this.panelEscritorio   = new System.Windows.Forms.Panel();
            this.lblBienvenida     = new System.Windows.Forms.Label();

            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelCabecera.SuspendLayout();
            this.panelEscritorio.SuspendLayout();
            this.SuspendLayout();

            this.panelMenuLateral.Controls.Add(this.btnProductos);
            this.panelMenuLateral.Controls.Add(this.btnAgendamientos);
            this.panelMenuLateral.Controls.Add(this.btnEstilistas);
            this.panelMenuLateral.Controls.Add(this.btnServicios);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock     = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name     = "panelMenuLateral";
            this.panelMenuLateral.Size     = new System.Drawing.Size(220, 620);
            this.panelMenuLateral.TabIndex = 0;

            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name     = "panelLogo";
            this.panelLogo.Size     = new System.Drawing.Size(220, 85);
            this.panelLogo.TabIndex = 0;

            this.lblLogo.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location  = new System.Drawing.Point(0, 0);
            this.lblLogo.Name      = "lblLogo";
            this.lblLogo.Size      = new System.Drawing.Size(220, 85);
            this.lblLogo.TabIndex  = 0;
            this.lblLogo.Text      = "✂ MANITO DE GATO";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnServicios.Dock                        = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize   = 0;
            this.btnServicios.FlatStyle                   = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font                        = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnServicios.Location                    = new System.Drawing.Point(0, 85);
            this.btnServicios.Name                        = "btnServicios";
            this.btnServicios.Padding                     = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnServicios.Size                        = new System.Drawing.Size(220, 60);
            this.btnServicios.TabIndex                    = 1;
            this.btnServicios.Text                        = "🛎  Servicios";
            this.btnServicios.TextAlign                   = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.UseVisualStyleBackColor     = true;
            this.btnServicios.Click                      += new System.EventHandler(this.btnServicios_Click);

            this.btnEstilistas.Dock                       = System.Windows.Forms.DockStyle.Top;
            this.btnEstilistas.FlatAppearance.BorderSize  = 0;
            this.btnEstilistas.FlatStyle                  = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstilistas.Font                       = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstilistas.Location                   = new System.Drawing.Point(0, 145);
            this.btnEstilistas.Name                       = "btnEstilistas";
            this.btnEstilistas.Padding                    = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEstilistas.Size                       = new System.Drawing.Size(220, 60);
            this.btnEstilistas.TabIndex                   = 2;
            this.btnEstilistas.Text                       = "💇  Estilistas";
            this.btnEstilistas.TextAlign                  = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstilistas.UseVisualStyleBackColor    = true;
            this.btnEstilistas.Click                     += new System.EventHandler(this.btnEstilistas_Click);

            this.btnAgendamientos.Dock                    = System.Windows.Forms.DockStyle.Top;
            this.btnAgendamientos.FlatAppearance.BorderSize = 0;
            this.btnAgendamientos.FlatStyle               = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamientos.Font                    = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgendamientos.Location                = new System.Drawing.Point(0, 205);
            this.btnAgendamientos.Name                    = "btnAgendamientos";
            this.btnAgendamientos.Padding                 = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnAgendamientos.Size                    = new System.Drawing.Size(220, 60);
            this.btnAgendamientos.TabIndex                = 3;
            this.btnAgendamientos.Text                    = "📅  Agendamientos";
            this.btnAgendamientos.TextAlign               = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgendamientos.UseVisualStyleBackColor = true;
            this.btnAgendamientos.Click                  += new System.EventHandler(this.btnAgendamientos_Click);

            this.btnProductos.Dock                        = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize   = 0;
            this.btnProductos.FlatStyle                   = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font                        = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProductos.Location                    = new System.Drawing.Point(0, 265);
            this.btnProductos.Name                        = "btnProductos";
            this.btnProductos.Padding                     = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnProductos.Size                        = new System.Drawing.Size(220, 60);
            this.btnProductos.TabIndex                    = 4;
            this.btnProductos.Text                        = "📦  Productos";
            this.btnProductos.TextAlign                   = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor     = true;
            this.btnProductos.Click                      += new System.EventHandler(this.btnProductos_Click);

            this.panelCabecera.Controls.Add(this.btnAlternarTema);
            this.panelCabecera.Controls.Add(this.lblTituloPrincipal);
            this.panelCabecera.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(220, 0);
            this.panelCabecera.Name     = "panelCabecera";
            this.panelCabecera.Size     = new System.Drawing.Size(830, 85);
            this.panelCabecera.TabIndex = 1;

            this.lblTituloPrincipal.Anchor    = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloPrincipal.AutoSize  = true;
            this.lblTituloPrincipal.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPrincipal.Location  = new System.Drawing.Point(360, 30);
            this.lblTituloPrincipal.Name      = "lblTituloPrincipal";
            this.lblTituloPrincipal.TabIndex  = 0;
            this.lblTituloPrincipal.Text      = "INICIO";

            this.btnAlternarTema.Anchor                      = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnAlternarTema.FlatAppearance.BorderSize   = 0;
            this.btnAlternarTema.FlatStyle                   = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlternarTema.Font                        = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlternarTema.Location                    = new System.Drawing.Point(655, 22);
            this.btnAlternarTema.Name                        = "btnAlternarTema";
            this.btnAlternarTema.Size                        = new System.Drawing.Size(155, 40);
            this.btnAlternarTema.TabIndex                    = 1;
            this.btnAlternarTema.Text                        = "Modo Oscuro";
            this.btnAlternarTema.UseVisualStyleBackColor     = true;
            this.btnAlternarTema.Click                      += new System.EventHandler(this.btnAlternarTema_Click);

            this.panelEscritorio.Controls.Add(this.lblBienvenida);
            this.panelEscritorio.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(220, 85);
            this.panelEscritorio.Name     = "panelEscritorio";
            this.panelEscritorio.Size     = new System.Drawing.Size(830, 535);
            this.panelEscritorio.TabIndex = 2;

            this.lblBienvenida.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenida.Font      = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.Location  = new System.Drawing.Point(0, 0);
            this.lblBienvenida.Name      = "lblBienvenida";
            this.lblBienvenida.Size      = new System.Drawing.Size(830, 535);
            this.lblBienvenida.TabIndex  = 0;
            this.lblBienvenida.Text      = "Bienvenido a Manito de Gato 🌸";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1050, 620);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelCabecera);
            this.Controls.Add(this.panelMenuLateral);
            this.MinimumSize         = new System.Drawing.Size(900, 500);
            this.Name                = "FormPrincipal";
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text                = "Manito de Gato — Salón de Belleza & Spa";

            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelEscritorio.ResumeLayout(false);
            this.ResumeLayout(false);
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
    }
}
