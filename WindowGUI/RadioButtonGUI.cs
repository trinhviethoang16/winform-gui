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
    public partial class RadioButtonGUI : Form
    {
        public RadioButtonGUI()
        {
            InitializeComponent();
        }

        private void showResult(Label lb, Panel pn)
        {
            RadioButton rb = new RadioButton();
            
            foreach(RadioButton radioButton in pn.Controls)
            {
                if(radioButton != null)
                {
                    if(radioButton.Checked)
                    {
                        rb = radioButton;
                        break;
                    }
                }
            }

            if(rb != null)
            {
                lb.Text = rb.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showResult(label1, panel1);
            showResult(label2, panel2);
            showResult(label3, panel3);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;

            if(rd.Checked)
            {
                label4.Text = rd.Text;
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;

            if (rd.Checked)
            {
                label5.Text = rd.Text;
            }
        }
    }
}
