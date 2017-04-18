namespace Inventario
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
            this.dgv_Reporte = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.bt_Agregar = new System.Windows.Forms.Button();
            this.bt_Eliminar = new System.Windows.Forms.Button();
            this.bt_Buscar = new System.Windows.Forms.Button();
            this.bt_Insertar = new System.Windows.Forms.Button();
            this.tb_Pos = new System.Windows.Forms.TextBox();
            this.bt_Reporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reporte)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Reporte
            // 
            this.dgv_Reporte.AllowUserToAddRows = false;
            this.dgv_Reporte.AllowUserToDeleteRows = false;
            this.dgv_Reporte.AllowUserToResizeRows = false;
            this.dgv_Reporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Nombre,
            this.col_Cantidad,
            this.col_Precio});
            this.dgv_Reporte.Location = new System.Drawing.Point(185, 12);
            this.dgv_Reporte.MultiSelect = false;
            this.dgv_Reporte.Name = "dgv_Reporte";
            this.dgv_Reporte.ReadOnly = true;
            this.dgv_Reporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Reporte.Size = new System.Drawing.Size(443, 410);
            this.dgv_Reporte.TabIndex = 0;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Código";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Nombre
            // 
            this.col_Nombre.HeaderText = "Nombre";
            this.col_Nombre.Name = "col_Nombre";
            this.col_Nombre.ReadOnly = true;
            // 
            // col_Cantidad
            // 
            this.col_Cantidad.HeaderText = "Cantidad";
            this.col_Cantidad.Name = "col_Cantidad";
            this.col_Cantidad.ReadOnly = true;
            // 
            // col_Precio
            // 
            this.col_Precio.HeaderText = "$ Precio";
            this.col_Precio.Name = "col_Precio";
            this.col_Precio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "$ Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(70, 12);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(100, 20);
            this.tb_ID.TabIndex = 2;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Location = new System.Drawing.Point(70, 34);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tb_Nombre.TabIndex = 2;
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.Location = new System.Drawing.Point(70, 78);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.tb_Cantidad.TabIndex = 2;
            // 
            // tb_Precio
            // 
            this.tb_Precio.Location = new System.Drawing.Point(70, 56);
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(100, 20);
            this.tb_Precio.TabIndex = 2;
            // 
            // bt_Agregar
            // 
            this.bt_Agregar.Location = new System.Drawing.Point(12, 104);
            this.bt_Agregar.Name = "bt_Agregar";
            this.bt_Agregar.Size = new System.Drawing.Size(158, 23);
            this.bt_Agregar.TabIndex = 3;
            this.bt_Agregar.Text = "Agregar";
            this.bt_Agregar.UseVisualStyleBackColor = true;
            this.bt_Agregar.Click += new System.EventHandler(this.bt_Agregar_Click);
            // 
            // bt_Eliminar
            // 
            this.bt_Eliminar.Location = new System.Drawing.Point(12, 133);
            this.bt_Eliminar.Name = "bt_Eliminar";
            this.bt_Eliminar.Size = new System.Drawing.Size(158, 23);
            this.bt_Eliminar.TabIndex = 3;
            this.bt_Eliminar.Text = "Eliminar (Por Código)";
            this.bt_Eliminar.UseVisualStyleBackColor = true;
            this.bt_Eliminar.Click += new System.EventHandler(this.bt_Eliminar_Click);
            // 
            // bt_Buscar
            // 
            this.bt_Buscar.Location = new System.Drawing.Point(12, 192);
            this.bt_Buscar.Name = "bt_Buscar";
            this.bt_Buscar.Size = new System.Drawing.Size(158, 23);
            this.bt_Buscar.TabIndex = 3;
            this.bt_Buscar.Text = "Buscar (Por Código)";
            this.bt_Buscar.UseVisualStyleBackColor = true;
            this.bt_Buscar.Click += new System.EventHandler(this.bt_Buscar_Click);
            // 
            // bt_Insertar
            // 
            this.bt_Insertar.Location = new System.Drawing.Point(12, 220);
            this.bt_Insertar.Name = "bt_Insertar";
            this.bt_Insertar.Size = new System.Drawing.Size(74, 23);
            this.bt_Insertar.TabIndex = 3;
            this.bt_Insertar.Text = "Insertar";
            this.bt_Insertar.UseVisualStyleBackColor = true;
//            this.bt_Insertar.Click += new System.EventHandler(this.bt_Insertar_Click);
            // 
            // tb_Pos
            // 
            this.tb_Pos.Location = new System.Drawing.Point(96, 222);
            this.tb_Pos.Name = "tb_Pos";
            this.tb_Pos.Size = new System.Drawing.Size(74, 20);
            this.tb_Pos.TabIndex = 2;
            // 
            // bt_Reporte
            // 
            this.bt_Reporte.Location = new System.Drawing.Point(12, 399);
            this.bt_Reporte.Name = "bt_Reporte";
            this.bt_Reporte.Size = new System.Drawing.Size(158, 23);
            this.bt_Reporte.TabIndex = 4;
            this.bt_Reporte.Text = "Generar Reporte";
            this.bt_Reporte.UseVisualStyleBackColor = true;
            this.bt_Reporte.Click += new System.EventHandler(this.bt_Reporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 434);
            this.Controls.Add(this.bt_Reporte);
            this.Controls.Add(this.bt_Insertar);
            this.Controls.Add(this.bt_Buscar);
            this.Controls.Add(this.bt_Eliminar);
            this.Controls.Add(this.bt_Agregar);
            this.Controls.Add(this.tb_Precio);
            this.Controls.Add(this.tb_Cantidad);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.tb_Pos);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Reporte);
            this.Name = "Form1";
            this.Text = "Inventario";
//            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Reporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.Button bt_Agregar;
        private System.Windows.Forms.Button bt_Eliminar;
        private System.Windows.Forms.Button bt_Buscar;
        private System.Windows.Forms.Button bt_Insertar;
        private System.Windows.Forms.TextBox tb_Pos;
        private System.Windows.Forms.Button bt_Reporte;
    }
}

