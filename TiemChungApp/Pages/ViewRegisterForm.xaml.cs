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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TiemChungApp.Models;
using TiemChungApp.Windows;

namespace TiemChungApp.Pages
{
    /// <summary>
    /// Interaction logic for ViewRegisterForm.xaml
    /// </summary>
    public partial class ViewRegisterForm : Page
    {

        private CollectionViewSource ViewRegisterFormSource;
        public static List<VaccinationForm> forms = new List<VaccinationForm>()
        {
            new VaccinationForm()
            {
                Id = 1,
                CustomerName = "Nguyen Huynh The Bao",
                CustomerId = 3,
                Gender = "Male",
                DOB ="03/01/2001",
                Address = "TPHCM",
                Telephone = "0909999000",
                Centre = "HCM",
                Vaccine = "Moderna",
                Combo   = "Combo for Covid",
                InjectDate = "05/05/2022"
            }
        };
        public ViewRegisterForm()
        {
            InitializeComponent();
            ViewRegisterFormSource = (CollectionViewSource)FindResource(nameof(ViewRegisterFormSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ViewRegisterFormSource.Source = forms;
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new RegisterVaccination();
            addWindow.ShowDialog();
            forms.Add(addWindow.newForm);
            FormListView.Items.Refresh();
        }

        private void deleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = FormListView.SelectedItem as VaccinationForm;
            var result = MessageBox.Show($"Bạn thật sự muốn xóa Phiếu đặt {selectedItem.Id}?",
               "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                forms.Remove(selectedItem);
            }
            FormListView.Items.Refresh();

        }

        private void editMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new RegisterVaccination();
            addWindow.ShowDialog();
            forms.Add(addWindow.newForm);
        }

        private void orderDetail_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
