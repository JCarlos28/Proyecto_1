using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Alium_Sistema_para_Bares
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection cn = new SqlConnection(@"Data Source=ingJuanCarlos\sqlexpress;Initial Catalog=Alium Bar base de datos;Integrated Security=True;");
            try 
            {
                SqlCommand cmd = new SqlCommand("select nombre_usuario,password_usuario from Usuario where nombre_usuario = '" + nombre_usuario.Text + "' and password_usuario = '" + password_usuario.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Usuario");

                DataRow dro;
                dro = ds.Tables["Usuario"].Rows[0];
                if((nombre_usuario.Text == dro["nombre_usuario"].ToString()) || (password_usuario.Text == dro["password_usuario"].ToString()))
                {
                  
                    MDIParent1 p = new MDIParent1();
                    p.Show();
                    this.Hide();
                    
                }
            }
            catch { MessageBox.Show("clave Incorrecta" ); }
            finally 
            {
                cn.Close();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        }
    }
