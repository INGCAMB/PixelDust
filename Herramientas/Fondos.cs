using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herramientas
{
    public partial class Fondos : UserControl
    {
        public delegate void BotonSeleccionadaFondoDelegate(object sender, BotonSeleccionadaFondoArgs e);
        public event BotonSeleccionadaFondoDelegate BotonSeleccionadaFondo;

        public Fondos()
        {
            InitializeComponent();
        }

        private void btnFondos_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;

            BotonSeleccionadaFondoArgs args = new BotonSeleccionadaFondoArgs(btnSeleccionado.Image);

            BotonSeleccionadaFondo(this, args);
        }
    }

    public class BotonSeleccionadaFondoArgs : EventArgs
    {
        public Image Imagen { get; set; }

        public BotonSeleccionadaFondoArgs(Image img)
        {
            Imagen = img;
        }
    }
}
