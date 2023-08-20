using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class Button : Form
    {
        private int count = 0;

        public Button()
        {
            InitializeComponent();
        }

        private void addButton()
        {
            Random random = new Random();
            System.Windows.Forms.Button button = new System.Windows.Forms.Button()
            {
                Text = count.ToString(), Location =
                    new Point(random.Next(0, this.Size.Width), random.Next(0, this.Size.Height))
            };
            button.Click += Button_Click;
            this.Controls.Add(button);
            count++;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            MessageBox.Show(btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addButton();
        }
    }
}
