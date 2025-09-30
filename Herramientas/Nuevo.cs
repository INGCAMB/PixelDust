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
    public partial class Nuevo : UserControl
    {
        public delegate void BotonSeleccionadaNuevoDelegate(object sender, BotonSeleccionadaNuevoArgs e);
        public event BotonSeleccionadaNuevoDelegate BotonSeleccionadaNuevo;

        public Nuevo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Button btnSeleccionado = (Button)sender;

            BotonSeleccionadaNuevoArgs args = new BotonSeleccionadaNuevoArgs(btnSeleccionado.Image);

            BotonSeleccionadaNuevo(this, args);
        }
    }

    public class BotonSeleccionadaNuevoArgs : EventArgs
    {
        public Image Imagen { get; set; }

        public BotonSeleccionadaNuevoArgs(Image img)
        {
            Imagen = img;
        }
    }
}
