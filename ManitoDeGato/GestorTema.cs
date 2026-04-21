using System.Drawing;
using System.Windows.Forms;

namespace ManitoDeGato
{
    public static class GestorTema
    {
        public static bool EsModoOscuro { get; set; } = false;

        public static Color FondoOscuro   = Color.FromArgb(25, 18, 28);
        public static Color PanelOscuro   = Color.FromArgb(42, 28, 50);
        public static Color TextoOscuro   = Color.White;
        public static Color AcentoOscuro  = Color.FromArgb(214, 73, 133);

        public static Color FondoClaro    = Color.FromArgb(255, 247, 252);
        public static Color PanelClaro    = Color.White;
        public static Color TextoClaro    = Color.FromArgb(50, 25, 55);
        public static Color AcentoClaro   = Color.FromArgb(180, 45, 95);

        public static void AplicarTema(Control control)
        {
            Color colorFondo  = EsModoOscuro ? FondoOscuro  : FondoClaro;
            Color colorPanel  = EsModoOscuro ? PanelOscuro  : PanelClaro;
            Color colorTexto  = EsModoOscuro ? TextoOscuro  : TextoClaro;

            if (control is Form formulario)
            {
                formulario.BackColor = colorFondo;
                formulario.ForeColor = colorTexto;
            }
            else
            {
                control.BackColor = colorFondo;
                control.ForeColor = colorTexto;
            }

            AplicarTemaRecursivo(control, colorPanel, colorTexto);
        }

        private static void AplicarTemaRecursivo(Control padre, Color colorPanel, Color colorTexto)
        {
            foreach (Control control in padre.Controls)
            {
                if (!(control is TextBox || control is ListView || control is NumericUpDown || control is ComboBox || control is DateTimePicker))
                    control.ForeColor = colorTexto;

                if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = colorPanel;
                    btn.Cursor = Cursors.Hand;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = EsModoOscuro ? Color.FromArgb(55, 38, 65) : Color.White;
                    txt.ForeColor = EsModoOscuro ? Color.White : Color.Black;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = EsModoOscuro ? Color.FromArgb(55, 38, 65) : Color.White;
                    cmb.ForeColor = EsModoOscuro ? Color.White : Color.Black;
                }
                else if (control is ListView lv)
                {
                    lv.BackColor = EsModoOscuro ? Color.FromArgb(35, 23, 40) : Color.White;
                    lv.ForeColor = EsModoOscuro ? Color.White : Color.Black;
                }
                else if (control is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                }

                if (control.HasChildren)
                    AplicarTemaRecursivo(control, colorPanel, colorTexto);
            }
        }
    }
}
