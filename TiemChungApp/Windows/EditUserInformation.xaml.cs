using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for EditUserInformation.xaml
    /// </summary>
    public partial class EditUserInformation : Window
    {
        public User EditedUser { get; set; }

        public EditUserInformation(User user)
        {
            InitializeComponent();
            EditedUser = user;
            this.DataContext = user;
        }

        private void UpdateInformationBtn_Click(object sender, RoutedEventArgs e)
        {
            EditedUser.Name = Cusname_Textbox.Text;
            EditedUser.PhoneNumber = Int16.Parse(PhoneNum_Textbox.Text);
            EditedUser.Address = Address_Textbox.Text;
            EditedUser.DOB = DOB_Textbox.Text;
            EditedUser.Sex = Sex_Textbox.Text;
            DialogResult = true;
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
