using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ventilator_RealTime
{
    public partial class Form1 : Form
    {   
        public Stopwatch timer { get; set; }

        public Form1()
        {
            InitializeComponent();
            orientationTrackbar.Enabled = false;
            speedTrackbar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = Stopwatch.StartNew();
            
            try
            {
                serialPort1.Open();
            }
            catch
            {
                textBox1.Text = "ne dela. vjerovatno nije spojeno.";
            }
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {   
            if(timer.ElapsedMilliseconds > 15)
            {
                timer = Stopwatch.StartNew();

                orientationLabel.Text = orientationTrackbar.Value.ToString() + " °";
                serialPort1.Write("S" + orientationTrackbar.Value.ToString());
            }
            
        }

        private void speedTrackbar_Scroll(object sender, EventArgs e)
        {
            if (timer.ElapsedMilliseconds > 15)
            {
                timer = Stopwatch.StartNew();

                speedLabel.Text = speedTrackbar.Value.ToString() + "";
                serialPort1.Write("M" + speedTrackbar.Value.ToString());
            }
        }

        private void power_CheckedChanged(object sender, EventArgs e)
        {
            if (power.Checked)
            {
                orientationTrackbar.Enabled = true;
                speedTrackbar.Enabled = true;
                groupBox1.Enabled = true;
                serialPort1.Write("1ON");
            }
            else
            {
                orientationTrackbar.Enabled = false;
                speedTrackbar.Enabled = false;
                groupBox1.Enabled = false;
                serialPort1.Write("0OFF");
            }
            
        }

        private void swingEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (swingEnable.Checked)
            {
                swingRadio1.Enabled = true;
                swingRadio2.Enabled = true;
                orientationTrackbar.Enabled = false;
                serialPort1.Write("R0");
            }
            else
            {
                swingRadio1.Enabled = false;
                swingRadio2.Enabled = false;
                orientationTrackbar.Enabled = true;
                serialPort1.Write("R0");
            }
            
        }

        private void swingRadio1_CheckedChanged(object sender, EventArgs e)
        {
            if (swingRadio1.Checked)
            {
                serialPort1.Write("R1");
            }
        }

        private void swingRadio2_CheckedChanged(object sender, EventArgs e)
        {
            if (swingRadio2.Checked)
            {
                serialPort1.Write("R2");
            }
        }
    }
}
