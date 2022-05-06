using System;
using System.Windows;
using TiemChungApp.Pages;

namespace TiemChungApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void NavigateToVaccineBuying(object sender, RoutedEventArgs e)
        {
            Main.Content = new VaccineBuying();
            Main.NavigationService.RemoveBackEntry();
        }
        private void NavigateToReceipt(object sender, RoutedEventArgs e)
        {
            Main.Content = new ReceiptView();
        }

        private void NavigateToRegistergVaccination(object sender, RoutedEventArgs e)
        {
            Main.Content = new ViewRegisterForm();
            Main.NavigationService.RemoveBackEntry();
        }

        private void NavigateToUserInformation(object sender, RoutedEventArgs e)
        {
            Main.Content = new UserInformation();
            Main.NavigationService.RemoveBackEntry();
        }
    }
}
