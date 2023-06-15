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
    public partial class rent : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A7BK3OE5;Initial Catalog=Ayubo;Integrated Security=True");
        int months, weeks, days, totdays, remaindays;
        public rent()
        {
            InitializeComponent();
        }

        private void btncd_Click(object sender, EventArgs e)
        {
            DateTime rented, returned;
            TimeSpan gap;
            
            rented = DateTime.Parse(dateTimePicker1.Text);
            returned = DateTime.Parse(dateTimePicker2.Text);
            gap= returned - rented;
            double nodays;
            nodays = gap.TotalDays;
            txttdr.Text=nodays.ToString();

            totdays = int.Parse(txttdr.Text);
            //calculate months
            months = totdays / 30;//assumed 30 days per month
            txtmonths.Text=months.ToString();

            //calculate remining days
            remaindays = totdays % 30;
            //calculate weeks 
            weeks = remaindays / 7;
            txtweeks.Text=weeks.ToString();
            //calculate days
            days = remaindays % 7;
            txtdays.Text=days.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtdrrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

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

        private void withdriver_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnctc_Click_1(object sender, EventArgs e)
        {
            double mrate, wrate, drate, drrate;
            double cost;
            mrate = double.Parse(txtmrate.Text);
            wrate = double.Parse(txtwrate.Text);
            drate = double.Parse(txtdrrate.Text);
            drrate = double.Parse(txtdrrate.Text);
            cost = months * mrate + weeks * wrate + days * drate;
            if (withdriver.Checked == true)
                cost = cost + (totdays * drrate);
            txttotcost.Text = cost.ToString();

        }

        private void btncd_Click_1(object sender, EventArgs e)
        {
            DateTime rented, returned;
            TimeSpan gap;

            rented = DateTime.Parse(dateTimePicker1.Text);
            returned = DateTime.Parse(dateTimePicker2.Text);
            gap = returned - rented;
            double nodays;
            nodays = gap.TotalDays;
            txttdr.Text = nodays.ToString();

            totdays = int.Parse(txttdr.Text);
            //calculate months
            months = totdays / 30;//assumed 30 days per month
            txtmonths.Text = months.ToString();

            //calculate remining days
            remaindays = totdays % 30;
            //calculate weeks 
            weeks = remaindays / 7;
            txtweeks.Text = weeks.ToString();
            //calculate days
            days = remaindays % 7;
            txtdays.Text = days.ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sqlsearch;
            sqlsearch = "select * from vehicle where vehicle_no='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlsearch, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtvtype.Text = dr["Type"].ToString();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongDateString();
        }

        private void withdriver_CheckedChanged_1(object sender, EventArgs e)
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

        private void rent_Load(object sender, EventArgs e)
        {
            fillcombo();
            timer1.Start();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnctc_Click(object sender, EventArgs e)
        {
            double mrate, wrate, drate, drrate;
            double cost;
            mrate=double.Parse(txtmrate.Text);
            wrate=double.Parse(txtwrate.Text);
            drate=double.Parse(txtdrrate.Text);
            drrate=double.Parse(txtdrrate.Text);
            cost=months*mrate+weeks*wrate+days*drate;
            if (withdriver.Checked == true)
                cost = cost + (totdays * drrate);
            txttotcost.Text = cost.ToString();

        }
    }
}
