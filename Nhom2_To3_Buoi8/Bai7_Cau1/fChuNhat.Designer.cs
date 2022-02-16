namespace Bai7_Cau1
{
    partial class fChuNhat
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
            this.txtDai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(116, 44);
            this.txtDai.Margin = new System.Windows.Forms.Padding(5);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(233, 25);
            this.txtDai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chiều dài";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chiều rộng";
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(116, 79);
            this.txtRong.Margin = new System.Windows.Forms.Padding(5);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(233, 25);
            this.txtRong.TabIndex = 2;
            // 
            // fChuNhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 148);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fChuNhat";
            this.Text = "fChuNhat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDai;
        public System.Windows.Forms.TextBox txtRong;
    }
}