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
    public partial class vehicle : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7BK3OE5;Initial Catalog=Ayubo;Integrated Security=True");

        public vehicle()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            comboBox1.Text = String.Empty;
            txtvtype.Clear();
            txtmake.Clear();
            txtmrate.Clear();
            txtwrate.Clear();
            txtdrate.Clear();
            txtdrrate.Clear();
        }
        private void fillcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select vehicle_no from vehicle", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "vehicle_no";
            comboBox1.ValueMember = "vehicle_no";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillcombo();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlsearch;
            sqlsearch = "select * from vehicle where vehicle_no='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtvtype.Text = dr["Type"].ToString();
                txtmake.Text = dr["Make"].ToString();
                txtmrate.Text = dr["month_rate"].ToString();
                txtwrate.Text = dr["week_rate"].ToString();
                txtdrate.Text = dr["day_rate"].ToString();
                txtdrrate.Text = dr["driver_rate"].ToString();
                comboBox1.Focus();
            }
            else
            {
                MessageBox.Show("invalid vehicle no please check!!!!!", "check the message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vehicle values (@vehicle_no,@Type,@Make,@month_rate,@week_rate,@day_rate,@driver_rate)";
                cmd.Parameters.AddWithValue("@vehicle_no", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@Make", txtmake.Text);
                cmd.Parameters.AddWithValue("@month_rate", txtmrate.Text);
                cmd.Parameters.AddWithValue("@week_rate", txtwrate.Text);
                cmd.Parameters.AddWithValue("@day_rate", txtdrate.Text);
                cmd.Parameters.AddWithValue("@driver_rate", txtdrate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New record added");
                clear();
                conn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();
                string QUARY = "update vehicle set Type='" + txtvtype.Text + "',Make='" + txtmake.Text + "',month_rate='" + txtmrate.Text + "',week_rate='" + txtwrate.Text + "',day_rate='" + txtdrate.Text + "',driver_rate='" + txtdrrate.Text + "' where  vehicle_no='" + comboBox1.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(QUARY, conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated!!!");
                clear();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("delete vehicle where vehicle_no=@vehicle_no", conn);
                cmd.Parameters.AddWithValue("@vehicle_no", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@Make", txtmake.Text);
                cmd.Parameters.AddWithValue("@month_rate", txtmrate.Text);
                cmd.Parameters.AddWithValue("@week_rate", txtwrate.Text);
                cmd.Parameters.AddWithValue("@day_rate", txtdrate.Text);
                cmd.Parameters.AddWithValue("@driver_rate", txtdrate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!!!!!!!");
                clear();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

            string sqlsearch;
            sqlsearch = "select * from vehicle where vehicle_no='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtvtype.Text = dr["Type"].ToString();
                txtmake.Text = dr["Make"].ToString();
                txtmrate.Text = dr["month_rate"].ToString();
                txtwrate.Text = dr["week_rate"].ToString();
                txtdrate.Text = dr["day_rate"].ToString();
                txtdrrate.Text = dr["driver_rate"].ToString();

                comboBox1.Focus();
            }
            else
            {
                MessageBox.Show("invalid package id please check!!!!!", "check the message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into vehicle values (@vehicle_no,@Type,@Make,@month_rate,@week_rate,@day_rate,@driver_rate)";
                cmd.Parameters.AddWithValue("@vehicle_no", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@Make", txtmake.Text);
                cmd.Parameters.AddWithValue("@month_rate", txtmrate.Text);
                cmd.Parameters.AddWithValue("@week_rate", txtwrate.Text);
                cmd.Parameters.AddWithValue("@day_rate", txtdrate.Text);
                cmd.Parameters.AddWithValue("@driver_rate", txtdrrate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("New record added");
                clear();
                conn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();
                string QUARY = "update vehicle set Type='" + txtvtype.Text + "',Make='" + txtmake.Text + "',month_rate='" + txtmrate.Text + "',week_rate='" + txtwrate.Text + "',day_rate='" + txtdrate.Text + "',driver_rate='" + txtdrrate.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(QUARY, conn);
                sda.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Record Updated!!!");
                clear();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("delete vehicle where vehicle_no=@vehicle_no", conn);
                //cmd.CommandText = "(@package_id,@package_type,@vehicle_type,@rate,@max_km,@max_hrs,@exkm_rate,@exhr_rate,@dr_night_rate,@ve_night_rate)";
                cmd.Parameters.AddWithValue("@vehicle_no", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@Make", txtmake.Text);
                cmd.Parameters.AddWithValue("@month_rate", txtmrate.Text);
                cmd.Parameters.AddWithValue("@week_rate", txtwrate.Text);
                cmd.Parameters.AddWithValue("@day_rate", txtdrate.Text);
                cmd.Parameters.AddWithValue("@driver_rate", txtdrrate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted!!!!!!!");
                clear();
                conn.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void manuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainmenu fr = new mainmenu();
            fr.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
