using MAUITutorial.Messages;
using MAUITutorial.Utilities;
using MAUITutorial.View;

namespace MAUITutorial.ViewModel
{
    public  class LoginPageSecondViewModel : BindableObject
    {
        public LoginPageSecondViewModel() 
        {
           isPasswordTF = true;
            OpenHidePassword = Constant.PasswordHide;
        }

        private string uaername;

        public string Username
        {
            get { return uaername; }
            set
            {
                uaername = value;
                OnPropertyChanged(nameof(Username));
            }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        private bool isPasswordTF;

        public bool IsPasswordTF
        {
            get { return isPasswordTF; }
            set
            {
                isPasswordTF = value;
                OnPropertyChanged(nameof(IsPasswordTF));
            }
        }



        private string openHidePassword;

        public string OpenHidePassword
        {
            get
            {
                return openHidePassword;
            }
            set
            {
                openHidePassword = value;
                OnPropertyChanged(nameof(OpenHidePassword));
            }
        }



        public Command OpenHidePasswordCmd
        {
            get
            {
                return new Command(async () =>
                {
                    if (OpenHidePassword == Constant.PasswordHide)
                    {
                        OpenHidePassword = Constant.PasswordShow;
                        IsPasswordTF = false;
                        await Utility.ToastMessage(MessageFile.PassordShow);
                    }
                    else
                    {
                        OpenHidePassword= Constant.PasswordHide;
                        IsPasswordTF = true;
                        await Utility.ToastMessage(MessageFile.PasswordHide);
                    }

                });
            }
        }


        public Command ChangeBackPage
        {
            get
            {
                return new Command(() =>
                    {
                        App.Current.MainPage.Navigation.PushAsync(new LoginPageFirstView());
                    });
            }
        }
        public Command LoginCmd
        {
            get
            {
                return new Command(() =>
                    {
                        Login();
                    });

            }
        }

        public async void Login()
        {
            string valid = valididation(Username, Password);
            if(valid == null)
            {
                await App.Current.MainPage.DisplayAlert("Message", "Login successfully.", "Ok");
            }
            else
            {
                await Utility.ToastMessage(valid);
            }

        }


        public string valididation(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                return "Enter username.";
            }
            else if (string.IsNullOrEmpty(password))
            {
                return "Enter password.";
            }
            else if (!AllowCheckBox)
            {
                return ("Please allow checkbox");
            }
            else
            {
                return null;
            }
        }


        private  bool allowCheckBox;

        public bool AllowCheckBox
        {
            get
            {
                return allowCheckBox;
            }
            set
            {
                allowCheckBox = value;
                OnPropertyChanged(nameof(AllowCheckBox));
            }
        }

        public Command SignUpCmd
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync(new SignUPView());
                });
            }
        }
    }
}

