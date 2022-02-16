
namespace Bai2._9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.textkq = new System.Windows.Forms.TextBox();
            this.buttontong = new System.Windows.Forms.Button();
            this.buttonhieu = new System.Windows.Forms.Button();
            this.buttontich = new System.Windows.Forms.Button();
            this.buttonthuong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text2);
            this.groupBox1.Controls.Add(this.text1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(80, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHÉP TOÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NHẬP A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "NHẬP B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "KẾT QUẢ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(163, 37);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(174, 22);
            this.text1.TabIndex = 2;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(163, 88);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(174, 22);
            this.text2.TabIndex = 3;
            // 
            // textkq
            // 
            this.textkq.Location = new System.Drawing.Point(244, 191);
            this.textkq.Name = "textkq";
            this.textkq.Size = new System.Drawing.Size(174, 20);
            this.textkq.TabIndex = 4;
            // 
            // buttontong
            // 
            this.buttontong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontong.Location = new System.Drawing.Point(14, 232);
            this.buttontong.Name = "buttontong";
            this.buttontong.Size = new System.Drawing.Size(121, 50);
            this.buttontong.TabIndex = 5;
            this.buttontong.Text = "TỔNG";
            this.buttontong.UseVisualStyleBackColor = true;
            this.buttontong.Click += new System.EventHandler(this.buttontong_Click);
            // 
            // buttonhieu
            // 
            this.buttonhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhieu.Location = new System.Drawing.Point(142, 232);
            this.buttonhieu.Name = "buttonhieu";
            this.buttonhieu.Size = new System.Drawing.Size(121, 50);
            this.buttonhieu.TabIndex = 6;
            this.buttonhieu.Text = "HIỆU";
            this.buttonhieu.UseVisualStyleBackColor = true;
            this.buttonhieu.Click += new System.EventHandler(this.buttonhieu_Click);
            // 
            // buttontich
            // 
            this.buttontich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontich.Location = new System.Drawing.Point(292, 232);
            this.buttontich.Name = "buttontich";
            this.buttontich.Size = new System.Drawing.Size(121, 50);
            this.buttontich.TabIndex = 7;
            this.buttontich.Text = "TÍCH";
            this.buttontich.UseVisualStyleBackColor = true;
            this.buttontich.Click += new System.EventHandler(this.buttontich_Click);
            // 
            // buttonthuong
            // 
            this.buttonthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthuong.Location = new System.Drawing.Point(420, 232);
            this.buttonthuong.Name = "buttonthuong";
            this.buttonthuong.Size = new System.Drawing.Size(121, 50);
            this.buttonthuong.TabIndex = 8;
            this.buttonthuong.Text = "THƯƠNG";
            this.buttonthuong.UseVisualStyleBackColor = true;
            this.buttonthuong.Click += new System.EventHandler(this.buttonthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 331);
            this.Controls.Add(this.buttonthuong);
            this.Controls.Add(this.buttontich);
            this.Controls.Add(this.buttonhieu);
            this.Controls.Add(this.buttontong);
            this.Controls.Add(this.textkq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Bai2.9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox textkq;
        private System.Windows.Forms.Button buttontong;
        private System.Windows.Forms.Button buttonhieu;
        private System.Windows.Forms.Button buttontich;
        private System.Windows.Forms.Button buttonthuong;
    }
}

