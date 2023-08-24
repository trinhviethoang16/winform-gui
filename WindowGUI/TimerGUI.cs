using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class TimerGUI : Form
    {
        Timer timer;
        private int i = 0;
        public TimerGUI()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += timer1_Tick;
            timer.Interval = 1000;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            button1.Text = button1.Text == "Stop" ? "Start" : "Stop";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }
    }
}
