using Hospital.Pages.ContentPages;
using Hospital.Pages.ContentPages.MedicalCardsPages;
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

namespace Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void PatientRegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            
            NavigationService?.Navigate(new PatientRegistrationPage());
        }

        private void ViewMedicalCardsButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new ViewMedicalCardsPage());
        }

        private void SendToHospitalizationButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new SendToHospitalizationPage());
        }

        private void SendToMedicalProceduresButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new SendToMedicalProceduresPage());
        }

        private void TrackingButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new TrackingPage());
        }

        private void BedOccupancyButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new BedOccupancyPage());
        }

        private void AppointmentSummarySheetsButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService?.Navigate(new AppointmentSummarySheetsPage());
        }
    }
}
