
namespace cau3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtqueQuan = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtngaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtmsSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewthongTin = new System.Windows.Forms.ListView();
            this.lvMssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvngaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lvsdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvqueQuan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(333, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtqueQuan);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtngaySinh);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtmsSV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // txtqueQuan
            // 
            this.txtqueQuan.FormattingEnabled = true;
            this.txtqueQuan.Items.AddRange(new object[] {
            "An Giang",
            "Kiên Giang",
            "Vinh Long",
            "Hà Tiên",
            "Đà Lạt",
            "Hà Nội",
            "Hồ Chí Minh",
            "Đà Nẳng"});
            this.txtqueQuan.Location = new System.Drawing.Point(517, 132);
            this.txtqueQuan.Name = "txtqueQuan";
            this.txtqueQuan.Size = new System.Drawing.Size(247, 24);
            this.txtqueQuan.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbNu);
            this.panel1.Controls.Add(this.rdbNam);
            this.panel1.Location = new System.Drawing.Point(517, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 36);
            this.panel1.TabIndex = 3;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(167, 8);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 0;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(43, 8);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 20);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtngaySinh
            // 
            this.txtngaySinh.CustomFormat = "dd/mm/yy";
            this.txtngaySinh.Location = new System.Drawing.Point(134, 133);
            this.txtngaySinh.Name = "txtngaySinh";
            this.txtngaySinh.Size = new System.Drawing.Size(247, 22);
            this.txtngaySinh.TabIndex = 2;
            this.txtngaySinh.Value = new System.DateTime(2021, 11, 13, 0, 0, 0, 0);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(134, 86);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(247, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(517, 89);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(247, 22);
            this.txtsdt.TabIndex = 1;
            // 
            // txtmsSV
            // 
            this.txtmsSV.Location = new System.Drawing.Point(134, 39);
            this.txtmsSV.Name = "txtmsSV";
            this.txtmsSV.Size = new System.Drawing.Size(247, 22);
            this.txtmsSV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 39);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(419, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sinh viên";
            // 
            // listViewthongTin
            // 
            this.listViewthongTin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvMssv,
            this.lvTen,
            this.lvngaySinh,
            this.lvPhai,
            this.Lvsdt,
            this.lvqueQuan});
            this.listViewthongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewthongTin.HideSelection = false;
            this.listViewthongTin.Location = new System.Drawing.Point(12, 310);
            this.listViewthongTin.Name = "listViewthongTin";
            this.listViewthongTin.Size = new System.Drawing.Size(798, 168);
            this.listViewthongTin.TabIndex = 2;
            this.listViewthongTin.UseCompatibleStateImageBehavior = false;
            this.listViewthongTin.View = System.Windows.Forms.View.Details;
            this.listViewthongTin.SelectedIndexChanged += new System.EventHandler(this.listViewthongTin_SelectedIndexChanged);
            // 
            // lvMssv
            // 
            this.lvMssv.Text = "Mã sinh viên";
            this.lvMssv.Width = 100;
            // 
            // lvTen
            // 
            this.lvTen.Text = "Họ và tên";
            this.lvTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvTen.Width = 150;
            // 
            // lvngaySinh
            // 
            this.lvngaySinh.Text = "Ngày sinh";
            this.lvngaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvngaySinh.Width = 225;
            // 
            // lvPhai
            // 
            this.lvPhai.Text = "Phái";
            this.lvPhai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvPhai.Width = 85;
            // 
            // Lvsdt
            // 
            this.Lvsdt.Text = "Điện thoại";
            this.Lvsdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Lvsdt.Width = 125;
            // 
            // lvqueQuan
            // 
            this.lvqueQuan.Text = "Quê quán";
            this.lvqueQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvqueQuan.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(95, 251);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(126, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(267, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(439, 251);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(126, 35);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(611, 251);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(126, 35);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 469);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.listViewthongTin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.DateTimePicker txtngaySinh;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtmsSV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewthongTin;
        private System.Windows.Forms.ColumnHeader lvMssv;
        private System.Windows.Forms.ColumnHeader lvTen;
        private System.Windows.Forms.ColumnHeader lvngaySinh;
        private System.Windows.Forms.ColumnHeader lvPhai;
        private System.Windows.Forms.ColumnHeader Lvsdt;
        private System.Windows.Forms.ColumnHeader lvqueQuan;
        private System.Windows.Forms.ComboBox txtqueQuan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
    }
}

