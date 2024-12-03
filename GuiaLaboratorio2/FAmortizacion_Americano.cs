using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GuiaLaboratorio2
{
    public partial class FAmortizacion_Americano : Form
    {
        private double CapPrestado;
        private double Cuota;
        private int Periodo;
        private double TI;
        private int Frecuencia;
        private int Tiempo;
        public FAmortizacion_Americano()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                CapPrestado = Convert.ToDouble(txbPrestamo.Text);
                Frecuencia = Convert.ToInt32(txbFrecuencia.Text);
                Tiempo = Convert.ToInt32(txbTiempo.Text);

                Periodo = CalcularPeriodo(Frecuencia, Tiempo);
                TI = Convert.ToDouble(txbTI.Text) / 100;

                Cuota = CalcularCuota(CapPrestado, TI, Periodo);

                txbCuota.Text = Cuota.ToString();



            }
            catch (Exception)
            {

            }

        }
        public double CalcularCuota(double CapPrestado, double Ti, int Periodos)
        {
            Ti = Ti / 12;
            txbCuota.Text = Cuota.ToString();
            return CapPrestado * Ti / (1 - (Math.Pow((1 + Ti), -Periodos)));
        }
        public int CalcularPeriodo(int Frecuencia, int Anios)
        {
            txbNroPeriodo.Text = (Frecuencia * Anios).ToString();
            return Convert.ToInt32(txbNroPeriodo.Text);
        }

        private void CrearTabla()
        {
            DGVAmortizacionFrancesa.Rows.Clear();
            DGVAmortizacionFrancesa.Columns.Clear();

            DGVAmortizacionFrancesa.Columns.Add("C1", "Nro");
            DGVAmortizacionFrancesa.Columns.Add("C2", "Cuota");
            DGVAmortizacionFrancesa.Columns.Add("C3", "Interes");
            DGVAmortizacionFrancesa.Columns.Add("C4", "Capital");
            DGVAmortizacionFrancesa.Columns.Add("C5", "Saldo");

            CompletarTabla();
        }

        private void CompletarTabla()
        {
            double Interes = 0;
            double Capital = 0;
            double Saldo = CapPrestado;


            for (int i = 1; i < Periodo + 1; i++)
            {
                Interes = Saldo * TI / Frecuencia;
                Capital = Cuota - Interes;
                Saldo = Saldo - Capital;

                DGVAmortizacionFrancesa.Rows.Add(i, Math.Round(Cuota, 2), Math.Round(Interes, 2), Math.Round(Capital, 2), Math.Round(Saldo, 2));
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            CrearTabla();
            DibujarGrafico();
        }

        private void DibujarGrafico()
        {
            chrtAmortizacion_Francesa.Series.Clear();

            Series seriesInteres = new Series("Interes");
            Series seriesCapital = new Series("Capital");

            seriesInteres.ChartType = SeriesChartType.Line;
            seriesCapital.ChartType = SeriesChartType.Line;

            chrtAmortizacion_Francesa.ChartAreas[0].AxisX.Minimum = 0;
            chrtAmortizacion_Francesa.ChartAreas[0].AxisX.IsStartedFromZero = true;

            foreach (DataGridViewRow row in DGVAmortizacionFrancesa.Rows)
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

            chrtAmortizacion_Francesa.Series.Add(seriesInteres);
            chrtAmortizacion_Francesa.Series.Add(seriesCapital);

            seriesInteres.BorderWidth = 4;
            seriesInteres.Color = Color.Red;

            seriesCapital.BorderWidth = 4;
            seriesCapital.Color = Color.Black;

            chrtAmortizacion_Francesa.ChartAreas[0].AxisX.Title = "Tiempo";
            chrtAmortizacion_Francesa.ChartAreas[0].AxisY.Title = "Monto";
        }

        private void label1T_Variable_Click(object sender, EventArgs e)
        {

        }
    }
}