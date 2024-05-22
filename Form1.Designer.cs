namespace Control_Station
{
    partial class Form1
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
            this.btnManualForward = new System.Windows.Forms.Button();
            this.btnManualBackward = new System.Windows.Forms.Button();
            this.btnManualStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnManualLeft = new System.Windows.Forms.Button();
            this.btnManualRight = new System.Windows.Forms.Button();
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.groupBoxCommingData = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblSpeedValue = new System.Windows.Forms.Label();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.groupBoxSpeedandData = new System.Windows.Forms.GroupBox();
            this.lblSpeedManual = new System.Windows.Forms.Label();
            this.groupBoxManual = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBoxAuto = new System.Windows.Forms.GroupBox();
            this.lblAngleAuto = new System.Windows.Forms.Label();
            this.cmbBoxAngle = new System.Windows.Forms.ComboBox();
            this.lblSpeedAuto = new System.Windows.Forms.Label();
            this.cmbBoxSpeed = new System.Windows.Forms.ComboBox();
            this.lblDistanceAuto = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAutoForward = new System.Windows.Forms.Button();
            this.btnAutoRight = new System.Windows.Forms.Button();
            this.btnAutoBackward = new System.Windows.Forms.Button();
            this.btnAutoLeft = new System.Windows.Forms.Button();
            this.btnAutoStop = new System.Windows.Forms.Button();
            this.cmbBoxDistance = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxControl.SuspendLayout();
            this.groupBoxCommingData.SuspendLayout();
            this.groupBoxSpeedandData.SuspendLayout();
            this.groupBoxManual.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxAuto.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManualForward
            // 
            this.btnManualForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManualForward.BackColor = System.Drawing.Color.Lime;
            this.btnManualForward.Location = new System.Drawing.Point(153, 17);
            this.btnManualForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualForward.Name = "btnManualForward";
            this.btnManualForward.Size = new System.Drawing.Size(121, 51);
            this.btnManualForward.TabIndex = 0;
            this.btnManualForward.Text = "FORWARD";
            this.btnManualForward.UseVisualStyleBackColor = false;
            this.btnManualForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnManualBackward
            // 
            this.btnManualBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManualBackward.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnManualBackward.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManualBackward.Location = new System.Drawing.Point(153, 176);
            this.btnManualBackward.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualBackward.Name = "btnManualBackward";
            this.btnManualBackward.Size = new System.Drawing.Size(121, 51);
            this.btnManualBackward.TabIndex = 1;
            this.btnManualBackward.Text = "BACKWARD";
            this.btnManualBackward.UseVisualStyleBackColor = false;
            this.btnManualBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnManualStop
            // 
            this.btnManualStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManualStop.BackColor = System.Drawing.Color.Red;
            this.btnManualStop.Location = new System.Drawing.Point(153, 93);
            this.btnManualStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualStop.Name = "btnManualStop";
            this.btnManualStop.Size = new System.Drawing.Size(121, 51);
            this.btnManualStop.TabIndex = 2;
            this.btnManualStop.Text = "STOP";
            this.btnManualStop.UseVisualStyleBackColor = false;
            this.btnManualStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ultrasonic3";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ultrasonic2";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ultrasonic1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 54);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "ENCODER";
            // 
            // btnManualLeft
            // 
            this.btnManualLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManualLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManualLeft.Location = new System.Drawing.Point(11, 93);
            this.btnManualLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualLeft.Name = "btnManualLeft";
            this.btnManualLeft.Size = new System.Drawing.Size(121, 51);
            this.btnManualLeft.TabIndex = 12;
            this.btnManualLeft.Text = "LEFT";
            this.btnManualLeft.UseVisualStyleBackColor = false;
            this.btnManualLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnManualRight
            // 
            this.btnManualRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManualRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnManualRight.Location = new System.Drawing.Point(292, 93);
            this.btnManualRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualRight.Name = "btnManualRight";
            this.btnManualRight.Size = new System.Drawing.Size(121, 51);
            this.btnManualRight.TabIndex = 13;
            this.btnManualRight.Text = "RIGHT";
            this.btnManualRight.UseVisualStyleBackColor = false;
            this.btnManualRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.btnManualForward);
            this.groupBoxControl.Controls.Add(this.btnManualRight);
            this.groupBoxControl.Controls.Add(this.btnManualBackward);
            this.groupBoxControl.Controls.Add(this.btnManualLeft);
            this.groupBoxControl.Controls.Add(this.btnManualStop);
            this.groupBoxControl.Location = new System.Drawing.Point(0, 22);
            this.groupBoxControl.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxControl.Size = new System.Drawing.Size(424, 236);
            this.groupBoxControl.TabIndex = 14;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "ControlPanel";
            // 
            // groupBoxCommingData
            // 
            this.groupBoxCommingData.Controls.Add(this.label14);
            this.groupBoxCommingData.Controls.Add(this.label15);
            this.groupBoxCommingData.Controls.Add(this.label9);
            this.groupBoxCommingData.Controls.Add(this.label10);
            this.groupBoxCommingData.Controls.Add(this.label8);
            this.groupBoxCommingData.Controls.Add(this.label1);
            this.groupBoxCommingData.Controls.Add(this.label5);
            this.groupBoxCommingData.Controls.Add(this.label2);
            this.groupBoxCommingData.Controls.Add(this.label6);
            this.groupBoxCommingData.Controls.Add(this.label3);
            this.groupBoxCommingData.Controls.Add(this.label7);
            this.groupBoxCommingData.Controls.Add(this.label4);
            this.groupBoxCommingData.Location = new System.Drawing.Point(474, 103);
            this.groupBoxCommingData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCommingData.Name = "groupBoxCommingData";
            this.groupBoxCommingData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCommingData.Size = new System.Drawing.Size(172, 264);
            this.groupBoxCommingData.TabIndex = 15;
            this.groupBoxCommingData.TabStop = false;
            this.groupBoxCommingData.Text = "Data";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 194);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "RandomValue";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(100, 194);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 161);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "CpuTemperature";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(434, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(394, 529);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(512, 529);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 23;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSend.Location = new System.Drawing.Point(429, 585);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(114, 38);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "button2";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hScrollBar1.Location = new System.Drawing.Point(59, 36);
            this.hScrollBar1.Maximum = 80;
            this.hScrollBar1.Minimum = 30;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(199, 82);
            this.hScrollBar1.SmallChange = 5;
            this.hScrollBar1.TabIndex = 26;
            this.hScrollBar1.Value = 30;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestart.Location = new System.Drawing.Point(645, 469);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(56, 41);
            this.btnRestart.TabIndex = 28;
            this.btnRestart.Text = "restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblSpeedValue
            // 
            this.lblSpeedValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpeedValue.Location = new System.Drawing.Point(155, 17);
            this.lblSpeedValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeedValue.Name = "lblSpeedValue";
            this.lblSpeedValue.Size = new System.Drawing.Size(38, 17);
            this.lblSpeedValue.TabIndex = 27;
            this.lblSpeedValue.Text = "label11";
            // 
            // btnManual
            // 
            this.btnManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManual.Location = new System.Drawing.Point(645, 11);
            this.btnManual.Margin = new System.Windows.Forms.Padding(2);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(91, 72);
            this.btnManual.TabIndex = 29;
            this.btnManual.Text = "Manual";
            this.toolTip1.SetToolTip(this.btnManual, "menesegtten");
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuto.Location = new System.Drawing.Point(842, 11);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(91, 72);
            this.btnAuto.TabIndex = 30;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // groupBoxSpeedandData
            // 
            this.groupBoxSpeedandData.Controls.Add(this.lblSpeedManual);
            this.groupBoxSpeedandData.Controls.Add(this.hScrollBar1);
            this.groupBoxSpeedandData.Controls.Add(this.lblSpeedValue);
            this.groupBoxSpeedandData.Location = new System.Drawing.Point(434, 22);
            this.groupBoxSpeedandData.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSpeedandData.Name = "groupBoxSpeedandData";
            this.groupBoxSpeedandData.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSpeedandData.Size = new System.Drawing.Size(339, 129);
            this.groupBoxSpeedandData.TabIndex = 31;
            this.groupBoxSpeedandData.TabStop = false;
            // 
            // lblSpeedManual
            // 
            this.lblSpeedManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSpeedManual.Location = new System.Drawing.Point(104, 17);
            this.lblSpeedManual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeedManual.Name = "lblSpeedManual";
            this.lblSpeedManual.Size = new System.Drawing.Size(47, 17);
            this.lblSpeedManual.TabIndex = 28;
            this.lblSpeedManual.Text = "Speed =";
            // 
            // groupBoxManual
            // 
            this.groupBoxManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxManual.Controls.Add(this.groupBox4);
            this.groupBoxManual.Controls.Add(this.groupBoxControl);
            this.groupBoxManual.Controls.Add(this.groupBoxSpeedandData);
            this.groupBoxManual.Enabled = false;
            this.groupBoxManual.Location = new System.Drawing.Point(14, 109);
            this.groupBoxManual.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxManual.Name = "groupBoxManual";
            this.groupBoxManual.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxManual.Size = new System.Drawing.Size(792, 273);
            this.groupBoxManual.TabIndex = 32;
            this.groupBoxManual.TabStop = false;
            this.groupBoxManual.Text = "ManuelMode";
            this.groupBoxManual.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Location = new System.Drawing.Point(434, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 102);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(104, 19);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "CpuTemperature";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(200, 19);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "0";
            // 
            // groupBoxAuto
            // 
            this.groupBoxAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxAuto.Controls.Add(this.lblAngleAuto);
            this.groupBoxAuto.Controls.Add(this.cmbBoxAngle);
            this.groupBoxAuto.Controls.Add(this.lblSpeedAuto);
            this.groupBoxAuto.Controls.Add(this.cmbBoxSpeed);
            this.groupBoxAuto.Controls.Add(this.lblDistanceAuto);
            this.groupBoxAuto.Controls.Add(this.groupBox3);
            this.groupBoxAuto.Controls.Add(this.groupBoxCommingData);
            this.groupBoxAuto.Controls.Add(this.cmbBoxDistance);
            this.groupBoxAuto.Enabled = false;
            this.groupBoxAuto.Location = new System.Drawing.Point(842, 120);
            this.groupBoxAuto.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAuto.Name = "groupBoxAuto";
            this.groupBoxAuto.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAuto.Size = new System.Drawing.Size(674, 390);
            this.groupBoxAuto.TabIndex = 33;
            this.groupBoxAuto.TabStop = false;
            this.groupBoxAuto.Text = "AutoMode";
            this.groupBoxAuto.Visible = false;
            // 
            // lblAngleAuto
            // 
            this.lblAngleAuto.AutoSize = true;
            this.lblAngleAuto.Location = new System.Drawing.Point(404, 28);
            this.lblAngleAuto.Name = "lblAngleAuto";
            this.lblAngleAuto.Size = new System.Drawing.Size(34, 13);
            this.lblAngleAuto.TabIndex = 21;
            this.lblAngleAuto.Text = "Angle";
            // 
            // cmbBoxAngle
            // 
            this.cmbBoxAngle.FormattingEnabled = true;
            this.cmbBoxAngle.Location = new System.Drawing.Point(362, 55);
            this.cmbBoxAngle.Name = "cmbBoxAngle";
            this.cmbBoxAngle.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxAngle.TabIndex = 20;
            // 
            // lblSpeedAuto
            // 
            this.lblSpeedAuto.AutoSize = true;
            this.lblSpeedAuto.Location = new System.Drawing.Point(250, 28);
            this.lblSpeedAuto.Name = "lblSpeedAuto";
            this.lblSpeedAuto.Size = new System.Drawing.Size(38, 13);
            this.lblSpeedAuto.TabIndex = 19;
            this.lblSpeedAuto.Text = "Speed";
            // 
            // cmbBoxSpeed
            // 
            this.cmbBoxSpeed.FormattingEnabled = true;
            this.cmbBoxSpeed.Location = new System.Drawing.Point(206, 55);
            this.cmbBoxSpeed.Name = "cmbBoxSpeed";
            this.cmbBoxSpeed.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSpeed.TabIndex = 18;
            // 
            // lblDistanceAuto
            // 
            this.lblDistanceAuto.AutoSize = true;
            this.lblDistanceAuto.Location = new System.Drawing.Point(81, 28);
            this.lblDistanceAuto.Name = "lblDistanceAuto";
            this.lblDistanceAuto.Size = new System.Drawing.Size(49, 13);
            this.lblDistanceAuto.TabIndex = 17;
            this.lblDistanceAuto.Text = "Distance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAutoForward);
            this.groupBox3.Controls.Add(this.btnAutoRight);
            this.groupBox3.Controls.Add(this.btnAutoBackward);
            this.groupBox3.Controls.Add(this.btnAutoLeft);
            this.groupBox3.Controls.Add(this.btnAutoStop);
            this.groupBox3.Location = new System.Drawing.Point(14, 103);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(424, 264);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ControlPanel";
            // 
            // btnAutoForward
            // 
            this.btnAutoForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutoForward.BackColor = System.Drawing.Color.Lime;
            this.btnAutoForward.Location = new System.Drawing.Point(153, 31);
            this.btnAutoForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoForward.Name = "btnAutoForward";
            this.btnAutoForward.Size = new System.Drawing.Size(121, 51);
            this.btnAutoForward.TabIndex = 0;
            this.btnAutoForward.Text = "FORWARD";
            this.btnAutoForward.UseVisualStyleBackColor = false;
            this.btnAutoForward.Click += new System.EventHandler(this.btnAutoForward_Click);
            // 
            // btnAutoRight
            // 
            this.btnAutoRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutoRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutoRight.Location = new System.Drawing.Point(292, 107);
            this.btnAutoRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoRight.Name = "btnAutoRight";
            this.btnAutoRight.Size = new System.Drawing.Size(121, 51);
            this.btnAutoRight.TabIndex = 13;
            this.btnAutoRight.Text = "RIGHT";
            this.btnAutoRight.UseVisualStyleBackColor = false;
            this.btnAutoRight.Click += new System.EventHandler(this.btnAutoRight_Click);
            // 
            // btnAutoBackward
            // 
            this.btnAutoBackward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutoBackward.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnAutoBackward.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAutoBackward.Location = new System.Drawing.Point(153, 190);
            this.btnAutoBackward.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoBackward.Name = "btnAutoBackward";
            this.btnAutoBackward.Size = new System.Drawing.Size(121, 51);
            this.btnAutoBackward.TabIndex = 1;
            this.btnAutoBackward.Text = "BACKWARD";
            this.btnAutoBackward.UseVisualStyleBackColor = false;
            this.btnAutoBackward.Click += new System.EventHandler(this.btnAutoBackward_Click);
            // 
            // btnAutoLeft
            // 
            this.btnAutoLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutoLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAutoLeft.Location = new System.Drawing.Point(11, 107);
            this.btnAutoLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoLeft.Name = "btnAutoLeft";
            this.btnAutoLeft.Size = new System.Drawing.Size(121, 51);
            this.btnAutoLeft.TabIndex = 12;
            this.btnAutoLeft.Text = "LEFT";
            this.btnAutoLeft.UseVisualStyleBackColor = false;
            this.btnAutoLeft.Click += new System.EventHandler(this.btnAutoLeft_Click);
            // 
            // btnAutoStop
            // 
            this.btnAutoStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAutoStop.BackColor = System.Drawing.Color.Red;
            this.btnAutoStop.Location = new System.Drawing.Point(153, 107);
            this.btnAutoStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnAutoStop.Name = "btnAutoStop";
            this.btnAutoStop.Size = new System.Drawing.Size(121, 51);
            this.btnAutoStop.TabIndex = 2;
            this.btnAutoStop.Text = "STOP";
            this.btnAutoStop.UseVisualStyleBackColor = false;
            this.btnAutoStop.Click += new System.EventHandler(this.btnAutoStop_Click);
            // 
            // cmbBoxDistance
            // 
            this.cmbBoxDistance.FormattingEnabled = true;
            this.cmbBoxDistance.Location = new System.Drawing.Point(46, 55);
            this.cmbBoxDistance.Name = "cmbBoxDistance";
            this.cmbBoxDistance.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxDistance.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1481, 714);
            this.Controls.Add(this.groupBoxAuto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxManual);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnSend);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Platform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxControl.ResumeLayout(false);
            this.groupBoxCommingData.ResumeLayout(false);
            this.groupBoxCommingData.PerformLayout();
            this.groupBoxSpeedandData.ResumeLayout(false);
            this.groupBoxManual.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxAuto.ResumeLayout(false);
            this.groupBoxAuto.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManualForward;
        private System.Windows.Forms.Button btnManualBackward;
        private System.Windows.Forms.Button btnManualStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnManualLeft;
        private System.Windows.Forms.Button btnManualRight;
        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBoxCommingData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
       
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblSpeedValue;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.GroupBox groupBoxSpeedandData;
        private System.Windows.Forms.Label lblSpeedManual;
        private System.Windows.Forms.GroupBox groupBoxManual;
        private System.Windows.Forms.GroupBox groupBoxAuto;
        private System.Windows.Forms.ComboBox cmbBoxDistance;
        private System.Windows.Forms.Label lblDistanceAuto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAutoForward;
        private System.Windows.Forms.Button btnAutoRight;
        private System.Windows.Forms.Button btnAutoBackward;
        private System.Windows.Forms.Button btnAutoLeft;
        private System.Windows.Forms.Button btnAutoStop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblAngleAuto;
        private System.Windows.Forms.ComboBox cmbBoxAngle;
        private System.Windows.Forms.Label lblSpeedAuto;
        private System.Windows.Forms.ComboBox cmbBoxSpeed;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

