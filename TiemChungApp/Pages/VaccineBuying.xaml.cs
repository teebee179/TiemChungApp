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

namespace TiemChungApp.Pages
{
    /// <summary>
    /// Interaction logic for VaccineBuying.xaml
    /// </summary>
    public partial class VaccineBuying : Page
    {
        private CollectionViewSource VaccineBuyingSource;
        public static List<Vaccine> vaccines = new List<Vaccine>()
        {
            new Vaccine()
            {
                Name = "Verocell",
                Status = "In stock",
                ExpiredDate = "1/1/2021"
            },
            new Vaccine()
            {
                Name = "Astra zeneca",
                Status = "In stock",
                ExpiredDate = "1/1/2021"
            },
            new Vaccine()
            {
                Name = "Pfizer",
                Status = "In stock",
                ExpiredDate = "1/1/2021"
            },
            new Vaccine()
            {
                Name = "Moderna",
                Status = "Out stock",
                ExpiredDate = "1/1/2021"
            },
        };

        public static List<Vaccine> vaccinesBuyingForm = new List<Vaccine>();

        public VaccineBuying()
        {
            InitializeComponent();
            VaccineBuyingSource = (CollectionViewSource)FindResource(nameof(VaccineBuyingSource));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            VaccineBuyingSource.Source = vaccines;
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            var name = vaccineName.Text.Trim();
            var type = vaccineType.Text.Trim();
            var qty = quantity.Text.Trim();
            var vaccine = new Vaccine()
            {
                Name = name,
                Type = type,
                Quantity = qty,
            };

            vaccinesBuyingForm.Add(vaccine);
            if(vaccine.Name != "" && vaccine.Type != "" && vaccine.Quantity != "")
            {
                MessageBox.Show($"Create vaccine buying form with {name} vaccine and quantity: {qty}");
            }
            else
            {
                MessageBox.Show("Order failed");
            }
           
        }
    }
}
