using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiemChungApp.Models
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string DOB { get; set; }
        public string Password { get; set; }

        public User(int ID, string name, string address, int phone, string dob, string pass)
        {
            this.CustomerID = ID;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phone;  
            this.DOB = dob; 
            this.Password = pass;
        }
    }
}
