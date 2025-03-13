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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            var controller = new LoginController();
            string userName = txt_UserName.Text;
            string passWord = txt_Password.Text;
            if (controller.Login(userName, passWord))
            {
                frm_TrangChu f = new frm_TrangChu(userName);//truyen username vao frm trang chu
                this.Hide(); 
                f.ShowDialog();  
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();//thoat
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát hay không?","thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.Green;
        }

        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.BackColor = Color.White;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.White;
        }

        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
            btn_Exit.BackColor = Color.Red;
        }
    }
}
