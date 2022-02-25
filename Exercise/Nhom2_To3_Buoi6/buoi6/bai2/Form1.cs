using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitExploreTreeview();
        }

        private void InitExploreTreeview()
        {
            treeViewPicture.ShowRootLines = true;
            treeViewPicture.ShowLines = true;
            TreeNode root;
            string[] driver = Directory.GetLogicalDrives();
            foreach(string dr in driver)
            {
                root = new TreeNode(dr);
                root.Nodes.Add(new TreeNode(""));
                treeViewPicture.Nodes.Add(root);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PicflowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void treeViewPicture_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(e.Node.FullPath);
            PicflowLayoutPanel.Controls.Clear();
            PictureBox[] pic;
            showPictureBox.Image = null;
            if (dir.Exists)
            {
                pic = new PictureBox[dir.GetFiles().GetLength(0)];
                int i = 0;
                foreach(FileInfo file in dir.GetFiles())
                {
                    if(file.Name.EndsWith("jpg") || file.Name.EndsWith("gif") || file.Name.EndsWith("bmp"))
                    {
                        pic[i] = new PictureBox();
                        pic[i].Name = "pic" + file.Name;
                        pic[i].SizeMode = PictureBoxSizeMode.Zoom;
                        pic[i].Size = new Size(100, 100);
                        pic[i].BorderStyle = BorderStyle.FixedSingle;
                        pic[i].Image = Image.FromFile(e.Node.FullPath + "//" + file.Name);
                        pic[i].Click += new EventHandler(Form1_Click);
                        PicflowLayoutPanel.Controls.Add(pic[i]);
                        i++;
                        PicflowLayoutPanel.Update();
                    }
                }
            }
        }



        private void FillNode(TreeNode rootNode)
        {
            DirectoryInfo dir = new DirectoryInfo(rootNode.FullPath);
            foreach(DirectoryInfo chirldName in dir.GetDirectories())
            {
                TreeNode chirldNode = new TreeNode(chirldName.Name);
                chirldNode.Nodes.Add(new TreeNode(""));
                rootNode.Nodes.Add(chirldNode);
            }
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            showPictureBox.Image = pic.Image;
        }


        private void PicflowLayoutPanel_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            showPictureBox.Image = pic.Image;
        }

        private void treeViewPicture_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                if(e.Node.Nodes[0].Text == "")
                {
                    e.Node.Nodes.Clear();
                    FillNode(e.Node);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
