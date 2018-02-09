namespace Proyecto_Pisip
{
    partial class Registro_Usuario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCodRol = new System.Windows.Forms.TextBox();
            this.btnBuscaEmpl = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtCodEmpleado = new System.Windows.Forms.TextBox();
            this.lblAccion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoUsu = new System.Windows.Forms.TextBox();
            this.txtClaveUsu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUsu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCodRol);
            this.panel1.Controls.Add(this.btnBuscaEmpl);
            this.panel1.Controls.Add(this.cmbRol);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtcodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.txtCodEmpleado);
            this.panel1.Controls.Add(this.lblAccion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtApellidoUsu);
            this.panel1.Controls.Add(this.txtClaveUsu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNombreUsu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 234);
            this.panel1.TabIndex = 34;
            // 
            // txtCodRol
            // 
            this.txtCodRol.Location = new System.Drawing.Point(209, 159);
            this.txtCodRol.Name = "txtCodRol";
            this.txtCodRol.Size = new System.Drawing.Size(37, 20);
            this.txtCodRol.TabIndex = 38;
            // 
            // btnBuscaEmpl
            // 
            this.btnBuscaEmpl.Location = new System.Drawing.Point(132, 41);
            this.btnBuscaEmpl.Name = "btnBuscaEmpl";
            this.btnBuscaEmpl.Size = new System.Drawing.Size(33, 23);
            this.btnBuscaEmpl.TabIndex = 37;
            this.btnBuscaEmpl.Text = "...";
            this.btnBuscaEmpl.UseVisualStyleBackColor = true;
            this.btnBuscaEmpl.Click += new System.EventHandler(this.btnBuscaEmpl_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(81, 159);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 21);
            this.cmbRol.TabIndex = 36;
            this.cmbRol.SelectedIndexChanged += new System.EventHandler(this.cmbRol_SelectedIndexChanged);
            this.cmbRol.Click += new System.EventHandler(this.cmbRol_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Estado";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtcodigo.Location = new System.Drawing.Point(81, 13);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(61, 20);
            this.txtcodigo.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Código";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstado.Location = new System.Drawing.Point(81, 191);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(84, 21);
            this.cmbEstado.TabIndex = 32;
            // 
            // txtCodEmpleado
            // 
            this.txtCodEmpleado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodEmpleado.Enabled = false;
            this.txtCodEmpleado.Location = new System.Drawing.Point(81, 41);
            this.txtCodEmpleado.Name = "txtCodEmpleado";
            this.txtCodEmpleado.Size = new System.Drawing.Size(45, 20);
            this.txtCodEmpleado.TabIndex = 31;
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Location = new System.Drawing.Point(181, 16);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(35, 13);
            this.lblAccion.TabIndex = 0;
            this.lblAccion.Text = "label8";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Perfil";
            // 
            // txtApellidoUsu
            // 
            this.txtApellidoUsu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellidoUsu.Enabled = false;
            this.txtApellidoUsu.Location = new System.Drawing.Point(81, 67);
            this.txtApellidoUsu.Name = "txtApellidoUsu";
            this.txtApellidoUsu.Size = new System.Drawing.Size(121, 20);
            this.txtApellidoUsu.TabIndex = 30;
            // 
            // txtClaveUsu
            // 
            this.txtClaveUsu.Location = new System.Drawing.Point(81, 127);
            this.txtClaveUsu.Name = "txtClaveUsu";
            this.txtClaveUsu.Size = new System.Drawing.Size(61, 20);
            this.txtClaveUsu.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Apellido";
            // 
            // txtNombreUsu
            // 
            this.txtNombreUsu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreUsu.Enabled = false;
            this.txtNombreUsu.Location = new System.Drawing.Point(81, 94);
            this.txtNombreUsu.Name = "txtNombreUsu";
            this.txtNombreUsu.Size = new System.Drawing.Size(121, 20);
            this.txtNombreUsu.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuario";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btnagregar);
            this.panel2.Location = new System.Drawing.Point(297, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 234);
            this.panel2.TabIndex = 35;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(17, 111);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(17, 64);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 14;
            this.btnagregar.Text = "Aceptar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Registro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 260);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Registro_Usuario";
            this.Text = "Registro_Usuario";
            this.Load += new System.EventHandler(this.Registro_Usuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCodEmpleado;
        public System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClaveUsu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnagregar;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscaEmpl;
        private System.Windows.Forms.TextBox txtCodRol;
        private System.Windows.Forms.TextBox txtApellidoUsu;
        private System.Windows.Forms.TextBox txtNombreUsu;
    }
}