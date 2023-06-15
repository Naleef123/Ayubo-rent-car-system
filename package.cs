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
    public partial class package : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7BK3OE5;Initial Catalog=Ayubo;Integrated Security=True");
        public package()
        {
            InitializeComponent();
        }
        private void fillcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select package_id from package", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "package_id";
            comboBox1.ValueMember = "package_id";
        }
        private void clear()
        {
            comboBox1.Text = String.Empty;
            txtvtype.Clear();
            txtptype.Clear();
            txtrate.Clear();
            txtmkm.Clear();
            txtmhours.Clear();
            txtexkmrate.Clear();
            txtexhrrate.Clear();
            txtdrnightrate.Clear();
            txtvnightrate.Clear();
            

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
        

            string sqlsearch;
            sqlsearch = "select * from package where package_id='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtptype.Text = dr["package_type"].ToString();
                txtvtype.Text = dr["vehicle_type"].ToString();
                txtrate.Text = dr["rate"].ToString();
                txtmkm.Text = dr["max_km"].ToString();
                txtmhours.Text = dr["max_hrs"].ToString();
                txtexkmrate.Text = dr["exkm_rate"].ToString();
                txtexhrrate.Text = dr["exhr_rate"].ToString();
                txtdrnightrate.Text = dr["dr_night_rate"].ToString();
                txtvnightrate.Text = dr["ve_night_rate"].ToString();
                comboBox1.Focus();
            }
            else
            {
                MessageBox.Show("invalid package id please check!!!!!", "check the message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void daytour_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into package values (@package_id,@package_type,@vehicle_type,@rate,@max_km,@max_hrs,@exkm_rate,@exhr_rate,@dr_night_rate,@ve_night_rate)";
                cmd.Parameters.AddWithValue("@package_id", comboBox1.Text);
                cmd.Parameters.AddWithValue("@package_type", txtptype.Text);
                cmd.Parameters.AddWithValue("@vehicle_type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@rate", txtrate.Text);
                cmd.Parameters.AddWithValue("@max_km", txtmkm.Text);
                cmd.Parameters.AddWithValue("@max_hrs", txtmhours.Text);
                cmd.Parameters.AddWithValue("@exkm_rate", txtexkmrate.Text);
                cmd.Parameters.AddWithValue("@exhr_rate", txtexhrrate.Text);
                cmd.Parameters.AddWithValue("@dr_night_rate",txtdrnightrate.Text);
                cmd.Parameters.AddWithValue("@ve_night_rate", txtvnightrate.Text);
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            try
            {

                conn.Open();
                string QUARY = "update package set package_type='" + txtptype.Text + "',vehicle_type='" + txtvtype.Text + "',rate='" + txtrate.Text + "',max_km='" + txtmkm.Text + "',max_hrs='" + txtmhours.Text + "',exkm_rate='" + txtexkmrate.Text + "',exhr_rate='" + txtexhrrate.Text + "',dr_night_rate='" + txtdrnightrate.Text + "',ve_night_rate='" + txtvnightrate.Text + "' where  package_id='" + comboBox1.Text + "' ";
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
                cmd = new SqlCommand("delete package where package_id=@package_id", conn);
                //cmd.CommandText = "(@package_id,@package_type,@vehicle_type,@rate,@max_km,@max_hrs,@exkm_rate,@exhr_rate,@dr_night_rate,@ve_night_rate)";
                cmd.Parameters.AddWithValue("@package_id", comboBox1.Text);
                cmd.Parameters.AddWithValue("@package_type", txtptype.Text);
                cmd.Parameters.AddWithValue("@vehicle_type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@rate", txtrate.Text);
                cmd.Parameters.AddWithValue("@max_km", txtmkm.Text);
                cmd.Parameters.AddWithValue("@max_hrs", txtmhours.Text);
                cmd.Parameters.AddWithValue("@exkm_rate", txtexkmrate.Text);
                cmd.Parameters.AddWithValue("@exhr_rate", txtexhrrate.Text);
                cmd.Parameters.AddWithValue("@dr_night_rate", txtdrnightrate.Text);
                cmd.Parameters.AddWithValue("@ve_night_rate", txtvnightrate.Text);
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

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            string sqlsearch;
            sqlsearch = "select * from package where package_id='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtptype.Text = dr["package_type"].ToString();
                txtvtype.Text = dr["vehicle_type"].ToString();
                txtrate.Text = dr["rate"].ToString();
                txtmkm.Text = dr["max_km"].ToString();
                txtmhours.Text = dr["max_hrs"].ToString();
                txtexkmrate.Text = dr["exkm_rate"].ToString();
                txtexhrrate.Text = dr["exhr_rate"].ToString();
                txtdrnightrate.Text = dr["dr_night_rate"].ToString();
                txtvnightrate.Text = dr["ve_night_rate"].ToString();
                comboBox1.Focus();
            }
            else
            {
                MessageBox.Show("invalid package id please check!!!!!", "check the message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();

        }

        private void btninsert_Click_1(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into package values (@package_id,@package_type,@vehicle_type,@rate,@max_km,@max_hrs,@exkm_rate,@exhr_rate,@dr_night_rate,@ve_night_rate)";
                cmd.Parameters.AddWithValue("@package_id", comboBox1.Text);
                cmd.Parameters.AddWithValue("@package_type", txtptype.Text);
                cmd.Parameters.AddWithValue("@vehicle_type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@rate", txtrate.Text);
                cmd.Parameters.AddWithValue("@max_km", txtmkm.Text);
                cmd.Parameters.AddWithValue("@max_hrs", txtmhours.Text);
                cmd.Parameters.AddWithValue("@exkm_rate", txtexkmrate.Text);
                cmd.Parameters.AddWithValue("@exhr_rate", txtexhrrate.Text);
                cmd.Parameters.AddWithValue("@dr_night_rate", txtdrnightrate.Text);
                cmd.Parameters.AddWithValue("@ve_night_rate", txtvnightrate.Text);
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

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                string QUARY = "update package set package_type='" + txtptype.Text + "',vehicle_type='" + txtvtype.Text + "',rate='" + txtrate.Text + "',max_km='" + txtmkm.Text + "',max_hrs='" + txtmhours.Text + "',exkm_rate='" + txtexkmrate.Text + "',exhr_rate='" + txtexhrrate.Text + "',dr_night_rate='" + txtdrnightrate.Text + "',ve_night_rate='" + txtvnightrate.Text + "' where  package_id='" + comboBox1.Text + "' ";
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

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd = new SqlCommand("delete package where package_id=@package_id", conn);
                //cmd.CommandText = "(@package_id,@package_type,@vehicle_type,@rate,@max_km,@max_hrs,@exkm_rate,@exhr_rate,@dr_night_rate,@ve_night_rate)";
                cmd.Parameters.AddWithValue("@package_id", comboBox1.Text);
                cmd.Parameters.AddWithValue("@package_type", txtptype.Text);
                cmd.Parameters.AddWithValue("@vehicle_type", txtvtype.Text);
                cmd.Parameters.AddWithValue("@rate", txtrate.Text);
                cmd.Parameters.AddWithValue("@max_km", txtmkm.Text);
                cmd.Parameters.AddWithValue("@max_hrs", txtmhours.Text);
                cmd.Parameters.AddWithValue("@exkm_rate", txtexkmrate.Text);
                cmd.Parameters.AddWithValue("@exhr_rate", txtexhrrate.Text);
                cmd.Parameters.AddWithValue("@dr_night_rate", txtdrnightrate.Text);
                cmd.Parameters.AddWithValue("@ve_night_rate", txtvnightrate.Text);
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

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
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
