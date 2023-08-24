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
    public partial class ThreadGUI : Form
    {
        private int speed = 150;
        public ThreadGUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Demo);
            thread.IsBackground = true;
            thread.Start();
        }

        private void Demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thread 2");
        }

        private void pictureBox()
        {
            new Thread(
                () =>
                {
                    while (true)
                    {
                        if (checkBox1.Checked)
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                        }
                        else
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y); ;
                        }
                        Thread.Sleep(speed);
                    }
                })
            { IsBackground = true }.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out speed))
            {
                
            }
        }
    }
}
