using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class ProcessGUI : Form
    {
        public ProcessGUI()
        {
            InitializeComponent();
        }

        private void getProcesses()
        {
            Process[] processArr = Process.GetProcesses();
            foreach (Process process in processArr)
            {
                textBox1.Text = process.ProcessName + "\n" + textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getProcesses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Process.Start("notepad.exe");
            
            //Process.Start(Application.StartupPath + "\\ProcessGUI.exe");

            //string link = @"http:\\www.google.com";
            //Process.Start(link);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "notepad.exe";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
        }
    }
}
