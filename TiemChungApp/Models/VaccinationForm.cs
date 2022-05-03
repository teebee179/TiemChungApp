using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class VaccinationForm : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int CustomerId { get; set; } 
        public string Gender { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string ParentName { get; set; }
        public string ParentRelationship { get; set; }
        public string ParentPhone { get; set; }
        public string Centre { get; set; }
        public string Vaccine { get; set; }
        public string Combo { get; set; }
        public string InjectDate { get; set; }
    }
}
