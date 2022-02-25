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

namespace bai3
{
    public partial class Form1 : Form
    {
        private string[] folderFile = null;
        private int selected = 0;
        private int start = 0;
        private int finish = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenList_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDialog = new FolderBrowserDialog();
            if(fbDialog.ShowDialog() == DialogResult.OK)
            {
                string[] part1 = null, part2 = null, part3 = null;
                part1 = Directory.GetFiles(fbDialog.SelectedPath, "*.jpg");
                part2 = Directory.GetFiles(fbDialog.SelectedPath, "*.jpeg");
                part3 = Directory.GetFiles(fbDialog.SelectedPath, "*.bmp");
                folderFile = new string[part1.Length + part2.Length + part3.Length];
                Array.Copy(part1, 0, folderFile, 0, part1.Length);
                Array.Copy(part2, 0, folderFile, part1.Length, part2.Length);
                Array.Copy(part3, 0, folderFile, part1.Length + part2.Length, part3.Length);
                selected = 0;
                start = 0;
                finish = folderFile.Length - 1;
                showImage(folderFile[selected]);
                btnStart.Enabled = true;
            }
        }

        private void showImage(string path)
        {
            Image img = Image.FromFile(path);
            showPictureBox.Width = img.Width / 2;
            showPictureBox.Height = img.Height / 2;
            showPictureBox.Image = img;
            showPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            if(selected == 0)
            {
                selected = folderFile.Length - 1;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected - 1;
                showImage(folderFile[selected]);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selected == folderFile.Length - 1)
            {
                selected = 0;
                showImage(folderFile[selected]);
            }
            else
            {
                selected = selected + 1;
                showImage(folderFile[selected]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            btnBefore.Enabled = true;
        }
    }
}
