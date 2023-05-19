using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamPractSummer.ViewModel
{
    public class LoginPageViewModel:INotifyPropertyChanged
    {
        public ICommand LoginCommand
        {
            get => new Command(() =>
            {
                App.Current.MainPage.DisplayAlert(this.Email, this.Password, "Close");
            });
        }

        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public event PropertyChangedEventHandler PropertyChanged;
    }
}