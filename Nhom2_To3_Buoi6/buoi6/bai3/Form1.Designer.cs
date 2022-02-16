
namespace bai3
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
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.btnOpenList = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // showPictureBox
            // 
            this.showPictureBox.Location = new System.Drawing.Point(-3, 0);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(608, 310);
            this.showPictureBox.TabIndex = 0;
            this.showPictureBox.TabStop = false;
            // 
            // btnOpenList
            // 
            this.btnOpenList.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenList.Location = new System.Drawing.Point(216, 327);
            this.btnOpenList.Name = "btnOpenList";
            this.btnOpenList.Size = new System.Drawing.Size(156, 34);
            this.btnOpenList.TabIndex = 1;
            this.btnOpenList.Text = "Mo danh sach hinh";
            this.btnOpenList.UseVisualStyleBackColor = true;
            this.btnOpenList.Click += new System.EventHandler(this.btnOpenList_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(399, 327);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(156, 34);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Sau >>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBefore
            // 
            this.btnBefore.Enabled = false;
            this.btnBefore.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBefore.Location = new System.Drawing.Point(33, 327);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(156, 34);
            this.btnBefore.TabIndex = 1;
            this.btnBefore.Text = "<< Truoc";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(116, 383);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(156, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bat dau";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(320, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 429);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnOpenList);
            this.Controls.Add(this.showPictureBox);
            this.Name = "Form1";
            this.Text = "Trinh xem anh";
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox showPictureBox;
        private System.Windows.Forms.Button btnOpenList;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
    }
}

