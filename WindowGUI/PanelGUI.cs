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
    public partial class PanelGUI : Form
    {
        public PanelGUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Hello";
            btn.AutoSize = true;

            //panel1.Controls.Add(btn);
            flowLayoutPanel1.Controls.Add(btn); //only 1 panel value
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}