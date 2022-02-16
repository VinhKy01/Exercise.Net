namespace cau4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbNhap = new System.Windows.Forms.GroupBox();
            this.rdbTron = new System.Windows.Forms.RadioButton();
            this.rdbTamGiac = new System.Windows.Forms.RadioButton();
            this.rdbVuong = new System.Windows.Forms.RadioButton();
            this.rdbChuNhat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbChuVi = new System.Windows.Forms.Label();
            this.lbDienTich = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grbNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChuNhat);
            this.groupBox1.Controls.Add(this.rdbTamGiac);
            this.groupBox1.Controls.Add(this.rdbVuong);
            this.groupBox1.Controls.Add(this.rdbTron);
            this.groupBox1.Location = new System.Drawing.Point(168, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(335, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chon hinh";
            // 
            // grbNhap
            // 
            this.grbNhap.Controls.Add(this.txtDienTich);
            this.grbNhap.Controls.Add(this.txtChuVi);
            this.grbNhap.Controls.Add(this.txt3);
            this.grbNhap.Controls.Add(this.txt2);
            this.grbNhap.Controls.Add(this.txt1);
            this.grbNhap.Controls.Add(this.lbDienTich);
            this.grbNhap.Controls.Add(this.lbChuVi);
            this.grbNhap.Controls.Add(this.lb3);
            this.grbNhap.Controls.Add(this.lb2);
            this.grbNhap.Controls.Add(this.lb1);
            this.grbNhap.Location = new System.Drawing.Point(168, 298);
            this.grbNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNhap.Name = "grbNhap";
            this.grbNhap.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbNhap.Size = new System.Drawing.Size(335, 247);
            this.grbNhap.TabIndex = 0;
            this.grbNhap.TabStop = false;
            this.grbNhap.Text = "Hinh tron";
            this.grbNhap.Visible = false;
            // 
            // rdbTron
            // 
            this.rdbTron.AutoSize = true;
            this.rdbTron.Location = new System.Drawing.Point(39, 38);
            this.rdbTron.Name = "rdbTron";
            this.rdbTron.Size = new System.Drawing.Size(92, 24);
            this.rdbTron.TabIndex = 0;
            this.rdbTron.TabStop = true;
            this.rdbTron.Text = "Hinh tron";
            this.rdbTron.UseVisualStyleBackColor = true;
            // 
            // rdbTamGiac
            // 
            this.rdbTamGiac.AutoSize = true;
            this.rdbTamGiac.Location = new System.Drawing.Point(181, 38);
            this.rdbTamGiac.Name = "rdbTamGiac";
            this.rdbTamGiac.Size = new System.Drawing.Size(91, 24);
            this.rdbTamGiac.TabIndex = 1;
            this.rdbTamGiac.TabStop = true;
            this.rdbTamGiac.Text = "Tam giac";
            this.rdbTamGiac.UseVisualStyleBackColor = true;
            // 
            // rdbVuong
            // 
            this.rdbVuong.AutoSize = true;
            this.rdbVuong.Location = new System.Drawing.Point(39, 68);
            this.rdbVuong.Name = "rdbVuong";
            this.rdbVuong.Size = new System.Drawing.Size(107, 24);
            this.rdbVuong.TabIndex = 2;
            this.rdbVuong.TabStop = true;
            this.rdbVuong.Text = "Hinh vuong";
            this.rdbVuong.UseVisualStyleBackColor = true;
            // 
            // rdbChuNhat
            // 
            this.rdbChuNhat.AutoSize = true;
            this.rdbChuNhat.Location = new System.Drawing.Point(181, 68);
            this.rdbChuNhat.Name = "rdbChuNhat";
            this.rdbChuNhat.Size = new System.Drawing.Size(126, 24);
            this.rdbChuNhat.TabIndex = 3;
            this.rdbChuNhat.TabStop = true;
            this.rdbChuNhat.Text = "Hinh chu nhat";
            this.rdbChuNhat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(216, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tinh chu vi va dien tich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(95, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(490, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hinh tron - Tam Giac - Hinh vuong - Hinh chu nhat";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(168, 234);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(95, 35);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Thuc hien";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(288, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 35);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Lam lai";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(408, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(35, 40);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(79, 20);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Ban kinh: ";
            this.lb1.Visible = false;
            // 
            // lbChuVi
            // 
            this.lbChuVi.AutoSize = true;
            this.lbChuVi.Location = new System.Drawing.Point(35, 160);
            this.lbChuVi.Name = "lbChuVi";
            this.lbChuVi.Size = new System.Drawing.Size(56, 20);
            this.lbChuVi.TabIndex = 0;
            this.lbChuVi.Text = "Chu vi:";
            // 
            // lbDienTich
            // 
            this.lbDienTich.AutoSize = true;
            this.lbDienTich.Location = new System.Drawing.Point(35, 200);
            this.lbDienTich.Name = "lbDienTich";
            this.lbDienTich.Size = new System.Drawing.Size(79, 20);
            this.lbDienTich.TabIndex = 0;
            this.lbDienTich.Text = "Dien tich: ";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(135, 35);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(173, 26);
            this.txt1.TabIndex = 1;
            this.txt1.Visible = false;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(135, 155);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(173, 26);
            this.txtChuVi.TabIndex = 1;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(135, 195);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(173, 26);
            this.txtDienTich.TabIndex = 1;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(35, 80);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(79, 20);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Ban kinh: ";
            this.lb2.Visible = false;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(135, 75);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(173, 26);
            this.txt2.TabIndex = 1;
            this.txt2.Visible = false;
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(35, 120);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(79, 20);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "Ban kinh: ";
            this.lb3.Visible = false;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(135, 115);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(173, 26);
            this.txt3.TabIndex = 1;
            this.txt3.Visible = false;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 551);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbNhap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Chu vi va dien tich";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbNhap.ResumeLayout(false);
            this.grbNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChuNhat;
        private System.Windows.Forms.RadioButton rdbTamGiac;
        private System.Windows.Forms.RadioButton rdbVuong;
        private System.Windows.Forms.RadioButton rdbTron;
        private System.Windows.Forms.GroupBox grbNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbDienTich;
        private System.Windows.Forms.Label lbChuVi;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
    }
}

