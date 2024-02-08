using Hospital.Classes;
using Hospital.Database;
using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для ViewMedicalCardsPage.xaml
    /// </summary>
    public partial class ViewMedicalCardsPage : Page
    {
        public ViewMedicalCardsPage()
        {
            InitializeComponent();
            var patientsDbSet = DbConnect.dB.Patients;
            patientsDbSet.Load();
            var patients = patientsDbSet.Local.ToObservableCollection();
            MedicalCardsDataGrid.ItemsSource = patients;
        }

        private void OnRowDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var selectedItem = MedicalCardsDataGrid.SelectedItem as Patient;

            if (selectedItem != null)
            {
                var medicalCardViewModel = new MedicalCardViewModel();

                medicalCardViewModel.FirstName = selectedItem.FirstName;
                medicalCardViewModel.LastName = selectedItem.LastName;
                medicalCardViewModel.Patronymic = selectedItem.Patronymic;
                medicalCardViewModel.Photo = selectedItem.Photo;
                medicalCardViewModel.Passport = selectedItem.Passport;
                medicalCardViewModel.Birthdate = selectedItem.Birthdate;
                medicalCardViewModel.Gender = selectedItem.Gender;
                medicalCardViewModel.Country = selectedItem.Country;
                medicalCardViewModel.City = selectedItem.City;
                medicalCardViewModel.Street = selectedItem.Street;
                medicalCardViewModel.House = (int)selectedItem.House;
                medicalCardViewModel.Apartment = (int)selectedItem.Apartment;
                medicalCardViewModel.PhoneNumber = selectedItem.PhoneNumber;
                medicalCardViewModel.Email = selectedItem.Email;
                medicalCardViewModel.MedicalCardNumber = selectedItem.MedicalCardNumber;
                medicalCardViewModel.InsuranceNumber = selectedItem.InsuranceNumber;
                medicalCardViewModel.LastAppointment = selectedItem.LastAppointment;
                medicalCardViewModel.NextAppointment = selectedItem.NextAppointment;
                medicalCardViewModel.Diagnosis = selectedItem.Diagnosis;
                medicalCardViewModel.MedicalHistory = selectedItem.MedicalHistory;

                var medicalCardPage = new MedicalCardPage { DataContext = medicalCardViewModel };
                NavigationService.Navigate(medicalCardPage);
            }
        }
    }
}
