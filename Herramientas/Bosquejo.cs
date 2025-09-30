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
    public partial class Bosquejo : UserControl
    {
        public delegate void BotonSeleccionadaBosquejoDelegate(object sender, BotonSeleccionadaBosquejoArgs e);
        public event BotonSeleccionadaBosquejoDelegate BotonSeleccionadaBosquejo;

        public Bosquejo()
        {
            InitializeComponent();
        }

        private void pbBosquejo_Click(object sender, EventArgs e)
        {
            PictureBox btnSeleccionado = (PictureBox)sender;

            BotonSeleccionadaBosquejoArgs args = new BotonSeleccionadaBosquejoArgs(btnSeleccionado.Image);

            BotonSeleccionadaBosquejo(this, args);
        }
    }

    public class BotonSeleccionadaBosquejoArgs : EventArgs
    {
        public Image Imagen { get; set; }

        public BotonSeleccionadaBosquejoArgs(Image img)
        {
            Imagen = img;
        }
    }
}
