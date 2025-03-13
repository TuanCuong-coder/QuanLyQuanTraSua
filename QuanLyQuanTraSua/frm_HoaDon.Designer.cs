
namespace QuanLyQuanTraSua
{
    partial class frm_HoaDon
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
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_HuyThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpk_DateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(129, 527);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(133, 54);
            this.btn_ThanhToan.TabIndex = 1;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_HuyThanhToan
            // 
            this.btn_HuyThanhToan.Location = new System.Drawing.Point(380, 527);
            this.btn_HuyThanhToan.Name = "btn_HuyThanhToan";
            this.btn_HuyThanhToan.Size = new System.Drawing.Size(132, 54);
            this.btn_HuyThanhToan.TabIndex = 2;
            this.btn_HuyThanhToan.Text = "Hủy";
            this.btn_HuyThanhToan.UseVisualStyleBackColor = true;
            this.btn_HuyThanhToan.Click += new System.EventHandler(this.btn_HuyThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hóa đơn thanh toán";
            // 
            // txt_tenBan
            // 
            this.txt_tenBan.Location = new System.Drawing.Point(189, 57);
            this.txt_tenBan.Name = "txt_tenBan";
            this.txt_tenBan.ReadOnly = true;
            this.txt_tenBan.Size = new System.Drawing.Size(308, 22);
            this.txt_tenBan.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bàn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày thanh toán:";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(189, 468);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(308, 22);
            this.txt_TongTien.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng tiền:";
            // 
            // dtpk_DateCheckIn
            // 
            this.dtpk_DateCheckIn.Location = new System.Drawing.Point(189, 99);
            this.dtpk_DateCheckIn.Name = "dtpk_DateCheckIn";
            this.dtpk_DateCheckIn.Size = new System.Drawing.Size(308, 22);
            this.dtpk_DateCheckIn.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 142);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(559, 299);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            
            // 
            // frm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(615, 610);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtpk_DateCheckIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_tenBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_HuyThanhToan);
            this.Controls.Add(this.btn_ThanhToan);
            this.Name = "frm_HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frm_HoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_HuyThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpk_DateCheckIn;
        private System.Windows.Forms.ListView listView1;
    }
}