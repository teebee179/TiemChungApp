using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using TiemChungApp.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TiemChungApp.Models;


namespace TiemChungApp.Pages
{
    public partial class UserInformation : Page
    {
        //class User
        //{
        //    public int CustomerID { get; set; }
        //    public string Name { get; set; }
        //    public string Address { get; set; }
        //    public int PhoneNumber { get; set; }
        //    public string DOB { get; set; }
        //    public string Password { get; set; }
        //    public string Sex { get; set; }

        //    public User(int ID, string name, string address, int phone, string dob, string pass, string sex)
        //    {
        //        this.CustomerID = ID;
        //        this.Name = name;
        //        this.Address = address;
        //        this.PhoneNumber = phone;
        //        this.DOB = dob;
        //        this.Password = pass;
        //        this.Sex = sex;
        //    }

        //    public object Clone()
        //    {
        //        return MemberwiseClone();
        //    }
        //}


        List<User> Users = new List<User>()
        {
            new User(1, "Vu Quang Hiep", "TP HCM", 0909999222, "02/01/2001", "123", "Male"),
            new User(2, "Nguyen Ngoc Phu Sy", "Hau Giang", 0909999111, "01/02/2001", "123", "Male"),
            new User(3, "Nguyen Huynh The Bao", "TP HCM", 0909999000, "03/01/2001", "123", "Male"),
            new User(4, "Vuong Hoang Bao", "TP HCM", 0909999333, "01/03/2001", "123", "Male"),
        };

        public UserInformation()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var Us = from user in Users
                     where user.CustomerID.Equals(1)
                     select user;
            this.DataContext = Us;
        }

        private void EditInformationBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in Users)
            {
                if(user.CustomerID == 1)
                {
                    User Us = user;
                    var screen = new EditUserInformation(Us);
                    if (screen.ShowDialog() == true)
                    {
                        var info = screen.EditedUser;
                        Us.Name = info.Name;
                        Us.Address = info.Address;
                        Us.PhoneNumber = info.PhoneNumber;
                        Us.DOB = info.DOB;
                        Us.Sex = info.Sex;
                    }
                }
            }
        }

        private void OKbtn_Click(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
