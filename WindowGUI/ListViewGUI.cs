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
    public partial class ListViewGUI : Form
    {
        ImageList largeImageList;
        ImageList smallImageList;
        public ListViewGUI()
        {
            InitializeComponent();
            loadListView();
        }

        private void loadImage()
        {
            largeImageList = new ImageList() { ImageSize = new Size(68,68)};
            largeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\1.jpg"));
            largeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\2.jpg"));
            largeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\3.jpg"));

            smallImageList = new ImageList() { ImageSize = new Size(16, 16) };
            smallImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\1.jpg"));
            smallImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\2.jpg"));
            smallImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Resources\\3.jpg"));
        }

        private void loadListView()
        {
            loadImage();
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.LargeImageList = largeImageList;
            listView.SmallImageList = smallImageList;
            listView.Columns.Add("Column 1");
            listView.Columns.Add("Column 2");
            listView.Columns.Add("Column 3");

            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item1";
            item1.ImageIndex = 0;
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item2";
            item2.ImageIndex = 1;
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item3";
            item3.ImageIndex = 2;
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });

            listView.Items.Add(item1);
            listView.Items.Add(item2);
            listView.Items.Add(item3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView.View = View.LargeIcon;
            listView.CheckBoxes = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.CheckBoxes = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView.View = View.SmallIcon;
            listView.CheckBoxes = false;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem item = lv.SelectedItems[0];
                MessageBox.Show(item.Text);
            }
        }
    }
}
