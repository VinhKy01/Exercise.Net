
namespace cau2
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdblopB = new System.Windows.Forms.RadioButton();
            this.rdblopA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstB = new System.Windows.Forms.ListBox();
            this.btnsangPhai = new System.Windows.Forms.Button();
            this.btntatCaSangPhai = new System.Windows.Forms.Button();
            this.btnsangTrai = new System.Windows.Forms.Button();
            this.btntatCaSangTrai = new System.Windows.Forms.Button();
            this.btntongSV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(171, 38);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(476, 22);
            this.txtTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(684, 33);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 33);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdblopB);
            this.groupBox1.Controls.Add(this.rdblopA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(276, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(304, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // rdblopB
            // 
            this.rdblopB.AutoSize = true;
            this.rdblopB.Location = new System.Drawing.Point(172, 23);
            this.rdblopB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdblopB.Name = "rdblopB";
            this.rdblopB.Size = new System.Drawing.Size(74, 24);
            this.rdblopB.TabIndex = 0;
            this.rdblopB.TabStop = true;
            this.rdblopB.Text = "Lớp B";
            this.rdblopB.UseVisualStyleBackColor = true;
            // 
            // rdblopA
            // 
            this.rdblopA.AutoSize = true;
            this.rdblopA.Location = new System.Drawing.Point(36, 23);
            this.rdblopA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdblopA.Name = "rdblopA";
            this.rdblopA.Size = new System.Drawing.Size(74, 24);
            this.rdblopA.TabIndex = 0;
            this.rdblopA.TabStop = true;
            this.rdblopA.Text = "Lớp A";
            this.rdblopA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstA);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(300, 174);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lóp A";
            // 
            // lstA
            // 
            this.lstA.FormattingEnabled = true;
            this.lstA.ItemHeight = 20;
            this.lstA.Location = new System.Drawing.Point(9, 28);
            this.lstA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstA.Name = "lstA";
            this.lstA.Size = new System.Drawing.Size(280, 144);
            this.lstA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(530, 146);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(300, 174);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // lstB
            // 
            this.lstB.FormattingEnabled = true;
            this.lstB.ItemHeight = 20;
            this.lstB.Location = new System.Drawing.Point(9, 28);
            this.lstB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstB.Name = "lstB";
            this.lstB.Size = new System.Drawing.Size(280, 144);
            this.lstB.TabIndex = 0;
            // 
            // btnsangPhai
            // 
            this.btnsangPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsangPhai.Location = new System.Drawing.Point(364, 170);
            this.btnsangPhai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsangPhai.Name = "btnsangPhai";
            this.btnsangPhai.Size = new System.Drawing.Size(146, 33);
            this.btnsangPhai.TabIndex = 2;
            this.btnsangPhai.Text = ">";
            this.btnsangPhai.UseVisualStyleBackColor = true;
            this.btnsangPhai.Click += new System.EventHandler(this.button2_Click);
            // 
            // btntatCaSangPhai
            // 
            this.btntatCaSangPhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntatCaSangPhai.Location = new System.Drawing.Point(364, 208);
            this.btntatCaSangPhai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntatCaSangPhai.Name = "btntatCaSangPhai";
            this.btntatCaSangPhai.Size = new System.Drawing.Size(146, 33);
            this.btntatCaSangPhai.TabIndex = 2;
            this.btntatCaSangPhai.Text = ">>";
            this.btntatCaSangPhai.UseVisualStyleBackColor = true;
            this.btntatCaSangPhai.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsangTrai
            // 
            this.btnsangTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsangTrai.Location = new System.Drawing.Point(364, 246);
            this.btnsangTrai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsangTrai.Name = "btnsangTrai";
            this.btnsangTrai.Size = new System.Drawing.Size(146, 33);
            this.btnsangTrai.TabIndex = 2;
            this.btnsangTrai.Text = "<";
            this.btnsangTrai.UseVisualStyleBackColor = true;
            this.btnsangTrai.Click += new System.EventHandler(this.button4_Click);
            // 
            // btntatCaSangTrai
            // 
            this.btntatCaSangTrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntatCaSangTrai.Location = new System.Drawing.Point(364, 284);
            this.btntatCaSangTrai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntatCaSangTrai.Name = "btntatCaSangTrai";
            this.btntatCaSangTrai.Size = new System.Drawing.Size(146, 33);
            this.btntatCaSangTrai.TabIndex = 2;
            this.btntatCaSangTrai.Text = "<<";
            this.btntatCaSangTrai.UseVisualStyleBackColor = true;
            this.btntatCaSangTrai.Click += new System.EventHandler(this.button5_Click);
            // 
            // btntongSV
            // 
            this.btntongSV.Location = new System.Drawing.Point(222, 368);
            this.btntongSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntongSV.Name = "btntongSV";
            this.btntongSV.Size = new System.Drawing.Size(170, 33);
            this.btntongSV.TabIndex = 2;
            this.btntongSV.Text = "Tổng số sinh viên";
            this.btntongSV.UseVisualStyleBackColor = true;
            this.btntongSV.Click += new System.EventHandler(this.btntongSV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(474, 368);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(146, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btntongSV);
            this.Controls.Add(this.btntatCaSangTrai);
            this.Controls.Add(this.btnsangTrai);
            this.Controls.Add(this.btntatCaSangPhai);
            this.Controls.Add(this.btnsangPhai);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdblopA;
        private System.Windows.Forms.RadioButton rdblopB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstB;
        private System.Windows.Forms.Button btnsangPhai;
        private System.Windows.Forms.Button btntatCaSangPhai;
        private System.Windows.Forms.Button btnsangTrai;
        private System.Windows.Forms.Button btntatCaSangTrai;
        private System.Windows.Forms.Button btntongSV;
        private System.Windows.Forms.Button btnThoat;
    }
}

