
namespace Bai2._7
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(62, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(153, 58);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(186, 26);
            this.text1.TabIndex = 2;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(153, 124);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(186, 26);
            this.text2.TabIndex = 3;
            // 
            // buttontong
            // 
            this.buttontong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontong.Location = new System.Drawing.Point(12, 282);
            this.buttontong.Name = "buttontong";
            this.buttontong.Size = new System.Drawing.Size(105, 42);
            this.buttontong.TabIndex = 1;
            this.buttontong.Text = "Tổng";
            this.buttontong.UseVisualStyleBackColor = true;
            this.buttontong.Click += new System.EventHandler(this.buttontong_Click);
            // 
            // buttonhieu
            // 
            this.buttonhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhieu.Location = new System.Drawing.Point(123, 282);
            this.buttonhieu.Name = "buttonhieu";
            this.buttonhieu.Size = new System.Drawing.Size(118, 42);
            this.buttonhieu.TabIndex = 2;
            this.buttonhieu.Text = "Hiệu";
            this.buttonhieu.UseVisualStyleBackColor = true;
            this.buttonhieu.Click += new System.EventHandler(this.buttonhieu_Click);
            // 
            // buttontich
            // 
            this.buttontich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttontich.Location = new System.Drawing.Point(247, 282);
            this.buttontich.Name = "buttontich";
            this.buttontich.Size = new System.Drawing.Size(118, 42);
            this.buttontich.TabIndex = 3;
            this.buttontich.Text = "Tích";
            this.buttontich.UseVisualStyleBackColor = true;
            this.buttontich.Click += new System.EventHandler(this.buttontich_Click);
            // 
            // buttonthuong
            // 
            this.buttonthuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonthuong.Location = new System.Drawing.Point(371, 282);
            this.buttonthuong.Name = "buttonthuong";
            this.buttonthuong.Size = new System.Drawing.Size(105, 42);
            this.buttonthuong.TabIndex = 4;
            this.buttonthuong.Text = "Thương";
            this.buttonthuong.UseVisualStyleBackColor = true;
            this.buttonthuong.Click += new System.EventHandler(this.buttonthuong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 353);
            this.Controls.Add(this.buttonthuong);
            this.Controls.Add(this.buttontich);
            this.Controls.Add(this.buttonhieu);
            this.Controls.Add(this.buttontong);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bai2.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttontong;
        private System.Windows.Forms.Button buttonhieu;
        private System.Windows.Forms.Button buttontich;
        private System.Windows.Forms.Button buttonthuong;
    }
}

