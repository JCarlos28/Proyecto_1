namespace Alium_Sistema_para_Bares
{
    partial class Mantenimiento_Ususario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.id_usuario = new System.Windows.Forms.TextBox();
            this.nombre_usuario = new System.Windows.Forms.TextBox();
            this.password_usuario = new System.Windows.Forms.TextBox();
            this.Id_nivel = new System.Windows.Forms.ComboBox();
            this.id_sucursal = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nivel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sucursal";
            // 
            // id_usuario
            // 
            this.id_usuario.Location = new System.Drawing.Point(87, 43);
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Size = new System.Drawing.Size(100, 20);
            this.id_usuario.TabIndex = 5;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.Location = new System.Drawing.Point(87, 65);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(100, 20);
            this.nombre_usuario.TabIndex = 6;
            // 
            // password_usuario
            // 
            this.password_usuario.Location = new System.Drawing.Point(87, 89);
            this.password_usuario.Name = "password_usuario";
            this.password_usuario.PasswordChar = '*';
            this.password_usuario.Size = new System.Drawing.Size(100, 20);
            this.password_usuario.TabIndex = 7;
            // 
            // Id_nivel
            // 
            this.Id_nivel.FormattingEnabled = true;
            this.Id_nivel.Location = new System.Drawing.Point(87, 111);
            this.Id_nivel.Name = "Id_nivel";
            this.Id_nivel.Size = new System.Drawing.Size(100, 21);
            this.Id_nivel.TabIndex = 8;
            // 
            // id_sucursal
            // 
            this.id_sucursal.FormattingEnabled = true;
            this.id_sucursal.Location = new System.Drawing.Point(87, 135);
            this.id_sucursal.Name = "id_sucursal";
            this.id_sucursal.Size = new System.Drawing.Size(100, 21);
            this.id_sucursal.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Consultar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(259, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Mantenimiento_Ususario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 245);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id_sucursal);
            this.Controls.Add(this.Id_nivel);
            this.Controls.Add(this.password_usuario);
            this.Controls.Add(this.nombre_usuario);
            this.Controls.Add(this.id_usuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenimiento_Ususario";
            this.Text = "Mantenimiento_Ususario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_usuario;
        private System.Windows.Forms.TextBox nombre_usuario;
        private System.Windows.Forms.TextBox password_usuario;
        private System.Windows.Forms.ComboBox Id_nivel;
        private System.Windows.Forms.ComboBox id_sucursal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}