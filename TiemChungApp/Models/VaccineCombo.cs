using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class VaccineCombo : INotifyPropertyChanged
    {
        public string ComboName { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
            return $"{ComboName}";
        }
    }
}
