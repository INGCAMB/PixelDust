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
    public partial class Lapiz: UserControl
    {
        public delegate void BotonSeleccionadaLapizDelegate(object sender, BotonSeleccionadaLapizArgs e);
        public event BotonSeleccionadaLapizDelegate BotonSeleccionadaLapiz;

        public Lapiz()
        {
            InitializeComponent();
        }

        private void btnLapiz_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;

            BotonSeleccionadaLapizArgs args = new BotonSeleccionadaLapizArgs(btnSeleccionado.Image);

            BotonSeleccionadaLapiz(this, args);
        }
    }

    public class BotonSeleccionadaLapizArgs : EventArgs
    {
        public Image Imagen { get; set; }

        public BotonSeleccionadaLapizArgs(Image img)
        {
            Imagen = img;
        }
    }
}
