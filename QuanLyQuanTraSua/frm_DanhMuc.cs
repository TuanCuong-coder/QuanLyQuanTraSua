using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanTraSua.Models;

namespace QuanLyQuanTraSua
{
    public partial class frm_DanhMuc : Form
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void LoadData()
        {
            //ket noi csdl va lay du lieu nhom quyen do len datagridview
            var lst = db.FoodCategories; //tuong duong select * from 
            if (lst.Any())
            {
                dtgv_Category.DataSource = null;
                dtgv_Category.DataSource = lst.ToList();
                dtgv_Category.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// ham resize

            }
        }

        private void frm_DanhMuc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_Category_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //lay ve row vua duoc click
            var r = dtgv_Category.Rows[e.RowIndex];

            txt_CategoryID.Text = r.Cells[0].Value.ToString();
            txt_CategoryName.Text = r.Cells[1].Value.ToString();
            btn_EditCategory.Visible = true;
            btn_DeleteCategory.Visible = true;
            txt_CategoryID.ReadOnly = true;
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {          
                if (btn_EditCategory.Visible)
                {
                    //nguoi dung dang trong tac vu sua/xoa
                    if (MessageBox.Show("Bạn có muốn hủy tác vụ hiện tại và chuyển sang thêm mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btn_EditCategory.Visible = false;
                        btn_DeleteCategory.Visible = false;

                        txt_CategoryID.ReadOnly = false;
                        txt_CategoryID.Text = "";
                        txt_CategoryName.Text = "";
                         return;
                    }
                }
                //lay ve du lieu tren form
                string id = txt_CategoryID.Text;
                string ten = txt_CategoryName.Text;
         

                if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(ten))
                {
                    //truong hop du du lieu
                    FoodCategory obj = new FoodCategory();
                    obj.id = int.Parse(txt_CategoryID.Text); ;
                    obj.name = ten;

                    //tao lenh insert
                    db.FoodCategories.InsertOnSubmit(obj);
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Them moi danh muc mon an thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //load lai data 
                        LoadData();
                    frm_TrangChu.Instance.LoadTables();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Them moi that bai. chi tiet loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //thieu id hoac ten
                    MessageBox.Show("Vui long nhap day du id vs ten", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btn_EditCategory_Click(object sender, EventArgs e)
        {
                //lay ve du lieu tren form
                string idText = txt_CategoryID.Text;
                string ten = txt_CategoryName.Text;
           
                if (!string.IsNullOrEmpty(idText) && !string.IsNullOrEmpty(ten))
                {
                //truong hop du du lieu
                int id = int.Parse(txt_CategoryID.Text);// chuyen id tu int sang string
                var qr = db.FoodCategories.Where(o => o.id == id);

                    if (qr.Any())
                    {                     
                        var obj = qr.SingleOrDefault();

                        obj.name = ten;

                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Cap nhat danh muc mon an thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //load lai data 
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cap nhat that bai. chi tiet loi: " + ex.Message, "Thong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    //thieu id hoac ten
                    MessageBox.Show("Vui long nhap day du id vs ten", "Canh bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btn_DeleteCategory_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu hay không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idText = txt_CategoryID.Text;

                    if (!string.IsNullOrEmpty(idText))
                    {
                    //truong hop du du lieu
                    int id = int.Parse(txt_CategoryID.Text);// chuyen id tu int sang string
                    var qr = db.FoodCategories.Where(o => o.id == id);

                        if (qr.Any())
                        {                       
                            var obj = qr.SingleOrDefault();

                            db.FoodCategories.DeleteOnSubmit(obj);
                            try
                            {
                                db.SubmitChanges();
                                MessageBox.Show("Xóa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //load lai data 
                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Xóa thất bại. Chi tiết lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        //thieu id hoac ten
                        MessageBox.Show("Vui lòng nhập đầy đủ id vs ten", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

 
        }
    }
}
