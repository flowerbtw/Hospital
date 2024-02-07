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
            NavigationService.Navigate(new MedicalCardPage());
        }
    }
}
