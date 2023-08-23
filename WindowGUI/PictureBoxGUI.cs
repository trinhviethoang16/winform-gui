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
    public partial class PictureBoxGUI : Form
    {
        private string extention = ".jpg";
        public PictureBoxGUI()
        {
            InitializeComponent();
            loadImageName();
        }

        private void loadImageName()
        {
            List<string> listImages = new List<string>() { "1", "2", "3", "4", "5" };
            comboBoxImage.DataSource = listImages;
        }

        private void comboBoxImage_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Bitmap bitmap = new Bitmap(Application.StartupPath + "\\Resources\\" 
                    + cb.SelectedValue.ToString() + extention);
                pictureBox1.Image = bitmap;
            }
        }
    }
}
