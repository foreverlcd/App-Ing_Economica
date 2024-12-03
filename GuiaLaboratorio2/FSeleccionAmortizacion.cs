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
    public partial class FSeleccionAmortizacion : Form
    {
        public FSeleccionAmortizacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbTiposAmortizaciones.SelectedItem.ToString()== "Francesa")
            {
                FAmortizacion_General fAmortizacion_frances = new FAmortizacion_General(1);
                fAmortizacion_frances.ShowDialog();
            }
            else if(cmbTiposAmortizaciones.SelectedItem.ToString() == "Alemana")
            {
                FAmortizacion_General fAmortizacion_aleman=new FAmortizacion_General(2);
                fAmortizacion_aleman.ShowDialog();
            }
            else
            {
                FAmortizacion_General fAmortizacion_americano = new FAmortizacion_General(3);
                fAmortizacion_americano.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
