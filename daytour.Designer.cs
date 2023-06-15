namespace ayubo
{
    partial class daytour
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpendtime = new System.Windows.Forms.DateTimePicker();
            this.dtpstarttime = new System.Windows.Forms.DateTimePicker();
            this.txtexhours = new System.Windows.Forms.TextBox();
            this.txttothours = new System.Windows.Forms.TextBox();
            this.calhrsbtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtendkm = new System.Windows.Forms.TextBox();
            this.txtstartkm = new System.Windows.Forms.TextBox();
            this.txtexkm1 = new System.Windows.Forms.TextBox();
            this.txttotkm1 = new System.Windows.Forms.TextBox();
            this.btncalculatekm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.txtexhourchrg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtexkmchrg = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtexhrrate = new System.Windows.Forms.TextBox();
            this.txtexkmrate = new System.Windows.Forms.TextBox();
            this.txtmhours = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtvtype = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtptype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.dtpendtime);
            this.groupBox2.Controls.Add(this.dtpstarttime);
            this.groupBox2.Controls.Add(this.txtexhours);
            this.groupBox2.Controls.Add(this.txttothours);
            this.groupBox2.Controls.Add(this.calhrsbtn);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "timecalculation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dtpendtime
            // 
            this.dtpendtime.CustomFormat = " HH:mm:ss tt";
            this.dtpendtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpendtime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpendtime.Location = new System.Drawing.Point(133, 87);
            this.dtpendtime.Name = "dtpendtime";
            this.dtpendtime.Size = new System.Drawing.Size(149, 22);
            this.dtpendtime.TabIndex = 46;
            this.dtpendtime.Value = new System.DateTime(2022, 6, 12, 13, 3, 0, 0);
            // 
            // dtpstarttime
            // 
            this.dtpstarttime.CustomFormat = " HH:mm:ss tt";
            this.dtpstarttime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstarttime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpstarttime.Location = new System.Drawing.Point(133, 37);
            this.dtpstarttime.Name = "dtpstarttime";
            this.dtpstarttime.Size = new System.Drawing.Size(149, 22);
            this.dtpstarttime.TabIndex = 45;
            this.dtpstarttime.Value = new System.DateTime(2022, 6, 12, 13, 2, 18, 0);
            this.dtpstarttime.ValueChanged += new System.EventHandler(this.dtpstarttime_ValueChanged);
            // 
            // txtexhours
            // 
            this.txtexhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexhours.Location = new System.Drawing.Point(717, 34);
            this.txtexhours.Name = "txtexhours";
            this.txtexhours.Size = new System.Drawing.Size(137, 22);
            this.txtexhours.TabIndex = 44;
            // 
            // txttothours
            // 
            this.txttothours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttothours.Location = new System.Drawing.Point(465, 31);
            this.txttothours.Name = "txttothours";
            this.txttothours.Size = new System.Drawing.Size(132, 22);
            this.txttothours.TabIndex = 43;
            // 
            // calhrsbtn
            // 
            this.calhrsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calhrsbtn.Location = new System.Drawing.Point(341, 115);
            this.calhrsbtn.Name = "calhrsbtn";
            this.calhrsbtn.Size = new System.Drawing.Size(157, 23);
            this.calhrsbtn.TabIndex = 42;
            this.calhrsbtn.Text = "CALCULATE HOURS";
            this.calhrsbtn.UseVisualStyleBackColor = true;
            this.calhrsbtn.Click += new System.EventHandler(this.calhrsbtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(596, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 16);
            this.label14.TabIndex = 25;
            this.label14.Text = "EXTRA HOURS";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(345, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "TOTAL HOURS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "END TIME";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "START TIME";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.txtendkm);
            this.groupBox3.Controls.Add(this.txtstartkm);
            this.groupBox3.Controls.Add(this.txtexkm1);
            this.groupBox3.Controls.Add(this.txttotkm1);
            this.groupBox3.Controls.Add(this.btncalculatekm);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(12, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "kmcalculation";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtendkm
            // 
            this.txtendkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendkm.Location = new System.Drawing.Point(133, 84);
            this.txtendkm.Name = "txtendkm";
            this.txtendkm.Size = new System.Drawing.Size(132, 22);
            this.txtendkm.TabIndex = 46;
            // 
            // txtstartkm
            // 
            this.txtstartkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartkm.Location = new System.Drawing.Point(133, 40);
            this.txtstartkm.Name = "txtstartkm";
            this.txtstartkm.Size = new System.Drawing.Size(132, 22);
            this.txtstartkm.TabIndex = 45;
            // 
            // txtexkm1
            // 
            this.txtexkm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexkm1.Location = new System.Drawing.Point(717, 28);
            this.txtexkm1.Name = "txtexkm1";
            this.txtexkm1.Size = new System.Drawing.Size(137, 22);
            this.txtexkm1.TabIndex = 44;
            // 
            // txttotkm1
            // 
            this.txttotkm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotkm1.Location = new System.Drawing.Point(465, 31);
            this.txttotkm1.Name = "txttotkm1";
            this.txttotkm1.Size = new System.Drawing.Size(132, 22);
            this.txttotkm1.TabIndex = 43;
            // 
            // btncalculatekm
            // 
            this.btncalculatekm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculatekm.Location = new System.Drawing.Point(341, 115);
            this.btncalculatekm.Name = "btncalculatekm";
            this.btncalculatekm.Size = new System.Drawing.Size(157, 23);
            this.btncalculatekm.TabIndex = 42;
            this.btncalculatekm.Text = "CALCULATE KM";
            this.btncalculatekm.UseVisualStyleBackColor = true;
            this.btncalculatekm.Click += new System.EventHandler(this.btncalculatekm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(612, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "EXTRA KM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(345, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "TOTAL KM";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "END KM";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "START KM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 569);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 24);
            this.label17.TabIndex = 23;
            this.label17.Text = "TOTAL COST";
            // 
            // txttotalcost
            // 
            this.txttotalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcost.Location = new System.Drawing.Point(172, 564);
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.Size = new System.Drawing.Size(132, 29);
            this.txttotalcost.TabIndex = 46;
            // 
            // txtexhourchrg
            // 
            this.txtexhourchrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexhourchrg.Location = new System.Drawing.Point(507, 572);
            this.txtexhourchrg.Name = "txtexhourchrg";
            this.txtexhourchrg.Size = new System.Drawing.Size(111, 22);
            this.txtexhourchrg.TabIndex = 48;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(350, 575);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 13);
            this.label18.TabIndex = 47;
            this.label18.Text = "EXTRA HOURS CHARGE";
            // 
            // txtexkmchrg
            // 
            this.txtexkmchrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexkmchrg.Location = new System.Drawing.Point(755, 570);
            this.txtexkmchrg.Name = "txtexkmchrg";
            this.txtexkmchrg.Size = new System.Drawing.Size(119, 22);
            this.txtexkmchrg.TabIndex = 50;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(624, 575);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "EXTRA KM CHARGE";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(666, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 36);
            this.button1.TabIndex = 51;
            this.button1.Text = "CALCULATE TOTAL COST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 52;
            this.button2.Text = "menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 53;
            this.button3.Text = "exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ayubo.Properties.Resources.car;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtexhrrate);
            this.groupBox1.Controls.Add(this.txtexkmrate);
            this.groupBox1.Controls.Add(this.txtmhours);
            this.groupBox1.Controls.Add(this.txtmkm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtrate);
            this.groupBox1.Controls.Add(this.txtvtype);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtptype);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "package";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(465, 25);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 41;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtexhrrate
            // 
            this.txtexhrrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexhrrate.Location = new System.Drawing.Point(666, 106);
            this.txtexhrrate.Name = "txtexhrrate";
            this.txtexhrrate.Size = new System.Drawing.Size(170, 22);
            this.txtexhrrate.TabIndex = 38;
            // 
            // txtexkmrate
            // 
            this.txtexkmrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexkmrate.Location = new System.Drawing.Point(666, 75);
            this.txtexkmrate.Name = "txtexkmrate";
            this.txtexkmrate.Size = new System.Drawing.Size(170, 22);
            this.txtexkmrate.TabIndex = 37;
            // 
            // txtmhours
            // 
            this.txtmhours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmhours.Location = new System.Drawing.Point(274, 174);
            this.txtmhours.Name = "txtmhours";
            this.txtmhours.Size = new System.Drawing.Size(170, 22);
            this.txtmhours.TabIndex = 36;
            // 
            // txtmkm
            // 
            this.txtmkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkm.Location = new System.Drawing.Point(274, 141);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(170, 22);
            this.txtmkm.TabIndex = 35;
            this.txtmkm.TextChanged += new System.EventHandler(this.txtmkm_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(462, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "EXTRA HOUR RATE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "EXTRA KM RATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "MAXIMUM HOURS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "MAXIMUM KM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtrate
            // 
            this.txtrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(274, 112);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(170, 22);
            this.txtrate.TabIndex = 28;
            // 
            // txtvtype
            // 
            this.txtvtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvtype.Location = new System.Drawing.Point(274, 83);
            this.txtvtype.Name = "txtvtype";
            this.txtvtype.Size = new System.Drawing.Size(170, 22);
            this.txtvtype.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(274, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 26;
            // 
            // txtptype
            // 
            this.txtptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtptype.Location = new System.Drawing.Point(274, 55);
            this.txtptype.Name = "txtptype";
            this.txtptype.Size = new System.Drawing.Size(170, 22);
            this.txtptype.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "RATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "VEHICLE TYPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "PACKAGE TYPE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "PACKAGE ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(578, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 29);
            this.label20.TabIndex = 47;
            this.label20.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // daytour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(924, 642);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtexkmchrg);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtexhourchrg);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txttotalcost);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "daytour";
            this.Text = "daytour";
            this.Load += new System.EventHandler(this.daytour_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtvtype;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtptype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtexhrrate;
        private System.Windows.Forms.TextBox txtexkmrate;
        private System.Windows.Forms.TextBox txtmhours;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calhrsbtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtexhours;
        private System.Windows.Forms.TextBox txttothours;
        private System.Windows.Forms.DateTimePicker dtpendtime;
        private System.Windows.Forms.DateTimePicker dtpstarttime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtendkm;
        private System.Windows.Forms.TextBox txtstartkm;
        private System.Windows.Forms.TextBox txtexkm1;
        private System.Windows.Forms.TextBox txttotkm1;
        private System.Windows.Forms.Button btncalculatekm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txttotalcost;
        private System.Windows.Forms.TextBox txtexhourchrg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtexkmchrg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer timer1;
    }
}