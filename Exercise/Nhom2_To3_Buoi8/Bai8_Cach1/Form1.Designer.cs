namespace Bai8_Cach1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbChuNhat = new System.Windows.Forms.RadioButton();
            this.rdbVuong = new System.Windows.Forms.RadioButton();
            this.rdbTron = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(269, 304);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 304);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChuNhat);
            this.groupBox1.Controls.Add(this.rdbVuong);
            this.groupBox1.Controls.Add(this.rdbTron);
            this.groupBox1.Location = new System.Drawing.Point(29, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(217, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // rdbChuNhat
            // 
            this.rdbChuNhat.AutoSize = true;
            this.rdbChuNhat.Location = new System.Drawing.Point(29, 116);
            this.rdbChuNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbChuNhat.Name = "rdbChuNhat";
            this.rdbChuNhat.Size = new System.Drawing.Size(105, 20);
            this.rdbChuNhat.TabIndex = 2;
            this.rdbChuNhat.TabStop = true;
            this.rdbChuNhat.Text = "Hình chữ nhật";
            this.rdbChuNhat.UseVisualStyleBackColor = true;
            this.rdbChuNhat.CheckedChanged += new System.EventHandler(this.rdbChuNhat_CheckedChanged);
            // 
            // rdbVuong
            // 
            this.rdbVuong.AutoSize = true;
            this.rdbVuong.Location = new System.Drawing.Point(29, 82);
            this.rdbVuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbVuong.Name = "rdbVuong";
            this.rdbVuong.Size = new System.Drawing.Size(93, 20);
            this.rdbVuong.TabIndex = 1;
            this.rdbVuong.TabStop = true;
            this.rdbVuong.Text = "Hình vuông";
            this.rdbVuong.UseVisualStyleBackColor = true;
            this.rdbVuong.CheckedChanged += new System.EventHandler(this.rdbVuong_CheckedChanged);
            // 
            // rdbTron
            // 
            this.rdbTron.AutoSize = true;
            this.rdbTron.Location = new System.Drawing.Point(29, 49);
            this.rdbTron.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbTron.Name = "rdbTron";
            this.rdbTron.Size = new System.Drawing.Size(78, 20);
            this.rdbTron.TabIndex = 0;
            this.rdbTron.TabStop = true;
            this.rdbTron.Text = "Hình tròn";
            this.rdbTron.UseVisualStyleBackColor = true;
            this.rdbTron.CheckedChanged += new System.EventHandler(this.rdbTron_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(159, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tính diện tích và chu vi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.menuToolStripMenuItem.Text = "Thực hiện";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBanKinh);
            this.groupBox2.Controls.Add(this.txtRong);
            this.groupBox2.Controls.Add(this.txtDai);
            this.groupBox2.Controls.Add(this.txtCanh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(265, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 194);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cạnh";
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(88, 26);
            this.txtCanh.MaxLength = 10;
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(144, 22);
            this.txtCanh.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dài";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(88, 65);
            this.txtDai.MaxLength = 10;
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(144, 22);
            this.txtDai.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rộng";
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(88, 104);
            this.txtRong.MaxLength = 10;
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(144, 22);
            this.txtRong.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bán kính";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(88, 143);
            this.txtBanKinh.MaxLength = 10;
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(144, 22);
            this.txtBanKinh.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChuNhat;
        private System.Windows.Forms.RadioButton rdbVuong;
        private System.Windows.Forms.RadioButton rdbTron;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

