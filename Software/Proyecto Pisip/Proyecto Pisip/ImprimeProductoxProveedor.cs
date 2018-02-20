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
    public partial class ImprimeProductoxProveedor : Form
    {
        public int CodProducto;
        public ImprimeProductoxProveedor()
        {
            InitializeComponent();
        }

        private void ImprimeProductoxProveedor_Load(object sender, EventArgs e)
        {
            rptDetalleProductos detalleProducProv = new rptDetalleProductos();
            detalleProducProv.SetParameterValue("codProducto", CodProducto);

            crvProdcutoxProveedor.ReportSource = detalleProducProv;

        }
    }
}
