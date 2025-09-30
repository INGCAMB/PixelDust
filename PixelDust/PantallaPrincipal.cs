using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelDust
{
    public partial class frmPantallaPrincipal : Form
    {
        bool pintar = false;
        bool borrar = false;
        bool presionado = false;
        Color colorapintar = Color.Black;
        int grosorX = 5;
        int grosorY = 5;

        public frmPantallaPrincipal()
        {
            InitializeComponent();

            btnLapizOficial.BotonSeleccionadaLapiz += new Herramientas.Lapiz.BotonSeleccionadaLapizDelegate(Lapiz_BotonSeleccionada);
            btnBorradorOficial.BotonSeleccionadaBorrador += new Herramientas.Borrador.BotonSeleccionadaBorradorDelegate(Borrador_BotonSeleccionada);
            btnNuevoOficial.BotonSeleccionadaNuevo += new Herramientas.Nuevo.BotonSeleccionadaNuevoDelegate(Nuevo_BotonSeleccionada);
            btnBlanco.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Blanco_BotonSeleccionada);
            btnNegro.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Negro_BotonSeleccionada);
            btnGris.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Gris_BotonSeleccionada);
            btnCafe.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Cafe_BotonSeleccionada);
            btnAzul.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Azul_BotonSeleccionada);
            btnRojo.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Rojo_BotonSeleccionada);
            btnVerde.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Verde_BotonSeleccionada);
            btnAmarillo.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Amarillo_BotonSeleccionada);
            btnNaranja.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Naranja_BotonSeleccionada);
            btnRosa.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Rosa_BotonSeleccionada);
            btnFiusha.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Fiusha_BotonSeleccionada);
            btnMorado.BotonSeleccionada += new Herramientas.Colores.BotonSeleccionadaDelegate(Morado_BotonSeleccionada);
            pbBosquejo1.BotonSeleccionadaBosquejo += new Herramientas.Bosquejo.BotonSeleccionadaBosquejoDelegate(Bosquejo1_BotonSeleccionada);
            pbBosquejo2.BotonSeleccionadaBosquejo += new Herramientas.Bosquejo.BotonSeleccionadaBosquejoDelegate(Bosquejo2_BotonSeleccionada);
            pbBosquejo3.BotonSeleccionadaBosquejo += new Herramientas.Bosquejo.BotonSeleccionadaBosquejoDelegate(Bosquejo3_BotonSeleccionada);
            pbBosquejo4.BotonSeleccionadaBosquejo += new Herramientas.Bosquejo.BotonSeleccionadaBosquejoDelegate(Bosquejo4_BotonSeleccionada);
            pbBosquejo5.BotonSeleccionadaBosquejo += new Herramientas.Bosquejo.BotonSeleccionadaBosquejoDelegate(Bosquejo5_BotonSeleccionada);
            pbBosquejo6.BotonSeleccionadaBosquejo += new Herramientas.Bosquejo.BotonSeleccionadaBosquejoDelegate(Bosquejo6_BotonSeleccionada);
            btnFondoNegro.BotonSeleccionadaFondo += new Herramientas.Fondos.BotonSeleccionadaFondoDelegate(FondoNegro_BotonSeleccionada);
            btnFondoBlanco.BotonSeleccionadaFondo += new Herramientas.Fondos.BotonSeleccionadaFondoDelegate(FondoBlanco_BotonSeleccionada);
            btnFondoGris.BotonSeleccionadaFondo += new Herramientas.Fondos.BotonSeleccionadaFondoDelegate(FondoGris_BotonSeleccionada);
            btnFondoAzul.BotonSeleccionadaFondo += new Herramientas.Fondos.BotonSeleccionadaFondoDelegate(FondoAzul_BotonSeleccionada);
            btnFondoRosa.BotonSeleccionadaFondo += new Herramientas.Fondos.BotonSeleccionadaFondoDelegate(FondoRosa_BotonSeleccionada);
            btnFondoVerde.BotonSeleccionadaFondo += new Herramientas.Fondos.BotonSeleccionadaFondoDelegate(FondoVerde_BotonSeleccionada);
        }

        public void QuitarGrafico()
        {
            Graphics grafico = pnlDibujar.CreateGraphics();
            grafico.Clear(Color.White);
            colorapintar = Color.Black;
            pnlDibujar.BackgroundImage = null;
        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Lapiz_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaLapizArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Black;
            grosorX = 5;
            grosorY = 5;
        }

        private void Borrador_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBorradorArgs e)
        {
            pintar = false;
            borrar = true;
        }

        private void Nuevo_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaNuevoArgs e)
        {
            QuitarGrafico();
        }

        private void Blanco_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.White;
            grosorX = 10;
            grosorY = 10;
        }

        private void Negro_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Black;
            grosorX = 10;
            grosorY = 10;
        }

        private void Gris_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Gray;
            grosorX = 10;
            grosorY = 10;
        }

        private void Cafe_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Brown;
            grosorX = 10;
            grosorY = 10;
        }

        private void Azul_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Blue;
            grosorX = 10;
            grosorY = 10;
        }

        private void Rojo_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Red;
            grosorX = 10;
            grosorY = 10;
        }

        private void Verde_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Green;
            grosorX = 10;
            grosorY = 10;
        }

        private void Amarillo_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Yellow;
            grosorX = 10;
            grosorY = 10;
        }

        private void Naranja_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Orange;
            grosorX = 10;
            grosorY = 10;
        }

        private void Rosa_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Pink;
            grosorX = 10;
            grosorY = 10;
        }

        private void Fiusha_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Fuchsia;
            grosorX = 10;
            grosorY = 10;
        }

        private void Morado_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaArgs e)
        {
            pintar = true;
            borrar = false;
            colorapintar = Color.Purple;
            grosorX = 10;
            grosorY = 10;
        }

        private void Bosquejo1_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBosquejoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackgroundImage = Properties.Resources.Boquejo1;
            pnlDibujar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Bosquejo2_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBosquejoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackgroundImage = Properties.Resources.Bosquejo2;
            pnlDibujar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Bosquejo3_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBosquejoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackgroundImage = Properties.Resources.Bosquejo3;
            pnlDibujar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Bosquejo4_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBosquejoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackgroundImage = Properties.Resources.Bosquejo4;
            pnlDibujar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Bosquejo5_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBosquejoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackgroundImage = Properties.Resources.Bosquejo5;
            pnlDibujar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Bosquejo6_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaBosquejoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackgroundImage = Properties.Resources.Bosquejo6;
            pnlDibujar.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void FondoNegro_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaFondoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackColor = Color.Black;
        }

        private void FondoBlanco_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaFondoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackColor = Color.White;
        }

        private void FondoGris_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaFondoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackColor = Color.Gray;
        }

        private void FondoAzul_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaFondoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackColor = Color.LightBlue;
        }

        private void FondoRosa_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaFondoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackColor = Color.MistyRose;
        }

        private void FondoVerde_BotonSeleccionada(object sender, Herramientas.BotonSeleccionadaFondoArgs e)
        {
            QuitarGrafico();
            pnlDibujar.BackColor = Color.PaleGreen;
        }

        private void pbPrueba_MouseDown(object sender, MouseEventArgs e)
        {
            presionado = true;
        }

        private void pbPrueba_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
        }

        private void pbPrueba_MouseMove(object sender, MouseEventArgs e)
        {
            if ((pintar) && (presionado))
            {
                Graphics grafico = pnlDibujar.CreateGraphics();
                grafico.FillEllipse(new SolidBrush(colorapintar), e.X, e.Y, grosorX, grosorY);
                //grafico.DrawLine(new Pen(Color.Black), e.X, e.Y, 10, 10);
                grafico.Dispose();
            }
            else if ((borrar) && (presionado))
            {
                Graphics grafico = pnlDibujar.CreateGraphics();
                grafico.FillRectangle(new SolidBrush(Color.White), e.X, e.Y, 25, 25);
                grafico.Dispose();
            }
        }
    }
}
