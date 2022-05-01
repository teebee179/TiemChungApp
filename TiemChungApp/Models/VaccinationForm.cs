using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class VaccinationForm
    {
        public int id { get; set; }
        public string customerName { get; set; }
        public string customerId { get; set; } 
        public string gender { get; set; }
        public string DOB { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string parentName { get; set; }
        public string parentRelationship { get; set; }
        public string parentPhone { get; set; }
        public string centre { get; set; }
        public string vaccine { get; set; }
        public string combo { get; set; }

        public string injectDate { get; set; }
    }
}
