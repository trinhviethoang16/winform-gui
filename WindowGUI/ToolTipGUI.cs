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
    public partial class ToolTipGUI : Form
    {
        public ToolTipGUI()
        {
            InitializeComponent();

            ToolTip tt = new ToolTip() { IsBalloon = true };
            tt.SetToolTip(button2, "this is a caption");
        }
    }
}
