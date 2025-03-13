
namespace QuanLyQuanTraSua
{
    partial class frm_TrangChu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.cbx_Food = new System.Windows.Forms.ComboBox();
            this.cbx_Category = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.đồUốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.bànĂnToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.doanhThuToolStripMenuItem.Text = "Thống kê";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // đồUốngToolStripMenuItem
            // 
            this.đồUốngToolStripMenuItem.Name = "đồUốngToolStripMenuItem";
            this.đồUốngToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.đồUốngToolStripMenuItem.Text = "Đồ uống";
            this.đồUốngToolStripMenuItem.Click += new System.EventHandler(this.đồUốngToolStripMenuItem_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.danhMụcToolStripMenuItem.Text = "Danh mục đồ uống";
            this.danhMụcToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // bànĂnToolStripMenuItem
            // 
            this.bànĂnToolStripMenuItem.Name = "bànĂnToolStripMenuItem";
            this.bànĂnToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.bànĂnToolStripMenuItem.Text = "Bàn ăn";
            this.bànĂnToolStripMenuItem.Click += new System.EventHandler(this.bànĂnToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(649, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 338);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(0, 2);
            this.lsvBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(543, 336);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.List;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_TongTien);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btn_CheckOut);
            this.panel3.Location = new System.Drawing.Point(649, 449);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 120);
            this.panel3.TabIndex = 3;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(83, 64);
            this.txt_TongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(205, 22);
            this.txt_TongTien.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng thành tiền:";
            // 
            // btn_CheckOut
            // 
            this.btn_CheckOut.Location = new System.Drawing.Point(374, 21);
            this.btn_CheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CheckOut.Name = "btn_CheckOut";
            this.btn_CheckOut.Size = new System.Drawing.Size(91, 65);
            this.btn_CheckOut.TabIndex = 3;
            this.btn_CheckOut.Text = "Thanh toán";
            this.btn_CheckOut.UseVisualStyleBackColor = true;
            this.btn_CheckOut.Click += new System.EventHandler(this.btn_CheckOut_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.btn_AddFood);
            this.panel4.Controls.Add(this.cbx_Food);
            this.panel4.Controls.Add(this.cbx_Category);
            this.panel4.Location = new System.Drawing.Point(649, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(518, 70);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh mục:";
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(430, 32);
            this.nmFoodCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(53, 22);
            this.nmFoodCount.TabIndex = 3;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(307, 3);
            this.btn_AddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(91, 55);
            this.btn_AddFood.TabIndex = 2;
            this.btn_AddFood.Text = "Thêm món";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click_1);
            // 
            // cbx_Food
            // 
            this.cbx_Food.FormattingEnabled = true;
            this.cbx_Food.Location = new System.Drawing.Point(83, 34);
            this.cbx_Food.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Food.Name = "cbx_Food";
            this.cbx_Food.Size = new System.Drawing.Size(205, 24);
            this.cbx_Food.TabIndex = 1;
            // 
            // cbx_Category
            // 
            this.cbx_Category.FormattingEnabled = true;
            this.cbx_Category.Location = new System.Drawing.Point(83, 2);
            this.cbx_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.Size = new System.Drawing.Size(205, 24);
            this.cbx_Category.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 34);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(631, 535);
            this.flpTable.TabIndex = 5;
            // 
            // btn_refesh
            // 
            this.btn_refesh.BackColor = System.Drawing.Color.Wheat;
            this.btn_refesh.FlatAppearance.BorderColor = System.Drawing.Color.NavajoWhite;
            this.btn_refesh.FlatAppearance.BorderSize = 0;
            this.btn_refesh.Location = new System.Drawing.Point(251, 0);
            this.btn_refesh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(88, 28);
            this.btn_refesh.TabIndex = 6;
            this.btn_refesh.Text = "Làm mới";
            this.btn_refesh.UseVisualStyleBackColor = false;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1207, 628);
            this.Controls.Add(this.btn_refesh);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_TrangChu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý quán trà sữa";
            this.Load += new System.EventHandler(this.frm_TrangChu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.ComboBox cbx_Food;
        private System.Windows.Forms.ComboBox cbx_Category;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btn_CheckOut;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồUốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànĂnToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Button btn_refesh;
    }
}