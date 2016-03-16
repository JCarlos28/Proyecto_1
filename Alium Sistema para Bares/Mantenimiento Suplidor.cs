using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alium_Sistema_para_Bares
{
    public partial class Mantenimiento_Suplidor : Form
    {
        public Mantenimiento_Suplidor()
        {
            InitializeComponent();
        }

        private void nombre_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int interruptor = 0;
            if (interruptor == 0)
            {
                nombre_pais.Visible = true;
                nombre_municipio.Visible = true;
                nombre_calle.Visible = true;
                nombre_sector.Visible = true;
                nombre_calle.Visible = true;
                nombre_region.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                nombre_provincia.Visible = true;


                interruptor = 1;
            }
            else
            {
                nombre_pais.Visible = false;
            }
           
        }

        private void Mantenimiento_Suplidor_Load(object sender, EventArgs e)
        {

        }
    }
}
