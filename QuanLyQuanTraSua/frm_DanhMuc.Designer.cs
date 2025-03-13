
namespace QuanLyQuanTraSua
{
    partial class frm_DanhMuc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btn_EditCategory = new System.Windows.Forms.Button();
            this.btn_DeleteCategory = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgv_Category = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel17);
            this.splitContainer1.Panel1.Controls.Add(this.panel12);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgv_Category);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1020, 533);
            this.splitContainer1.SplitterDistance = 429;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.btn_EditCategory);
            this.panel17.Controls.Add(this.btn_DeleteCategory);
            this.panel17.Controls.Add(this.btn_AddCategory);
            this.panel17.Location = new System.Drawing.Point(241, 282);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(141, 197);
            this.panel17.TabIndex = 8;
            // 
            // btn_EditCategory
            // 
            this.btn_EditCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EditCategory.Location = new System.Drawing.Point(31, 76);
            this.btn_EditCategory.Name = "btn_EditCategory";
            this.btn_EditCategory.Size = new System.Drawing.Size(90, 36);
            this.btn_EditCategory.TabIndex = 2;
            this.btn_EditCategory.Text = "Sửa";
            this.btn_EditCategory.UseVisualStyleBackColor = true;
            this.btn_EditCategory.Click += new System.EventHandler(this.btn_EditCategory_Click);
            // 
            // btn_DeleteCategory
            // 
            this.btn_DeleteCategory.Location = new System.Drawing.Point(31, 128);
            this.btn_DeleteCategory.Name = "btn_DeleteCategory";
            this.btn_DeleteCategory.Size = new System.Drawing.Size(90, 40);
            this.btn_DeleteCategory.TabIndex = 1;
            this.btn_DeleteCategory.Text = "Xóa";
            this.btn_DeleteCategory.UseVisualStyleBackColor = true;
            this.btn_DeleteCategory.Click += new System.EventHandler(this.btn_DeleteCategory_Click);
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.Location = new System.Drawing.Point(31, 16);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(90, 43);
            this.btn_AddCategory.TabIndex = 0;
            this.btn_AddCategory.Text = "Thêm";
            this.btn_AddCategory.UseVisualStyleBackColor = true;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Controls.Add(this.panel16);
            this.panel12.Location = new System.Drawing.Point(12, 12);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(398, 143);
            this.panel12.TabIndex = 7;
            // 
            // panel15
            // 
            this.panel15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel15.Controls.Add(this.txt_CategoryName);
            this.panel15.Controls.Add(this.label9);
            this.panel15.Location = new System.Drawing.Point(3, 59);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(367, 50);
            this.panel15.TabIndex = 2;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Location = new System.Drawing.Point(128, 14);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(216, 22);
            this.txt_CategoryName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên danh mục:";
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.Controls.Add(this.txt_CategoryID);
            this.panel16.Controls.Add(this.label10);
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(367, 50);
            this.panel16.TabIndex = 1;
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.Location = new System.Drawing.Point(128, 14);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.ReadOnly = true;
            this.txt_CategoryID.Size = new System.Drawing.Size(216, 22);
            this.txt_CategoryID.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // dtgv_Category
            // 
            this.dtgv_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Category.Location = new System.Drawing.Point(20, 71);
            this.dtgv_Category.Name = "dtgv_Category";
            this.dtgv_Category.RowHeadersWidth = 51;
            this.dtgv_Category.RowTemplate.Height = 24;
            this.dtgv_Category.Size = new System.Drawing.Size(542, 422);
            this.dtgv_Category.TabIndex = 0;
            this.dtgv_Category.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_Category_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh sách danh mục đồ uống";
            // 
            // frm_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1020, 533);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_DanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đồ uống";
            this.Load += new System.EventHandler(this.frm_DanhMuc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txt_CategoryID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btn_EditCategory;
        private System.Windows.Forms.Button btn_DeleteCategory;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_Category;
    }
}