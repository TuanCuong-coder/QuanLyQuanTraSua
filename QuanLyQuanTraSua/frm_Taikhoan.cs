using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.Controllers;
using QuanLyQuanTraSua.Models;


namespace QuanLyQuanTraSua
{
    public partial class frm_Taikhoan : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frm_Taikhoan(string username)
        {
            InitializeComponent();
            LoadData(username);
        }

        public void LoadData(string username)
        {
                var taikhoan = db.Accounts.SingleOrDefault(a => a.UserName.Trim() == username.Trim());
                if (taikhoan != null)
                {
                    txt_UserName.Text = taikhoan.UserName;
                    txt_DisplayName.Text = taikhoan.DisplayName;
                    txt_PassWord.Text = taikhoan.PassWord;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //lay thong tin tu o nhap lieu
            string tenHienThi = txt_DisplayName.Text;
            string matKhau = txt_PassWord.Text;

            //kiem tra du lieu nhap vao
            if (string.IsNullOrEmpty(tenHienThi) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Tên hiển thị và mật khẩu không được để trống", "Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            //lay tai khoan can cap sua
            var taikhoan = db.Accounts.SingleOrDefault(a => a.UserName.Trim() == txt_UserName.Text.Trim());

            if (taikhoan != null)
            {
                //cap nhat thong tinn tai khoan
                taikhoan.DisplayName = tenHienThi;
                taikhoan.PassWord = matKhau;

                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Cập nhật tài khoản thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadData(txt_UserName.Text.Trim());
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật, chi tiết lỗi :" + ex.Message,"Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }
    }
}
