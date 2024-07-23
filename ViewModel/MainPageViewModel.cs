
using MAUITutorial.View;

namespace MAUITutorial.ViewModel
{
    public class MainPageViewModel : BindableObject
    {
        public MainPageViewModel()
        {
            //ChangeBorderColor = "Bye Bye Xamarin";
            //ChangeFontSize = 30;
            //ChangeFontAttribute = "None";

            //changeBorderColor = "Black";
            //LoginPasswordOpenHide = "hidepassword.png";
            //IsPasswordTrueFalse = true;
        }

        public Command ChangeLoginPage
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync (new LoginPageSecondView());
                });
            }
        }




        public Command ChangeSigneUpPage
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage.Navigation.PushAsync(new SignUPView());
                });
            }
        }
 

         
        //public Command SignUpCmd
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            App.Current.MainPage.Navigation.PushAsync(new StackPageDemo());
        //        });
        //    }
        //}




        //public Command ChangeBackPage
        //{
        //    get
        //    {
        //        return new Command(() =>
        //            {
        //                App.Current.MainPage.Navigation.PushAsync(new LoginPageFirstView());
        //            });
                    
        //    }
        //}
         
        //public Command  ChangeBackPageSecond
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            App.Current.MainPage.Navigation.PushAsync(new LoginPageSecondView());
        //        });
        //    }
        //}



        //public Command ChangeLoginButton
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            App.Current.MainPage.Navigation.PushAsync(new SignUPView());
        //        });
        //    }
        //}



        


        //public Command LoginPageChange
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            App.Current.MainPage.Navigation.PushAsync(new SignUPView());
        //        });
        //    }
        //}




        //private string changeBorderColor;

        //public string ChangeBorderColor
        //{
        //    get { return changeBorderColor; }
        //    set
        //    {
        //        changeBorderColor = value;
        //        OnPropertyChanged(nameof(ChangeBorderColor));
        //    }
        //}




        //private bool isPasswordTrueFalse;

        //public bool IsPasswordTrueFalse
        //{
        //    get { return isPasswordTrueFalse; }
        //    set
        //    {
        //        isPasswordTrueFalse = value;
        //        OnPropertyChanged(nameof(IsPasswordTrueFalse));
        //    }
        //}








        //private string loginPasswordOpenHide;
        //public string LoginPasswordOpenHide
        //{
        //    get { return loginPasswordOpenHide; }
        //    set
        //    {
        //        loginPasswordOpenHide = value;
        //        OnPropertyChanged(nameof(LoginPasswordOpenHide));
        //    }
        //}




        //public Command LoginPasswordImageCmd
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            if (LoginPasswordOpenHide == "hidepassword.png")
        //            {
        //                LoginPasswordOpenHide = "openpassword.png";
        //                IsPasswordTrueFalse = false;
        //            }
        //            else
        //            {
        //                LoginPasswordOpenHide = "hidepassword.png";
        //                IsPasswordTrueFalse = true;
        //            }
        //        });
        //    }
        //}





        //////change login page 2

        //private bool isPasswordTF2;

        //public bool IsPasswordTF2
        //{
        //    get { return isPasswordTF2; }
        //    set
        //    {
        //        isPasswordTF = value;
        //        OnPropertyChanged(nameof(IsPasswordTF2));
        //    }

        //}



        //private string openHidePassword2;

        //public string OpenHidePassword2
        //{
        //    get
        //    {
        //        return openHidePassword2;
        //    }
        //    set
        //    {
        //        openHidePassword2 = value;
        //        OnPropertyChanged(nameof(OpenHidePassword2));
        //    }
        //}



        //public Command OpenHidePasswordCmd2
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            if (OpenHidePassword2 == "hidepassword")
        //            {
        //                OpenHidePassword2 = "openpassword.png";
        //                IsPasswordTF2 = false;
        //            }
        //            else
        //            {
        //                OpenHidePassword2 = "hidepassword.png";
        //                IsPasswordTF2 = true;
        //            }

        //        });
        //    }
        //}







        //private int changeFontSize;

        //public int ChangeFontSize
        //{
        //    get { return changeFontSize; }
        //    set
        //    {
        //        changeFontSize = value;
        //        OnPropertyChanged(nameof(ChangeFontSize));
        //    }
        //}



        //private string changeFontAttribute;

        //public string ChangeFontAttribute
        //{
        //    get { return changeFontAttribute; }
        //    set
        //    {
        //        changeFontAttribute = value;
        //        OnPropertyChanged(nameof(ChangeFontAttribute));
        //    }
        //}









        //private string hidepassword;

        //public string Hidepassword
        //{
        //    get
        //    {
        //        return hidepassword;
        //    }
        //    set
        //    {
        //        hidepassword = value;

        //        if (hidepassword == value)
        //        {
        //            hidepassword = unchecked(value);
        //        }
        //        else
        //        {
        //            Hidepassword = null;
        //        }
        //        OnPropertyChanged(nameof(Hidepassword));
        //    }

        //}


        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value;
        //        if (!string.IsNullOrWhiteSpace(Name))
        //        {
        //            Password = Name;
        //        }
        //        else
        //        {
        //            Password=string.Empty;
        //        }

        //        OnPropertyChanged(nameof(Name));
        //    }
        //}

        //private string password;
        //public string Password
        //{
        //    get { return password; }
        //    set { password = value;
        //        OnPropertyChanged(nameof(Password));
        //    }
        //}




        //public Command Logincmd1
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            App.Current.MainPage.Navigation.PushAsync(new SignUPView());
        //        });
        //    }
        ////}

        //public Command ChangeFontAttributes
        //{
        //    get
        //    {
        //        return new Command(() =>
        //        {
        //            App.Current.MainPage.Navigation.PushAsync(new ActivityControlPage());
        //        });
        //    }
        //}

        //public Command ForgotCmd
        //{
        //    get
        //    {
        //        return new Command(() =>
        //    {
        //        App.Current.MainPage.Navigation.PushAsync(new ForgotPageView());
        //    });
        //    }




            //public Command ChnageFrameClorCmd 
            //{
            //    get
            //    {
            //        return new Command(() =>
            //        {
            //            if (ChangeBorderColor == "Welcome MAUI.")
            //            {
            //                ChangeBorderColor = "Hi Team";
            //                ChangeFontSize = 20;
            //                ChangeFontAttribute = "Italic";
            //            }
            //            else
            //            {
            //                ChangeBorderColor = "Welcome MAUI.";
            //                ChangeFontSize = 40;
            //                ChangeFontAttribute = "Bold";
            //            } 
            //        });

        }

    }


