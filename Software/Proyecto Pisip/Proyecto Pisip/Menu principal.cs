﻿using System;
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

        private void ingresoMantenimientoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Actualizar_proveedor act_proveedor = new Actualizar_proveedor();
            act_proveedor.Show();
        }

        private void ingresoMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresoMantenimientoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Actualizar_Usuario act_usuario = new Actualizar_Usuario();
            act_usuario.Show();
        }

        private void ingresoMantenimientoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Actualizar_productos act_producto = new Actualizar_productos();
            act_producto.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas venta = new Ventas();
            venta.lblAccion.Text = "I";
            venta.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void reporteProductosXProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codprod;
            ImprimeProductoxProveedor impProxProv = new ImprimeProductoxProveedor();
            codprod = 0;
            impProxProv.CodProducto = codprod;
            impProxProv.ShowDialog();
        }

        private void reportesStockMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codprod;
            ImprimeStockMinimo impStockMinimo = new ImprimeStockMinimo();
            codprod = 0;
            impStockMinimo.codProducto = codprod;
            impStockMinimo.ShowDialog();
        }

        private void reportePorFechaCaducidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteProductoCaducado repProdCaduca = new reporteProductoCaducado();
            repProdCaduca.Show();
        }
    }
}
