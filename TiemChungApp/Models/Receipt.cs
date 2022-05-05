using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class Receipt : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        public string BillID { get; set; }
        public int CustomerID { get; set; }
        public string CreateDate { get; set; }
        public int Total { get; set; }

    }
}
