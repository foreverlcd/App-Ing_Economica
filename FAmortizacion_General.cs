using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuiaLaboratorio2
{

    public partial class FAmortizacion_General : Form
    {
        private double CapPrestado;
        private double Cuota;
        private int Periodo;
        private double TI;
        private int Frecuencia;
        private int Tiempo;
        private int TAmortizacion;
        private double CapAmortizado;
        private double InteresAmericano;
        public FAmortizacion_General(int Tipo)
        {
            InitializeComponent();
            TAmortizacion = Tipo;
            label_Variable.Text = "";
            label_T_Variable.Text = "";
            DeterminarTipo();
        }

        public void DeterminarTipo()
        {
            if (TAmortizacion==1)
            {
                label_T_Variable.Text = "Amortizacion Francesa".ToString();
                label_Variable.Text = "Cuota Nivelada:".ToString();
            }
            else if (TAmortizacion==2)

            {
                label_T_Variable.Text = "Amortizacion Alemana".ToString();
                label_Variable.Text = "Abono a Capital:".ToString();
            }
            else
            {
                label_T_Variable.Text = "Amortizacion Americana".ToString();
                label_Variable.Text="Interes por Cuota:".ToString();
            }

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CapPrestado = Convert.ToDouble(txbPrestamo.Text);
                Frecuencia = Convert.ToInt32(txbFrecuencia.Text);
                Tiempo = Convert.ToInt32(txbTiempo.Text);
                Periodo = CalcularPeriodo(Frecuencia,Tiempo);
                TI = Convert.ToDouble(txbTI.Text)/100;

                switch (TAmortizacion)
                {
                    case 1:
                        AmortizacionFrancesa();
                        break;
                    case 2:
                        AmortizacionAleman();
                        break;
                    case 3:
                        AmortizacionAmericano();
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }

            }
            catch(Exception)
            {
               
            }

        }
        public void AmortizacionFrancesa()
        {
            Cuota = CalcularCuota(CapPrestado, TI, Periodo);
            txbVariable.Text = Cuota.ToString();
        }

        public void AmortizacionAleman()
        {
            CapAmortizado = CalcularCapitalAmortizado(CapPrestado, Periodo);
            txbVariable.Text = CapAmortizado.ToString();
        }

        public void AmortizacionAmericano()
        {
            InteresAmericano = CalcularInteresAmericano(CapPrestado, TI);
            txbVariable.Text = InteresAmericano.ToString();
        }


        public double CalcularCuota(double CaPrestado,double Ti,int Periodos)
        {
            Ti = Ti / 12;
            return CaPrestado * Ti / (1 - (Math.Pow((1 + Ti), -Periodos)));
        }

        public double CalcularCapitalAmortizado(double CaPrestado, int Periodos)
        {
            return CaPrestado/Periodos;
        }
        public double CalcularInteresAmericano(double CaPrestado, double Ti)
        {
            Ti = Ti / 12;
            return CaPrestado * Ti;
        }



        public int CalcularPeriodo(int Frecuencia,int Anios)
        {
            txbNroPeriodo.Text= (Frecuencia*Anios).ToString();
            return Convert.ToInt32(txbNroPeriodo.Text);
        }













        private void CrearTabla()
        {
            DGVAmortizacion.Rows.Clear();
            DGVAmortizacion.Columns.Clear();

            DGVAmortizacion.Columns.Add("C1", "Nro");
            DGVAmortizacion.Columns.Add("C2", "Cuota");
            DGVAmortizacion.Columns.Add("C3", "Interes");
            DGVAmortizacion.Columns.Add("C4", "Capital");
            DGVAmortizacion.Columns.Add("C5", "Saldo");


            switch (TAmortizacion)
            {
                case 1:
                    CompletarTablaFrances();
                    break;
                case 2:
                    CompletarTablaAleman();
                    break;
                case 3:
                    CompletarTablaAmericana();
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }


        }

        private void CompletarTablaFrances()
        {
            double Interes = 0;
            double Capital = 0;
            double Saldo = CapPrestado;
          

            for (int i = 1; i < Periodo + 1; i++)
            {
                Interes = Saldo * TI / Frecuencia;
                Capital = Cuota - Interes;
                Saldo = Saldo - Capital;

                DGVAmortizacion.Rows.Add(i, Math.Round(Cuota, 2), Math.Round(Interes, 2), Math.Round(Capital, 2), Math.Round(Saldo, 2));
            }
        }

        private void CompletarTablaAleman()
        {
            double Interes = 0;
            double CuotaV = 0;
            double Saldo = CapPrestado;
            

            for (int i = 1; i < Periodo + 1; i++)
            {
                Interes = Saldo * TI / Frecuencia;
                CuotaV = CapAmortizado + Interes;
                Saldo = Saldo - CapAmortizado;

                DGVAmortizacion.Rows.Add(i, Math.Round(CuotaV, 2), Math.Round(Interes, 2), Math.Round(CapAmortizado, 2), Math.Round(Saldo, 2));
            }
        }

        private void CompletarTablaAmericana()
        {
            double CuotaA=InteresAmericano;
            double CuotaFinal;
            for (int i = 1; i < Periodo - 1; i++)
            {
                
                DGVAmortizacion.Rows.Add(i, Math.Round(CuotaA, 2), Math.Round(InteresAmericano, 2), 0, Math.Round(CapPrestado, 2));
            }

            CuotaFinal = InteresAmericano + CapPrestado;
            DGVAmortizacion.Rows.Add(Periodo, CuotaFinal, InteresAmericano, CapPrestado, 0);
        }





        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CrearTabla();
            DibujarGrafico();
        }

        private void DibujarGrafico()
        {
            chrtAmortizacion.Series.Clear();

            Series seriesInteres = new Series("Interes");
            Series seriesCapital = new Series("Capital");

            seriesInteres.ChartType = SeriesChartType.Line;
            seriesCapital.ChartType = SeriesChartType.Line;

            chrtAmortizacion.ChartAreas[0].AxisX.Minimum = 0;
            chrtAmortizacion.ChartAreas[0].AxisX.IsStartedFromZero = true;

            foreach (DataGridViewRow row in DGVAmortizacion.Rows)
            {
                if (!row.IsNewRow)
                {
                    double xValue = Convert.ToDouble(row.Cells[0].Value);
                    double yValueInteres = Convert.ToDouble(row.Cells[2].Value);
                    double yValueCapital = Convert.ToDouble(row.Cells[3].Value);

                    seriesInteres.Points.AddXY(xValue, yValueInteres);
                    seriesCapital.Points.AddXY(xValue, yValueCapital);
                }
            }

            chrtAmortizacion.Series.Add(seriesInteres);
            chrtAmortizacion.Series.Add(seriesCapital);

            seriesInteres.BorderWidth = 4;
            seriesInteres.Color = Color.Red;

            seriesCapital.BorderWidth = 4;
            seriesCapital.Color = Color.Black;

            chrtAmortizacion.ChartAreas[0].AxisX.Title = "Tiempo";
            chrtAmortizacion.ChartAreas[0].AxisY.Title = "Monto";
        }

        private void chrtAmortizacion_Click(object sender, EventArgs e)
        {

        }
    }
}
