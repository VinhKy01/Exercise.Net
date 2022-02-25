
namespace bai5
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
            this.nmSize = new System.Windows.Forms.NumericUpDown();
            this.btnChoseColorBorder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChoseColorFill = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChoseType = new System.Windows.Forms.ComboBox();
            this.Panel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSize)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nmSize);
            this.groupBox1.Controls.Add(this.btnChoseColorBorder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // nmSize
            // 
            this.nmSize.Location = new System.Drawing.Point(84, 130);
            this.nmSize.Name = "nmSize";
            this.nmSize.Size = new System.Drawing.Size(125, 26);
            this.nmSize.TabIndex = 0;
            // 
            // btnChoseColorBorder
            // 
            this.btnChoseColorBorder.Location = new System.Drawing.Point(84, 54);
            this.btnChoseColorBorder.Name = "btnChoseColorBorder";
            this.btnChoseColorBorder.Size = new System.Drawing.Size(125, 29);
            this.btnChoseColorBorder.TabIndex = 0;
            this.btnChoseColorBorder.UseVisualStyleBackColor = true;
            this.btnChoseColorBorder.Click += new System.EventHandler(this.btnChoseColorBorder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChoseColorFill);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 79);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fill";
            // 
            // btnChoseColorFill
            // 
            this.btnChoseColorFill.Location = new System.Drawing.Point(84, 34);
            this.btnChoseColorFill.Name = "btnChoseColorFill";
            this.btnChoseColorFill.Size = new System.Drawing.Size(125, 29);
            this.btnChoseColorFill.TabIndex = 0;
            this.btnChoseColorFill.UseVisualStyleBackColor = true;
            this.btnChoseColorFill.Click += new System.EventHandler(this.btnChoseColorFill_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "chon hinh ve";
            // 
            // cbChoseType
            // 
            this.cbChoseType.FormattingEnabled = true;
            this.cbChoseType.Items.AddRange(new object[] {
            "Duong thang",
            "Hinh Ellipse rong",
            "Hinh Ellipse day",
            "Hinh Vuong rong",
            "Hinh Vuong day"});
            this.cbChoseType.Location = new System.Drawing.Point(12, 48);
            this.cbChoseType.Name = "cbChoseType";
            this.cbChoseType.Size = new System.Drawing.Size(226, 21);
            this.cbChoseType.TabIndex = 2;
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(256, 42);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(364, 324);
            this.Panel.TabIndex = 3;
            this.Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseDown);
            this.Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseMove);
            this.Panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 396);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.cbChoseType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ve hinh co ban";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSize)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmSize;
        private System.Windows.Forms.Button btnChoseColorBorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChoseColorFill;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbChoseType;
        private System.Windows.Forms.Panel Panel;
    }
}

