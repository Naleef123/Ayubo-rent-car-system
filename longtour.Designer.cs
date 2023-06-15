namespace ayubo
{
    partial class longtour
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
            this.button1 = new System.Windows.Forms.Button();
            this.txttotdays = new System.Windows.Forms.TextBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtexkms = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtendkm = new System.Windows.Forms.TextBox();
            this.txtstartkm = new System.Windows.Forms.TextBox();
            this.txttotkms = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtbasehirechrg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtovernchrg = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtexkmchrg = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txttotalcost = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtvnightrate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtdrnightrate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtexkmrate = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtvtype = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtptype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txttotdays);
            this.groupBox2.Controls.Add(this.dtpenddate);
            this.groupBox2.Controls.Add(this.dtpstartdate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(6, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "calculate days";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate days";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txttotdays
            // 
            this.txttotdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotdays.Location = new System.Drawing.Point(440, 21);
            this.txttotdays.Name = "txttotdays";
            this.txttotdays.Size = new System.Drawing.Size(100, 22);
            this.txttotdays.TabIndex = 5;
            // 
            // dtpenddate
            // 
            this.dtpenddate.Location = new System.Drawing.Point(116, 71);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(161, 20);
            this.dtpenddate.TabIndex = 4;
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.Location = new System.Drawing.Point(116, 20);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(161, 20);
            this.dtpstartdate.TabIndex = 3;
            this.dtpstartdate.ValueChanged += new System.EventHandler(this.dtpstarttime_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(327, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Total days";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "End date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Start date";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtexkms);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtendkm);
            this.groupBox3.Controls.Add(this.txtstartkm);
            this.groupBox3.Controls.Add(this.txttotkms);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(6, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "calculate days";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 68);
            this.button2.TabIndex = 10;
            this.button2.Text = "Calculate kms";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtexkms
            // 
            this.txtexkms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexkms.Location = new System.Drawing.Point(440, 69);
            this.txtexkms.Name = "txtexkms";
            this.txtexkms.Size = new System.Drawing.Size(100, 22);
            this.txtexkms.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(327, 72);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 16);
            this.label17.TabIndex = 8;
            this.label17.Text = "Extra kms";
            // 
            // txtendkm
            // 
            this.txtendkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendkm.Location = new System.Drawing.Point(134, 69);
            this.txtendkm.Name = "txtendkm";
            this.txtendkm.Size = new System.Drawing.Size(100, 22);
            this.txtendkm.TabIndex = 7;
            // 
            // txtstartkm
            // 
            this.txtstartkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartkm.Location = new System.Drawing.Point(134, 19);
            this.txtstartkm.Name = "txtstartkm";
            this.txtstartkm.Size = new System.Drawing.Size(100, 22);
            this.txtstartkm.TabIndex = 6;
            // 
            // txttotkms
            // 
            this.txttotkms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotkms.Location = new System.Drawing.Point(440, 21);
            this.txttotkms.Name = "txttotkms";
            this.txttotkms.Size = new System.Drawing.Size(100, 22);
            this.txttotkms.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(327, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total kms";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(26, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "End km";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(26, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Start km";
            // 
            // txtbasehirechrg
            // 
            this.txtbasehirechrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbasehirechrg.Location = new System.Drawing.Point(173, 508);
            this.txtbasehirechrg.Name = "txtbasehirechrg";
            this.txtbasehirechrg.Size = new System.Drawing.Size(100, 22);
            this.txtbasehirechrg.TabIndex = 8;
            this.txtbasehirechrg.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(27, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "Base hire charge";
            // 
            // txtovernchrg
            // 
            this.txtovernchrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtovernchrg.Location = new System.Drawing.Point(447, 508);
            this.txtovernchrg.Name = "txtovernchrg";
            this.txtovernchrg.Size = new System.Drawing.Size(100, 22);
            this.txtovernchrg.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(306, 511);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 16);
            this.label19.TabIndex = 9;
            this.label19.Text = "Overnight charge";
            // 
            // txtexkmchrg
            // 
            this.txtexkmchrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexkmchrg.Location = new System.Drawing.Point(743, 508);
            this.txtexkmchrg.Name = "txtexkmchrg";
            this.txtexkmchrg.Size = new System.Drawing.Size(100, 22);
            this.txtexkmchrg.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(592, 511);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "Extra km charge";
            // 
            // txttotalcost
            // 
            this.txttotalcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalcost.Location = new System.Drawing.Point(186, 558);
            this.txttotalcost.Name = "txttotalcost";
            this.txttotalcost.Size = new System.Drawing.Size(132, 29);
            this.txttotalcost.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(26, 563);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(139, 24);
            this.label21.TabIndex = 47;
            this.label21.Text = "TOTAL COST";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(398, 552);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 35);
            this.button3.TabIndex = 49;
            this.button3.Text = "Calculate the total amount";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "menu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(90, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 51;
            this.button5.Text = "exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ayubo.Properties.Resources.car;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtvnightrate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtdrnightrate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtexkmrate);
            this.groupBox1.Controls.Add(this.txtmkm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtrate);
            this.groupBox1.Controls.Add(this.txtvtype);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtptype);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "package";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtvnightrate
            // 
            this.txtvnightrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvnightrate.Location = new System.Drawing.Point(666, 144);
            this.txtvnightrate.Name = "txtvnightrate";
            this.txtvnightrate.Size = new System.Drawing.Size(170, 22);
            this.txtvnightrate.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(462, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "VEHICLE NIGHT RATE";
            // 
            // txtdrnightrate
            // 
            this.txtdrnightrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdrnightrate.Location = new System.Drawing.Point(666, 109);
            this.txtdrnightrate.Name = "txtdrnightrate";
            this.txtdrnightrate.Size = new System.Drawing.Size(170, 22);
            this.txtdrnightrate.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(462, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 16);
            this.label9.TabIndex = 42;
            this.label9.Text = "DRIVER NIGHT RATE";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            // txtexkmrate
            // 
            this.txtexkmrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexkmrate.Location = new System.Drawing.Point(666, 75);
            this.txtexkmrate.Name = "txtexkmrate";
            this.txtexkmrate.Size = new System.Drawing.Size(170, 22);
            this.txtexkmrate.TabIndex = 37;
            // 
            // txtmkm
            // 
            this.txtmkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkm.Location = new System.Drawing.Point(274, 141);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(170, 22);
            this.txtmkm.TabIndex = 35;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "MAXIMUM KM";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(714, 563);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // longtour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(899, 619);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txttotalcost);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtexkmchrg);
            this.Controls.Add(this.txtovernchrg);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtbasehirechrg);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "longtour";
            this.Text = "longtour";
            this.Load += new System.EventHandler(this.longtour_Load);
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
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtexkmrate;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtvtype;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtptype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtdrnightrate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtvnightrate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txttotdays;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtexkms;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtendkm;
        private System.Windows.Forms.TextBox txtstartkm;
        private System.Windows.Forms.TextBox txttotkms;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbasehirechrg;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtovernchrg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtexkmchrg;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txttotalcost;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}