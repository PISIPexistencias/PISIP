namespace Proyecto_Pisip
{
    partial class Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtCodFactura = new System.Windows.Forms.TextBox();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtCedulaCli = new System.Windows.Forms.TextBox();
            this.btnAgregarDetalle = new System.Windows.Forms.Button();
            this.btnEliminarDetalle = new System.Windows.Forms.Button();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAccion = new System.Windows.Forms.Label();
            this.btnBuscaFactura = new System.Windows.Forms.Button();
            this.btnBuscaCliente = new System.Windows.Forms.Button();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPorcentajeIVA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCobraIva = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetallefatMostrar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallefatMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cedula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(440, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Sub total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "I.V.A 12%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(440, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "TOTAL";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(515, 31);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(28, 13);
            this.lblIva.TabIndex = 12;
            this.lblIva.Text = "0,00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(515, 9);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(28, 13);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "0,00";
            // 
            // txtCodFactura
            // 
            this.txtCodFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodFactura.Enabled = false;
            this.txtCodFactura.Location = new System.Drawing.Point(90, 9);
            this.txtCodFactura.Name = "txtCodFactura";
            this.txtCodFactura.Size = new System.Drawing.Size(120, 20);
            this.txtCodFactura.TabIndex = 15;
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreCli.Enabled = false;
            this.txtNombreCli.Location = new System.Drawing.Point(257, 47);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(180, 20);
            this.txtNombreCli.TabIndex = 18;
            // 
            // txtCedulaCli
            // 
            this.txtCedulaCli.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCedulaCli.Enabled = false;
            this.txtCedulaCli.Location = new System.Drawing.Point(50, 47);
            this.txtCedulaCli.Name = "txtCedulaCli";
            this.txtCedulaCli.Size = new System.Drawing.Size(75, 20);
            this.txtCedulaCli.TabIndex = 19;
            // 
            // btnAgregarDetalle
            // 
            this.btnAgregarDetalle.Location = new System.Drawing.Point(152, 57);
            this.btnAgregarDetalle.Name = "btnAgregarDetalle";
            this.btnAgregarDetalle.Size = new System.Drawing.Size(99, 23);
            this.btnAgregarDetalle.TabIndex = 26;
            this.btnAgregarDetalle.Text = "Agregar Detalle";
            this.btnAgregarDetalle.UseVisualStyleBackColor = true;
            this.btnAgregarDetalle.Click += new System.EventHandler(this.btnAgregarDetalle_Click);
            // 
            // btnEliminarDetalle
            // 
            this.btnEliminarDetalle.Enabled = false;
            this.btnEliminarDetalle.Location = new System.Drawing.Point(299, 57);
            this.btnEliminarDetalle.Name = "btnEliminarDetalle";
            this.btnEliminarDetalle.Size = new System.Drawing.Size(101, 23);
            this.btnEliminarDetalle.TabIndex = 27;
            this.btnEliminarDetalle.Text = "Eliminar Detalle";
            this.btnEliminarDetalle.UseVisualStyleBackColor = true;
            this.btnEliminarDetalle.Click += new System.EventHandler(this.btnEliminarDetalle_Click);
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvDetalleFactura.Location = new System.Drawing.Point(17, 13);
            this.dgvDetalleFactura.MultiSelect = false;
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(562, 134);
            this.dgvDetalleFactura.TabIndex = 28;
            this.dgvDetalleFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleFactura_CellContentClick);
            this.dgvDetalleFactura.Click += new System.EventHandler(this.dgvDetalleFactura_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(515, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 13);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "0,00";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAccion);
            this.panel1.Controls.Add(this.btnBuscaFactura);
            this.panel1.Controls.Add(this.btnBuscaCliente);
            this.panel1.Controls.Add(this.txtCodigoCli);
            this.panel1.Controls.Add(this.dtpFechaFactura);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodFactura);
            this.panel1.Controls.Add(this.txtCedulaCli);
            this.panel1.Controls.Add(this.txtNombreCli);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 81);
            this.panel1.TabIndex = 30;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(544, 50);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(35, 13);
            this.lblAccion.TabIndex = 44;
            this.lblAccion.Text = "label8";
            // 
            // btnBuscaFactura
            // 
            this.btnBuscaFactura.Image = global::Proyecto_Pisip.Properties.Resources.busqueda1;
            this.btnBuscaFactura.Location = new System.Drawing.Point(218, 2);
            this.btnBuscaFactura.Name = "btnBuscaFactura";
            this.btnBuscaFactura.Size = new System.Drawing.Size(33, 33);
            this.btnBuscaFactura.TabIndex = 43;
            this.btnBuscaFactura.Text = "...";
            this.btnBuscaFactura.UseVisualStyleBackColor = true;
            this.btnBuscaFactura.Click += new System.EventHandler(this.btnBuscaFactura_Click);
            // 
            // btnBuscaCliente
            // 
            this.btnBuscaCliente.Image = global::Proyecto_Pisip.Properties.Resources.busqueda1;
            this.btnBuscaCliente.Location = new System.Drawing.Point(443, 40);
            this.btnBuscaCliente.Name = "btnBuscaCliente";
            this.btnBuscaCliente.Size = new System.Drawing.Size(33, 33);
            this.btnBuscaCliente.TabIndex = 42;
            this.btnBuscaCliente.Text = "...";
            this.btnBuscaCliente.UseVisualStyleBackColor = true;
            this.btnBuscaCliente.Click += new System.EventHandler(this.btnBuscaCliente_Click);
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigoCli.Enabled = false;
            this.txtCodigoCli.Location = new System.Drawing.Point(216, 47);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(35, 20);
            this.txtCodigoCli.TabIndex = 41;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(483, 9);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(102, 20);
            this.dtpFechaFactura.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtPorcentajeIVA);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblCobraIva);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnProducto);
            this.panel2.Controls.Add(this.txtCodProducto);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.txtPrecioVenta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtNombreProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnAgregarDetalle);
            this.panel2.Controls.Add(this.btnEliminarDetalle);
            this.panel2.Location = new System.Drawing.Point(7, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 89);
            this.panel2.TabIndex = 31;
            // 
            // txtPorcentajeIVA
            // 
            this.txtPorcentajeIVA.Location = new System.Drawing.Point(573, 54);
            this.txtPorcentajeIVA.Name = "txtPorcentajeIVA";
            this.txtPorcentajeIVA.Size = new System.Drawing.Size(29, 20);
            this.txtPorcentajeIVA.TabIndex = 56;
            this.txtPorcentajeIVA.Text = "12";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "% IVA";
            // 
            // lblCobraIva
            // 
            this.lblCobraIva.AutoSize = true;
            this.lblCobraIva.Location = new System.Drawing.Point(575, 20);
            this.lblCobraIva.Name = "lblCobraIva";
            this.lblCobraIva.Size = new System.Drawing.Size(10, 13);
            this.lblCobraIva.TabIndex = 54;
            this.lblCobraIva.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "IVA";
            // 
            // btnProducto
            // 
            this.btnProducto.Image = global::Proyecto_Pisip.Properties.Resources.busqueda1;
            this.btnProducto.Location = new System.Drawing.Point(257, 10);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(33, 33);
            this.btnProducto.TabIndex = 52;
            this.btnProducto.Text = "...";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodProducto.Enabled = false;
            this.txtCodProducto.Location = new System.Drawing.Point(69, 17);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(35, 20);
            this.txtCodProducto.TabIndex = 51;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(483, 17);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(35, 20);
            this.txtCantidad.TabIndex = 49;
            this.txtCantidad.Text = "0";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(378, 17);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(39, 20);
            this.txtPrecioVenta.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(296, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Precio Unitario";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(119, 17);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 20);
            this.txtNombreProducto.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Producto";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvDetallefatMostrar);
            this.panel3.Controls.Add(this.dgvDetalleFactura);
            this.panel3.Location = new System.Drawing.Point(7, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 152);
            this.panel3.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.lblSubTotal);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lblIva);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(7, 352);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(607, 76);
            this.panel4.TabIndex = 33;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(21, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Anular";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(21, 249);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnImprimir);
            this.panel5.Controls.Add(this.btnIngresar);
            this.panel5.Controls.Add(this.btnNuevo);
            this.panel5.Controls.Add(this.btnModificar);
            this.panel5.Controls.Add(this.btnSalir);
            this.panel5.Location = new System.Drawing.Point(633, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 416);
            this.panel5.TabIndex = 36;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(21, 121);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 37;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(21, 71);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtStock
            // 
            this.txtStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(483, 54);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(35, 20);
            this.txtStock.TabIndex = 58;
            this.txtStock.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(428, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Stock";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Location = new System.Drawing.Point(21, 208);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Secuencial";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "Precio Unitario";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "CobraIva";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "CodigoProducto";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // dgvDetallefatMostrar
            // 
            this.dgvDetallefatMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallefatMostrar.Location = new System.Drawing.Point(23, 13);
            this.dgvDetallefatMostrar.MultiSelect = false;
            this.dgvDetallefatMostrar.Name = "dgvDetallefatMostrar";
            this.dgvDetallefatMostrar.ReadOnly = true;
            this.dgvDetallefatMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetallefatMostrar.Size = new System.Drawing.Size(562, 134);
            this.dgvDetallefatMostrar.TabIndex = 29;
            this.dgvDetallefatMostrar.Visible = false;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.MaximizeBox = false;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallefatMostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtCodFactura;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.TextBox txtCedulaCli;
        private System.Windows.Forms.Button btnAgregarDetalle;
        private System.Windows.Forms.Button btnEliminarDetalle;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Button btnBuscaCliente;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBuscaFactura;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblCobraIva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPorcentajeIVA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dgvDetallefatMostrar;
    }
}