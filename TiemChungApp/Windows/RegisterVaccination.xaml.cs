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
    /// Interaction logic for RegisterVaccination.xaml
    /// </summary>
    public partial class RegisterVaccination : Window
    {
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

        public List<VaccineCombo> combo = new List<VaccineCombo>()
        {
            new VaccineCombo()
            {
                ComboName = "Combo for 3 to 6 years old",
                Vaccines = vaccines
            },
            new VaccineCombo(){
                ComboName = "Combo for 3 to 6 years old",
                Vaccines = vaccines
            },
            new VaccineCombo(){
                ComboName = "Combo for 3 to 6 years old",
                Vaccines = vaccines
            },
        };

        public List<String> centre = new List<String>() { "Cơ sở 1", "Cơ sở 2", "Cơ sở 3" };
        public RegisterVaccination()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var availableVaccine = from vaccine in vaccines
                                   where vaccine.Status == "In stock"
                                   select vaccine;
            vaccineCombobox.ItemsSource = availableVaccine;
            selectCombo.ItemsSource = combo;
            centreCombobox.ItemsSource = centre;

        }

        public VaccinationForm newForm;
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";
            if (isMale.IsChecked ?? false)
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
            if (vaccineCombobox.SelectedItem == null)
            {
                vaccine = "";
            }
            else
            {
                vaccine = vaccineCombobox.SelectedItem.ToString();
            }

            string centre = "";
            if (centreCombobox.SelectedItem == null)
            {
                centre = "";
            }
            else
            {
                centre = centreCombobox.SelectedItem.ToString();
            }

            newForm = new VaccinationForm()
            {
                Id = 1,
                CustomerName = username.Text,
                CustomerId = Int32.Parse(UserCode.Text),
                DOB = dob.ToString(),
                Address = address.Text,
                Telephone = phone.Text,
                ParentName = parentName.Text,
                ParentRelationship = relationship.Text,
                ParentPhone = parentPhone.Text,
                Gender = gender,
                Centre = centre,
                Vaccine = vaccine,
                Combo = combo,
                InjectDate =  injectDate.ToString(),
            };
            
            this.Close();

        }
    }
}
