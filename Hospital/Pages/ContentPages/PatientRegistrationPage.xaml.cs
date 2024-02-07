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

namespace Hospital.Pages.ContentPages
{
    /// <summary>
    /// Логика взаимодействия для PatientRegistrationPage.xaml
    /// </summary>
    public partial class PatientRegistrationPage : Page
    {
        int firstNameClicksCount = 0;
        int lastNameClicksCount = 0;
        int patronymicClicksCount = 0;
        int passportClicksCount = 0;
        int birthdateClicksCount = 0;
        int genderClicksCount = 0;
        int countryClicksCount = 0;
        int cityClicksCount = 0;
        int streetClicksCount = 0;
        int houseClicksCount = 0;
        int apartmentClicksCount = 0;
        int phoneNumberClicksCount = 0;
        int emailClicksCount = 0;
        int medicalCardNumberClicksCount = 0;
        int insuranceNumberClicksCount = 0;
        int lastAppointmentClicksCount = 0;
        int nextAppointmentClicksCount = 0;
        int diagnosisClicksCount = 0;
        int medicalHistoryClicksCount = 0;

        public PatientRegistrationPage()
        {
            InitializeComponent();
        }

        private void FirstNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstNameClicksCount == 0)
            {
                FirstNameTextBox.Text = string.Empty;
                firstNameClicksCount = 1;
            }
        }

        private void LastNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastNameClicksCount == 0)
            {
                LastNameTextBox.Text = string.Empty;
                lastNameClicksCount = 1;
            }
        }

        private void PatronymicTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (patronymicClicksCount == 0)
            {
                PatronymicTextBox.Text = string.Empty;
                patronymicClicksCount = 1;
            }
        }

        private void PassportTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passportClicksCount == 0)
            {
                PassportTextBox.Text = string.Empty;
                passportClicksCount = 1;
            }
        }

        private void BirthdateTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (birthdateClicksCount == 0)
            {
                BirthdateTextBox.Text = string.Empty;
                birthdateClicksCount = 1;
            }
        }

        private void GenderTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (genderClicksCount == 0)
            {
                GenderTextBox.Text = string.Empty;
                genderClicksCount = 1;
            }
        }

        private void CountryTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (countryClicksCount == 0)
            {
                CountryTextBox.Text = string.Empty;
                countryClicksCount = 1;
            }
        }

        private void CityTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (cityClicksCount == 0)
            {
                CityTextBox.Text = string.Empty;
                cityClicksCount = 1;
            }
        }

        private void StreetTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (streetClicksCount == 0)
            {
                StreetTextBox.Text = string.Empty;
                streetClicksCount = 1;
            }
        }

        private void HouseTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (houseClicksCount == 0)
            {
                HouseTextBox.Text = string.Empty;
                houseClicksCount = 1;
            }
        }

        private void ApartmentTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (apartmentClicksCount == 0)
            {
                ApartmentTextBox.Text = string.Empty;
                apartmentClicksCount = 1;
            }
        }

        private void PhoneNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (phoneNumberClicksCount == 0)
            {
                PhoneNumberTextBox.Text = string.Empty;
                phoneNumberClicksCount = 1;
            }
        }

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (emailClicksCount == 0)
            {
                EmailTextBox.Text = string.Empty;
                emailClicksCount = 1;
            }
        }

        private void MedicalCardNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (medicalCardNumberClicksCount == 0)
            {
                MedicalCardNumberTextBox.Text = string.Empty;
                medicalCardNumberClicksCount = 1;
            }
        }

        private void InsuranceNumberTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (insuranceNumberClicksCount == 0)
            {
                InsuranceNumberTextBox.Text = string.Empty;
                insuranceNumberClicksCount = 1;
            }
        }

        private void LastAppointmentTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (lastAppointmentClicksCount == 0)
            {
                LastAppointmentTextBox.Text = string.Empty;
                lastAppointmentClicksCount = 1;
            }
        }

        private void NextAppointmentTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (nextAppointmentClicksCount == 0)
            {
                NextAppointmentTextBox.Text = string.Empty;
                nextAppointmentClicksCount = 1;
            }
        }

        private void DiagnosisTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (diagnosisClicksCount == 0)
            {
                DiagnosisTextBox.Text = string.Empty;
                diagnosisClicksCount = 1;
            }
        }

        private void MedicalHistoryTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (medicalHistoryClicksCount == 0)
            {
                MedicalHistoryTextBox.Text = string.Empty;
                medicalHistoryClicksCount = 1;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredFirstName = FirstNameTextBox.Text;
            string enteredLastName = LastNameTextBox.Text;
            string enteredPatronymic = PatronymicTextBox.Text;
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
                MessageBox.Show($"Error when creating a record: the house number is written incorrectly");
            }

            int enteredApartment;
            bool apartmentResult = int.TryParse(ApartmentTextBox.Text, out enteredApartment);
            if (!apartmentResult)
            {
                MessageBox.Show($"Error when creating a record: the apartment number is written incorrectly");
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

                MessageBox.Show("A new record has been created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when creating a record: {ex.Message}");
            }
        }
    }
}
