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
        public List<VaccinationForm> forms = new List<VaccinationForm>();
        public ViewRegisterForm()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FormListView.ItemsSource = forms;
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
            var result = MessageBox.Show($"Bạn thật sự muốn xóa Phiếu đặt {selectedItem.id}?",
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
            var addWindow = new RegisterVaccination();
            addWindow.ShowDialog();
            forms.Add(addWindow.newForm);
        }
    }
}
