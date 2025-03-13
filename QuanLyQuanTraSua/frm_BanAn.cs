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
    public partial class frm_BanAn : Form
    {
        public frm_BanAn()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void LoadData()
        {
            //ket noi csdl va lay du lieu nhom quyen do len datagridview
            var lst = db.TableFoods; //tuong duong select * from 
            if (lst.Any())
            {
                dtgvTable.DataSource = null;
                dtgvTable.DataSource = lst.ToList();
                dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// ham resize

            }
        }

        private void frm_BanAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgvTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = dtgvTable.Rows[e.RowIndex];

            txt_TableID.Text = r.Cells[0].Value.ToString();
            txt_TableName.Text = r.Cells[1].Value.ToString();
            txt_TableStatus.Text = r.Cells[2].Value.ToString();
            btn_EditTable.Visible = true;
            btn_DeleteTable.Visible = true;
            txt_TableID.ReadOnly = true;
        }

        private void btn_AddTable_Click(object sender, EventArgs e)
        {
                if (btn_EditTable.Visible)
                {
                    //nguoi dung dang trong tac vu sua/xoa
                    if (MessageBox.Show("Bạn có muốn hủy tác vụ hiện tại và chuyển sang thêm mới không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btn_EditTable.Visible = false;
                        btn_DeleteTable.Visible = false;

                        txt_TableID.ReadOnly = false;
                        txt_TableID.Text = "";
                        txt_TableName.Text = "";
                         txt_TableStatus.Text = "";
                        return;
                    }
                }
                //lay ve du lieu tren form
                string id = txt_TableID.Text;
                string ten = txt_TableName.Text;
            string trangthai = txt_TableStatus.Text;


                if (!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(trangthai))
                {
                    //truong hop du du lieu
                    TableFood obj = new TableFood();
                    obj.id = int.Parse(txt_TableID.Text); ;
                    obj.name = ten;
                obj.status = trangthai;

                    //tao lenh insert
                    db.TableFoods.InsertOnSubmit(obj);
                    try
                    {
                        db.SubmitChanges();
                        MessageBox.Show("Thêm mới bàn ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //load lai data 
                        LoadData();
                    frm_TrangChu.Instance.LoadTables();
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới thất bại, chi tiết lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //thieu id hoac ten
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void btn_EditTable_Click(object sender, EventArgs e)
        {
                //lay ve du lieu tren form
                string idText = txt_TableID.Text;
                string ten = txt_TableName.Text;
              string trangthai = txt_TableStatus.Text;

                if (!string.IsNullOrEmpty(idText) && !string.IsNullOrEmpty(ten) && !string.IsNullOrEmpty(trangthai))
                {
                    //truong hop du du lieu
                    int id = int.Parse(txt_TableID.Text);// chuyen id tu int sang string
                    var qr = db.TableFoods.Where(o => o.id == id);

                    if (qr.Any())
                    {
                    var obj = qr.SingleOrDefault();
                        obj.name = ten;
                    obj.status = trangthai;
                        try
                        {
                            db.SubmitChanges();
                            MessageBox.Show("Cập nhật bàn ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //load lai data 
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Cập nhật thất bại. chi tiết lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    //thieu id hoac ten
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void btn_DeleteTable_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Bạn có muốn xóa dữ liệu hay không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idText = txt_TableID.Text;

                    if (!string.IsNullOrEmpty(idText))
                    {
                        //truong hop du du lieu
                        int id = int.Parse(txt_TableID.Text);// chuyen id tu int sang string
                        var qr = db.TableFoods.Where(o => o.id == id);

                        if (qr.Any())
                        {
                            var obj = qr.SingleOrDefault();
                            db.TableFoods.DeleteOnSubmit(obj);
                            try
                            {
                                db.SubmitChanges();
                                MessageBox.Show("Xóa bàn ăn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
