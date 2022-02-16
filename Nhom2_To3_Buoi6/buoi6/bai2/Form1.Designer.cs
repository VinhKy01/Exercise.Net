
namespace bai2
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
            this.treeViewPicture = new System.Windows.Forms.TreeView();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.PicflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewPicture
            // 
            this.treeViewPicture.Location = new System.Drawing.Point(12, 12);
            this.treeViewPicture.Name = "treeViewPicture";
            this.treeViewPicture.Size = new System.Drawing.Size(241, 406);
            this.treeViewPicture.TabIndex = 0;
            this.treeViewPicture.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewPicture_BeforeExpand);
            this.treeViewPicture.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPicture_AfterSelect);
            // 
            // showPictureBox
            // 
            this.showPictureBox.Location = new System.Drawing.Point(307, 12);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(437, 206);
            this.showPictureBox.TabIndex = 1;
            this.showPictureBox.TabStop = false;
            // 
            // PicflowLayoutPanel
            // 
            this.PicflowLayoutPanel.Location = new System.Drawing.Point(259, 224);
            this.PicflowLayoutPanel.Name = "PicflowLayoutPanel";
            this.PicflowLayoutPanel.Size = new System.Drawing.Size(532, 194);
            this.PicflowLayoutPanel.TabIndex = 2;
            this.PicflowLayoutPanel.Click += new System.EventHandler(this.PicflowLayoutPanel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 430);
            this.Controls.Add(this.PicflowLayoutPanel);
            this.Controls.Add(this.showPictureBox);
            this.Controls.Add(this.treeViewPicture);
            this.Name = "Form1";
            this.Text = "Hien thi anh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewPicture;
        private System.Windows.Forms.PictureBox showPictureBox;
        private System.Windows.Forms.FlowLayoutPanel PicflowLayoutPanel;
    }
}

