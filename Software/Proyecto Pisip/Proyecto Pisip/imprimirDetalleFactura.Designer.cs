namespace Proyecto_Pisip
{
    partial class imprimirDetalleFactura
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
            this.crvDetalleFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDetalleFactura
            // 
            this.crvDetalleFactura.ActiveViewIndex = -1;
            this.crvDetalleFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDetalleFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDetalleFactura.Location = new System.Drawing.Point(0, 0);
            this.crvDetalleFactura.Name = "crvDetalleFactura";
            this.crvDetalleFactura.ShowGroupTreeButton = false;
            this.crvDetalleFactura.ShowLogo = false;
            this.crvDetalleFactura.Size = new System.Drawing.Size(691, 385);
            this.crvDetalleFactura.TabIndex = 0;
            this.crvDetalleFactura.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // imprimirDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 385);
            this.Controls.Add(this.crvDetalleFactura);
            this.MaximizeBox = false;
            this.Name = "imprimirDetalleFactura";
            this.Text = "Detalle Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imprimirDetalleFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDetalleFactura;
    }
}