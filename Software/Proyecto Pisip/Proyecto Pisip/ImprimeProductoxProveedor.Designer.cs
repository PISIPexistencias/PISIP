namespace Proyecto_Pisip
{
    partial class ImprimeProductoxProveedor
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
            this.crvProdcutoxProveedor = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProdcutoxProveedor
            // 
            this.crvProdcutoxProveedor.ActiveViewIndex = -1;
            this.crvProdcutoxProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProdcutoxProveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProdcutoxProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProdcutoxProveedor.Location = new System.Drawing.Point(0, 0);
            this.crvProdcutoxProveedor.Name = "crvProdcutoxProveedor";
            this.crvProdcutoxProveedor.ShowGroupTreeButton = false;
            this.crvProdcutoxProveedor.ShowLogo = false;
            this.crvProdcutoxProveedor.ShowParameterPanelButton = false;
            this.crvProdcutoxProveedor.ShowRefreshButton = false;
            this.crvProdcutoxProveedor.Size = new System.Drawing.Size(738, 427);
            this.crvProdcutoxProveedor.TabIndex = 0;
            this.crvProdcutoxProveedor.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ImprimeProductoxProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.crvProdcutoxProveedor);
            this.MaximizeBox = false;
            this.Name = "ImprimeProductoxProveedor";
            this.Text = "ImprimeProductoxProveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImprimeProductoxProveedor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProdcutoxProveedor;
    }
}