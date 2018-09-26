using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeNode_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(TreeNode item in treeView1.Nodes)
            {
                MyExpand(item);
            }

        }
        private void MyExpand(TreeNode p)
        {
            FileSystemInfo[] x = new DirectoryInfo(p.FullPath).GetFileSystemInfos()
                .Where(k => (k.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                .ToArray();

            foreach (FileSystemInfo item in x)
            {
                TreeNode folder = new TreeNode(item.Name, 0, 0);
                p.Nodes.Add(folder);
                folder.Name = item.Name;

                if (folder.FullPath.EndsWith(".txt"))
                    folder.ImageIndex = folder.SelectedImageIndex = 2;

                if (folder.FullPath.EndsWith(".docx"))
                    folder.ImageIndex = folder.SelectedImageIndex = 4;
                if (folder.FullPath.EndsWith(".pdf"))
                    folder.ImageIndex = folder.SelectedImageIndex = 3;
                if (folder.FullPath.EndsWith(".xml"))
                    folder.ImageIndex = folder.SelectedImageIndex = 5;
                if (folder.FullPath.EndsWith(".jpg"))
                    folder.ImageIndex = folder.SelectedImageIndex = 6;
                if (folder.FullPath.EndsWith(".rar"))
                    folder.ImageIndex = folder.SelectedImageIndex = 7;

                if (item.GetType() == typeof(DirectoryInfo))
                    MyExpand(folder);
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            textBox1.Text = e.Node.FullPath;
            treeView2.Nodes.Clear();
            if (e.Node.Nodes.Count > 0)
            {
                foreach (TreeNode item in e.Node.Nodes)
                {
                    TreeNode tn = new TreeNode(item.Name, item.ImageIndex, item.ImageIndex);
                    tn.Name = e.Node.FullPath + @"\" + item.Text;
                    treeView2.Nodes.Add(tn);
                }
            }
            else
            {
                TreeNode tn = new TreeNode(e.Node.Name, e.Node.ImageIndex, e.Node.ImageIndex);
                tn.Name = e.Node.FullPath;
                treeView2.Nodes.Add(tn);
            }

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Collapse();
        }



        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            DirectoryInfo l = new DirectoryInfo(e.Node.Name);

            if ((l.Attributes & FileAttributes.Archive) != FileAttributes.Archive)
            {
                treeView2.Nodes.Clear();
                FileSystemInfo[] x = new DirectoryInfo(e.Node.Name).GetFileSystemInfos()
                .Where(k => (k.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                .ToArray();

                foreach (FileSystemInfo item in x)
                {
                    TreeNode folder = new TreeNode(item.Name);
                    folder.Name = item.FullName;
                    treeView2.Nodes.Add(folder);

                    if (folder.FullPath.EndsWith(".txt"))
                        folder.ImageIndex = 2;
                    if (folder.FullPath.EndsWith(".docx"))
                        folder.ImageIndex = 4;
                    if (folder.FullPath.EndsWith(".pdf"))
                        folder.ImageIndex = 3;
                    if (folder.FullPath.EndsWith(".xml"))
                        folder.ImageIndex = 5;
                    if (folder.FullPath.EndsWith(".jpg"))
                        folder.ImageIndex = 6;
                    if (folder.FullPath.EndsWith(".rar"))
                        folder.ImageIndex = 7;
                }

            }
            else
            {
                Process.Start(e.Node.Name);
            }
            
        }
    }
}
