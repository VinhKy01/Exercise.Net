namespace bai9
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mởFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraSốHoànHảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFormToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mởFormToolStripMenuItem
            // 
            this.mởFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraSốHoànHảoToolStripMenuItem,
            this.tạoMảngToolStripMenuItem});
            this.mởFormToolStripMenuItem.Name = "mởFormToolStripMenuItem";
            this.mởFormToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.mởFormToolStripMenuItem.Text = "Mở Form";
            // 
            // kiểmTraSốHoànHảoToolStripMenuItem
            // 
            this.kiểmTraSốHoànHảoToolStripMenuItem.Name = "kiểmTraSốHoànHảoToolStripMenuItem";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.kiểmTraSốHoànHảoToolStripMenuItem.Text = "Kiểm tra số hoàn hảo";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraSốHoànHảoToolStripMenuItem_Click);
            // 
            // tạoMảngToolStripMenuItem
            // 
            this.tạoMảngToolStripMenuItem.Name = "tạoMảngToolStripMenuItem";
            this.tạoMảngToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tạoMảngToolStripMenuItem.Text = "Tạo mảng";
            this.tạoMảngToolStripMenuItem.Click += new System.EventHandler(this.tạoMảngToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số N:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(189, 38);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(137, 20);
            this.txtN.TabIndex = 3;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.Location = new System.Drawing.Point(10, 74);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(170, 28);
            this.btnKiemTra.TabIndex = 4;
            this.btnKiemTra.Text = "Kiểm tra số hoàn hảo";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMang.Location = new System.Drawing.Point(206, 74);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(170, 28);
            this.btnTaoMang.TabIndex = 4;
            this.btnTaoMang.Text = "Tạo mạng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Enabled = false;
            this.btnLamLai.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.Location = new System.Drawing.Point(43, 108);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(104, 28);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(235, 108);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 28);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 152);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mởFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraSốHoànHảoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

