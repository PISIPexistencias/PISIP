﻿namespace Proyecto_Pisip
{
    partial class Actualizar_clientes
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
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txt_nom_actualizar = new System.Windows.Forms.TextBox();
            this.txt_ape_actualizar = new System.Windows.Forms.TextBox();
            this.txt_ced_actualizar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Proyecto_Pisip.Properties.Resources.busqueda;
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnbuscar.Location = new System.Drawing.Point(50, 3);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 53);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txt_nom_actualizar
            // 
            this.txt_nom_actualizar.Location = new System.Drawing.Point(374, 11);
            this.txt_nom_actualizar.MaxLength = 50;
            this.txt_nom_actualizar.Name = "txt_nom_actualizar";
            this.txt_nom_actualizar.Size = new System.Drawing.Size(106, 20);
            this.txt_nom_actualizar.TabIndex = 24;
            this.txt_nom_actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nom_actualizar_KeyPress);
            // 
            // txt_ape_actualizar
            // 
            this.txt_ape_actualizar.Location = new System.Drawing.Point(193, 11);
            this.txt_ape_actualizar.MaxLength = 50;
            this.txt_ape_actualizar.Name = "txt_ape_actualizar";
            this.txt_ape_actualizar.Size = new System.Drawing.Size(103, 20);
            this.txt_ape_actualizar.TabIndex = 23;
            this.txt_ape_actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ape_actualizar_KeyPress);
            // 
            // txt_ced_actualizar
            // 
            this.txt_ced_actualizar.Location = new System.Drawing.Point(49, 11);
            this.txt_ced_actualizar.MaxLength = 10;
            this.txt_ced_actualizar.Name = "txt_ced_actualizar";
            this.txt_ced_actualizar.Size = new System.Drawing.Size(67, 20);
            this.txt_ced_actualizar.TabIndex = 22;
            this.txt_ced_actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ced_actualizar_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cedula";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Proyecto_Pisip.Properties.Resources.eliminar;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneliminar.Location = new System.Drawing.Point(293, 3);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 53);
            this.btneliminar.TabIndex = 30;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::Proyecto_Pisip.Properties.Resources.nuevo;
            this.btnnuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnnuevo.Location = new System.Drawing.Point(131, 3);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 53);
            this.btnnuevo.TabIndex = 31;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = global::Proyecto_Pisip.Properties.Resources.editar;
            this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnmodificar.Location = new System.Drawing.Point(212, 3);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 53);
            this.btnmodificar.TabIndex = 29;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_ced_actualizar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_ape_actualizar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_nom_actualizar);
            this.panel1.Location = new System.Drawing.Point(17, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 58);
            this.panel1.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.btnnuevo);
            this.panel2.Controls.Add(this.btneliminar);
            this.panel2.Controls.Add(this.btnmodificar);
            this.panel2.Location = new System.Drawing.Point(17, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 65);
            this.panel2.TabIndex = 33;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Proyecto_Pisip.Properties.Resources.salir;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsalir.Location = new System.Drawing.Point(374, 3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 53);
            this.btnsalir.TabIndex = 32;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(7, 14);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(483, 168);
            this.dgvClientes.TabIndex = 29;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvClientes);
            this.panel3.Location = new System.Drawing.Point(17, 149);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 195);
            this.panel3.TabIndex = 34;
            // 
            // Actualizar_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 356);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Actualizar_clientes";
            this.Text = "Mantenimiento Cliente";
            this.Activated += new System.EventHandler(this.Actualizar_clientes_Activated);
            this.Load += new System.EventHandler(this.Actualizar_clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txt_nom_actualizar;
        private System.Windows.Forms.TextBox txt_ape_actualizar;
        private System.Windows.Forms.TextBox txt_ced_actualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel3;
    }
}