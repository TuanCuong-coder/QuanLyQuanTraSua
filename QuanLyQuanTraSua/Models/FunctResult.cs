using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanTraSua.Models
{
    class FunctResult<t>
    {
        public EnumErrCode ErrCode { get; set; }
        public string ErrDesc { get; set; }
        public t Data { get; set; }
    }
}
