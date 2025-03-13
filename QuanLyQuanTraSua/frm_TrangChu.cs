using QuanLyQuanTraSua.Controllers;
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
    public partial class frm_TrangChu : Form
    {
        public static frm_TrangChu Instance;//thong qua cai nay co the dung cac lenh trong form trang chu
        
        public frm_TrangChu(string username)
        {
            InitializeComponent();
            InitializeForm();
            this.username = username;
            Instance = this; //dai dien cho class frm_trangchu
        }
        private string username;

        private void InitializeForm()
        {
            cbx_Category.SelectedIndexChanged += cbx_Category_SelectedIndexChanged;
            try
            {
                LoadTables();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi khởi tạo form: {ex.Message}", "Thông báo");
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var categories = db.FoodCategories
                        .Select(c => new { c.id, c.name })
                        .ToList();

                    cbx_Category.DataSource = categories;
                    cbx_Category.DisplayMember = "name";
                    cbx_Category.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh mục đồ uống: {ex.Message}", "Thông báo");
            }
        }
        public void LoadTables()
        {
            try
            {
                flpTable.Controls.Clear();
                var tables = TableController.LoadTables();

                foreach (var table in tables)
                {
                    var btn = new Button
                    {
                        Width = 100,
                        Height = 100,
                        Text = $"{table.name}\n{table.status}",
                        Tag = table.id,
                        BackColor = table.status == "Trống" ? Color.Honeydew : Color.BurlyWood
                    };

                    btn.Paint += Btn_Paint;//sự kiện Paint vẽ viền

                    btn.Click += BtnTable_Click;// su kien khi an btn 
                    flpTable.Controls.Add(btn);//them buuton vao flowlaypout
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách bàn: {ex.Message}", "Thông báo");
            }
        }

        //vẽ viền button
        private void Btn_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                using (Pen pen = new Pen(Color.Gray, 1))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, btn.Width - 1, btn.Height - 1); // Vẽ viền xung quanh button
                }
            }
        }
       
        //load lại form 
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadTables(); // Load danh sách bàn
        }
     

        // ấn button , thực hiệc các chức năng
        private void BtnTable_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Tag.ToString(), out int tableId))
            {
                // Gán thông tin bàn vào ListView (hoặc Tag của ListView để thêm món)
                lsvBill.Tag = tableId;

                // Hiển thị chi tiết hóa đơn của bàn
                DisplayBillDetails(tableId);
                
                // Hiển thị tổng tiền của bàn
                LoadTotalPrice(tableId); // Gọi hàm tính tổng tiền
            }
            else
            {
                ShowError("Dữ liệu bàn không hợp lệ.");
            }
        }

        //của minh , tông tiền từng món 
        private void DisplayBillDetails(int tableId)
        {
            try
            {
                lsvBill.Items.Clear();
                lsvBill.Text = ""; // Reset tổng tiền
                var billDetails = TableController.GetBillDetailsByTableId(tableId);


                double totalAmount = 0; // Biến lưu tổng tiền của hóa đơn

                foreach (var item in billDetails)
                {
                    var listItem = new ListViewItem(item.FoodName);
                    listItem.SubItems.Add(item.Quantity.ToString());
                    listItem.SubItems.Add(item.Price.ToString()); // Hiển thị giá theo định dạng tiền tệ
                    listItem.SubItems.Add(item.TotalPrice.ToString()); // Hiển thị thành tiền theo định dạng tiền tệ
                    lsvBill.Items.Add(listItem);

                    totalAmount += item.TotalPrice; // Cộng tổng tiền
                }

                // Hiển thị tổng tiền
                lsvBill.Text = $"Tổng tiền: {totalAmount:C0}";
            }
            catch (Exception ex)
            {
                ShowError($"Lỗi khi hiển thị hóa đơn: {ex.Message}");
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //của minh , lấy tên món theo danh muc 
        private void LoadFoodItemsByCategory(int categoryId)
        {
            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var foodItems = db.Foods
                        .Where(f => f.idCategory == categoryId)
                        .Select(f => new { f.id, f.name })
                        .ToList();

                    cbx_Food.DataSource = foodItems;
                    cbx_Food.DisplayMember = "name";
                    cbx_Food.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách món ăn: {ex.Message}", "Thông báo");
            }
        }

        // thêm món ăn vào bàn ăn (mai cường)
        private void btn_AddFood_Click_1(object sender, EventArgs e)
        {
            if (lsvBill.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn bàn để thêm món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tableId = (int)lsvBill.Tag;

            if (cbx_Food.SelectedValue == null || nmFoodCount.Value <= 0)
            {
                MessageBox.Show("Vui lòng chọn món và số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int foodId = (int)cbx_Food.SelectedValue;
            int count = (int)nmFoodCount.Value;

            try
            {
                using (var db = new DataClasses1DataContext())
                {
                    var currentBill = db.Bills.FirstOrDefault(b => b.idTable == tableId && b.status == 0);
                    if (currentBill == null)
                    {
                        // Nếu chưa có hóa đơn, tạo mới
                        var newBill = new Bill
                        {
                            idTable = tableId,
                            DateCheckIn = DateTime.Now,
                            status = 0
                        };
                        db.Bills.InsertOnSubmit(newBill);
                        db.SubmitChanges();

                        currentBill = newBill;
                    }

                    var billInfo = db.BillInfos.FirstOrDefault(bi => bi.idBill == currentBill.id && bi.idFood == foodId);
                    if (billInfo == null)
                    {
                        var newBillInfo = new BillInfo
                        {
                            idBill = currentBill.id,
                            idFood = foodId,
                            count = count,
                            isDelete = false
                        };
                        db.BillInfos.InsertOnSubmit(newBillInfo);
                    }
                    else
                    {
                        // Nếu món ăn đã tồn tại, cập nhật số lượng
                        billInfo.count += count;
                    }

                    db.SubmitChanges(); // thay đổi và lưu vào database 

                    // Cập nhật trạng thái bàn
                    var table = db.TableFoods.FirstOrDefault(t => t.id == tableId);
                    if (table != null)
                    {
                        table.status = "Có người"; // Cập nhật trạng thái bàn
                        db.SubmitChanges();
                    }

                    // Cập nhật giao diện
                    DisplayBillDetails(tableId);
                    LoadTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món, chi tiết lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        // chọn danh mục xong load đồ uống của danh mục đó
        private void cbx_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Category.SelectedValue != null && int.TryParse(cbx_Category.SelectedValue.ToString(), out int categoryId))
            {
                LoadFoodItemsByCategory(categoryId);
            }
        }
       
        //đăng xuất
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            frm_Taikhoan f = new frm_Taikhoan(this.username);
            f.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongKe f = new frm_ThongKe();
            f.ShowDialog();
        }

        private void đồUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DoUong f = new frm_DoUong();
            f.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DanhMuc f = new frm_DanhMuc();
            f.ShowDialog();
        }

        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BanAn f = new frm_BanAn();
            f.ShowDialog();
        }

        //hiển thị lsv có các cột và giá trị khi trang chủ load
        private void frm_TrangChu_Load(object sender, EventArgs e)
        {
            // để lsv ở chế độ hiển thị dạng chi tiết
            lsvBill.View = View.Details;

            // Thêm các cột cho ListView
            lsvBill.Columns.Add("Tên món", 150);
            lsvBill.Columns.Add("Số lượng", 70);
            lsvBill.Columns.Add("Giá", 100);
            lsvBill.Columns.Add("Thành tiền", 100);

            lsvBill.FullRowSelect = true; // Cho phép chọn cả dòng
            lsvBill.GridLines = true;     // Hiển thị các đường kẻ
        }

       // ấn nút thanh toán để show form hoa đơn, truyền đung table id của bàn đó sang form hóa đơn 
        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            if (lsvBill.Tag != null)
            {
                int tableId = (int)lsvBill.Tag;
                frm_HoaDon f = new frm_HoaDon (tableId); // Truyền tableId vào
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // hàm tính tổng hóa đơn 
        private void LoadTotalPrice(int tableId)
        {  try
            {
                double totalPrice = TableController.GetTotalBillByTableId(tableId);
                txt_TongTien.Text = totalPrice.ToString(""); // Định dạng tiền tệ                                                            
            }
            catch (Exception ex)
            {
                ShowError("Có lỗi xảy ra khi tính tổng tiền, chi tiết lỗi: " + ex.Message);
            }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            LoadTables();
        }
    }
}
