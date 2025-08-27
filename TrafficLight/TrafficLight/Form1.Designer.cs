namespace TrafficLight
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_COMPort = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbStep4 = new System.Windows.Forms.TextBox();
            this.tbStep3 = new System.Windows.Forms.TextBox();
            this.tbStep2 = new System.Windows.Forms.TextBox();
            this.tbStep1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GreenB = new System.Windows.Forms.TextBox();
            this.YellowB = new System.Windows.Forms.TextBox();
            this.RedB = new System.Windows.Forms.TextBox();
            this.GreenA = new System.Windows.Forms.TextBox();
            this.YellowA = new System.Windows.Forms.TextBox();
            this.RedA = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tmrPort1 = new System.Windows.Forms.Timer(this.components);
            this.Port1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbStopBit);
            this.panel1.Controls.Add(this.cbParity);
            this.panel1.Controls.Add(this.cbDataBits);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbb_COMPort);
            this.panel1.Controls.Add(this.cbBaudRate);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 221);
            this.panel1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stop Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(18, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Baud Rate";
            // 
            // cbStopBit
            // 
            this.cbStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStopBit.ForeColor = System.Drawing.Color.Black;
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Location = new System.Drawing.Point(96, 174);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(122, 24);
            this.cbStopBit.TabIndex = 12;
            this.cbStopBit.SelectedIndexChanged += new System.EventHandler(this.cbStopBit_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParity.ForeColor = System.Drawing.Color.Black;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(96, 137);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(122, 24);
            this.cbParity.TabIndex = 10;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbDataBits
            // 
            this.cbDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBits.ForeColor = System.Drawing.Color.Black;
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(96, 97);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(122, 24);
            this.cbDataBits.TabIndex = 8;
            this.cbDataBits.SelectedIndexChanged += new System.EventHandler(this.cbDataBits_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ports";
            // 
            // cbb_COMPort
            // 
            this.cbb_COMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_COMPort.FormattingEnabled = true;
            this.cbb_COMPort.Location = new System.Drawing.Point(96, 21);
            this.cbb_COMPort.Name = "cbb_COMPort";
            this.cbb_COMPort.Size = new System.Drawing.Size(122, 24);
            this.cbb_COMPort.TabIndex = 0;
            this.cbb_COMPort.SelectedIndexChanged += new System.EventHandler(this.cbb_COMPort_SelectedIndexChanged);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudRate.ForeColor = System.Drawing.Color.Black;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(96, 59);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(122, 24);
            this.cbBaudRate.TabIndex = 6;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudRate_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.tbStep4);
            this.panel2.Controls.Add(this.tbStep3);
            this.panel2.Controls.Add(this.tbStep2);
            this.panel2.Controls.Add(this.tbStep1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(265, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 221);
            this.panel2.TabIndex = 14;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(71, 173);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(224, 34);
            this.btnConnect.TabIndex = 24;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(221, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Yellow_A - Red_B ON";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(221, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Green_A - Red_B ON";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Red_A - Yellow_B ON";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(221, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 16);
            this.label12.TabIndex = 20;
            this.label12.Text = "Red_A - Green_B ON";
            // 
            // tbStep4
            // 
            this.tbStep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStep4.Location = new System.Drawing.Point(71, 137);
            this.tbStep4.Name = "tbStep4";
            this.tbStep4.Size = new System.Drawing.Size(144, 22);
            this.tbStep4.TabIndex = 19;
            // 
            // tbStep3
            // 
            this.tbStep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStep3.Location = new System.Drawing.Point(71, 95);
            this.tbStep3.Name = "tbStep3";
            this.tbStep3.Size = new System.Drawing.Size(144, 22);
            this.tbStep3.TabIndex = 18;
            // 
            // tbStep2
            // 
            this.tbStep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStep2.Location = new System.Drawing.Point(71, 57);
            this.tbStep2.Name = "tbStep2";
            this.tbStep2.Size = new System.Drawing.Size(144, 22);
            this.tbStep2.TabIndex = 17;
            // 
            // tbStep1
            // 
            this.tbStep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStep1.Location = new System.Drawing.Point(71, 19);
            this.tbStep1.Name = "tbStep1";
            this.tbStep1.Size = new System.Drawing.Size(144, 22);
            this.tbStep1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Step 4:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Step 3:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Step 2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Step 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(280, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Time Adjustments";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.GreenB);
            this.panel3.Controls.Add(this.YellowB);
            this.panel3.Controls.Add(this.RedB);
            this.panel3.Controls.Add(this.GreenA);
            this.panel3.Controls.Add(this.YellowA);
            this.panel3.Controls.Add(this.RedA);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(12, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 175);
            this.panel3.TabIndex = 16;
            // 
            // GreenB
            // 
            this.GreenB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GreenB.Location = new System.Drawing.Point(456, 91);
            this.GreenB.Multiline = true;
            this.GreenB.Name = "GreenB";
            this.GreenB.Size = new System.Drawing.Size(111, 57);
            this.GreenB.TabIndex = 15;
            // 
            // YellowB
            // 
            this.YellowB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.YellowB.Location = new System.Drawing.Point(307, 91);
            this.YellowB.Multiline = true;
            this.YellowB.Name = "YellowB";
            this.YellowB.Size = new System.Drawing.Size(111, 57);
            this.YellowB.TabIndex = 14;
            // 
            // RedB
            // 
            this.RedB.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RedB.Location = new System.Drawing.Point(155, 91);
            this.RedB.Multiline = true;
            this.RedB.Name = "RedB";
            this.RedB.Size = new System.Drawing.Size(111, 57);
            this.RedB.TabIndex = 13;
            // 
            // GreenA
            // 
            this.GreenA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GreenA.Location = new System.Drawing.Point(456, 26);
            this.GreenA.Multiline = true;
            this.GreenA.Name = "GreenA";
            this.GreenA.Size = new System.Drawing.Size(111, 57);
            this.GreenA.TabIndex = 12;
            // 
            // YellowA
            // 
            this.YellowA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.YellowA.Location = new System.Drawing.Point(307, 26);
            this.YellowA.Multiline = true;
            this.YellowA.Name = "YellowA";
            this.YellowA.Size = new System.Drawing.Size(111, 57);
            this.YellowA.TabIndex = 11;
            // 
            // RedA
            // 
            this.RedA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.RedA.Location = new System.Drawing.Point(155, 26);
            this.RedA.Multiline = true;
            this.RedA.Name = "RedA";
            this.RedA.Size = new System.Drawing.Size(111, 57);
            this.RedA.TabIndex = 10;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(45, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 64);
            this.label19.TabIndex = 9;
            this.label19.Text = "B";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(45, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 64);
            this.label20.TabIndex = 8;
            this.label20.Text = "A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 246);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 24);
            this.label16.TabIndex = 17;
            this.label16.Text = "Monitoring";
            // 
            // tmrPort1
            // 
            this.tmrPort1.Tick += new System.EventHandler(this.tmrPort1_Tick);
            // 
            // Port1
            // 
            this.Port1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Port1_DataReceived);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(654, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(104, 17);
            this.statusLabel.Text = "Connection Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 461);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_COMPort;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbStep4;
        private System.Windows.Forms.TextBox tbStep3;
        private System.Windows.Forms.TextBox tbStep2;
        private System.Windows.Forms.TextBox tbStep1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer tmrPort1;
        private System.IO.Ports.SerialPort Port1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TextBox GreenB;
        private System.Windows.Forms.TextBox YellowB;
        private System.Windows.Forms.TextBox RedB;
        private System.Windows.Forms.TextBox GreenA;
        private System.Windows.Forms.TextBox YellowA;
        private System.Windows.Forms.TextBox RedA;
    }
}

