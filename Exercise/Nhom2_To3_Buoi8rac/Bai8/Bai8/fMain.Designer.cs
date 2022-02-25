namespace Bai8
{
    partial class fMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbHinhVuong = new System.Windows.Forms.RadioButton();
            this.rdbHinhChuNhat = new System.Windows.Forms.RadioButton();
            this.rdbHinhTron = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TINH DIEN TICH VA CHU VI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbHinhTron);
            this.groupBox1.Controls.Add(this.rdbHinhChuNhat);
            this.groupBox1.Controls.Add(this.rdbHinhVuong);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBanKinh);
            this.panel1.Controls.Add(this.txtRong);
            this.panel1.Controls.Add(this.txtDai);
            this.panel1.Controls.Add(this.txtCanh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(177, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 183);
            this.panel1.TabIndex = 2;
            // 
            // rdbHinhVuong
            // 
            this.rdbHinhVuong.AutoSize = true;
            this.rdbHinhVuong.Checked = true;
            this.rdbHinhVuong.ForeColor = System.Drawing.Color.Blue;
            this.rdbHinhVuong.Location = new System.Drawing.Point(27, 39);
            this.rdbHinhVuong.Name = "rdbHinhVuong";
            this.rdbHinhVuong.Size = new System.Drawing.Size(103, 23);
            this.rdbHinhVuong.TabIndex = 0;
            this.rdbHinhVuong.TabStop = true;
            this.rdbHinhVuong.Text = "Hinh vuong";
            this.rdbHinhVuong.UseVisualStyleBackColor = true;
            this.rdbHinhVuong.CheckedChanged += new System.EventHandler(this.rdbHinhVuong_CheckedChanged);
            // 
            // rdbHinhChuNhat
            // 
            this.rdbHinhChuNhat.AutoSize = true;
            this.rdbHinhChuNhat.ForeColor = System.Drawing.Color.Blue;
            this.rdbHinhChuNhat.Location = new System.Drawing.Point(27, 86);
            this.rdbHinhChuNhat.Name = "rdbHinhChuNhat";
            this.rdbHinhChuNhat.Size = new System.Drawing.Size(119, 23);
            this.rdbHinhChuNhat.TabIndex = 0;
            this.rdbHinhChuNhat.Text = "Hinh chu nhat";
            this.rdbHinhChuNhat.UseVisualStyleBackColor = true;
            this.rdbHinhChuNhat.CheckedChanged += new System.EventHandler(this.rdbHinhChuNhat_CheckedChanged);
            // 
            // rdbHinhTron
            // 
            this.rdbHinhTron.AutoSize = true;
            this.rdbHinhTron.ForeColor = System.Drawing.Color.Blue;
            this.rdbHinhTron.Location = new System.Drawing.Point(27, 133);
            this.rdbHinhTron.Name = "rdbHinhTron";
            this.rdbHinhTron.Size = new System.Drawing.Size(90, 23);
            this.rdbHinhTron.TabIndex = 0;
            this.rdbHinhTron.Text = "Hinh tron";
            this.rdbHinhTron.UseVisualStyleBackColor = true;
            this.rdbHinhTron.CheckedChanged += new System.EventHandler(this.rdbHinhTron_CheckedChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(112, 225);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(107, 39);
            this.btnThucHien.TabIndex = 3;
            this.btnThucHien.Text = "Thuc hien";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(291, 225);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Canh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dai:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rong:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ban kinh:";
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(98, 36);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(100, 26);
            this.txtCanh.TabIndex = 1;
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(98, 83);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(72, 26);
            this.txtDai.TabIndex = 1;
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(232, 85);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(72, 26);
            this.txtRong.TabIndex = 1;
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(98, 133);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(100, 26);
            this.txtBanKinh.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 275);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai tap";
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
        private System.Windows.Forms.RadioButton rdbHinhTron;
        private System.Windows.Forms.RadioButton rdbHinhChuNhat;
        private System.Windows.Forms.RadioButton rdbHinhVuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
    }
}

