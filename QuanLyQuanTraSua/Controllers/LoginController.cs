using QuanLyQuanTraSua.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace QuanLyQuanTraSua.Controllers
{
    class LoginController
    {
        private DataClasses1DataContext db = new DataClasses1DataContext();

        public bool Login(string username, string password)
        {
            return db.Accounts.Any(acc => acc.UserName == username && acc.PassWord == password);
        }
    }
}
