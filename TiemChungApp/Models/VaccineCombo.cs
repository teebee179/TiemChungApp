using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class VaccineCombo
    {
        public string comboName { get; set; }
        public List<Vaccine> Vaccines { get; set; }

        public VaccineCombo(string name, List<Vaccine> combo)
        {
            this.comboName = name;
            this.Vaccines = new List<Vaccine>(combo);
        }
        public override string ToString()
        {
            return $"{comboName}";
        }
    }
}
