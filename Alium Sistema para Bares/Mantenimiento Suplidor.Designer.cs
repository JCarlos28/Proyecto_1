namespace Alium_Sistema_para_Bares
{
    partial class Mantenimiento_Suplidor
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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nombre_tercero = new System.Windows.Forms.TextBox();
            this.id_suplidor = new System.Windows.Forms.TextBox();
            this.id_compania = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nombre_pais = new System.Windows.Forms.ComboBox();
            this.nombre_region = new System.Windows.Forms.ComboBox();
            this.nombre_provincia = new System.Windows.Forms.ComboBox();
            this.nombre_municipio = new System.Windows.Forms.ComboBox();
            this.nombre_sector = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre_calle = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Suplidor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Compañia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Activo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nombre_tercero
            // 
            this.nombre_tercero.Location = new System.Drawing.Point(74, 75);
            this.nombre_tercero.Name = "nombre_tercero";
            this.nombre_tercero.Size = new System.Drawing.Size(100, 20);
            this.nombre_tercero.TabIndex = 7;
            // 
            // id_suplidor
            // 
            this.id_suplidor.Location = new System.Drawing.Point(74, 49);
            this.id_suplidor.Name = "id_suplidor";
            this.id_suplidor.Size = new System.Drawing.Size(100, 20);
            this.id_suplidor.TabIndex = 8;
            // 
            // id_compania
            // 
            this.id_compania.Location = new System.Drawing.Point(74, 96);
            this.id_compania.Name = "id_compania";
            this.id_compania.Size = new System.Drawing.Size(100, 20);
            this.id_compania.TabIndex = 9;
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(74, 118);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Dirreccion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombre_pais
            // 
            this.nombre_pais.FormattingEnabled = true;
            this.nombre_pais.Location = new System.Drawing.Point(341, 43);
            this.nombre_pais.Name = "nombre_pais";
            this.nombre_pais.Size = new System.Drawing.Size(121, 21);
            this.nombre_pais.TabIndex = 12;
            this.nombre_pais.Text = "Pais";
            this.nombre_pais.Visible = false;
            this.nombre_pais.SelectedIndexChanged += new System.EventHandler(this.nombre_pais_SelectedIndexChanged);
            // 
            // nombre_region
            // 
            this.nombre_region.FormattingEnabled = true;
            this.nombre_region.Location = new System.Drawing.Point(341, 70);
            this.nombre_region.Name = "nombre_region";
            this.nombre_region.Size = new System.Drawing.Size(121, 21);
            this.nombre_region.TabIndex = 13;
            this.nombre_region.Text = "Region";
            this.nombre_region.Visible = false;
            // 
            // nombre_provincia
            // 
            this.nombre_provincia.FormattingEnabled = true;
            this.nombre_provincia.Location = new System.Drawing.Point(341, 97);
            this.nombre_provincia.Name = "nombre_provincia";
            this.nombre_provincia.Size = new System.Drawing.Size(121, 21);
            this.nombre_provincia.TabIndex = 14;
            this.nombre_provincia.Text = "Provincia";
            this.nombre_provincia.Visible = false;
            // 
            // nombre_municipio
            // 
            this.nombre_municipio.FormattingEnabled = true;
            this.nombre_municipio.Location = new System.Drawing.Point(341, 124);
            this.nombre_municipio.Name = "nombre_municipio";
            this.nombre_municipio.Size = new System.Drawing.Size(121, 21);
            this.nombre_municipio.TabIndex = 15;
            this.nombre_municipio.Text = "Municipio";
            this.nombre_municipio.Visible = false;
            // 
            // nombre_sector
            // 
            this.nombre_sector.Location = new System.Drawing.Point(341, 163);
            this.nombre_sector.Name = "nombre_sector";
            this.nombre_sector.Size = new System.Drawing.Size(121, 20);
            this.nombre_sector.TabIndex = 16;
            this.nombre_sector.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sector";
            this.label5.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Calle";
            this.label7.Visible = false;
            // 
            // nombre_calle
            // 
            this.nombre_calle.Location = new System.Drawing.Point(341, 190);
            this.nombre_calle.Name = "nombre_calle";
            this.nombre_calle.Size = new System.Drawing.Size(121, 20);
            this.nombre_calle.TabIndex = 19;
            this.nombre_calle.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(124, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(237, 237);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Consultar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(354, 237);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Mantenimiento_Suplidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 302);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nombre_calle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombre_sector);
            this.Controls.Add(this.nombre_municipio);
            this.Controls.Add(this.nombre_provincia);
            this.Controls.Add(this.nombre_region);
            this.Controls.Add(this.nombre_pais);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.id_compania);
            this.Controls.Add(this.id_suplidor);
            this.Controls.Add(this.nombre_tercero);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mantenimiento_Suplidor";
            this.Text = "Mantenimiento_Suplidor";
            this.Load += new System.EventHandler(this.Mantenimiento_Suplidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombre_tercero;
        private System.Windows.Forms.TextBox id_suplidor;
        private System.Windows.Forms.TextBox id_compania;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox nombre_pais;
        private System.Windows.Forms.ComboBox nombre_region;
        private System.Windows.Forms.ComboBox nombre_provincia;
        private System.Windows.Forms.ComboBox nombre_municipio;
        private System.Windows.Forms.TextBox nombre_sector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre_calle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}