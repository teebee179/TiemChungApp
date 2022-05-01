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
    /// Interaction logic for RegisterVaccine.xaml
    /// </summary>
    public partial class RegisterVaccine : Page
    {
        public List<Vaccine> vaccines = new List<Vaccine>()
        {
            new Vaccine("Verocell", "In stock", "1/1/2021"),
            new Vaccine("Astra zeneca", "In stock", "1/1/2021"),
            new Vaccine("Pfizer", "In stock", "1/1/2021"),
            new Vaccine("Moderna", "Out stock", "1/1/2021"),
        };

        public List<VaccineCombo> combo = new List<VaccineCombo>()
        {
            new VaccineCombo("Combo for 3 to 6 years old", new List<Vaccine>()),
            new VaccineCombo("Combo for pregnant", new List<Vaccine>()),
            new VaccineCombo("Combo for Covid", new List<Vaccine>()),
        };

        public List<String> centre = new List<String>() { "Cơ sở 1", "Cơ sở 2", "Cơ sở 3" };
        public RegisterVaccine()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var availableVaccine = from vaccine in vaccines
                                   where vaccine.status == "In stock"
                                   select vaccine;
            vaccineCombobox.ItemsSource = availableVaccine;
            selectCombo.ItemsSource = combo;
            centreCombobox.ItemsSource = centre;
            
        }

        public List<VaccinationForm> forms = new List<VaccinationForm>();

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";
            if(isMale.IsChecked ?? false)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }

            string combo = "";
            foreach (var item in selectCombo.SelectedItems)
            {
                combo += item.ToString() + ", ";
            }

            string vaccine = "";
            if(vaccineCombobox.SelectedItem == null)
            {
                vaccine = "";
            }
            else
            {
                vaccine = vaccineCombobox.SelectedItem.ToString();
            }

            string centre = "";
            if(centreCombobox.SelectedItem == null)
            {
                centre = "";
            }
            else
            {
                centre = centreCombobox.SelectedItem.ToString();
            }

            var newForm = new VaccinationForm()
            {
                id = 1,
                customerName = username.Text,
                customerId = UserCode.Text,
                DOB = dob.Text,
                address = address.Text,
                telephone = phone.Text,
                parentName = parentName.Text,
                parentRelationship = relationship.Text,
                parentPhone = parentPhone.Text,
                gender = gender,
                centre = centre,
                vaccine = vaccine,
                combo = combo,
            };

            forms.Add(newForm);

            
        }
    }
}
