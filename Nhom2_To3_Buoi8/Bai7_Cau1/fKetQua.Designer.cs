namespace Bai7_Cau1
{
    partial class fKetQua
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
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(120, 96);
            this.txtDT.Margin = new System.Windows.Forms.Padding(5);
            this.txtDT.Name = "txtDT";
            this.txtDT.ReadOnly = true;
            this.txtDT.Size = new System.Drawing.Size(233, 26);
            this.txtDT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diện tích";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(120, 61);
            this.txtCV.Margin = new System.Windows.Forms.Padding(5);
            this.txtCV.Name = "txtCV";
            this.txtCV.ReadOnly = true;
            this.txtCV.Size = new System.Drawing.Size(233, 26);
            this.txtCV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chu vi";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.Location = new System.Drawing.Point(38, 21);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(205, 23);
            this.lbTitle.TabIndex = 11;
            this.lbTitle.Text = "Chu vi - Diện tích hình ";
            // 
            // fKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 143);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fKetQua";
            this.Text = "fKetQua";
            this.Load += new System.EventHandler(this.fKetQua_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTitle;
    }
}