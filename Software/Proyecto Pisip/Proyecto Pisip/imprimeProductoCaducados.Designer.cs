namespace Proyecto_Pisip
{
    partial class imprimeProductoCaducados
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
            this.crvProductoCaduca = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvProductoCaduca
            // 
            this.crvProductoCaduca.ActiveViewIndex = -1;
            this.crvProductoCaduca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductoCaduca.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductoCaduca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductoCaduca.Location = new System.Drawing.Point(0, 0);
            this.crvProductoCaduca.Name = "crvProductoCaduca";
            this.crvProductoCaduca.ShowGroupTreeButton = false;
            this.crvProductoCaduca.ShowLogo = false;
            this.crvProductoCaduca.ShowParameterPanelButton = false;
            this.crvProductoCaduca.ShowRefreshButton = false;
            this.crvProductoCaduca.Size = new System.Drawing.Size(714, 411);
            this.crvProductoCaduca.TabIndex = 0;
            this.crvProductoCaduca.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // imprimeProductoCaducados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 411);
            this.Controls.Add(this.crvProductoCaduca);
            this.MaximizeBox = false;
            this.Name = "imprimeProductoCaducados";
            this.Text = "imprimeProductoCaducados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.imprimeProductoCaducados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductoCaduca;
    }
}