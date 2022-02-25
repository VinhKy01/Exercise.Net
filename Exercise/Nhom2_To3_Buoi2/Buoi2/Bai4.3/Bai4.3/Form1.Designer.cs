
namespace Bai4._3
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
            this.textS = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(159, 99);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(148, 20);
            this.textS.TabIndex = 14;
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(159, 54);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(148, 20);
            this.textN.TabIndex = 13;
            // 
            // buttonTinh
            // 
            this.buttonTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinh.Location = new System.Drawing.Point(143, 156);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(99, 56);
            this.buttonTinh.TabIndex = 12;
            this.buttonTinh.Text = "TÍNH";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tổng S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhập n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 265);
            this.Controls.Add(this.textS);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.buttonTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CẤU TRÚC LẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textS;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

