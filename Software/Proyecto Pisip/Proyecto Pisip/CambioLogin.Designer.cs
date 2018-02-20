namespace Proyecto_Pisip
{
    partial class CambioLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.txtClaveNueva = new System.Windows.Forms.TextBox();
            this.txtComfirmaClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblclave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPrimeraVez = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPrimeraVez);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblclave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtComfirmaClave);
            this.panel1.Controls.Add(this.txtClaveNueva);
            this.panel1.Controls.Add(this.txtClaveActual);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 128);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnCambiar);
            this.panel2.Location = new System.Drawing.Point(13, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Image = global::Proyecto_Pisip.Properties.Resources.cambiarclave1;
            this.btnCambiar.Location = new System.Drawing.Point(22, 7);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 53);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Proyecto_Pisip.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(200, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 53);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(165, 28);
            this.txtClaveActual.MaxLength = 10;
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(75, 20);
            this.txtClaveActual.TabIndex = 0;
            // 
            // txtClaveNueva
            // 
            this.txtClaveNueva.Location = new System.Drawing.Point(165, 55);
            this.txtClaveNueva.MaxLength = 10;
            this.txtClaveNueva.Name = "txtClaveNueva";
            this.txtClaveNueva.PasswordChar = '*';
            this.txtClaveNueva.Size = new System.Drawing.Size(75, 20);
            this.txtClaveNueva.TabIndex = 1;
            // 
            // txtComfirmaClave
            // 
            this.txtComfirmaClave.Location = new System.Drawing.Point(165, 82);
            this.txtComfirmaClave.MaxLength = 10;
            this.txtComfirmaClave.Name = "txtComfirmaClave";
            this.txtComfirmaClave.PasswordChar = '*';
            this.txtComfirmaClave.Size = new System.Drawing.Size(75, 20);
            this.txtComfirmaClave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clave Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave Nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirmar Clave";
            // 
            // lblclave
            // 
            this.lblclave.AutoSize = true;
            this.lblclave.Location = new System.Drawing.Point(205, 10);
            this.lblclave.Name = "lblclave";
            this.lblclave.Size = new System.Drawing.Size(35, 13);
            this.lblclave.TabIndex = 6;
            this.lblclave.Text = "label4";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(101, 10);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "label4";
            // 
            // lblPrimeraVez
            // 
            this.lblPrimeraVez.AutoSize = true;
            this.lblPrimeraVez.Location = new System.Drawing.Point(3, 10);
            this.lblPrimeraVez.Name = "lblPrimeraVez";
            this.lblPrimeraVez.Size = new System.Drawing.Size(35, 13);
            this.lblPrimeraVez.TabIndex = 8;
            this.lblPrimeraVez.Text = "label4";
            // 
            // CambioLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 237);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "CambioLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio CLave";
            this.Load += new System.EventHandler(this.CambioLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComfirmaClave;
        private System.Windows.Forms.TextBox txtClaveNueva;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambiar;
        public System.Windows.Forms.Label lblclave;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblPrimeraVez;
    }
}