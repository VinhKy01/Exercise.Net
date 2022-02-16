namespace fLogin
{
    partial class fManager
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
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSearchMng = new System.Windows.Forms.Button();
            this.cbbKichThuoc = new System.Windows.Forms.ComboBox();
            this.cbbHangTV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numTv = new System.Windows.Forms.NumericUpDown();
            this.txtInsurance = new System.Windows.Forms.TextBox();
            this.txtPriceTV = new System.Windows.Forms.TextBox();
            this.txtModelTV = new System.Windows.Forms.TextBox();
            this.btnAddMng = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvListBillMng = new System.Windows.Forms.DataGridView();
            this.numSale = new System.Windows.Forms.NumericUpDown();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnDelBill = new System.Windows.Forms.Button();
            this.btnPayMng = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnTrịViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExitMng = new System.Windows.Forms.Button();
            this.dtgvListTiviMng = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTv)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBillMng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTiviMng)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchName);
            this.groupBox1.Controls.Add(this.btnSearchByName);
            this.groupBox1.Controls.Add(this.btnSearchMng);
            this.groupBox1.Controls.Add(this.cbbKichThuoc);
            this.groupBox1.Controls.Add(this.cbbHangTV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(99, 81);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(130, 22);
            this.txtSearchName.TabIndex = 3;
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(235, 79);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(64, 27);
            this.btnSearchByName.TabIndex = 2;
            this.btnSearchByName.Text = "Tìm";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSearchMng
            // 
            this.btnSearchMng.Location = new System.Drawing.Point(235, 23);
            this.btnSearchMng.Name = "btnSearchMng";
            this.btnSearchMng.Size = new System.Drawing.Size(64, 52);
            this.btnSearchMng.TabIndex = 2;
            this.btnSearchMng.Text = "Tìm kiếm";
            this.btnSearchMng.UseVisualStyleBackColor = true;
            this.btnSearchMng.Click += new System.EventHandler(this.btnSearchMng_Click);
            // 
            // cbbKichThuoc
            // 
            this.cbbKichThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKichThuoc.FormattingEnabled = true;
            this.cbbKichThuoc.Location = new System.Drawing.Point(99, 52);
            this.cbbKichThuoc.Name = "cbbKichThuoc";
            this.cbbKichThuoc.Size = new System.Drawing.Size(130, 23);
            this.cbbKichThuoc.TabIndex = 1;
            // 
            // cbbHangTV
            // 
            this.cbbHangTV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbHangTV.FormattingEnabled = true;
            this.cbbHangTV.Location = new System.Drawing.Point(99, 23);
            this.cbbHangTV.Name = "cbbHangTV";
            this.cbbHangTV.Size = new System.Drawing.Size(130, 23);
            this.cbbHangTV.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kích thước";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thương hiệu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numTv);
            this.groupBox2.Controls.Add(this.txtInsurance);
            this.groupBox2.Controls.Add(this.txtPriceTV);
            this.groupBox2.Controls.Add(this.txtModelTV);
            this.groupBox2.Controls.Add(this.btnAddMng);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(24, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // numTv
            // 
            this.numTv.Location = new System.Drawing.Point(85, 112);
            this.numTv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTv.Name = "numTv";
            this.numTv.Size = new System.Drawing.Size(55, 22);
            this.numTv.TabIndex = 4;
            this.numTv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtInsurance
            // 
            this.txtInsurance.Location = new System.Drawing.Point(83, 79);
            this.txtInsurance.Name = "txtInsurance";
            this.txtInsurance.ReadOnly = true;
            this.txtInsurance.Size = new System.Drawing.Size(216, 22);
            this.txtInsurance.TabIndex = 3;
            // 
            // txtPriceTV
            // 
            this.txtPriceTV.Location = new System.Drawing.Point(83, 51);
            this.txtPriceTV.Name = "txtPriceTV";
            this.txtPriceTV.ReadOnly = true;
            this.txtPriceTV.Size = new System.Drawing.Size(216, 22);
            this.txtPriceTV.TabIndex = 3;
            // 
            // txtModelTV
            // 
            this.txtModelTV.Location = new System.Drawing.Point(83, 24);
            this.txtModelTV.Name = "txtModelTV";
            this.txtModelTV.ReadOnly = true;
            this.txtModelTV.Size = new System.Drawing.Size(216, 22);
            this.txtModelTV.TabIndex = 3;
            // 
            // btnAddMng
            // 
            this.btnAddMng.Location = new System.Drawing.Point(170, 107);
            this.btnAddMng.Name = "btnAddMng";
            this.btnAddMng.Size = new System.Drawing.Size(129, 36);
            this.btnAddMng.TabIndex = 2;
            this.btnAddMng.Text = "Thêm vào giỏ hàng";
            this.btnAddMng.UseVisualStyleBackColor = true;
            this.btnAddMng.Click += new System.EventHandler(this.btnAddMng_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số lượng: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bảo hành:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Model:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvListBillMng);
            this.groupBox3.Controls.Add(this.numSale);
            this.groupBox3.Controls.Add(this.btnSale);
            this.groupBox3.Controls.Add(this.btnDelBill);
            this.groupBox3.Controls.Add(this.btnPayMng);
            this.groupBox3.Controls.Add(this.txtTotalPrice);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(26, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(914, 144);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // dtgvListBillMng
            // 
            this.dtgvListBillMng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListBillMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListBillMng.Location = new System.Drawing.Point(18, 26);
            this.dtgvListBillMng.Name = "dtgvListBillMng";
            this.dtgvListBillMng.Size = new System.Drawing.Size(624, 104);
            this.dtgvListBillMng.TabIndex = 4;
            this.dtgvListBillMng.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListBillMng_CellClick);
            this.dtgvListBillMng.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgvListBillMng_RowsAdded);
            this.dtgvListBillMng.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtgvListBillMng_RowsRemoved);
            // 
            // numSale
            // 
            this.numSale.Location = new System.Drawing.Point(739, 63);
            this.numSale.Name = "numSale";
            this.numSale.Size = new System.Drawing.Size(69, 22);
            this.numSale.TabIndex = 4;
            this.numSale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(814, 58);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(91, 29);
            this.btnSale.TabIndex = 2;
            this.btnSale.Text = "Áp dụng";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnDelBill
            // 
            this.btnDelBill.Location = new System.Drawing.Point(739, 98);
            this.btnDelBill.Name = "btnDelBill";
            this.btnDelBill.Size = new System.Drawing.Size(67, 32);
            this.btnDelBill.TabIndex = 2;
            this.btnDelBill.Text = "Xóa";
            this.btnDelBill.UseVisualStyleBackColor = true;
            this.btnDelBill.Click += new System.EventHandler(this.btnDelBill_Click);
            // 
            // btnPayMng
            // 
            this.btnPayMng.Location = new System.Drawing.Point(814, 98);
            this.btnPayMng.Name = "btnPayMng";
            this.btnPayMng.Size = new System.Drawing.Size(91, 32);
            this.btnPayMng.TabIndex = 2;
            this.btnPayMng.Text = "Thanh toán";
            this.btnPayMng.UseVisualStyleBackColor = true;
            this.btnPayMng.Click += new System.EventHandler(this.btnPayMng_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(739, 26);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(169, 22);
            this.txtTotalPrice.TabIndex = 3;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 15);
            this.label10.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(648, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thành tiền:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(648, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Khuyến mãi:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnTrịViênToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnTrịViênToolStripMenuItem
            // 
            this.quảnTrịViênToolStripMenuItem.Name = "quảnTrịViênToolStripMenuItem";
            this.quảnTrịViênToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.quảnTrịViênToolStripMenuItem.Text = "Quản trị viên";
            this.quảnTrịViênToolStripMenuItem.Click += new System.EventHandler(this.quảnTrịViênToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // btnExitMng
            // 
            this.btnExitMng.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExitMng.Location = new System.Drawing.Point(875, 7);
            this.btnExitMng.Name = "btnExitMng";
            this.btnExitMng.Size = new System.Drawing.Size(63, 24);
            this.btnExitMng.TabIndex = 3;
            this.btnExitMng.Text = "Thoát";
            this.btnExitMng.UseVisualStyleBackColor = true;
            this.btnExitMng.Click += new System.EventHandler(this.btnExitMng_Click);
            // 
            // dtgvListTiviMng
            // 
            this.dtgvListTiviMng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListTiviMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListTiviMng.Location = new System.Drawing.Point(340, 37);
            this.dtgvListTiviMng.Name = "dtgvListTiviMng";
            this.dtgvListTiviMng.Size = new System.Drawing.Size(600, 271);
            this.dtgvListTiviMng.TabIndex = 4;
            this.dtgvListTiviMng.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListTiviMng_CellClick);
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReload.Location = new System.Drawing.Point(806, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(63, 24);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 470);
            this.Controls.Add(this.dtgvListTiviMng);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnExitMng);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng Tivi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fManager_FormClosing);
            this.Load += new System.EventHandler(this.fManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListBillMng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSale)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTiviMng)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchMng;
        private System.Windows.Forms.ComboBox cbbHangTV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInsurance;
        private System.Windows.Forms.TextBox txtPriceTV;
        private System.Windows.Forms.TextBox txtModelTV;
        private System.Windows.Forms.Button btnAddMng;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numSale;
        private System.Windows.Forms.Button btnPayMng;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnTrịViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnExitMng;
        private System.Windows.Forms.DataGridView dtgvListTiviMng;
        private System.Windows.Forms.DataGridView dtgvListBillMng;
        private System.Windows.Forms.ComboBox cbbKichThuoc;
        private System.Windows.Forms.Button btnDelBill;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numTv;
        private System.Windows.Forms.Label label13;
    }
}