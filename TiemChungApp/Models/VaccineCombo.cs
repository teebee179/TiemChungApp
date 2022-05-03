using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class VaccineCombo
    {
        public string ComboName { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public override string ToString()
        {
            return $"{ComboName}";
        }
    }
}
