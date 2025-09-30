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
    public partial class Borrador : UserControl
    {
        public delegate void BotonSeleccionadaBorradorDelegate(object sender, BotonSeleccionadaBorradorArgs e);
        public event BotonSeleccionadaBorradorDelegate BotonSeleccionadaBorrador;

        public Borrador()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;

            BotonSeleccionadaBorradorArgs args = new BotonSeleccionadaBorradorArgs(btnSeleccionado.Image);

            BotonSeleccionadaBorrador(this, args);
        }
    }

    public class BotonSeleccionadaBorradorArgs : EventArgs
    {
        public Image Imagen { get; set; }

        public BotonSeleccionadaBorradorArgs(Image img)
        {
            Imagen = img;
        }
    }
}
