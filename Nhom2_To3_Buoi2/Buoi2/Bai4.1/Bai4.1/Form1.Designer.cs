
namespace Bai4._1
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTinh = new System.Windows.Forms.Button();
            this.textN = new System.Windows.Forms.TextBox();
            this.textS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng S";
            // 
            // buttonTinh
            // 
            this.buttonTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTinh.Location = new System.Drawing.Point(141, 174);
            this.buttonTinh.Name = "buttonTinh";
            this.buttonTinh.Size = new System.Drawing.Size(99, 56);
            this.buttonTinh.TabIndex = 2;
            this.buttonTinh.Text = "TÍNH";
            this.buttonTinh.UseVisualStyleBackColor = true;
            this.buttonTinh.Click += new System.EventHandler(this.buttonTinh_Click);
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(157, 72);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(148, 20);
            this.textN.TabIndex = 3;
            this.textN.TextChanged += new System.EventHandler(this.textN_TextChanged);
            // 
            // textS
            // 
            this.textS.Location = new System.Drawing.Point(157, 117);
            this.textS.Name = "textS";
            this.textS.Size = new System.Drawing.Size(148, 20);
            this.textS.TabIndex = 4;
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
            this.Text = "CẤU TRÚC LẶP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTinh;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textS;
    }
}

