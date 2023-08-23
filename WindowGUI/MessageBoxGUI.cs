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
    public partial class Messagebox : Form
    {
        public Messagebox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("This is massage box", "Caption", MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

            switch(dialog)
            {
                case DialogResult.Abort:
                    MessageBox.Show("I say abort !");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("I say cancel !");
                    break;
                case DialogResult.Ignore:
                    MessageBox.Show("I say ignore !");
                    break;
                case DialogResult.No:
                    MessageBox.Show("I say no !");
                    break;
                case DialogResult.None:
                    MessageBox.Show("I say none !");
                    break;
                case DialogResult.OK:
                    MessageBox.Show("I say ok !");
                    break;
                case DialogResult.Retry:
                    MessageBox.Show("I say retry !");
                    break;
                case DialogResult.Yes:
                    MessageBox.Show("I say yes !");
                    break;
                default:
                    break;
            }
        }
    }
}
