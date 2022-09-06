using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace app_clase_1_demo.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        ContentPage _page;

        string _entryUsername;
        string _entryPassword;

        public string entryPassword
        {
            get { return _entryPassword; }
            set
            {
                if (this._entryPassword != value)
                {
                    this._entryPassword = value;
                    //notify that value changed
                    PropertyChanged.Invoke(
                        this,
                        new PropertyChangedEventArgs(
                            nameof(this.entryPassword)
                            )
                        );
                }
            }
        }
        public string entryUsername
        {
            get
            {
                return _entryUsername;
            }
            set
            {
                if (this._entryUsername != value)
                {
                    this._entryUsername = value;
                    //notify that value changed

                    PropertyChanged.Invoke(
                        this,
                        new PropertyChangedEventArgs(
                            nameof(this.entryUsername)
                            )
                        );
                }
            }
        }

        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel(ContentPage page)
        {
            SubmitCommand = new Command(Login);
            _page = page;
        }


        public async void Login()
        {
            if(entryUsername == "misterPro" && entryPassword == "holo15")
            {
                await _page.DisplayAlert("INFO", "Credenciales Correctas", "OK");
                entryUsername = "";
                entryPassword = "";

            }
            else
            {
                await _page.DisplayAlert("ERROR", "Credenciales Incorrectas", "OK");
            }
        }
    }
}
