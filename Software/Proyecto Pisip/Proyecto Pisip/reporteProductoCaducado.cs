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
    public partial class reporteProductoCaducado : Form
    {
        public reporteProductoCaducado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaCaduca;
            fechaCaduca = dtpFechaCaduca.Value;
            imprimeProductoCaducados detProdCaducado = new imprimeProductoCaducados();
            detProdCaducado.fechaCaduca = fechaCaduca;

            detProdCaducado.ShowDialog();

        }
    }
}
