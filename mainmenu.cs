using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ayubo
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicle fr = new vehicle();
            fr.Show();
            this. Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            package fr = new package();
            fr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rent fr = new rent();
            fr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            daytour fr = new daytour();
            fr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            longtour fr = new longtour();
            fr.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            login fr = new login();
            fr.Show();
            this.Hide();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text=DateTime.Now.ToLongDateString();
            label3.Text=DateTime.Now.ToLongTimeString();
        }
    }
}
