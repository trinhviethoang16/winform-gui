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
    public partial class TextBoxGUI : Form
    {
        public TextBoxGUI()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int num = 0;

            if(Int32.TryParse(txtBox.Text, out num))
            {
                lbValue.Text = (num * num).ToString();
            }
            else
            {
                lbValue.Text = "Wrong input";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbValue.Text = txtBox.Text;
        }
    }
}
