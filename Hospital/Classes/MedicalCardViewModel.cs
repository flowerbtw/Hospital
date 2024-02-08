using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Classes
{
    public class MedicalCardViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _patronymic;
        private string _photo;
        private string _passport;
        private string _birthdate;
        private string _gender;
        private string _country;
        private string _city;
        private string _street;
        private int _house;
        private int _apartment;
        private string _phoneNumber;
        private string _email;
        private string _medicalCardNumber;
        private string _insuranceNumber;
        private string _lastAppointment;
        private string _nextAppointment;
        private string _diagnosis;
        private string _medicalHistory;

        // Constructor
        public MedicalCardViewModel()
        {
        }

        // Properties for data binding
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
                OnPropertyChanged(nameof(Patronymic));
            }
        }

        public string Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged(nameof(Photo));
            }
        }

        public string Passport
        {
            get => _passport;
            set
            {
                _passport = value;
                OnPropertyChanged(nameof(Passport));
            }
        }

        public string Birthdate
        {
            get => _birthdate;
            set
            {
                _birthdate = value;
                OnPropertyChanged(nameof(Birthdate));
            }
        }

        public string Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }

        public string Country
        {
            get => _country;
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        public string City
        {
            get => _city;
            set
            {
                _city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        public string Street
        {
            get => _street;
            set
            {
                _street = value;
                OnPropertyChanged(nameof(Street));
            }
        }

        public int House
        {
            get => _house;
            set
            {
                _house = value;
                OnPropertyChanged(nameof(House));
            }
        }

        public int Apartment
        {
            get => _apartment;
            set
            {
                _apartment = value;
                OnPropertyChanged(nameof(Apartment));
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string MedicalCardNumber
        {
            get => _medicalCardNumber;
            set
            {
                _medicalCardNumber = value;
                OnPropertyChanged(nameof(MedicalCardNumber));
            }
        }

        public string InsuranceNumber
        {
            get => _insuranceNumber;
            set
            {
                _insuranceNumber = value;
                OnPropertyChanged(nameof(InsuranceNumber));
            }
        }

        public string LastAppointment
        {
            get => _lastAppointment;
            set
            {
                _lastAppointment = value;
                OnPropertyChanged(nameof(LastAppointment));
            }
        }

        public string NextAppointment
        {
            get => _nextAppointment;
            set
            {
                _nextAppointment = value;
                OnPropertyChanged(nameof(NextAppointment));
            }
        }

        public string Diagnosis
        {
            get => _diagnosis;
            set
            {
                _diagnosis = value;
                OnPropertyChanged(nameof(Diagnosis));
            }
        }

        public string MedicalHistory
        {
            get => _medicalHistory;
            set
            {
                _medicalHistory = value;
                OnPropertyChanged(nameof(MedicalHistory));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
