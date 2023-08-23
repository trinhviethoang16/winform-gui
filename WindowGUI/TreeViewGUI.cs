using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowGUI
{
    public partial class TreeViewGUI : Form
    {
        private string path = @"E:\"; //your path
        public TreeViewGUI()
        {
            InitializeComponent();
            //loadTreeView();
            
            if(Directory.Exists(path))
            {
                TreeNode root = new TreeNode() { Text = path };
                treeView.Nodes.Add(root);
                loadExplorer(root);
            }
        }

        private void loadExplorer(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            try
            {
                var folderList = new DirectoryInfo(root.Text).GetDirectories();

                if (folderList.Count() == 0)
                {
                    return;
                }

                foreach (DirectoryInfo folder in folderList)
                {
                    if (Directory.Exists(folder.FullName))
                    {
                        TreeNode node = new TreeNode() { Text = folder.FullName };
                        root.Nodes.Add(node);
                        loadExplorer(node);
                    }

                }
            }
            catch
            {
                return;
            }
        }

        //private void loadTreeView()
        //{
        //    TreeNode root1 = new TreeNode();
        //    root1.Text = "Root1";
        //    root1.ImageIndex = 0;
        //    TreeNode node1 = new TreeNode() { Text = "Node1" };
        //    root1.Nodes.Add(node1);

        //    TreeNode root2 = new TreeNode();
        //    root2.Text = "Root2";
        //    root2.ImageIndex = 1;
        //    TreeNode node2 = new TreeNode() { Text = "Node2" };
        //    root2.Nodes.Add(node2);

        //    TreeNode root3 = new TreeNode();
        //    root3.Text = "Root3";
        //    root3.ImageIndex = 2;
        //    TreeNode node3 = new TreeNode() { Text = "Node3" };
        //    root3.Nodes.Add(node3);

        //    treeView.Nodes.Add(root1);
        //    treeView.Nodes.Add(root2);
        //    treeView.Nodes.Add(root3);
        //}
    }
}