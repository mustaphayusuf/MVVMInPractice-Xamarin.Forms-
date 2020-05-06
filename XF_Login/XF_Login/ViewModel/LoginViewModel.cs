using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XF_Login.View;

namespace XF_Login.ViewModel
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        {
            
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }


        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter Email and Password", "OK");
            else
            {
                if (Email == "musty4000@gmail.com" && Password == "12345")
                {
                    App.Current.MainPage.DisplayAlert("Login Success", "", "OK");
                    App.Current.MainPage.Navigation.PushAsync(new WelcomePage());
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "Ok");
                }
            }
        }
    }
}
