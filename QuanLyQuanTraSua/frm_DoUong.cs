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
    public partial class frm_DoUong : Form
    {
        public frm_DoUong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        public void LoadCategories()
        {
            var categories = db.FoodCategories.ToList(); // Lấy danh sách các danh mục món ăn
            cbx_FoodCategory.DataSource = categories;
            cbx_FoodCategory.DisplayMember = "Name"; // Hiển thị tên danh mục
            cbx_FoodCategory.ValueMember = "Id"; // Giá trị sẽ là Id của danh mục
        }

        public void LoadData()
        {
            var lst = from f in db.Foods
                      join fc in db.FoodCategories on f.idCategory equals fc.id
                      select new
                      {
                          f.id,
                          f.name,
                          CategoryName = fc.name, // Tên danh mục mon an 
                          f.price
                      };

            if (lst.Any())
            {
                dtgv_Food.DataSource = null;
                dtgv_Food.DataSource = lst.ToList();
                dtgv_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        private void frm_DoUong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategories(); //load danh muc do uong


        }
        private void dtgv_Food_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //lấy về row vừa được click
            var r = dtgv_Food.Rows[e.RowIndex];

            txt_FoodID.Text = r.Cells[0].Value.ToString();
            txt_FoodName.Text = r.Cells[1].Value.ToString();

            //đổ dữ liệu nên combobox ; dữ liệu là string
            string categoryName = r.Cells[2].Value.ToString();
            cbx_FoodCategory.SelectedItem = cbx_FoodCategory.Items.Cast<FoodCategory>()
                                              .FirstOrDefault(fc => fc.name == categoryName);
            nmFoodPrice.Value = Convert.ToDecimal(r.Cells[3].Value);
            btn_EditFood.Visible = true; 
            btn_DeleteFood.Visible = true;
            txt_FoodID.ReadOnly = true;
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
                if (btn_EditFood.Visible)
                {
                    //nguoi dung dang trong tac vu sua/xoa
                    if (MessageBox.Show("Bạn có muốn hủy tác vụ hiện tại và chuyển sang thêm mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btn_EditFood.Visible = false;
                        btn_DeleteFood.Visible = false;

                        txt_FoodID.ReadOnly = false;
                        txt_FoodID.Text = "";
                        txt_FoodName.Text = "";
                    nmFoodPrice.Value = 0;
                    cbx_FoodCategory.SelectedIndex = 0;
                        return;
                    }
                }
                //lay ve du lieu tren form
                string id = txt_FoodID.Text;
                string ten = txt_FoodName.Text;
            decimal price = nmFoodPrice.Value;

            //lay gia tri id duoc chon tu combobox
            var DanhMucDuocChon = cbx_FoodCategory.SelectedItem as FoodCategory;
            if (DanhMucDuocChon == null)
            {
                MessageBox.Show("Vui lòng chọn danh mục hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idDanhMuc = DanhMucDuocChon.id;

            //kiem tra du lieu dau vao
                if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(ten))
                {
                //truong hop du du lieu
                Food obj = new Food();
                obj.id = int.Parse(txt_FoodID.Text); ;
                obj.name = ten;
                obj.price = (float)price;
                obj.idCategory = idDanhMuc;


                //tao lenh insert
                db.Foods.InsertOnSubmit(obj);
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Them moi danh muc mon an thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //load lai data 
                        LoadData();
                    LoadCategories();
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

        private void btn_EditFood_Click(object sender, EventArgs e)
        {
                //lay ve du lieu tren form
                string idText = txt_FoodID.Text;
                string ten = txt_FoodName.Text;
                decimal gia = nmFoodPrice.Value;
                var DanhMucDuocChon = cbx_FoodCategory.SelectedItem as FoodCategory;
                int idDanhMuc = DanhMucDuocChon.id;
            if (!string.IsNullOrEmpty(idText) && !string.IsNullOrEmpty(ten) && DanhMucDuocChon != null && gia > 0)
                {
                    //truong hop du du lieu
                    int id = int.Parse(txt_FoodID.Text);// chuyen id tu int sang string
                    var qr = db.Foods.Where(o => o.id == id);

                    if (qr.Any())
                    {
                        var obj = qr.SingleOrDefault();
                        obj.name = ten;//cap nhat ten
                    obj.price = (float)gia;//cap nhat gia
                    obj.idCategory = idDanhMuc;//cap nhat danh muc 

                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật món ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //load lai data 
                            LoadData();
                        LoadCategories();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cập nhật thất bại.Chi tiết: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảng báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }

        private void btn_DeleteFood_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu hay không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idText = txt_FoodID.Text;

                    if (!string.IsNullOrEmpty(idText))
                    {
                        //truong hop du du lieu
                        int id = int.Parse(txt_FoodID.Text);// chuyen id tu int sang string
                        var qr = db.Foods.Where(o => o.id == id);

                        if (qr.Any())
                        {
                            var obj = qr.SingleOrDefault();
                            db.Foods.DeleteOnSubmit(obj);
                            try
                            {
                                db.SubmitChanges();
                                MessageBox.Show("Xóa danh mục thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //load lai data 
                                LoadData();
                            LoadCategories();
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

        private void btn_SearchFood_Click(object sender, EventArgs e)
        {
            // gia tri lay tu thanh tim kiem
            string TenTimKiem = txt_SearchFood.Text.Trim().ToLower(); //chuyen ve dang chu thuong

            
            if (!string.IsNullOrEmpty(TenTimKiem))
            {
                //tim theo ten do uong
                var KqTimKiem = from food in db.Foods
                                    where food.name.ToLower().Contains(TenTimKiem) //tim theo ten, khong phan bieet chu hoa , thuong
                                    join fc in db.FoodCategories on food.idCategory equals fc.id
                                    select new
                                    {
                                        food.id,
                                        food.name,
                                        CategoryName = fc.name, //ten danh muc
                                        food.price
                                    };

               //cap nhat dtgv voi kq tim kiem
                dtgv_Food.DataSource = KqTimKiem.ToList();
            }
            else
            {
                //ko co tu khoa tim kiem thi hien thi toan bo
                LoadData(); //lay lai toan bo 
            }
        }


        private void txt_SearchFood_TextChanged(object sender, EventArgs e)
        {
            //lay tu o tim kiem 
            string TenTimKiem = txt_SearchFood.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(TenTimKiem))
            {
                var KqTimKiem = from food in db.Foods
                                    where food.name.Contains(TenTimKiem) // Tìm kiếm theo tên món
                                    select new
                                    {
                                        food.name,
                                        food.price,
                                        Category = food.FoodCategory.name 
                                    };

                // Đưa kq tim kiem vao dtgv
                dtgv_Food.DataSource = KqTimKiem.ToList();
            }
            else
            {
                //neu ko co tu khoa tim kiem hien thi toan bo danh sach
                var DoUong = from food in db.Foods
                               select new
                               {
                                   food.name,
                                   food.price,
                                   Category = food.FoodCategory.name
                               };

                dtgv_Food.DataSource = DoUong.ToList();
            }

        }
    }
}
