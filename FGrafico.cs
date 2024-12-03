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
    public partial class FGrafico : Form
    {
        private List<double> Datos;
        private string Categoria = "";
        public FGrafico(List<double> datosPrincipal,string Categoria)
        {
            InitializeComponent();
            Datos = datosPrincipal;
            this.Categoria = Categoria;
        }

        private void FGrafico_Load(object sender, EventArgs e)
        {
            CrearTabla(Datos[0], Datos[2],Convert.ToInt16(Datos[1]), Categoria);
            DibujarGrafico();
        }
        private void CrearTabla(double Capital,double TI,int Tiempo,string Categoria)
        {
            DGVDatos.Rows.Clear();
            DGVDatos.Columns.Clear();
            DGVDatos.Columns.Add("C1", $"Tiempo");
            DGVDatos.Columns.Add("C2", $"Interes");
            DGVDatos.Columns.Add("C1", $"Monto Total");
    

            if (Categoria=="Años")
            {

                bucle(Capital, TI, Tiempo);
            }
            else if (Categoria=="Meses")
            {
                TI = TI / 12;
                bucle(Capital, TI, Tiempo);
            }
            else if (Categoria=="Dias")
            {
                TI = TI / 365;
                bucle(Capital, TI, Tiempo);
            }
            
        }
        private void bucle(double Capital, double TI, int Tiempo)
        {
            double Interes = 0;
            double Monto=0;
            for (int i = 0; i < Tiempo+1; i++)
            {
                Interes = i * Capital * TI/100;
                Monto = Capital+Interes;
                DGVDatos.Rows.Add(i,Interes, Monto);
            }
        }
        private void DibujarGrafico()
        {

            chart1.Series.Clear();

            Series series = new Series("Valor");
            series.ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
         

            series.IsValueShownAsLabel = true;
            foreach (DataGridViewRow row in DGVDatos.Rows)
            {
                if (!row.IsNewRow)
                {
                    double xValue = Convert.ToDouble(row.Cells[0].Value); 
                    double yValue = Convert.ToDouble(row.Cells[2].Value); 
                    series.Points.AddXY(xValue, yValue);
                }
            }

        
            chart1.Series.Add(series);
            chart1.Series["Valor"].BorderWidth = 4;
            chart1.Series["Valor"].Color = Color.Red;

            chart1.ChartAreas[0].AxisX.Title = "Tiempo";
            chart1.ChartAreas[0].AxisY.Title = "Monto";
        }
    }
}
