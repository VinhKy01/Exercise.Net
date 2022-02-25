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
            this.grbPS1 = new System.Windows.Forms.GroupBox();
            this.txtMau1 = new System.Windows.Forms.TextBox();
            this.txtTu1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTinh = new System.Windows.Forms.GroupBox();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.grbKQ = new System.Windows.Forms.GroupBox();
            this.txtMauKQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTuKQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbPS2 = new System.Windows.Forms.GroupBox();
            this.txtMau2 = new System.Windows.Forms.TextBox();
            this.txtTu2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbPS1.SuspendLayout();
            this.grbTinh.SuspendLayout();
            this.grbKQ.SuspendLayout();
            this.grbPS2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbPS1
            // 
            this.grbPS1.Controls.Add(this.txtMau1);
            this.grbPS1.Controls.Add(this.txtTu1);
            this.grbPS1.Controls.Add(this.label2);
            this.grbPS1.Controls.Add(this.label1);
            this.grbPS1.Location = new System.Drawing.Point(32, 27);
            this.grbPS1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPS1.Name = "grbPS1";
            this.grbPS1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPS1.Size = new System.Drawing.Size(218, 141);
            this.grbPS1.TabIndex = 0;
            this.grbPS1.TabStop = false;
            this.grbPS1.Text = "Phan so 1";
            // 
            // txtMau1
            // 
            this.txtMau1.Location = new System.Drawing.Point(98, 84);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.Size = new System.Drawing.Size(100, 26);
            this.txtMau1.TabIndex = 1;
            // 
            // txtTu1
            // 
            this.txtTu1.Location = new System.Drawing.Point(98, 46);
            this.txtTu1.Name = "txtTu1";
            this.txtTu1.Size = new System.Drawing.Size(100, 26);
            this.txtTu1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mau so";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tu so";
            // 
            // grbTinh
            // 
            this.grbTinh.Controls.Add(this.btnChia);
            this.grbTinh.Controls.Add(this.btnTru);
            this.grbTinh.Controls.Add(this.btnNhan);
            this.grbTinh.Controls.Add(this.btnCong);
            this.grbTinh.Location = new System.Drawing.Point(32, 199);
            this.grbTinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTinh.Name = "grbTinh";
            this.grbTinh.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbTinh.Size = new System.Drawing.Size(218, 125);
            this.grbTinh.TabIndex = 2;
            this.grbTinh.TabStop = false;
            this.grbTinh.Text = "Tinh toan";
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(118, 77);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(85, 33);
            this.btnChia.TabIndex = 7;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(118, 34);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(85, 33);
            this.btnTru.TabIndex = 5;
            this.btnTru.Text = "Tru";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(18, 77);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(85, 33);
            this.btnNhan.TabIndex = 6;
            this.btnNhan.Text = "Nhan";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(18, 34);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(85, 33);
            this.btnCong.TabIndex = 4;
            this.btnCong.Text = "Cong";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // grbKQ
            // 
            this.grbKQ.Controls.Add(this.txtMauKQ);
            this.grbKQ.Controls.Add(this.label5);
            this.grbKQ.Controls.Add(this.txtTuKQ);
            this.grbKQ.Controls.Add(this.label6);
            this.grbKQ.Location = new System.Drawing.Point(315, 199);
            this.grbKQ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbKQ.Name = "grbKQ";
            this.grbKQ.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbKQ.Size = new System.Drawing.Size(218, 125);
            this.grbKQ.TabIndex = 4;
            this.grbKQ.TabStop = false;
            this.grbKQ.Text = "Ket qua";
            // 
            // txtMauKQ
            // 
            this.txtMauKQ.Location = new System.Drawing.Point(90, 79);
            this.txtMauKQ.Name = "txtMauKQ";
            this.txtMauKQ.Size = new System.Drawing.Size(100, 26);
            this.txtMauKQ.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tu so";
            // 
            // txtTuKQ
            // 
            this.txtTuKQ.Location = new System.Drawing.Point(90, 41);
            this.txtTuKQ.Name = "txtTuKQ";
            this.txtTuKQ.Size = new System.Drawing.Size(100, 26);
            this.txtTuKQ.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mau so";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(162, 352);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 41);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Lam lai";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(299, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 41);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grbPS2
            // 
            this.grbPS2.Controls.Add(this.txtMau2);
            this.grbPS2.Controls.Add(this.txtTu2);
            this.grbPS2.Controls.Add(this.label3);
            this.grbPS2.Controls.Add(this.label4);
            this.grbPS2.Location = new System.Drawing.Point(315, 27);
            this.grbPS2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPS2.Name = "grbPS2";
            this.grbPS2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbPS2.Size = new System.Drawing.Size(218, 141);
            this.grbPS2.TabIndex = 1;
            this.grbPS2.TabStop = false;
            this.grbPS2.Text = "Phan so 2";
            // 
            // txtMau2
            // 
            this.txtMau2.Location = new System.Drawing.Point(98, 84);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.Size = new System.Drawing.Size(100, 26);
            this.txtMau2.TabIndex = 3;
            // 
            // txtTu2
            // 
            this.txtTu2.Location = new System.Drawing.Point(98, 46);
            this.txtTu2.Name = "txtTu2";
            this.txtTu2.Size = new System.Drawing.Size(100, 26);
            this.txtTu2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mau so";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tu so";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 431);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbKQ);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grbTinh);
            this.Controls.Add(this.grbPS2);
            this.Controls.Add(this.grbPS1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tinh phan so";
            this.grbPS1.ResumeLayout(false);
            this.grbPS1.PerformLayout();
            this.grbTinh.ResumeLayout(false);
            this.grbKQ.ResumeLayout(false);
            this.grbKQ.PerformLayout();
            this.grbPS2.ResumeLayout(false);
            this.grbPS2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPS1;
        private System.Windows.Forms.TextBox txtMau1;
        private System.Windows.Forms.TextBox txtTu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTinh;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.GroupBox grbKQ;
        private System.Windows.Forms.TextBox txtMauKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTuKQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grbPS2;
        private System.Windows.Forms.TextBox txtMau2;
        private System.Windows.Forms.TextBox txtTu2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

