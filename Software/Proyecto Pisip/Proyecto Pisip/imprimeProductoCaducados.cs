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
    public partial class imprimeProductoCaducados : Form
    {
        public DateTime fechaCaduca;
        public imprimeProductoCaducados()
        {
            InitializeComponent();
        }

        private void imprimeProductoCaducados_Load(object sender, EventArgs e)
        {
            rptDetalleProdxFechaCaduca detProcFechaCaducado = new rptDetalleProdxFechaCaduca();
            detProcFechaCaducado.SetParameterValue("fechaCaduca", fechaCaduca);

            crvProductoCaduca.ReportSource = detProcFechaCaducado;
        }
    }
}
