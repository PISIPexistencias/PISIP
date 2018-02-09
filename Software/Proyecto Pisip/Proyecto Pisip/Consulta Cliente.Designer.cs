namespace Proyecto_Pisip
{
    partial class Consulta_Cliente
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaCli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.dgvClientes);
            this.panel6.Location = new System.Drawing.Point(12, 103);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(457, 216);
            this.panel6.TabIndex = 36;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(7, 13);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(433, 186);
            this.dgvClientes.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSalir);
            this.panel4.Controls.Add(this.btnbuscar);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtCedulaCli);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtApellidoCli);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtNombreCli);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 85);
            this.panel4.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Cedula";
            // 
            // txtCedulaCli
            // 
            this.txtCedulaCli.Location = new System.Drawing.Point(49, 11);
            this.txtCedulaCli.Name = "txtCedulaCli";
            this.txtCedulaCli.Size = new System.Drawing.Size(67, 20);
            this.txtCedulaCli.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Apellidos";
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(177, 11);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(86, 20);
            this.txtApellidoCli.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Nombres";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(334, 11);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(106, 20);
            this.txtNombreCli.TabIndex = 24;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(293, 57);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Seleccionar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(112, 57);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Consulta_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 326);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.Name = "Consulta_Cliente";
            this.Text = "Consulta_Cliente";
            this.Load += new System.EventHandler(this.Consulta_Cliente_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaCli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.DataGridView dgvClientes;
    }
}