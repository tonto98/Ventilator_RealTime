namespace Ventilator_RealTime
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.orientationTrackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.orientationLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speedTrackbar = new System.Windows.Forms.TrackBar();
            this.power = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.swingEnable = new System.Windows.Forms.CheckBox();
            this.swingRadio1 = new System.Windows.Forms.RadioButton();
            this.swingRadio2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.orientationTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // orientationTrackbar
            // 
            this.orientationTrackbar.Location = new System.Drawing.Point(47, 195);
            this.orientationTrackbar.Maximum = 180;
            this.orientationTrackbar.Name = "orientationTrackbar";
            this.orientationTrackbar.Size = new System.Drawing.Size(694, 45);
            this.orientationTrackbar.TabIndex = 0;
            this.orientationTrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fan Orientation";
            // 
            // orientationLabel
            // 
            this.orientationLabel.AutoSize = true;
            this.orientationLabel.Location = new System.Drawing.Point(129, 169);
            this.orientationLabel.Name = "orientationLabel";
            this.orientationLabel.Size = new System.Drawing.Size(20, 13);
            this.orientationLabel.TabIndex = 2;
            this.orientationLabel.Text = "0 °";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(129, 276);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(13, 13);
            this.speedLabel.TabIndex = 4;
            this.speedLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fan Speed";
            // 
            // speedTrackbar
            // 
            this.speedTrackbar.Location = new System.Drawing.Point(47, 307);
            this.speedTrackbar.Maximum = 254;
            this.speedTrackbar.Name = "speedTrackbar";
            this.speedTrackbar.Size = new System.Drawing.Size(694, 45);
            this.speedTrackbar.TabIndex = 5;
            this.speedTrackbar.Scroll += new System.EventHandler(this.speedTrackbar_Scroll);
            // 
            // power
            // 
            this.power.AutoSize = true;
            this.power.Location = new System.Drawing.Point(47, 73);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(56, 17);
            this.power.TabIndex = 6;
            this.power.Text = "Power";
            this.power.UseVisualStyleBackColor = true;
            this.power.CheckedChanged += new System.EventHandler(this.power_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 54);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Errors:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.swingRadio2);
            this.groupBox1.Controls.Add(this.swingRadio1);
            this.groupBox1.Controls.Add(this.swingEnable);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(180, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fan Swing Mode";
            // 
            // swingEnable
            // 
            this.swingEnable.AutoSize = true;
            this.swingEnable.Location = new System.Drawing.Point(7, 20);
            this.swingEnable.Name = "swingEnable";
            this.swingEnable.Size = new System.Drawing.Size(59, 17);
            this.swingEnable.TabIndex = 0;
            this.swingEnable.Text = "Enable";
            this.swingEnable.UseVisualStyleBackColor = true;
            this.swingEnable.CheckedChanged += new System.EventHandler(this.swingEnable_CheckedChanged);
            // 
            // swingRadio1
            // 
            this.swingRadio1.AutoSize = true;
            this.swingRadio1.Checked = true;
            this.swingRadio1.Enabled = false;
            this.swingRadio1.Location = new System.Drawing.Point(7, 51);
            this.swingRadio1.Name = "swingRadio1";
            this.swingRadio1.Size = new System.Drawing.Size(97, 17);
            this.swingRadio1.TabIndex = 1;
            this.swingRadio1.TabStop = true;
            this.swingRadio1.Text = "Swing Speed 1";
            this.swingRadio1.UseVisualStyleBackColor = true;
            this.swingRadio1.CheckedChanged += new System.EventHandler(this.swingRadio1_CheckedChanged);
            // 
            // swingRadio2
            // 
            this.swingRadio2.AutoSize = true;
            this.swingRadio2.Enabled = false;
            this.swingRadio2.Location = new System.Drawing.Point(99, 51);
            this.swingRadio2.Name = "swingRadio2";
            this.swingRadio2.Size = new System.Drawing.Size(97, 17);
            this.swingRadio2.TabIndex = 2;
            this.swingRadio2.Text = "Swing Speed 2";
            this.swingRadio2.UseVisualStyleBackColor = true;
            this.swingRadio2.CheckedChanged += new System.EventHandler(this.swingRadio2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.power);
            this.Controls.Add(this.speedTrackbar);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.orientationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orientationTrackbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orientationTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedTrackbar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar orientationTrackbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orientationLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar speedTrackbar;
        private System.Windows.Forms.CheckBox power;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox swingEnable;
        private System.Windows.Forms.RadioButton swingRadio2;
        private System.Windows.Forms.RadioButton swingRadio1;
    }
}

