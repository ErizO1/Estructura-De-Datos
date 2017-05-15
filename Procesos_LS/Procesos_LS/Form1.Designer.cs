namespace Procesos_LS
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vacio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_maximo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_procesos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ciclos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_totales = new System.Windows.Forms.TextBox();
            this.bt_comenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciclos sin procesos en cola";
            // 
            // tb_vacio
            // 
            this.tb_vacio.Location = new System.Drawing.Point(204, 6);
            this.tb_vacio.Name = "tb_vacio";
            this.tb_vacio.Size = new System.Drawing.Size(100, 20);
            this.tb_vacio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad máxima de procesos en cola";
            // 
            // tb_maximo
            // 
            this.tb_maximo.Location = new System.Drawing.Point(204, 32);
            this.tb_maximo.Name = "tb_maximo";
            this.tb_maximo.Size = new System.Drawing.Size(100, 20);
            this.tb_maximo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Procesos pendientes al finalizar";
            // 
            // tb_procesos
            // 
            this.tb_procesos.Location = new System.Drawing.Point(204, 58);
            this.tb_procesos.Name = "tb_procesos";
            this.tb_procesos.Size = new System.Drawing.Size(100, 20);
            this.tb_procesos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ciclos pendientes al finalizar";
            // 
            // tb_ciclos
            // 
            this.tb_ciclos.Location = new System.Drawing.Point(204, 84);
            this.tb_ciclos.Name = "tb_ciclos";
            this.tb_ciclos.Size = new System.Drawing.Size(100, 20);
            this.tb_ciclos.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Procesos atendidos en su totalidad";
            // 
            // tb_totales
            // 
            this.tb_totales.Location = new System.Drawing.Point(204, 110);
            this.tb_totales.Name = "tb_totales";
            this.tb_totales.Size = new System.Drawing.Size(100, 20);
            this.tb_totales.TabIndex = 1;
            // 
            // bt_comenzar
            // 
            this.bt_comenzar.Location = new System.Drawing.Point(15, 136);
            this.bt_comenzar.Name = "bt_comenzar";
            this.bt_comenzar.Size = new System.Drawing.Size(289, 23);
            this.bt_comenzar.TabIndex = 2;
            this.bt_comenzar.Text = "Comenzar";
            this.bt_comenzar.UseVisualStyleBackColor = true;
            this.bt_comenzar.Click += new System.EventHandler(this.bt_comenzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 168);
            this.Controls.Add(this.bt_comenzar);
            this.Controls.Add(this.tb_totales);
            this.Controls.Add(this.tb_ciclos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_procesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_maximo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_vacio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Procesos - Listas Circulares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vacio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_maximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_procesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ciclos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_totales;
        private System.Windows.Forms.Button bt_comenzar;
    }
}

