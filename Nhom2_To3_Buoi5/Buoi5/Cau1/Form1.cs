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

namespace Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel);
            if (exit == DialogResult.OK)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog font= new FontDialog();
            if (font.ShowDialog() == DialogResult.OK && txtVanBan.Text != "")
                this.txtVanBan.Font = font.Font;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK && txtVanBan.Text != "")
                this.txtVanBan.ForeColor = color.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Mở file";
            open.Filter = "Open file|*.doc|Open file|*.docx|Text|*.txt";
            DialogResult op = open.ShowDialog();
            if(op == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                txtVanBan.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save file";
            save.Filter = "Văn bản(*.vb2)|*.vb2|Text|*.txt";
            DialogResult op = save.ShowDialog();
            if(op == DialogResult.OK)
            {
                StreamWriter file = new StreamWriter(save.FileName);
                file.Write(txtVanBan.Text);
                file.Close();
            }
        }
    }
}
