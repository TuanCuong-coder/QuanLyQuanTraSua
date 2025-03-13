using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanTraSua.Models;

namespace QuanLyQuanTraSua.Controllers
{
    internal class AdminController
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public FunctResult<List<Account>>GetAll()
        {
            FunctResult<List<Account>> rs = new FunctResult<List<Account>>();
            try
            {
                var qr = db.Accounts ;
                if (qr.Any())
                {
                    //lay duoc du lieu tu csdl
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrDesc = "Lay du lieu thanh cong";
                    rs.Data = qr.ToList();
                }
                else
                {
                    //empty
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrDesc = "Du lieu trong csdl dang trong";
                    rs.Data = null;
                }
            }
            catch (Exception ex)
            {
                //error
                rs.ErrCode = EnumErrCode.Success;
                rs.ErrDesc = "Co loi xay ra trong qua trinh lay du lieu. chi tiet loi" + ex.Message;
                rs.Data = null;
            }
            return rs;
        }
    }
}
