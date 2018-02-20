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
    public partial class ImprimeStockMinimo : Form
    {
        public int codProducto;
        public ImprimeStockMinimo()
        {
            InitializeComponent();
        }

        private void ImprimeStockMinimo_Load(object sender, EventArgs e)
        {
            rptStockMinimo detStockMinimo = new rptStockMinimo();
            detStockMinimo.SetParameterValue("codProducto", codProducto);

            crvStockMinimo.ReportSource = detStockMinimo;
        }
    }
}
