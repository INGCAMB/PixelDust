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
    public partial class Colores : UserControl
    {
        public delegate void BotonSeleccionadaDelegate(object sender, BotonSeleccionadaArgs e);
        public event BotonSeleccionadaDelegate BotonSeleccionada;

        public Colores()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;

            BotonSeleccionadaArgs args = new BotonSeleccionadaArgs(btnSeleccionado.Image);

            BotonSeleccionada(this, args);
        }
    }

    public class BotonSeleccionadaArgs : EventArgs
    {
        public Image Imagen { get; set; }

        public BotonSeleccionadaArgs(Image img)
        {
            Imagen = img;
        }
    }
}
