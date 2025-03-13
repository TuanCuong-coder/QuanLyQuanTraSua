
namespace QuanLyQuanTraSua
{
    partial class frm_DoUong
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
            this.btn_SearchFood = new System.Windows.Forms.Button();
            this.txt_SearchFood = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_EditFood = new System.Windows.Forms.Button();
            this.btn_DeleteFood = new System.Windows.Forms.Button();
            this.btn_AddFood = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbx_FoodCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_FoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_FoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgv_Food = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Food)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_SearchFood);
            this.splitContainer1.Panel1.Controls.Add(this.txt_SearchFood);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.panel5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgv_Food);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 627);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_SearchFood
            // 
            this.btn_SearchFood.Location = new System.Drawing.Point(24, 83);
            this.btn_SearchFood.Name = "btn_SearchFood";
            this.btn_SearchFood.Size = new System.Drawing.Size(84, 31);
            this.btn_SearchFood.TabIndex = 6;
            this.btn_SearchFood.Text = "Tìm kiếm";
            this.btn_SearchFood.UseVisualStyleBackColor = true;
            this.btn_SearchFood.Click += new System.EventHandler(this.btn_SearchFood_Click);
            // 
            // txt_SearchFood
            // 
            this.txt_SearchFood.Location = new System.Drawing.Point(24, 45);
            this.txt_SearchFood.Name = "txt_SearchFood";
            this.txt_SearchFood.Size = new System.Drawing.Size(291, 22);
            this.txt_SearchFood.TabIndex = 5;
            this.txt_SearchFood.TextChanged += new System.EventHandler(this.txt_SearchFood_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm đồ uống";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_EditFood);
            this.panel4.Controls.Add(this.btn_DeleteFood);
            this.panel4.Controls.Add(this.btn_AddFood);
            this.panel4.Location = new System.Drawing.Point(231, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(104, 163);
            this.panel4.TabIndex = 2;
            // 
            // btn_EditFood
            // 
            this.btn_EditFood.Location = new System.Drawing.Point(7, 53);
            this.btn_EditFood.Name = "btn_EditFood";
            this.btn_EditFood.Size = new System.Drawing.Size(77, 44);
            this.btn_EditFood.TabIndex = 2;
            this.btn_EditFood.Text = "Sửa";
            this.btn_EditFood.UseVisualStyleBackColor = true;
            this.btn_EditFood.Click += new System.EventHandler(this.btn_EditFood_Click);
            // 
            // btn_DeleteFood
            // 
            this.btn_DeleteFood.Location = new System.Drawing.Point(9, 103);
            this.btn_DeleteFood.Name = "btn_DeleteFood";
            this.btn_DeleteFood.Size = new System.Drawing.Size(75, 44);
            this.btn_DeleteFood.TabIndex = 1;
            this.btn_DeleteFood.Text = "Xóa";
            this.btn_DeleteFood.UseVisualStyleBackColor = true;
            this.btn_DeleteFood.Click += new System.EventHandler(this.btn_DeleteFood_Click);
            // 
            // btn_AddFood
            // 
            this.btn_AddFood.Location = new System.Drawing.Point(3, 3);
            this.btn_AddFood.Name = "btn_AddFood";
            this.btn_AddFood.Size = new System.Drawing.Size(81, 44);
            this.btn_AddFood.TabIndex = 0;
            this.btn_AddFood.Text = "Thêm";
            this.btn_AddFood.UseVisualStyleBackColor = true;
            this.btn_AddFood.Click += new System.EventHandler(this.btn_AddFood_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(24, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(311, 248);
            this.panel5.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Location = new System.Drawing.Point(3, 171);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(294, 50);
            this.panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(90, 14);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(190, 22);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbx_FoodCategory);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Location = new System.Drawing.Point(3, 115);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(294, 50);
            this.panel9.TabIndex = 3;
            // 
            // cbx_FoodCategory
            // 
            this.cbx_FoodCategory.FormattingEnabled = true;
            this.cbx_FoodCategory.Location = new System.Drawing.Point(90, 14);
            this.cbx_FoodCategory.Name = "cbx_FoodCategory";
            this.cbx_FoodCategory.Size = new System.Drawing.Size(190, 24);
            this.cbx_FoodCategory.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_FoodName);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Location = new System.Drawing.Point(3, 59);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 50);
            this.panel8.TabIndex = 2;
            // 
            // txt_FoodName
            // 
            this.txt_FoodName.Location = new System.Drawing.Point(90, 12);
            this.txt_FoodName.Name = "txt_FoodName";
            this.txt_FoodName.Size = new System.Drawing.Size(190, 22);
            this.txt_FoodName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txt_FoodID);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(294, 50);
            this.panel7.TabIndex = 1;
            // 
            // txt_FoodID
            // 
            this.txt_FoodID.Location = new System.Drawing.Point(90, 14);
            this.txt_FoodID.Name = "txt_FoodID";
            this.txt_FoodID.ReadOnly = true;
            this.txt_FoodID.Size = new System.Drawing.Size(190, 22);
            this.txt_FoodID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // dtgv_Food
            // 
            this.dtgv_Food.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Food.Location = new System.Drawing.Point(15, 45);
            this.dtgv_Food.Name = "dtgv_Food";
            this.dtgv_Food.RowHeadersWidth = 51;
            this.dtgv_Food.RowTemplate.Height = 24;
            this.dtgv_Food.Size = new System.Drawing.Size(641, 570);
            this.dtgv_Food.TabIndex = 0;
            this.dtgv_Food.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgv_Food_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách đồ uống";
            // 
            // frm_DoUong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1026, 627);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frm_DoUong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách đồ uống ";
            this.Load += new System.EventHandler(this.frm_DoUong_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbx_FoodCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_FoodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_FoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_EditFood;
        private System.Windows.Forms.Button btn_DeleteFood;
        private System.Windows.Forms.Button btn_AddFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_Food;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SearchFood;
        private System.Windows.Forms.TextBox txt_SearchFood;
    }
}