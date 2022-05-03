using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class Guardian : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int GuardianID { get; set; }
        public string Name { get; set; }
        public string MobilePhone { get; set; }
        public string Relationship  { get; set; }

    }
}
