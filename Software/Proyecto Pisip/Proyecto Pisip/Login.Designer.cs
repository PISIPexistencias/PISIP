﻿namespace Proyecto_Pisip
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.Lbpass = new System.Windows.Forms.Label();
            this.Lbuser = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtpass);
            this.panel1.Controls.Add(this.txtuser);
            this.panel1.Controls.Add(this.Lbpass);
            this.panel1.Controls.Add(this.Lbuser);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 100);
            this.panel1.TabIndex = 6;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(115, 60);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 7;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(115, 21);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 6;
            // 
            // Lbpass
            // 
            this.Lbpass.AutoSize = true;
            this.Lbpass.Location = new System.Drawing.Point(28, 60);
            this.Lbpass.Name = "Lbpass";
            this.Lbpass.Size = new System.Drawing.Size(61, 13);
            this.Lbpass.TabIndex = 5;
            this.Lbpass.Text = "Contraseña";
            // 
            // Lbuser
            // 
            this.Lbuser.AutoSize = true;
            this.Lbuser.Location = new System.Drawing.Point(28, 21);
            this.Lbuser.Name = "Lbuser";
            this.Lbuser.Size = new System.Drawing.Size(43, 13);
            this.Lbuser.TabIndex = 4;
            this.Lbuser.Text = "Usuario";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsalir);
            this.panel2.Controls.Add(this.btningresar);
            this.panel2.Location = new System.Drawing.Point(13, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 38);
            this.panel2.TabIndex = 7;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(138, 8);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btningresar
            // 
            this.btningresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btningresar.Location = new System.Drawing.Point(29, 8);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(75, 23);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 170);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label Lbpass;
        private System.Windows.Forms.Label Lbuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btningresar;
    }
}

