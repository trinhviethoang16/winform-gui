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
    public partial class NotifyIconGUI : Form
    {
        public NotifyIconGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000, "This is message !", textBox1.Text, ToolTipIcon.Error);
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = toolStripTextBox1.Text;
        }
    }
}
