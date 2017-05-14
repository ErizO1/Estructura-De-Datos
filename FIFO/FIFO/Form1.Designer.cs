namespace FIFO
{
    partial class Form1
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
            this.tb_vacios = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_procesos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Comenzar = new System.Windows.Forms.Button();
            this.tb_ciclos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_vacios
            // 
            this.tb_vacios.Location = new System.Drawing.Point(174, 9);
            this.tb_vacios.Name = "tb_vacios";
            this.tb_vacios.Size = new System.Drawing.Size(100, 20);
            this.tb_vacios.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciclos sin procesos en cola";
            // 
            // tb_procesos
            // 
            this.tb_procesos.Location = new System.Drawing.Point(174, 35);
            this.tb_procesos.Name = "tb_procesos";
            this.tb_procesos.Size = new System.Drawing.Size(100, 20);
            this.tb_procesos.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procesos Pendientes al finalizar";
            // 
            // bt_Comenzar
            // 
            this.bt_Comenzar.Location = new System.Drawing.Point(12, 93);
            this.bt_Comenzar.Name = "bt_Comenzar";
            this.bt_Comenzar.Size = new System.Drawing.Size(259, 23);
            this.bt_Comenzar.TabIndex = 2;
            this.bt_Comenzar.Text = "Comenzar";
            this.bt_Comenzar.UseVisualStyleBackColor = true;
            this.bt_Comenzar.Click += new System.EventHandler(this.bt_Comenzar_Click);
            // 
            // tb_ciclos
            // 
            this.tb_ciclos.Location = new System.Drawing.Point(174, 61);
            this.tb_ciclos.Name = "tb_ciclos";
            this.tb_ciclos.Size = new System.Drawing.Size(100, 20);
            this.tb_ciclos.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ciclos Pendientes al finalizar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.bt_Comenzar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ciclos);
            this.Controls.Add(this.tb_procesos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_vacios);
            this.Name = "Form1";
            this.Text = "FIFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_vacios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_procesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Comenzar;
        private System.Windows.Forms.TextBox tb_ciclos;
        private System.Windows.Forms.Label label3;
    }
}

