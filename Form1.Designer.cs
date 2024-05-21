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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Lime;
            this.btnForward.Location = new System.Drawing.Point(204, 21);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(161, 63);
            this.btnForward.TabIndex = 0;
            this.btnForward.Text = "FORWARD";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnBackward.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBackward.Location = new System.Drawing.Point(204, 217);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(161, 63);
            this.btnBackward.TabIndex = 1;
            this.btnBackward.Text = "BACKWARD";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(204, 115);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(161, 63);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ultrasonic3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ultrasonic2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ultrasonic1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "ENCODER";
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLeft.Location = new System.Drawing.Point(15, 115);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(161, 63);
            this.btnLeft.TabIndex = 12;
            this.btnLeft.Text = "LEFT";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRight.Location = new System.Drawing.Point(389, 115);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(161, 63);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = "RIGHT";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnForward);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnBackward);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(52, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 290);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ControlCommands";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(624, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 280);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 15;
            this.label14.Text = "RandomValue";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(133, 217);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 16);
            this.label15.TabIndex = 14;
            this.label15.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "CpuTemperature";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(942, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 59);
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
            this.textBox1.Location = new System.Drawing.Point(889, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1046, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 23;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(936, 216);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(152, 47);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "button2";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(52, 340);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1094, 313);
            this.axWindowsMediaPlayer1.TabIndex = 25;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(1149, 250);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(326, 82);
            this.hScrollBar1.TabIndex = 26;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1247, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "label11";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(1311, 130);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 51);
            this.btnRestart.TabIndex = 28;
            this.btnRestart.Text = "restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRestart;
    }
}

