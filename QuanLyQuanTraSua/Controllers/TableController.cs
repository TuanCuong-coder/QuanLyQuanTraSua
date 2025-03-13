using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using QuanLyQuanTraSua.Models;
using QuanLyQuanTraSua.Libs;
using System.Collections;
using System.Data.SqlClient;

namespace QuanLyQuanTraSua.Controllers
{
    public class TableController
    {
        private static readonly DataClasses1DataContext db = new DataClasses1DataContext("Data Source=TUANCUONG;Initial Catalog=QuanLyQuanTraSua;Persist Security Info=True;User ID=sa;Password=123456");


        public static List<TableFood> LoadTables()
        {
            try
            {
                using (var db = new DataClasses1DataContext("Data Source=TUANCUONG;Initial Catalog=QuanLyQuanTraSua;Persist Security Info=True;User ID=sa;Password=123456"))
                {
                    return db.TableFoods.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải danh sách bàn: {ex.Message}");
                return new List<TableFood>();
            }
        }


        //cập nhật trạng thái bàn , cái này luôn phải  khai báo lại biến datacontext thay vì dùng static 
        public static bool UpdateTableStatus(int tableId, string newStatus)
        {
            try
            {
                using (var db = new DataClasses1DataContext("Data Source=TUANCUONG;Initial Catalog=QuanLyQuanTraSua;Persist Security Info=True;User ID=sa;Password=123456"))
                {
                    var table = db.TableFoods.SingleOrDefault(t => t.id == tableId);
                    if (table == null)
                    {
                        Console.WriteLine("Không tìm thấy bàn với ID được cung cấp.");
                        return false;
                    }

                    table.status = newStatus; //cap nhat trang thái bàn 
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi cập nhật trạng thái bàn: {ex.Message}");
                return false;
            }
        }

        //phuong thức lấy chi tiết hóa đơn từ tableid 
        public static List<BillDetailDTO> GetBillDetailsByTableId(int tableId)
        {
            try
            {
                var result = (from b in db.Bills
                              join bi in db.BillInfos on b.id equals bi.idBill
                              join f in db.Foods on bi.idFood equals f.id
                              where b.idTable == tableId && b.status == 0 // Chỉ lấy hóa đơn chưa thanh toán
                              && bi.isDelete == false // lấy hóa đơn chưa bị xóa
                              select new BillDetailDTO
                              { 
                                  FoodName = f.name,
                                  Quantity = bi.count,
                                  Price = f.price,
                                  TotalPrice = bi.count * f.price
                              }).ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi lấy hóa đơn: "+ex.Message);
                return new List<BillDetailDTO>();
            }
        }

   
       //phuong thuc lay hoa don boi id table 
        public static DataTable GetBillByTableId(int tableId)
        {
            string query = @"
                SELECT 
                    f.Name AS FoodName, 
                    bi.Count, 
                    f.Price, 
                    (bi.Count * f.Price) AS TotalPrice 
                FROM 
                    BillInfo AS bi 
                JOIN 
                    Bill AS b ON bi.idBill = b.id 
                JOIN 
                    Food AS f ON bi.idFood = f.id 
                WHERE 
                    b.idTable = @tableId AND b.Status = 0";

            try
            {
                return LayDuLieu.Instance.ExecuteQuery(query, new object[] { tableId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi truy vấn hóa đơn: {ex.Message}");
                return new DataTable();
            }
        }


        public static List<FoodCategory> GetCategories()
        {
            try
            {
                return db.FoodCategories.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải danh sách danh mục: {ex.Message}");
                return new List<FoodCategory>();
            }
        }
        public static List<Food> GetFoodsByCategory(int categoryId)
        {
            try
            {
                return db.Foods.Where(f => f.idCategory == categoryId).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi tải danh sách món ăn theo danh mục: {ex.Message}");
                return new List<Food>();
            }
        }

       
        //phuong thuc tinh tong gia tri hoa don
        public static double GetTotalBillByTableId(int tableId)
        {
            try
            {
                var billDetails = GetBillDetailsByTableId(tableId);
                return billDetails.Sum(b => b.TotalPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi tính tổng giá trị hóa đơn. chi tiết lỗi : " +ex.Message);
                return 0;
            }
        }

        // phuong thuc thanh toan 
        public static bool ThanhToan(int tableId)
        {
            try
            {
              
                var bill = db.Bills.SingleOrDefault(b => b.idTable == tableId && b.status == 0);

                if (bill == null)
                {
                    Console.WriteLine("Không tìm thấy hóa đơn chưa thanh toán cho bàn này.");
                    return false; 
                }

                bill.status = 1; // chuyen trạng thái đã thanh toán
                db.SubmitChanges();

                //chuyen trang thai ban thanh trong
                var table = db.TableFoods.SingleOrDefault(t => t.id == tableId);
                if (table != null)
                {
                    table.status = "Trống"; 
                    db.SubmitChanges(); 
                }

                // Xóa các món ăn trong BillInfo
                var billInfo = db.BillInfos.Where(bi => bi.idBill == bill.id);

                //update isDelete=1 ; ẩn nhưng vấn lưu vào db 
                string query1 = @"
                WITH BI AS
                (
	                SELECT isDelete, BillInfo.idBill FROM BillInfo
	                JOIN Bill ON BillInfo.idBill = Bill.id
                )
                UPDATE BI
                SET isDelete = 1
                WHERE BI.idBill = {0}";

                db.ExecuteCommand(query1, bill.id);//chay query 1 voi bien truyen vao la billid

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thanh toán, chi tiết lỗi: " + ex.Message);
                return false;
            }
        }

    }

    public class BillDetailDTO
    {
        public string FoodName { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
    }
}
