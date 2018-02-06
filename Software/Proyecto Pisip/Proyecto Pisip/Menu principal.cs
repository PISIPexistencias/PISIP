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
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_clientes act_cliente = new Actualizar_clientes();
            act_cliente.Show();
        }

        private void ingresoMantenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Actualizar_empleado act_empleado = new Actualizar_empleado();
            act_empleado.Show();
        }
    }
}
