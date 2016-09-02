using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Directory.GetLogicalDrives();//загруска лок дисков
            DirectoryInfo directory; //инфо/
            TreeNode tn; //создание дерева

            foreach (string s in drives)
            {
                tn = treeView1.Nodes.Add(s); //построение дерева
                directory = new DirectoryInfo(s); //плюсик

                try
                {
                    add(tn, directory);
                }
                catch
                {

                }
            }
        }

        private TreeNode add(TreeNode tn, DirectoryInfo dir)
        {
            DirectoryInfo[] d;
            TreeNode t = null;
            d = dir.GetDirectories("*");
            foreach (DirectoryInfo res in d)
            {
                if (res != null)
                {
                    t = tn.Nodes.Add(res.Name);
                    add(t, res);
                }
            }
            return t;
        }

        private void tr_path_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.FullPath;

            listBox1.Items.Clear();
            listBox1.Items.Add("Attributes: " + File.GetAttributes(path));
            listBox1.Items.Add("Creation time: " + Directory.GetCreationTime(path));
            listBox1.Items.Add("Last Opened: " + File.GetLastAccessTime(path));
            listBox1.Items.Add("Last Edited: " + File.GetLastWriteTime(path));
            listBox1.Items.Add("Full Name: " + path);
        }
    }
}