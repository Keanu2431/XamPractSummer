using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamPractSummer.Views;

namespace XamPractSummer.ViewModel
{
    public class LoginPageViewModel : BaseViewModel
    {
        #region fields

        private string _errorMessage = "Login Attempt Error";
        private bool _isLoginError;

        #endregion

        #region Properties

        public bool IsLoginError
        {
            get => _isLoginError;
            set
            {
                _isLoginError = value;
                OnPropertyChanged("IsLoginError");
            }
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                _errorMessage = value;
                OnPropertyChanged("ErrorMessage");
            }
        }

        public ICommand LoginCommand => new Command(AttemptLogin);
        // public INavigation Navigation { get; set;}

        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        #endregion

        private void AttemptLogin()
        {
            if (Email.ToLower().Equals("apple") && Password.Equals("pie"))
            {
                Application.Current.MainPage.Navigation.PushAsync(new HomePage(),true);
            }
            else
            {
                IsLoginError = true;
            }
        }
        
        
    }
}