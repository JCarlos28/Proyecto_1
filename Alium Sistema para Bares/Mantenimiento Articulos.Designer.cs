namespace Alium_Sistema_para_Bares
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.id_articulo = new System.Windows.Forms.TextBox();
            this.nombre_articulo = new System.Windows.Forms.TextBox();
            this.precio_articulo = new System.Windows.Forms.TextBox();
            this.cantidad_articulo = new System.Windows.Forms.TextBox();
            this.punto_reorden = new System.Windows.Forms.TextBox();
            this.id_unidad = new System.Windows.Forms.TextBox();
            this.id_suplicador = new System.Windows.Forms.TextBox();
            this.id_categoria = new System.Windows.Forms.TextBox();
            this.id_almacen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio de Venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Existente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Punto de Reorden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Id Suplidor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Id Almacen";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(307, 149);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(75, 23);
            this.status.TabIndex = 9;
            this.status.Text = "Activo";
            this.status.UseVisualStyleBackColor = true;
            this.status.Click += new System.EventHandler(this.status_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Estatus";
            // 
            // id_articulo
            // 
            this.id_articulo.Location = new System.Drawing.Point(102, 48);
            this.id_articulo.Name = "id_articulo";
            this.id_articulo.Size = new System.Drawing.Size(114, 20);
            this.id_articulo.TabIndex = 12;
            // 
            // nombre_articulo
            // 
            this.nombre_articulo.Location = new System.Drawing.Point(102, 74);
            this.nombre_articulo.Name = "nombre_articulo";
            this.nombre_articulo.Size = new System.Drawing.Size(114, 20);
            this.nombre_articulo.TabIndex = 13;
            // 
            // precio_articulo
            // 
            this.precio_articulo.Location = new System.Drawing.Point(102, 99);
            this.precio_articulo.Name = "precio_articulo";
            this.precio_articulo.Size = new System.Drawing.Size(114, 20);
            this.precio_articulo.TabIndex = 14;
            // 
            // cantidad_articulo
            // 
            this.cantidad_articulo.Location = new System.Drawing.Point(102, 124);
            this.cantidad_articulo.Name = "cantidad_articulo";
            this.cantidad_articulo.Size = new System.Drawing.Size(114, 20);
            this.cantidad_articulo.TabIndex = 15;
            // 
            // punto_reorden
            // 
            this.punto_reorden.Location = new System.Drawing.Point(102, 147);
            this.punto_reorden.Name = "punto_reorden";
            this.punto_reorden.Size = new System.Drawing.Size(114, 20);
            this.punto_reorden.TabIndex = 16;
            // 
            // id_unidad
            // 
            this.id_unidad.Location = new System.Drawing.Point(307, 48);
            this.id_unidad.Name = "id_unidad";
            this.id_unidad.Size = new System.Drawing.Size(114, 20);
            this.id_unidad.TabIndex = 17;
            // 
            // id_suplicador
            // 
            this.id_suplicador.Location = new System.Drawing.Point(307, 74);
            this.id_suplicador.Name = "id_suplicador";
            this.id_suplicador.Size = new System.Drawing.Size(114, 20);
            this.id_suplicador.TabIndex = 18;
            // 
            // id_categoria
            // 
            this.id_categoria.Location = new System.Drawing.Point(307, 99);
            this.id_categoria.Name = "id_categoria";
            this.id_categoria.Size = new System.Drawing.Size(114, 20);
            this.id_categoria.TabIndex = 19;
            // 
            // id_almacen
            // 
            this.id_almacen.Location = new System.Drawing.Point(307, 123);
            this.id_almacen.Name = "id_almacen";
            this.id_almacen.Size = new System.Drawing.Size(114, 20);
            this.id_almacen.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(102, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 270);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_almacen);
            this.Controls.Add(this.id_categoria);
            this.Controls.Add(this.id_suplicador);
            this.Controls.Add(this.id_unidad);
            this.Controls.Add(this.punto_reorden);
            this.Controls.Add(this.cantidad_articulo);
            this.Controls.Add(this.precio_articulo);
            this.Controls.Add(this.nombre_articulo);
            this.Controls.Add(this.id_articulo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id_articulo;
        private System.Windows.Forms.TextBox nombre_articulo;
        private System.Windows.Forms.TextBox precio_articulo;
        private System.Windows.Forms.TextBox cantidad_articulo;
        private System.Windows.Forms.TextBox punto_reorden;
        private System.Windows.Forms.TextBox id_unidad;
        private System.Windows.Forms.TextBox id_suplicador;
        private System.Windows.Forms.TextBox id_categoria;
        private System.Windows.Forms.TextBox id_almacen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

