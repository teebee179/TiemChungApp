using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class Vaccine : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public string name { get; set; }
        public string status { get; set; }
        public string expiredDate { get; set; }
        public Vaccine(string name, string status, string expiredDate)
        {
            this.name = name;
            this.status = status;
            this.expiredDate = expiredDate;
        }
        public override string ToString()
        {
            return $"{name}";
        }
    }
}
