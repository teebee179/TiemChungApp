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

        private void NavigateToDashboard(object sender, RoutedEventArgs e)
        {
            Main.Content = new Dashboard();
            Main.NavigationService.RemoveBackEntry();
        }
    }
}
