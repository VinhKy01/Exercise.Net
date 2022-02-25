namespace cau1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnRemake = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap N: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kiem tra N:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cac SNT < N:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(190, 38);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(249, 29);
            this.txtInput.TabIndex = 0;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtOuput
            // 
            this.txtOuput.Location = new System.Drawing.Point(190, 112);
            this.txtOuput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.Size = new System.Drawing.Size(249, 29);
            this.txtOuput.TabIndex = 1;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(190, 190);
            this.txtShow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(249, 29);
            this.txtShow.TabIndex = 2;
            // 
            // btnRemake
            // 
            this.btnRemake.Location = new System.Drawing.Point(57, 269);
            this.btnRemake.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemake.Name = "btnRemake";
            this.btnRemake.Size = new System.Drawing.Size(138, 42);
            this.btnRemake.TabIndex = 3;
            this.btnRemake.Text = "Lam lai";
            this.btnRemake.UseVisualStyleBackColor = true;
            this.btnRemake.Click += new System.EventHandler(this.btnRemake_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(266, 269);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 364);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemake);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "So nguyen to";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOuput;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnRemake;
        private System.Windows.Forms.Button btnExit;
    }
}

