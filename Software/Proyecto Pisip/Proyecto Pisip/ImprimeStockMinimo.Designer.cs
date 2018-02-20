namespace Proyecto_Pisip
{
    partial class ImprimeStockMinimo
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
            this.crvStockMinimo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvStockMinimo
            // 
            this.crvStockMinimo.ActiveViewIndex = -1;
            this.crvStockMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvStockMinimo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvStockMinimo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvStockMinimo.Location = new System.Drawing.Point(0, 0);
            this.crvStockMinimo.Name = "crvStockMinimo";
            this.crvStockMinimo.ShowGroupTreeButton = false;
            this.crvStockMinimo.ShowLogo = false;
            this.crvStockMinimo.Size = new System.Drawing.Size(731, 422);
            this.crvStockMinimo.TabIndex = 0;
            this.crvStockMinimo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ImprimeStockMinimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 422);
            this.Controls.Add(this.crvStockMinimo);
            this.MaximizeBox = false;
            this.Name = "ImprimeStockMinimo";
            this.Text = "ImprimeStockMinimo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImprimeStockMinimo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvStockMinimo;
    }
}