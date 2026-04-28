namespace ManitoDeGato
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelFondo      = new System.Windows.Forms.Panel();
            panelCard       = new System.Windows.Forms.Panel();
            lblTitulo       = new System.Windows.Forms.Label();
            lblSubtitulo    = new System.Windows.Forms.Label();
            lblNombre       = new System.Windows.Forms.Label();
            txtNombre       = new System.Windows.Forms.TextBox();
            lblContrasena   = new System.Windows.Forms.Label();
            txtContrasena   = new System.Windows.Forms.TextBox();
            chkMostrar      = new System.Windows.Forms.CheckBox();
            btnIniciar      = new System.Windows.Forms.Button();
            btnSalir        = new System.Windows.Forms.Button();

            panelFondo.SuspendLayout();
            panelCard.SuspendLayout();
            SuspendLayout();

            // panelFondo — ocupa todo el formulario
            panelFondo.Dock     = System.Windows.Forms.DockStyle.Fill;
            panelFondo.Name     = "panelFondo";
            panelFondo.TabIndex = 0;
            panelFondo.Controls.Add(panelCard);

            // panelCard — tarjeta central
            panelCard.Size      = new System.Drawing.Size(380, 370);
            panelCard.Name      = "panelCard";
            panelCard.TabIndex  = 0;
            panelCard.Controls.Add(lblTitulo);
            panelCard.Controls.Add(lblSubtitulo);
            panelCard.Controls.Add(lblNombre);
            panelCard.Controls.Add(txtNombre);
            panelCard.Controls.Add(lblContrasena);
            panelCard.Controls.Add(txtContrasena);
            panelCard.Controls.Add(chkMostrar);
            panelCard.Controls.Add(btnIniciar);
            panelCard.Controls.Add(btnSalir);

            // lblTitulo
            lblTitulo.AutoSize  = false;
            lblTitulo.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitulo.Location  = new System.Drawing.Point(0, 28);
            lblTitulo.Name      = "lblTitulo";
            lblTitulo.Size      = new System.Drawing.Size(380, 40);
            lblTitulo.TabIndex  = 0;
            lblTitulo.Text      = "Manito de Gato";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblSubtitulo
            lblSubtitulo.AutoSize  = false;
            lblSubtitulo.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblSubtitulo.Location  = new System.Drawing.Point(0, 70);
            lblSubtitulo.Name      = "lblSubtitulo";
            lblSubtitulo.Size      = new System.Drawing.Size(380, 22);
            lblSubtitulo.TabIndex  = 1;
            lblSubtitulo.Text      = "Inicio de sesión";
            lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNombre
            lblNombre.AutoSize = true;
            lblNombre.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblNombre.Location = new System.Drawing.Point(40, 112);
            lblNombre.Name     = "lblNombre";
            lblNombre.TabIndex = 2;
            lblNombre.Text     = "USUARIO";

            // txtNombre
            txtNombre.Font      = new System.Drawing.Font("Segoe UI", 11F);
            txtNombre.Location  = new System.Drawing.Point(40, 133);
            txtNombre.Name      = "txtNombre";
            txtNombre.Size      = new System.Drawing.Size(300, 28);
            txtNombre.TabIndex  = 3;
            txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblContrasena
            lblContrasena.AutoSize = true;
            lblContrasena.Font     = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblContrasena.Location = new System.Drawing.Point(40, 178);
            lblContrasena.Name     = "lblContrasena";
            lblContrasena.TabIndex = 4;
            lblContrasena.Text     = "CONTRASENA";

            // txtContrasena
            txtContrasena.Font                 = new System.Drawing.Font("Segoe UI", 11F);
            txtContrasena.Location             = new System.Drawing.Point(40, 199);
            txtContrasena.Name                 = "txtContrasena";
            txtContrasena.Size                 = new System.Drawing.Size(300, 28);
            txtContrasena.TabIndex             = 5;
            txtContrasena.UseSystemPasswordChar = true;
            txtContrasena.BorderStyle          = System.Windows.Forms.BorderStyle.FixedSingle;

            // chkMostrar
            chkMostrar.AutoSize = true;
            chkMostrar.Font     = new System.Drawing.Font("Segoe UI", 8.5F);
            chkMostrar.Location = new System.Drawing.Point(40, 235);
            chkMostrar.Name     = "chkMostrar";
            chkMostrar.Size     = new System.Drawing.Size(148, 20);
            chkMostrar.TabIndex = 6;
            chkMostrar.Text     = "Mostrar contrasena";
            chkMostrar.UseVisualStyleBackColor = true;
            chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);

            // btnIniciar
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            btnIniciar.Font                      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            btnIniciar.Location                  = new System.Drawing.Point(40, 280);
            btnIniciar.Name                      = "btnIniciar";
            btnIniciar.Size                      = new System.Drawing.Size(300, 42);
            btnIniciar.TabIndex                  = 7;
            btnIniciar.Text                      = "Iniciar Sesion";
            btnIniciar.Cursor                    = System.Windows.Forms.Cursors.Hand;
            btnIniciar.Click                    += new System.EventHandler(this.btnIniciar_Click);

            // btnSalir
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle                 = System.Windows.Forms.FlatStyle.Flat;
            btnSalir.Font                      = new System.Drawing.Font("Segoe UI", 9F);
            btnSalir.Location                  = new System.Drawing.Point(140, 330);
            btnSalir.Name                      = "btnSalir";
            btnSalir.Size                      = new System.Drawing.Size(100, 26);
            btnSalir.TabIndex                  = 8;
            btnSalir.Text                      = "Salir";
            btnSalir.Cursor                    = System.Windows.Forms.Cursors.Hand;
            btnSalir.Click                    += new System.EventHandler(this.btnSalir_Click);

            // FormLogin
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize          = new System.Drawing.Size(520, 440);
            Controls.Add(panelFondo);
            Name            = "FormLogin";
            Text            = "ManitoDeGato — Inicio de Sesion";
            StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;

            panelCard.SuspendLayout();
            panelFondo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel    panelFondo;
        private System.Windows.Forms.Panel    panelCard;
        private System.Windows.Forms.Label    lblTitulo;
        private System.Windows.Forms.Label    lblSubtitulo;
        private System.Windows.Forms.Label    lblNombre;
        private System.Windows.Forms.TextBox  txtNombre;
        private System.Windows.Forms.Label    lblContrasena;
        private System.Windows.Forms.TextBox  txtContrasena;
        private System.Windows.Forms.CheckBox chkMostrar;
        private System.Windows.Forms.Button   btnIniciar;
        private System.Windows.Forms.Button   btnSalir;
    }
}