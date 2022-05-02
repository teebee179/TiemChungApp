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
    /// Interaction logic for ChangeUserPassword.xaml
    /// </summary>
    public partial class ChangeUserPassword : Window
    {
        public User EditedUser { get; set; }

        public ChangeUserPassword(User user)
        {
            InitializeComponent();
            EditedUser = (User)user.Clone();
        }

        private void UpdatePassword_btn_Click(object sender, RoutedEventArgs e)
        {
            if(EditedUser.Password.Equals(OldPassword_Textbox.Password))
            {
                if (NewPassword_Textbox1.Password.Equals(NewPassword_Textbox2.Password))
                {
                    EditedUser.Password = NewPassword_Textbox1.Password;
                    MessageBoxResult result = MessageBox.Show("Password changed successfully");
                    DialogResult = true;
                }
                else
                {
                    MessageBoxResult result = MessageBox.Show("Password in the 'New password and Re-enter new password' is not similar, please re-enter the form!");
                }
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Invalid passsword, please re-enter the form!");
            }
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
