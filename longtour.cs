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
    public partial class longtour : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7BK3OE5;Initial Catalog=Ayubo;Integrated Security=True");
        public longtour()
        {
            InitializeComponent();
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
               // txtmhours.Text = dr["max_hrs"].ToString();
                txtexkmrate.Text = dr["exkm_rate"].ToString();
               // txtexhrrate.Text = dr["exhr_rate"].ToString();
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
        private void fillcombo()
        {
            SqlDataAdapter da = new SqlDataAdapter("select package_id from package", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "package_id";
            comboBox1.ValueMember = "package_id";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void longtour_Load(object sender, EventArgs e)
        {
            fillcombo();
            timer1.Start();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtpstarttime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainmenu fr = new mainmenu();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime renteddate, returndate;
            TimeSpan datedif;
            double gap;
            renteddate=DateTime.Parse(dtpstartdate.Text);
            returndate=DateTime.Parse(dtpenddate.Text);
            datedif = returndate - renteddate;
            gap=datedif.TotalDays;
            txttotdays.Text = gap.ToString();
            if (gap<0)
            {
                MessageBox.Show("nagative number ", "error");            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double skm, ekm, tot_ex_km, limit, rate, tot_km, exkmchrg;
            skm = double.Parse(txtstartkm.Text);
            ekm = double.Parse(txtendkm.Text);
            tot_km = ekm - skm;
            txttotkms.Text = tot_km.ToString();
            rate = double.Parse(txtexkmrate.Text);
            limit = double.Parse(txtmkm.Text);


            if (tot_km > limit)
            {
                tot_ex_km = tot_km - limit;
            }
            else
            {
                tot_ex_km = 0;
            }
            txttotkms.Text = tot_km.ToString();
            txtexkms.Text = tot_ex_km.ToString();
            exkmchrg = rate * tot_ex_km;
            txtexkmchrg.Text = exkmchrg.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double overnightchrg, total_days,total_cost,base_hire,exkmchrg;
            total_days = double.Parse(txttotdays.Text);
            overnightchrg = double.Parse(txtdrnightrate.Text);
            overnightchrg = (total_days - 1) * overnightchrg;
            txtovernchrg.Text= overnightchrg.ToString();
            txtbasehirechrg.Text = txtrate.Text;
            base_hire = double.Parse(txtbasehirechrg.Text);
            exkmchrg = double.Parse(txtexkmchrg.Text);
            total_cost = overnightchrg + base_hire+ exkmchrg ;
            txttotalcost.Text= total_cost.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToLongDateString();
        }
    }
}
