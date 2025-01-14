﻿using System;
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
        List<User> Users = new List<User>()
        {
            new User()
            {
                CustomerID = 1,
                Name = "Vu Quang Hiep",
                Address ="TP HCM",
                PhoneNumber = "0909999222",
                DOB = "02/01/2001",
                Password = "123",
                Sex = "Male"

            },
            new User()
            {
                CustomerID = 2,
                Name = "Nguyen Ngoc Phu Sy",
                Address = "Hau Giang",
                PhoneNumber = "0909999111",
                DOB ="01/02/2001",
                Password = "123",
                Sex = "Male"
            },
            new User()
            {
                CustomerID = 3,
                Name = "Nguyen Huynh The Bao",
                Address = "TP HCM",
                PhoneNumber = "0909999000",
                DOB ="03/01/2001",
                Password ="123",
                Sex = "Male"
            },
            new User()
            {
                CustomerID = 4,
                Name = "Vuong Hoang Bao",
                Address = "TP HCM",
                PhoneNumber = "0909999333",
                DOB ="01/03/2001",
                Password="123",
                Sex = "Male"
            },
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

        private void ChangePasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var user in Users)
            {
                if (user.CustomerID == 1)
                {
                    User Us = user;
                    var screen = new ChangeUserPassword(Us);
                    if (screen.ShowDialog() == true)
                    {
                        var info = screen.EditedUser;
                        Us.Password = info.Password;
                    }
                }
            }
        }
    }
}
