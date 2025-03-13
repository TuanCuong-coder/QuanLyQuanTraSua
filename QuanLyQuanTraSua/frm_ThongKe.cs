using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class frm_ThongKe : Form
    {
        // DataContext đại diện cho cơ sở dữ liệu
        DataClasses1DataContext db = new DataClasses1DataContext();

        public frm_ThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
          
        }

        private void txtTotalRevenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Lấy khoảng ngày từ DateTimePicker
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date;

                // Tính tổng doanh thu
                var totalRevenue = db.Bills
                    .Where(b => b.DateCheckIn >= fromDate && b.DateCheckIn <= toDate)
                    .Join(db.BillInfos, b => b.id, bi => bi.idBill, (b, bi) => new { bi, b })
                    .Join(db.Foods, bb => bb.bi.idFood, f => f.id, (bb, f) => new { bb.bi, f })
                    .Sum(x => x.f.price * x.bi.count);

                //txtTotalRevenue.Text = totalRevenue.HasValue ? totalRevenue.Value.ToString("NO") : "0";

                txtTotalRevenue.Text = totalRevenue.ToString("N0");

                // Tính tổng số lượng món đã bán
                var totalItemsSold = db.Bills
                    .Where(b => b.DateCheckIn >= fromDate && b.DateCheckIn <= toDate)
                    .Join(db.BillInfos, b => b.id, bi => bi.idBill, (b, bi) => bi)
                    .Sum(bi => bi.count);

                //txtTotalItemsSold.Text = totalItemsSold.HasValue ? totalItemsSold.Value.ToString("NO") : "0";

                txtTotalItemsSold.Text = totalItemsSold.ToString("N0");

                // Tìm món bán chạy nhất
                var bestSeller = db.Bills
                    .Where(b => b.DateCheckIn >= fromDate && b.DateCheckIn <= toDate)
                    .Join(db.BillInfos, b => b.id, bi => bi.idBill, (b, bi) => bi)
                    .GroupBy(bi => bi.Food)
                    .OrderByDescending(g => g.Sum(bi => bi.count))
                    .Select(g => new { g.Key.name, TotalSold = g.Sum(bi => bi.count) })
                    .FirstOrDefault();

                txtBestSeller.Text = bestSeller != null ? bestSeller.name : "Không có";
                txtBestSeller1.Text = bestSeller != null ? bestSeller.TotalSold.ToString() : "Không có";

                // Tìm món bán ít nhất
                var leastSeller = db.Bills
                    .Where(b => b.DateCheckIn >= fromDate && b.DateCheckIn <= toDate)
                    .Join(db.BillInfos, b => b.id, bi => bi.idBill, (b, bi) => bi)
                    .GroupBy(bi => bi.Food)
                    .OrderBy(g => g.Sum(bi => bi.count))
                    .Select(g => new { g.Key.name, TotalSold = g.Sum(bi => bi.count) })
                    .FirstOrDefault();

                txtLeastSeller.Text = leastSeller != null ? leastSeller.name : "Không có";
                txtLeastSeller1.Text = leastSeller != null ? leastSeller.TotalSold.ToString() : "Không có";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
