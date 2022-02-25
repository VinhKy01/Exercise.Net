
namespace cau6
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbMin = new System.Windows.Forms.RadioButton();
            this.rdbXuat = new System.Windows.Forms.RadioButton();
            this.rdbChanCuoi = new System.Windows.Forms.RadioButton();
            this.rdbLietKeChan = new System.Windows.Forms.RadioButton();
            this.rdbSoGTChan = new System.Windows.Forms.RadioButton();
            this.rdbTongChan = new System.Windows.Forms.RadioButton();
            this.rdbSoGTLe = new System.Windows.Forms.RadioButton();
            this.rdbTongLe = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(41, 145);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(674, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ket qua";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(26, 27);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(626, 39);
            this.txtOutput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(41, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(674, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mang";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(26, 34);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(626, 39);
            this.txtInput.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbMin);
            this.groupBox3.Controls.Add(this.rdbXuat);
            this.groupBox3.Controls.Add(this.rdbChanCuoi);
            this.groupBox3.Controls.Add(this.rdbLietKeChan);
            this.groupBox3.Controls.Add(this.rdbSoGTChan);
            this.groupBox3.Controls.Add(this.rdbTongChan);
            this.groupBox3.Controls.Add(this.rdbSoGTLe);
            this.groupBox3.Controls.Add(this.rdbTongLe);
            this.groupBox3.Location = new System.Drawing.Point(41, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 243);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chon thao tac";
            // 
            // rdbMin
            // 
            this.rdbMin.AutoSize = true;
            this.rdbMin.Location = new System.Drawing.Point(38, 94);
            this.rdbMin.Name = "rdbMin";
            this.rdbMin.Size = new System.Drawing.Size(235, 24);
            this.rdbMin.TabIndex = 0;
            this.rdbMin.TabStop = true;
            this.rdbMin.Text = "Tìm giá trị nhỏ nhất của mảng";
            this.rdbMin.UseVisualStyleBackColor = true;
            // 
            // rdbXuat
            // 
            this.rdbXuat.AutoSize = true;
            this.rdbXuat.Location = new System.Drawing.Point(38, 41);
            this.rdbXuat.Name = "rdbXuat";
            this.rdbXuat.Size = new System.Drawing.Size(257, 24);
            this.rdbXuat.TabIndex = 0;
            this.rdbXuat.TabStop = true;
            this.rdbXuat.Text = "Nhập và xuất mảng lên màn hình";
            this.rdbXuat.UseVisualStyleBackColor = true;
            // 
            // rdbChanCuoi
            // 
            this.rdbChanCuoi.AutoSize = true;
            this.rdbChanCuoi.Location = new System.Drawing.Point(38, 200);
            this.rdbChanCuoi.Name = "rdbChanCuoi";
            this.rdbChanCuoi.Size = new System.Drawing.Size(269, 24);
            this.rdbChanCuoi.TabIndex = 0;
            this.rdbChanCuoi.TabStop = true;
            this.rdbChanCuoi.Text = "Tìm số chẵn cuối cùng trong mảng";
            this.rdbChanCuoi.UseVisualStyleBackColor = true;
            // 
            // rdbLietKeChan
            // 
            this.rdbLietKeChan.AutoSize = true;
            this.rdbLietKeChan.Location = new System.Drawing.Point(38, 147);
            this.rdbLietKeChan.Name = "rdbLietKeChan";
            this.rdbLietKeChan.Size = new System.Drawing.Size(269, 24);
            this.rdbLietKeChan.TabIndex = 0;
            this.rdbLietKeChan.TabStop = true;
            this.rdbLietKeChan.Text = "Liệt kê các giá trị chẵn trong mảng";
            this.rdbLietKeChan.UseVisualStyleBackColor = true;
            // 
            // rdbSoGTChan
            // 
            this.rdbSoGTChan.AutoSize = true;
            this.rdbSoGTChan.Location = new System.Drawing.Point(349, 147);
            this.rdbSoGTChan.Name = "rdbSoGTChan";
            this.rdbSoGTChan.Size = new System.Drawing.Size(320, 24);
            this.rdbSoGTChan.TabIndex = 0;
            this.rdbSoGTChan.TabStop = true;
            this.rdbSoGTChan.Text = "Đếm số lượng các giá trị chẵn trong mảng";
            this.rdbSoGTChan.UseVisualStyleBackColor = true;
            // 
            // rdbTongChan
            // 
            this.rdbTongChan.AutoSize = true;
            this.rdbTongChan.Location = new System.Drawing.Point(349, 94);
            this.rdbTongChan.Name = "rdbTongChan";
            this.rdbTongChan.Size = new System.Drawing.Size(288, 24);
            this.rdbTongChan.TabIndex = 0;
            this.rdbTongChan.TabStop = true;
            this.rdbTongChan.Text = "Tính tổng các giá trị chẵn trong mảng";
            this.rdbTongChan.UseVisualStyleBackColor = true;
            // 
            // rdbSoGTLe
            // 
            this.rdbSoGTLe.AutoSize = true;
            this.rdbSoGTLe.Location = new System.Drawing.Point(349, 200);
            this.rdbSoGTLe.Name = "rdbSoGTLe";
            this.rdbSoGTLe.Size = new System.Drawing.Size(297, 24);
            this.rdbSoGTLe.TabIndex = 0;
            this.rdbSoGTLe.TabStop = true;
            this.rdbSoGTLe.Text = "Đếm số lượng các giá trị lẻ trong mảng";
            this.rdbSoGTLe.UseVisualStyleBackColor = true;
            // 
            // rdbTongLe
            // 
            this.rdbTongLe.AutoSize = true;
            this.rdbTongLe.Location = new System.Drawing.Point(349, 41);
            this.rdbTongLe.Name = "rdbTongLe";
            this.rdbTongLe.Size = new System.Drawing.Size(265, 24);
            this.rdbTongLe.TabIndex = 0;
            this.rdbTongLe.TabStop = true;
            this.rdbTongLe.Text = "Tính tổng các giá trị lẻ trong mảng";
            this.rdbTongLe.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thuc hien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 522);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Thoat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Thao tac mang";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbMin;
        private System.Windows.Forms.RadioButton rdbXuat;
        private System.Windows.Forms.RadioButton rdbChanCuoi;
        private System.Windows.Forms.RadioButton rdbLietKeChan;
        private System.Windows.Forms.RadioButton rdbSoGTChan;
        private System.Windows.Forms.RadioButton rdbTongChan;
        private System.Windows.Forms.RadioButton rdbSoGTLe;
        private System.Windows.Forms.RadioButton rdbTongLe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

