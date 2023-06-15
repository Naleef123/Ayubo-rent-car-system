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
    public partial class daytour : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7BK3OE5;Initial Catalog=Ayubo;Integrated Security=True");
        int tothours;
       
        
        public daytour()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtmkm_TextChanged(object sender, EventArgs e)
        {

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
                comboBox1.Focus();
            }
            else
            {
                MessageBox.Show("invalid package id please check!!!!!", "check the message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
     
        }

        private void daytour_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void dtpstarttime_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void calhrsbtn_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime start, end;
                TimeSpan gap;
                double mhrs, th ;

                start = DateTime.Parse (dtpstarttime.Text) ;
                end = DateTime.Parse(dtpendtime.Text) ;
                gap = end - start;
                double noofhours,rate1,exhrchrg;
                noofhours = gap.TotalHours;
                txttothours.Text = noofhours.ToString();

                double remainhours;
                remainhours = tothours % 24;

                mhrs = double.Parse(txtmhours.Text) ;
                th = double.Parse(txttothours.Text) ;
                rate1 = double.Parse(txtexhrrate.Text) ;
                
                
                th = gap.TotalHours;
                
                if (th > mhrs)
                {
                    double eh = th - mhrs;
                    txtexhours.Text = eh.ToString();
                    exhrchrg=eh*rate1 ;
                    txtexhourchrg.Text = exhrchrg.ToString();
                }
                else
                {
                    double eh = 0;
                    txtexhours.Text = eh.ToString();
                }
                
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }










        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btncalculatekm_Click(object sender, EventArgs e)
        {
            double skm, ekm, tot_ex_km, limit, rate, tot_km,exkmchrg;
            skm = double.Parse(txtstartkm.Text) ;
            ekm = double.Parse(txtendkm.Text) ;
            tot_km = ekm - skm;
            txttotkm1.Text=tot_km.ToString();
            rate = double.Parse(txtexkmrate.Text) ;
            limit = double.Parse(txtmkm.Text);
            
           
            if (tot_km > limit)
            {
                tot_ex_km=tot_km- limit;
            }
            else
            {
                tot_ex_km=0;
            }
            txttotkm1.Text = tot_km.ToString();
            txtexkm1.Text=tot_ex_km.ToString();
            exkmchrg = rate * tot_ex_km;
            txtexkmchrg.Text = exkmchrg.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu fr = new mainmenu();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double base_hire, total_cost,exkmchrg,exhrchrg;
            base_hire = double.Parse(txtrate.Text);
            exkmchrg=double.Parse(txtexkmchrg.Text);
            exhrchrg = double.Parse(txtexhourchrg.Text);
            total_cost = base_hire + exkmchrg + exhrchrg;
            txttotalcost.Text = total_cost.ToString();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label20.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
