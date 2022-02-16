namespace Bai7_Cau1
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
            this.rdbTamGiac = new System.Windows.Forms.RadioButton();
            this.rdbChuNhat = new System.Windows.Forms.RadioButton();
            this.rdbVuong = new System.Windows.Forms.RadioButton();
            this.rdbTron = new System.Windows.Forms.RadioButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(181, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính diện tích và chu vi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTamGiac);
            this.groupBox1.Controls.Add(this.rdbChuNhat);
            this.groupBox1.Controls.Add(this.rdbVuong);
            this.groupBox1.Controls.Add(this.rdbTron);
            this.groupBox1.Location = new System.Drawing.Point(32, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 158);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn";
            // 
            // rdbTamGiac
            // 
            this.rdbTamGiac.AutoSize = true;
            this.rdbTamGiac.Location = new System.Drawing.Point(22, 121);
            this.rdbTamGiac.Name = "rdbTamGiac";
            this.rdbTamGiac.Size = new System.Drawing.Size(80, 21);
            this.rdbTamGiac.TabIndex = 3;
            this.rdbTamGiac.TabStop = true;
            this.rdbTamGiac.Text = "Tam giác";
            this.rdbTamGiac.UseVisualStyleBackColor = true;
            this.rdbTamGiac.CheckedChanged += new System.EventHandler(this.rdbTamGiac_CheckedChanged);
            // 
            // rdbChuNhat
            // 
            this.rdbChuNhat.AutoSize = true;
            this.rdbChuNhat.Location = new System.Drawing.Point(22, 94);
            this.rdbChuNhat.Name = "rdbChuNhat";
            this.rdbChuNhat.Size = new System.Drawing.Size(109, 21);
            this.rdbChuNhat.TabIndex = 2;
            this.rdbChuNhat.TabStop = true;
            this.rdbChuNhat.Text = "Hình chữ nhật";
            this.rdbChuNhat.UseVisualStyleBackColor = true;
            this.rdbChuNhat.CheckedChanged += new System.EventHandler(this.rdbChuNhat_CheckedChanged);
            // 
            // rdbVuong
            // 
            this.rdbVuong.AutoSize = true;
            this.rdbVuong.Location = new System.Drawing.Point(22, 67);
            this.rdbVuong.Name = "rdbVuong";
            this.rdbVuong.Size = new System.Drawing.Size(93, 21);
            this.rdbVuong.TabIndex = 1;
            this.rdbVuong.TabStop = true;
            this.rdbVuong.Text = "Hình vuông";
            this.rdbVuong.UseVisualStyleBackColor = true;
            this.rdbVuong.CheckedChanged += new System.EventHandler(this.rdbVuong_CheckedChanged);
            // 
            // rdbTron
            // 
            this.rdbTron.AutoSize = true;
            this.rdbTron.Location = new System.Drawing.Point(22, 40);
            this.rdbTron.Name = "rdbTron";
            this.rdbTron.Size = new System.Drawing.Size(81, 21);
            this.rdbTron.TabIndex = 0;
            this.rdbTron.TabStop = true;
            this.rdbTron.Text = "Hình tròn";
            this.rdbTron.UseVisualStyleBackColor = true;
            this.rdbTron.CheckedChanged += new System.EventHandler(this.drbTron_CheckedChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(201, 86);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(387, 148);
            this.mainPanel.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.menuToolStripMenuItem.Text = "Thực hiện";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(621, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTamGiac;
        private System.Windows.Forms.RadioButton rdbChuNhat;
        private System.Windows.Forms.RadioButton rdbVuong;
        private System.Windows.Forms.RadioButton rdbTron;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

