using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ayubo
{
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-A7BK3OE5;Initial Catalog=Ayubo;Integrated Security=True");
        
        
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;

            username = txtusername.Text;
            password = txtpassword.Text;

            try
            {
                string querry = "select * from login_table where username='" + txtusername + "'and password='" + txtpassword + "'";
                SqlCommand cmd = new SqlCommand("select * from login_table where username=@username and password = @password",conn);
                cmd.Parameters.AddWithValue("@username", txtusername.Text);
                cmd.Parameters.AddWithValue("@password",txtpassword.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count>0)
                {
                    username = txtusername.Text;
                    password=txtpassword.Text;
                    // page that needed to be load next
                    mainmenu fr = new mainmenu();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("check username and password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();

                    txtusername.Focus();
                        
                }
                
            

            
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
