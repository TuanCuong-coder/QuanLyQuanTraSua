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
    public partial class frm_HoaDon : Form
    {
        private int tableId;// id ban
        public frm_HoaDon(int id)
        {
            InitializeComponent();
            this.tableId = id;
        }

        private void btn_HuyThanhToan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {
            {
                
                listView1.View = View.Details;
                listView1.Columns.Add("Tên món", 150);
                listView1.Columns.Add("Số lượng", 70);
                listView1.Columns.Add("Giá", 100);
                listView1.Columns.Add("Thành tiền", 100);
                listView1.FullRowSelect = true; 
                listView1.GridLines = true;    

                //đổ du lieu cua hoa don
                LoadBillDetails(tableId);

                LoadTableName(tableId);  //do du lieu ten ban
            }
        }

        //load chi tiet hoa don tu frm trang chu
        private void LoadBillDetails(int tableId)
        {
            try
            {
                // Lấy chi tiết hóa đơn từ controller
                var billDetails = TableController.GetBillDetailsByTableId(tableId);
                double totalAmount = 0;

                // Hiển thị chi tiết hóa đơn vào ListView
                foreach (var item in billDetails)
                {
                    var listItem = new ListViewItem(item.FoodName);
                    listItem.SubItems.Add(item.Quantity.ToString());
                    listItem.SubItems.Add(item.Price.ToString("")); 
                    listItem.SubItems.Add(item.TotalPrice.ToString(""));
                    listView1.Items.Add(listItem);

                    totalAmount += item.TotalPrice; // Tính tổng tiền
                }

                // Hiển thị tổng tiền
                txt_TongTien.Text = totalAmount.ToString(""); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn, chi tiet loi: "+ ex.Message, "Thông báo");
            }
        }

        private void LoadTableName(int tableId)
        {
                using (var db = new DataClasses1DataContext())
                {
                    var table = db.TableFoods.FirstOrDefault(t => t.id == tableId);
                    if (table != null)
                    {
                        txt_tenBan.Text = table.name;  
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bàn", "Thông báo");
                    }
                }
        }
        
        //xu ly khi an thanh toan thanh cong
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                bool thanhCong = TableController.ThanhToan(tableId);
                if (thanhCong)
                {
                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_TrangChu.Instance.LoadTables();
                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
