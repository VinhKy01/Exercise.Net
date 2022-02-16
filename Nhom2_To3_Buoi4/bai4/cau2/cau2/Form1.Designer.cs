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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRemake = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtOuput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(247, 213);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 42);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Thoat";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRemake
            // 
            this.btnRemake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRemake.Location = new System.Drawing.Point(73, 213);
            this.btnRemake.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemake.Name = "btnRemake";
            this.btnRemake.Size = new System.Drawing.Size(138, 42);
            this.btnRemake.TabIndex = 11;
            this.btnRemake.Text = "Lam lai";
            this.btnRemake.UseVisualStyleBackColor = true;
            this.btnRemake.Click += new System.EventHandler(this.btnRemake_Click);
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtShow.Location = new System.Drawing.Point(150, 161);
            this.txtShow.Margin = new System.Windows.Forms.Padding(6);
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(275, 26);
            this.txtShow.TabIndex = 10;
            // 
            // txtOuput
            // 
            this.txtOuput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOuput.Location = new System.Drawing.Point(150, 83);
            this.txtOuput.Margin = new System.Windows.Forms.Padding(6);
            this.txtOuput.Name = "txtOuput";
            this.txtOuput.Size = new System.Drawing.Size(275, 26);
            this.txtOuput.TabIndex = 7;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInput.Location = new System.Drawing.Point(150, 9);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(275, 26);
            this.txtInput.TabIndex = 5;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cac SHH < N:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kiem tra N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhap N: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 291);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRemake);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtOuput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "So hoan hao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemake;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtOuput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

