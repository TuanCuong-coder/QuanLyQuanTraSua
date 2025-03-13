
namespace QuanLyQuanTraSua
{
    partial class frm_BanAn
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
            this.panel19 = new System.Windows.Forms.Panel();
            this.btn_EditTable = new System.Windows.Forms.Button();
            this.btn_DeleteTable = new System.Windows.Forms.Button();
            this.btn_AddTable = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_TableStatus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txt_TableName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txt_TableID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel19);
            this.splitContainer1.Panel1.Controls.Add(this.panel11);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvTable);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1058, 589);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btn_EditTable);
            this.panel19.Controls.Add(this.btn_DeleteTable);
            this.panel19.Controls.Add(this.btn_AddTable);
            this.panel19.Location = new System.Drawing.Point(243, 329);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(111, 218);
            this.panel19.TabIndex = 9;
            // 
            // btn_EditTable
            // 
            this.btn_EditTable.Location = new System.Drawing.Point(10, 69);
            this.btn_EditTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_EditTable.Name = "btn_EditTable";
            this.btn_EditTable.Size = new System.Drawing.Size(98, 58);
            this.btn_EditTable.TabIndex = 2;
            this.btn_EditTable.Text = "Sửa";
            this.btn_EditTable.UseVisualStyleBackColor = true;
            this.btn_EditTable.Click += new System.EventHandler(this.btn_EditTable_Click);
            // 
            // btn_DeleteTable
            // 
            this.btn_DeleteTable.Location = new System.Drawing.Point(10, 134);
            this.btn_DeleteTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DeleteTable.Name = "btn_DeleteTable";
            this.btn_DeleteTable.Size = new System.Drawing.Size(98, 58);
            this.btn_DeleteTable.TabIndex = 1;
            this.btn_DeleteTable.Text = "Xóa";
            this.btn_DeleteTable.UseVisualStyleBackColor = true;
            this.btn_DeleteTable.Click += new System.EventHandler(this.btn_DeleteTable_Click);
            // 
            // btn_AddTable
            // 
            this.btn_AddTable.Location = new System.Drawing.Point(10, 4);
            this.btn_AddTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddTable.Name = "btn_AddTable";
            this.btn_AddTable.Size = new System.Drawing.Size(98, 58);
            this.btn_AddTable.TabIndex = 0;
            this.btn_AddTable.Text = "Thêm";
            this.btn_AddTable.UseVisualStyleBackColor = true;
            this.btn_AddTable.Click += new System.EventHandler(this.btn_AddTable_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Location = new System.Drawing.Point(27, 15);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(340, 229);
            this.panel11.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_TableStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 62);
            this.panel1.TabIndex = 2;
            // 
            // txt_TableStatus
            // 
            this.txt_TableStatus.Location = new System.Drawing.Point(111, 18);
            this.txt_TableStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TableStatus.Name = "txt_TableStatus";
            this.txt_TableStatus.Size = new System.Drawing.Size(194, 26);
            this.txt_TableStatus.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txt_TableName);
            this.panel13.Controls.Add(this.label7);
            this.panel13.Location = new System.Drawing.Point(3, 74);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(314, 62);
            this.panel13.TabIndex = 2;
            // 
            // txt_TableName
            // 
            this.txt_TableName.Location = new System.Drawing.Point(116, 15);
            this.txt_TableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TableName.Name = "txt_TableName";
            this.txt_TableName.Size = new System.Drawing.Size(194, 26);
            this.txt_TableName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên bàn:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txt_TableID);
            this.panel14.Controls.Add(this.label8);
            this.panel14.Location = new System.Drawing.Point(3, 4);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(314, 62);
            this.panel14.TabIndex = 1;
            // 
            // txt_TableID
            // 
            this.txt_TableID.Location = new System.Drawing.Point(110, 15);
            this.txt_TableID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TableID.Name = "txt_TableID";
            this.txt_TableID.ReadOnly = true;
            this.txt_TableID.Size = new System.Drawing.Size(194, 26);
            this.txt_TableID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // dtgvTable
            // 
            this.dtgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(46, 62);
            this.dtgvTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(552, 484);
            this.dtgvTable.TabIndex = 0;
            this.dtgvTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvTable_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách bàn ăn";
            // 
            // frm_BanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1058, 589);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_BanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách bàn ăn";
            this.Load += new System.EventHandler(this.frm_BanAn_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txt_TableName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txt_TableID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btn_EditTable;
        private System.Windows.Forms.Button btn_DeleteTable;
        private System.Windows.Forms.Button btn_AddTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TableStatus;
    }
}