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
using TiemChungApp.Pages;

namespace TiemChungApp.Windows
{
    /// <summary>
    /// Interaction logic for ReceiptWindow.xaml
    /// </summary>
    public partial class ReceiptWindow : Window
    {
        public ReceiptWindow()
        {
            InitializeComponent();
        }
        public Receipt newRec;
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {

            newRec = new Receipt()
            {
                BillID = billid.ToString(),
                CustomerID = Int32.Parse(cusid.Text),
                CreateDate = created.ToString(),
                Total = Int32.Parse(total.Text),
            };
            this.Close();

        }
    }
}
