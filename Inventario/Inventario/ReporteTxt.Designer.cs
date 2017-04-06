namespace Inventario
{
    partial class ReporteTxt
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
            this.tb_Reporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_Reporte
            // 
            this.tb_Reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Reporte.Location = new System.Drawing.Point(0, 0);
            this.tb_Reporte.Multiline = true;
            this.tb_Reporte.Name = "tb_Reporte";
            this.tb_Reporte.ReadOnly = true;
            this.tb_Reporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Reporte.Size = new System.Drawing.Size(642, 454);
            this.tb_Reporte.TabIndex = 0;
            this.tb_Reporte.Text = "Ejemplo Del texto";
            // 
            // ReporteTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 454);
            this.Controls.Add(this.tb_Reporte);
            this.Name = "ReporteTxt";
            this.Text = "ReporteTxt";
            this.Load += new System.EventHandler(this.ReporteTxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Reporte;
    }
}