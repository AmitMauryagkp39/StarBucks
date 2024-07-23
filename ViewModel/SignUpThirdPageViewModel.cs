using MAUITutorial.Messages;
using MAUITutorial.Utilities;
using MAUITutorial.View;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUITutorial.ViewModel
{
    public class SignUpThirdPageViewModel :BindableObject
    {
        public SignUpThirdPageViewModel()
        {

             isPasswordTF2 = false;
            openHidePassword2 = Constant2.PasswordHide2;
        }





        private string email;

        public string Email
        {
            get 
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private string password;

        public string Password
        {
            get
            {
                return password;
            }
            set 
            {
                password = value;
                OnPropertyChanged(nameof(Password));   
            }
        }






        public Command ChangeBackPage
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync(new LoginPageSecondView());
                });
            }
        }


        public Command ChangeBackPage2
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync(new LoginPageSecondView());
                });
            }
        }


        public Command SignupCmd
        {
           get
            {
                return new Command(() =>
                {
                    Signup();
                });
            }
        }


        public async void Signup()
        {
          string valid = Validation(Email, Password);
            if (valid == null)
            {
                await App.Current.MainPage.DisplayAlert("Message", "Sign up successfully!", "Ok");
            }
            else
            {
                await Utility.ToastMessage(valid);
            }
        }




        public string Validation (string Email, string Password)
        {
            if(string.IsNullOrEmpty(Email) || string.IsNullOrWhiteSpace(Email))
            {
                return ("Please enter email");
            }
          else if(string.IsNullOrEmpty(Password)|| string.IsNullOrWhiteSpace(Password))
            {
                return ("Please enter password");
            }
            else if(!IsAcceptAgreement)
                {
                return ("Please allow checkbox");
            }
            else
            {
                return null;
            }
        }


        private bool isAcceptAgreement;

        public bool IsAcceptAgreement
        {
            get 
            {
                return isAcceptAgreement;
            }
            set 
            {
                isAcceptAgreement = value;
                OnPropertyChanged(nameof (IsAcceptAgreement));
           
            }
        }



       




        private bool isPasswordTF2;

        public bool IsPasswordTF2
        {
            get { return isPasswordTF2; }
            set
            {
                isPasswordTF2 = value;
                OnPropertyChanged(nameof(IsPasswordTF2));
            }

        }



        private string openHidePassword2;

        public string OpenHidePassword2
        {
            get
            {
                return openHidePassword2;
            }
            set
            {
                openHidePassword2 = value;
                OnPropertyChanged(nameof(OpenHidePassword2));
            }
        }



        public Command OpenHidePasswordCmd2
        {
            get
            {
                return new Command(async () =>
                {
                    if (OpenHidePassword2 == Constant2.PasswordHide2)
                    {
                        OpenHidePassword2 = Constant2.PasswordOpen2;
                        IsPasswordTF2 = false;
                        await Utility2.ToastMessage(MessageFile.PassordShow);
                    }
                    else
                    {
                        OpenHidePassword2 = Constant2.PasswordHide2;
                        IsPasswordTF2 = true;
                        await Utility2.ToastMessage(MessageFile.PasswordHide);

                    }

                });
            }
        }



        public Command LoginCmd
        {
            get
            {
                return new Command(()=>
                {
                    App.Current.MainPage.Navigation.PushAsync(new LoginPageSecondView());
                });
            }
        }




    }
}


  
