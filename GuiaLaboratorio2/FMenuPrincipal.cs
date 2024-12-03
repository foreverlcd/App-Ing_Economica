using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaLaboratorio2
{
    public partial class FMenuPrincipal : Form
    {
        public FMenuPrincipal()
        {
            InitializeComponent();

            //string rutaImagen = "C:\\Users\\User\\Desktop\\ESCRITORIO\\Ing.Economica\\Nueva carpeta\\GuiaLaboratorio2\\GuiaLaboratorio2\\Imagenes\\IMG2.png";

        
            //pictureBox1.Image = new System.Drawing.Bitmap(rutaImagen);
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; 

        }

        private void btnAmortizaciones_Click(object sender, EventArgs e)
        {
            FSeleccionAmortizacion fSeleccionAmortizacion = new FSeleccionAmortizacion();
            fSeleccionAmortizacion.ShowDialog();
        }

        private void btnInteresSimple_Click(object sender, EventArgs e)
        {
            FInteres_Simple fInteres_Simple = new FInteres_Simple();
            fInteres_Simple.ShowDialog();
        }

        private void btnInteresCompuesto_Click(object sender, EventArgs e)
        {
            FInteres_Compuesto fInteres_Compuesto = new FInteres_Compuesto();
            fInteres_Compuesto.ShowDialog();
        }

        private void FMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAnualidades_Click(object sender, EventArgs e)
        {
            Anualidad anualidad = new Anualidad();
            anualidad.ShowDialog();
        }

        private void btnGradiente_Click(object sender, EventArgs e)
        {
            FGradienteAritmetico gradiente = new FGradienteAritmetico();
            gradiente.ShowDialog();
        }

        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            FDepreciacionLineaRecta depreciacion = new FDepreciacionLineaRecta();
            depreciacion.ShowDialog();
        }

        private void vtnVANDIR_Click(object sender, EventArgs e)
        {
            FVAN van = new FVAN();
            van.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
