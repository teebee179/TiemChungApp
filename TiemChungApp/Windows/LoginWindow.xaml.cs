using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TiemChungApp.Models;

namespace TiemChungApp.Windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        //private readonly ApplicationDbContext _context = new ApplicationDbContext();
        MainWindow mainWindow = new MainWindow();

        public LoginWindow()
        {
            InitializeComponent();
        }

        User user = new User()
        {
            CustomerID = 1,
            Name = "Vu Quang Hiep",
            Address = "TP HCM",
            PhoneNumber = "0909999222",
            DOB = "02/01/2001",
            Password = "123",
            Sex = "Male"

        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //if (GetConfiguration("Username") != "" && GetConfiguration("Password") != "")
            //{
            //    this.Close();
            //    mainWindow.Show();
            //}
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var username = txtUsername.Text;
            byte[] password = System.Text.Encoding.ASCII.GetBytes(txtPassword.Password);

            //var user = _context.Users.SingleOrDefault(x => x.UserName == username);
            //var user = from user in Users
            //           select user;

            var hashPassword = MD5.HashData(password);

            if (user == null)
            {
                MessageBox.Show("Đăng nhập không thành công");
                return;
            }


            if (user.Password == Convert.ToHexString(hashPassword).ToLower())
            {

                if (ckbSave.IsChecked == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    //AddUpdateAppSettings("Username", user.CustomerID.ToString());
                    //AddUpdateAppSettings("Password", user.Password);
                    this.Close();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Close();
                    mainWindow.Show();
                }
            }
            else
            {
                // something else (incorrect password)
                MessageBox.Show("Đăng nhập không thành công");
            }

        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void AddUpdateAppSettings(string key, string value)
        //{
        //    try
        //    {
        //        ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
        //        fileMap.ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + "App.config";
        //        Configuration configFile = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        //        var settings = configFile.AppSettings.Settings;
        //        if (settings[key] == null)
        //        {
        //            settings.Add(key, value);
        //        }
        //        else
        //        {
        //            settings[key].Value = value;
        //        }
        //        configFile.Save(ConfigurationSaveMode.Modified);
        //        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        //    }
        //    catch (ConfigurationErrorsException)
        //    {
        //        Console.WriteLine("Error writing app settings");
        //    }
        //}

        //public string GetConfiguration(string key)
        //{
        //    ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
        //    fileMap.ExeConfigFilename = AppDomain.CurrentDomain.BaseDirectory + "App.config";
        //    Configuration configFile = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
        //    var settings = configFile.AppSettings.Settings;
        //    if (settings[key] == null)
        //    {
        //        settings.Add(key, "");
        //        configFile.Save(ConfigurationSaveMode.Modified);
        //        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        //    }
        //    string ans = configFile.AppSettings.Settings[key].Value;
        //    return ans;
        //}
    }
}
