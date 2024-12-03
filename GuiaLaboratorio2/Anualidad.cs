using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiaLaboratorio2
{
    public partial class Anualidad : Form
    {
        public Anualidad()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbRenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbValorFuturo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxValorPresente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnValorF_Click(object sender, EventArgs e)
        {
            double Renta = Convert.ToDouble(txtbRenta.Text);
            double tasaAnual = Convert.ToDouble(txtBTasa.Text);
            int duracionAnual = Convert.ToInt32(txtBPeriodo.Text);
            string periodo = comboBoxPeriodoPagos.Text;

            ValorFuturo( Renta,  tasaAnual,  duracionAnual,  periodo);
        }

        private void btnValorP_Click(object sender, EventArgs e)
        {
            double Renta = Convert.ToDouble(txtbRenta.Text);
            double tasaAnual = Convert.ToDouble(txtBTasa.Text);
            int duracionAnual = Convert.ToInt32(txtBPeriodo.Text);
            string periodo = comboBoxPeriodoPagos.Text;

            ValorPresente(Renta, tasaAnual, duracionAnual, periodo);
        }

        private void comboBoxPeriodoPagos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ValorFuturo(double renta, double tasaAnual, int duracionAnual, string periodo)
        {
            int n = 0;
            if (periodo == "Anual")
                n = 1;
            if (periodo == "Mensual")
                n = 12;
            if (periodo == "Trimestral")
                n = 4;
            if (periodo == "Semestral")
                n = 2;

            double tasa = tasaAnual/(100*n);
            int duracion = duracionAnual * n;

            double VF = renta/tasa* (Math.Pow(1 + tasa, duracion)-1);
            txtbValorFuturo.Text = VF.ToString("F2");
        }
        private void ValorPresente(double renta, double tasaAnual, int duracionAnual, string periodo)
        {
            int n = 0;
            if (periodo == "Anual")
                n = 1;
            if (periodo == "Mensual")
                n = 12;
            if (periodo == "Trimestral")
                n = 4;
            if (periodo == "Semestral")
                n = 2;

            double tasa = tasaAnual/(100*n);
            int duracion = duracionAnual * n;

            double VP = renta/tasa* (1-Math.Pow(1+tasa, duracion*(-1)));
            txtBoxValorPresente.Text = VP.ToString("F2");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBPeriodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
