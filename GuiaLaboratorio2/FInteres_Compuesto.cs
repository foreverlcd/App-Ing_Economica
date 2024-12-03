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
    public partial class FInteres_Compuesto : Form
    {
        private double dias;
        public List<double> datos = new List<double>();
        public string CatTiempo = "";
        public FInteres_Compuesto()
        {
            InitializeComponent();
            txbInteres.Enabled = false;
            txbMonto.BackColor = Color.White;
            txbMonto.ForeColor = Color.White;
            txbMonto.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            double Capital = 0, TI = 0;
            if (string.IsNullOrWhiteSpace(txbCapital.Text) || string.IsNullOrWhiteSpace(txbTI.Text) || string.IsNullOrWhiteSpace(txbTiempo.Text))
            {
                MessageBox.Show("Complete todos los Campos!!");
            }
            else
            {
                Capital = Convert.ToDouble(txbCapital.Text);
                TI = Convert.ToDouble(txbTI.Text);

                if (radioButton1.Checked)
                {
                    dias = Convert.ToDouble(txbTiempo.Text) / 365;
                    RealizarCalculo(Capital, TI);
                    CatTiempo = "Dias";
                }
                else if (radioButton2.Checked)
                {
                    dias = Convert.ToDouble(txbTiempo.Text) / 12;
                    RealizarCalculo(Capital, TI);
                    CatTiempo = "Meses";
                }
                else if (radioButton3.Checked)
                {
                    dias = Convert.ToDouble(txbTiempo.Text);
                    RealizarCalculo(Capital, TI);
                    CatTiempo = "Años";
                }
                else
                {
                    MessageBox.Show("Seleccione el tiempo");
                }

            }


        }

        private void RealizarCalculo(double Capital, double Tasa)
        {
            double Resultado = Capital * ((Math.Pow((1 + Tasa / 100), dias) - 1));
            txbInteres.Text = Resultado.ToString();
            txbMonto.Text = Convert.ToString(Resultado + Capital);
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txbCapital.Text = "";
            txbInteres.Text = "";
            txbMonto.Text = "";
            txbTI.Text = "";
            txbTiempo.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            double Capital = 0, TI = 0;
            Capital = Convert.ToDouble(txbCapital.Text);
            TI = Convert.ToDouble(txbTI.Text);

            datos.Add(Capital);
            datos.Add(Convert.ToDouble(txbTiempo.Text));
            datos.Add(TI);

            FGraficoComp graficoForm1 = new FGraficoComp(datos, CatTiempo);

            /*Console.WriteLine(datos.Count);
            Console.WriteLine(datos[0]);
            Console.WriteLine(datos[1]); 
            Console.WriteLine(datos[2]);*/

            graficoForm1.ShowDialog();

            datos.Clear();

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
