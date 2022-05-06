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
        public string Name { get; set; }
        public string Type { get; set; }
        public string Quantity { get; set; }
        public int Price { get; set; }
        public string Status { get; set; }
        public string ExpiredDate { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
