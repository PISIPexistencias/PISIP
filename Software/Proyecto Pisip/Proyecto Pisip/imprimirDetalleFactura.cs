using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Pisip
{
    public partial class imprimirDetalleFactura : Form
    {
        public int numeroFactura;
        public imprimirDetalleFactura()
        {
            InitializeComponent();
        }

        private void imprimirDetalleFactura_Load(object sender, EventArgs e)
        {
            rptDetalleFactura factura = new rptDetalleFactura();
            factura.SetParameterValue("codFactura", numeroFactura);

            crvDetalleFactura.ReportSource = factura;
        }
    }
}
