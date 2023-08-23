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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string isGay = checkBox1.CheckState == CheckState.Checked ? "is" :
                checkBox1.CheckState == CheckState.Unchecked ? "is not" : "is and not";
            string showString = string.Format("Hello {0}, you {1} gay !", name, isGay);
            MessageBox.Show(showString);
        }
    }
}
