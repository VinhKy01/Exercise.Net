
namespace Bai3._4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textday = new System.Windows.Forms.TextBox();
            this.textmonth = new System.Windows.Forms.TextBox();
            this.textyear = new System.Windows.Forms.TextBox();
            this.buttonkiemtra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KIỂM TRA NGÀY HỢP LỆ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textyear);
            this.groupBox1.Controls.Add(this.textmonth);
            this.groupBox1.Controls.Add(this.textday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(66, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NGÀY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "THÁNG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "NĂM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textday
            // 
            this.textday.Location = new System.Drawing.Point(135, 36);
            this.textday.Name = "textday";
            this.textday.Size = new System.Drawing.Size(163, 22);
            this.textday.TabIndex = 3;
            // 
            // textmonth
            // 
            this.textmonth.Location = new System.Drawing.Point(135, 75);
            this.textmonth.Name = "textmonth";
            this.textmonth.Size = new System.Drawing.Size(163, 22);
            this.textmonth.TabIndex = 4;
            // 
            // textyear
            // 
            this.textyear.Location = new System.Drawing.Point(135, 112);
            this.textyear.Name = "textyear";
            this.textyear.Size = new System.Drawing.Size(163, 22);
            this.textyear.TabIndex = 5;
            // 
            // buttonkiemtra
            // 
            this.buttonkiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonkiemtra.Location = new System.Drawing.Point(190, 235);
            this.buttonkiemtra.Name = "buttonkiemtra";
            this.buttonkiemtra.Size = new System.Drawing.Size(96, 37);
            this.buttonkiemtra.TabIndex = 2;
            this.buttonkiemtra.Text = "KIỂM TRA";
            this.buttonkiemtra.UseVisualStyleBackColor = true;
            this.buttonkiemtra.Click += new System.EventHandler(this.buttonkiemtra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 284);
            this.Controls.Add(this.buttonkiemtra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bai3.4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textyear;
        private System.Windows.Forms.TextBox textmonth;
        private System.Windows.Forms.TextBox textday;
        private System.Windows.Forms.Button buttonkiemtra;
    }
}

