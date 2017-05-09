namespace Rutas
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
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Minutos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_AgregarInicio = new System.Windows.Forms.Button();
            this.bt_Borrar = new System.Windows.Forms.Button();
            this.bt_InsertarDespuesDe = new System.Windows.Forms.Button();
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.bt_Reporte = new System.Windows.Forms.Button();
            this.bt_Recorrido = new System.Windows.Forms.Button();
            this.tb_Reporte = new System.Windows.Forms.TextBox();
            this.dtp_Inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_Fin = new System.Windows.Forms.DateTimePicker();
            this.tb_inicio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Location = new System.Drawing.Point(12, 64);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(75, 23);
            this.bt_Agregar.TabIndex = 2;
            this.bt_Agregar.Text = "Agregar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(65, 12);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(159, 20);
            this.tb_Nombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // tb_Minutos
            // 
            this.tb_Minutos.Location = new System.Drawing.Point(65, 38);
            this.tb_Minutos.Name = "tb_Minutos";
            this.tb_Minutos.Size = new System.Drawing.Size(159, 20);
            this.tb_Minutos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minutos:";
            // 
            // bt_AgregarInicio
            // 
            this.bt_AgregarInicio.Location = new System.Drawing.Point(93, 64);
            this.bt_AgregarInicio.Name = "bt_AgregarInicio";
            this.bt_AgregarInicio.Size = new System.Drawing.Size(131, 23);
            this.bt_AgregarInicio.TabIndex = 3;
            this.bt_AgregarInicio.Text = "Agregar al Inicio";
            this.bt_AgregarInicio.UseVisualStyleBackColor = true;
            this.bt_AgregarInicio.Click += new System.EventHandler(this.bt_AgregarInicio_Click);
            // 
            // bt_Borrar
            // 
            this.bt_Borrar.Location = new System.Drawing.Point(12, 172);
            this.bt_Borrar.Name = "bt_Borrar";
            this.bt_Borrar.Size = new System.Drawing.Size(104, 23);
            this.bt_Borrar.TabIndex = 6;
            this.bt_Borrar.Text = "Borrar";
            this.bt_Borrar.UseVisualStyleBackColor = true;
            this.bt_Borrar.Click += new System.EventHandler(this.bt_Borrar_Click);
            // 
            // bt_InsertarDespuesDe
            // 
            this.bt_InsertarDespuesDe.Location = new System.Drawing.Point(120, 172);
            this.bt_InsertarDespuesDe.Name = "bt_InsertarDespuesDe";
            this.bt_InsertarDespuesDe.Size = new System.Drawing.Size(104, 23);
            this.bt_InsertarDespuesDe.TabIndex = 7;
            this.bt_InsertarDespuesDe.Text = "Inserter Despues";
            this.bt_InsertarDespuesDe.UseVisualStyleBackColor = true;
            this.bt_InsertarDespuesDe.Click += new System.EventHandler(this.bt_InsertarDespuesDe_Click);
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Location = new System.Drawing.Point(12, 143);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(212, 23);
            this.bt_Buscar.TabIndex = 5;
            this.bt_Buscar.Text = "Buscar";
            this.bt_Buscar.UseVisualStyleBackColor = true;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click);
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(12, 117);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(212, 20);
            this.tb_Buscar.TabIndex = 4;
            // 
            // bt_Reporte
            // 
            this.bt_Reporte.Location = new System.Drawing.Point(15, 412);
            this.bt_Reporte.Name = "bt_Reporte";
            this.bt_Reporte.Size = new System.Drawing.Size(209, 23);
            this.bt_Reporte.TabIndex = 8;
            this.bt_Reporte.Text = "Reporte";
            this.bt_Reporte.UseVisualStyleBackColor = true;
            this.bt_Reporte.Click += new System.EventHandler(this.bt_Reporte_Click);
            // 
            // bt_Recorrido
            // 
            this.bt_Recorrido.Location = new System.Drawing.Point(12, 330);
            this.bt_Recorrido.Name = "bt_Recorrido";
            this.bt_Recorrido.Size = new System.Drawing.Size(212, 23);
            this.bt_Recorrido.TabIndex = 9;
            this.bt_Recorrido.Text = "Recorrido";
            this.bt_Recorrido.UseVisualStyleBackColor = true;
            this.bt_Recorrido.Click += new System.EventHandler(this.bt_Recorrido_Click);
            // 
            // tb_Reporte
            // 
            this.tb_Reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Reporte.Location = new System.Drawing.Point(240, 12);
            this.tb_Reporte.Multiline = true;
            this.tb_Reporte.Name = "tb_Reporte";
            this.tb_Reporte.ReadOnly = true;
            this.tb_Reporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Reporte.Size = new System.Drawing.Size(422, 423);
            this.tb_Reporte.TabIndex = 10;
            // 
            // dtp_Inicio
            // 
            this.dtp_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Inicio.Location = new System.Drawing.Point(12, 304);
            this.dtp_Inicio.Name = "dtp_Inicio";
            this.dtp_Inicio.Size = new System.Drawing.Size(104, 20);
            this.dtp_Inicio.TabIndex = 13;
            // 
            // dtp_Fin
            // 
            this.dtp_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Fin.Location = new System.Drawing.Point(120, 304);
            this.dtp_Fin.Name = "dtp_Fin";
            this.dtp_Fin.Size = new System.Drawing.Size(104, 20);
            this.dtp_Fin.TabIndex = 13;
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(12, 278);
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(212, 20);
            this.tb_inicio.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 447);
            this.Controls.Add(this.tb_inicio);
            this.Controls.Add(this.dtp_Fin);
            this.Controls.Add(this.dtp_Inicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Buscar);
            this.Controls.Add(this.tb_Minutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.bt_Recorrido);
            this.Controls.Add(this.bt_InsertarDespuesDe);
            this.Controls.Add(this.bt_Reporte);
            this.Controls.Add(this.bt_Borrar);
            this.Controls.Add(this.bt_Buscar);
            this.Controls.Add(this.bt_AgregarInicio);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.tb_Reporte);
            this.Name = "Form1";
            this.Text = "Rutas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Minutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_AgregarInicio;
        private System.Windows.Forms.Button bt_Borrar;
        private System.Windows.Forms.Button bt_InsertarDespuesDe;
        private System.Windows.Forms.Button bt_Buscar;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Button bt_Reporte;
        private System.Windows.Forms.Button bt_Recorrido;
        private System.Windows.Forms.TextBox tb_Reporte;
        private System.Windows.Forms.DateTimePicker dtp_Inicio;
        private System.Windows.Forms.DateTimePicker dtp_Fin;
        private System.Windows.Forms.TextBox tb_inicio;
    }
}

