using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class Receipt
    {
        public string BillID { get; set; }
        public int CustomerID { get; set; }
        public DateOnly CreateDate { get; set; }
        public int Total { get; set; }
    }
}
