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
    public partial class ContextMenuGUI : Form
    {
        ContextMenuStrip contextMenu;
        public ContextMenuGUI()
        {
            InitializeComponent();

            contextMenu = new ContextMenuStrip();
            contextMenu.AutoSize = true;
            var item = new ToolStripLabel() { Text = "Click me", AutoSize = true };
            item.Click += Item_Click;
            contextMenu.Items.Add(item);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripItem).Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            contextMenu.Show(this, this.PointToClient(MousePosition));
        }
    }
}
