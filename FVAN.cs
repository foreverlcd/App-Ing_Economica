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
    public partial class FVAN : Form
    {
        public FVAN()
        {
            InitializeComponent();
        }

        private void btnGenerartabla_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtbNaños.Text);
            dgvTablaFlujo.Rows.Clear();
            dgvTablaFlujo.Rows.Add(n-1);
            for (int i = 1;i<=n;i++)
            {
                dgvTablaFlujo.Rows[i-1].Cells[0].Value = i;
            }
        }

        private void VAN()
        {
            double i = Convert.ToDouble(txtbTasa.Text);
            double Io = Convert.ToDouble(txtbInversion.Text);
            i = i/100;
            int n = Convert.ToInt32(txtbNaños.Text);
            double van = -Io;
            for (int j = 1; j<=n; j++)
            {
                double vt = Convert.ToDouble(dgvTablaFlujo.Rows[j-1].Cells[1].Value);
                double x = vt/Math.Pow(1+i, j);
                van = van+x;
            }
            txtbVAN.Text = van.ToString("F2");
        }

        private void btnVAN_Click(object sender, EventArgs e)
        {
            VAN();
        }

        private double CalcularVAN(double tasa)
        {
            double i = tasa / 100;
            double Io = Convert.ToDouble(txtbInversion.Text);
            int n = Convert.ToInt32(txtbNaños.Text);
            double van = -Io;

            for (int j = 1; j <= n; j++)
            {
                double vt = Convert.ToDouble(dgvTablaFlujo.Rows[j - 1].Cells[1].Value);
                double x = vt / Math.Pow(1 + i, j);
                van += x;
            }

            return van;
        }

        private double CalcularTIR()
        {
            double tasa = 0.1; // Estimación inicial para la TIR (10%)
            double precision = 0.0001;
            double van;

            do
            {
                van = CalcularVAN(tasa);
                tasa -= van / DerivadaVAN(tasa); // Método de Newton-Raphson
            }
            while (Math.Abs(van) > precision);

            return tasa;
        }

        private double DerivadaVAN(double tasa)
        {
            double i = tasa / 100;
            double Io = Convert.ToDouble(txtbInversion.Text);
            int n = Convert.ToInt32(txtbNaños.Text);
            double derivada = 0;

            for (int j = 1; j <= n; j++)
            {
                double vt = Convert.ToDouble(dgvTablaFlujo.Rows[j - 1].Cells[1].Value);
                derivada -= (j * vt) / Math.Pow(1 + i, j + 1);
            }

            return derivada;
        }

        

        private void btnTIR_Click_1(object sender, EventArgs e)
        {
            double tir = CalcularTIR();
            txtbTIR.Text = tir.ToString("F2");
        }

        private double CalcularPayback()
        {
            double inversionInicial = Convert.ToDouble(txtbInversion.Text);
            int n = Convert.ToInt32(txtbNaños.Text);
            double flujoAcumulado = 0;
            double payback = 0;

            for (int j = 1; j <= n; j++)
            {
                double flujo = Convert.ToDouble(dgvTablaFlujo.Rows[j - 1].Cells[1].Value);
                flujoAcumulado += flujo;

                if (flujoAcumulado >= inversionInicial)
                {
                    payback = j - 1 + (inversionInicial - (flujoAcumulado - flujo)) / flujo;
                    break;
                }
            }

            return payback;
        }

        private void btnPayback_Click(object sender, EventArgs e)
        {
            double payback = CalcularPayback();
            txtbPayback.Text = payback.ToString("F2");
        }
    }
}
