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
    public partial class FDepreciacionLineaRecta : Form
    {
        public FDepreciacionLineaRecta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDepreciacion_Click(object sender, EventArgs e)
        {
            double costo = Convert.ToDouble(txtbCosto.Text);
            double valorRescate = Convert.ToDouble(txtbValorRescate.Text);
            int vidaUtil = Convert.ToInt32(txtbVidaUtil.Text);
            double depreciacion = (costo - valorRescate) / vidaUtil;
            txtbDepre.Text = depreciacion.ToString("F2");
            double ValorFinal = costo - (depreciacion * vidaUtil);
            txtbValorFinal.Text = ValorFinal.ToString("F2");
        }

    }
}
