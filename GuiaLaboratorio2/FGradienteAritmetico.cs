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
    public partial class FGradienteAritmetico : Form
    {
        public FGradienteAritmetico()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ValorPresenteCreciente(double A, double i, int n, double g)
        {
            i = i/100;
            double P;
            P = A*((Math.Pow(1+i, n)-1)/(i*Math.Pow(1+i, n))) + (g/i)* ((Math.Pow(1+i, n)-1)/(i*Math.Pow(1+i, n))-(n/Math.Pow(1+i, n)));
            txtbVPC.Text = P.ToString("F2");
        }

        private void NesimaCuotaCreciente(double A, int n, double g)
        {
            double Cn;
            Cn = A + (n-1)*g;
            txtbNCC.Text = Cn.ToString("F2");
        }

        private void ValorPresenteDecreciente(double A, double i, int n, double g)
        {
            i = i/100;
            double P;
            P = A*((Math.Pow(1+i, n)-1)/(i*Math.Pow(1+i, n))) - (g/i)* ((Math.Pow(1+i, n)-1)/(i*Math.Pow(1+i, n))-(n/Math.Pow(1+i, n)));
            txtbVPD.Text = P.ToString("F2");
        }

        private void NesimaCuotaDecreciente(double A, int n, double g)
        {
            double Cn;
            Cn = A + (n-1)*g;
            txtbNCD.Text = Cn.ToString("F2");
        }

        private void btnVCP_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtbA.Text);
            double i = Convert.ToDouble(txtbi.Text);
            int n = Convert.ToInt32(txtbn.Text);
            double g = Convert.ToDouble(txtbg.Text);
            ValorPresenteCreciente(A, i, n, g);
        }

        private void btnCalcncuotaCrec_Click(object sender, EventArgs e)
        {
            if (txtbCNCCn.Text == string.Empty)
            {
                MessageBox.Show("Complete el valor de n");
            }
            else
            {
                double A = Convert.ToDouble(txtbA.Text);
                int n = Convert.ToInt32(txtbCNCCn.Text);
                double g = Convert.ToDouble(txtbg.Text);
                NesimaCuotaCreciente(A, n, g);
            }
            
        }

        private void btnVPD_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(txtbA.Text);
            double i = Convert.ToDouble(txtbi.Text);
            int n = Convert.ToInt32(txtbn.Text);
            double g = Convert.ToDouble(txtbg.Text);
            ValorPresenteDecreciente(A, i, n, g);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbCNCDn.Text == string.Empty)
            {
                MessageBox.Show("Complete el valor de n");
            }
            else
            {
                double A = Convert.ToDouble(txtbA.Text);
                int n = Convert.ToInt32(txtbCNCDn.Text);
                double g = Convert.ToDouble(txtbg.Text);
                NesimaCuotaDecreciente(A, n, g);
            }
        }

        private void FGradienteAritmetico_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
