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

namespace Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        int passwordCount = 0;
        int loginCount = 0;

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (loginCount == 0)
            {
                LoginTextBox.Text = string.Empty;
                loginCount = 1;
            }
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (passwordCount == 0)
            { 
                PasswordTextBox.Text = string.Empty;
                passwordCount = 1;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredLogin = LoginTextBox.Text;
            string enteredPassword = PasswordTextBox.Text;

            Doctor doctor = DbConnect.dB.Doctors.FirstOrDefault(p => p.Login == enteredLogin && p.Password == enteredPassword);

            if (doctor != null)
            {
                NavigationService?.Navigate(new MenuPage());
            }
            else
            {
                MessageBox.Show("Wrong login or password");
            }
        }

        private void ForgotPassword_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
