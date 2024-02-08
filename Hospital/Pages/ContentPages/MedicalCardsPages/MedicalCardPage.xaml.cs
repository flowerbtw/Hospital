using Hospital.Classes;
using Hospital.Database;
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

namespace Hospital.Pages.ContentPages.MedicalCardsPages
{
    /// <summary>
    /// Логика взаимодействия для MedicalCardPage.xaml
    /// </summary>
    public partial class MedicalCardPage : Page
    {
        public MedicalCardPage()
        {
            InitializeComponent();
            DataContext = new MedicalCardViewModel();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredFirstName = FirstNameTextBox.Text;
            string enteredLastName = LastNameTextBox.Text;
            string enteredPatronymic = PatronymicTextBox.Text;
            string enteredPhoto = Photo.Source.ToString();
            string enteredPassport = PassportTextBox.Text;
            string enteredBirthdate = BirthdateTextBox.Text;
            string enteredGender = GenderTextBox.Text;
            string enteredCountry = CountryTextBox.Text;
            string enteredCity = CityTextBox.Text;
            string enteredStreet = StreetTextBox.Text;

            int enteredHouse;
            bool houseResult = int.TryParse(HouseTextBox.Text, out enteredHouse);
            if (!houseResult)
            {
                MessageBox.Show($"Error when saving a record: the house number is written incorrectly");
            }

            int enteredApartment;
            bool apartmentResult = int.TryParse(ApartmentTextBox.Text, out enteredApartment);
            if (!apartmentResult)
            {
                MessageBox.Show($"Error when saving a record: the apartment number is written incorrectly");
            }

            string enteredPhoneNumber = PhoneNumberTextBox.Text;
            string enteredEmail = EmailTextBox.Text;
            string enteredMedicalCardNumber = MedicalCardNumberTextBox.Text;
            string enteredInsuranceNumber = InsuranceNumberTextBox.Text;
            string enteredLastAppointment = LastAppointmentTextBox.Text;
            string enteredNextAppointment = NextAppointmentTextBox.Text;
            string enteredDiagnosis = DiagnosisTextBox.Text;
            string enteredMedicalHistory = MedicalHistoryTextBox.Text;

            try
            {
                var newPatient = new Patient
                {
                    FirstName = enteredFirstName,
                    LastName = enteredLastName,
                    Patronymic = enteredPatronymic,
                    Photo = enteredPhoto,
                    Passport = enteredPassport,
                    Birthdate = enteredBirthdate,
                    Gender = enteredGender,
                    Country = enteredCountry,
                    City = enteredCity,
                    Street = enteredStreet,
                    House = enteredHouse,
                    Apartment = enteredApartment,
                    PhoneNumber = enteredPhoneNumber,
                    Email = enteredEmail,
                    MedicalCardNumber = enteredMedicalCardNumber,
                    InsuranceNumber = enteredInsuranceNumber,
                    LastAppointment = enteredLastAppointment,
                    NextAppointment = enteredNextAppointment,
                    Diagnosis = enteredDiagnosis,
                    MedicalHistory = enteredMedicalHistory,
                };

                DbConnect.dB.Patients.Add(newPatient);
                DbConnect.dB.SaveChanges();

                MessageBox.Show("Record was saved succesfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when saving a record: {ex.Message}");
            }
        }
    }
}
