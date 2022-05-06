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
    /// Interaction logic for Receipt.xaml
    /// </summary>
    public partial class ReceiptView : Page
    {
        private CollectionViewSource ReceiptViewSource;
        public List<Receipt> receipts = new List<Receipt>();
        public ReceiptView()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            FormListView.ItemsSource = receipts;
            ReceiptViewSource = (CollectionViewSource)FindResource(nameof(ReceiptViewSource));
        }

        private void addBtnRec_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new ReceiptWindow();
            addWindow.ShowDialog();
            receipts.Add(addWindow.newRec);
            FormListView.Items.Refresh();
        }

        private void deleteMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = FormListView.SelectedItem as Receipt;
            var result = MessageBox.Show($"Bạn thật sự muốn xóa Phiếu đặt {selectedItem.BillID}?",
               "Xác nhận xóa", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                receipts.Remove(selectedItem);
            }
            FormListView.Items.Refresh();

        }

        private void editMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new ReceiptWindow();
            addWindow.ShowDialog();
            receipts.Add(addWindow.newRec);
        }

        private void orderDetail_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
