using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using app_clase_1_demo.ViewModel;

namespace app_clase_1_demo
{
    public partial class MainPage : ContentPage
    {
        LoginViewModel loginViewModel;
        public MainPage()
        {

            InitializeComponent();
            BindingContext = new LoginViewModel(this);
            loginViewModel = BindingContext as LoginViewModel;

            entryUsername.Completed += (object sender, EventArgs e) =>
            {
                entryPassword.Focus();
            };

            entryPassword.Completed += (object sender, EventArgs e) =>
            {
                loginViewModel.SubmitCommand.Execute(null);
            };
        }

        
}
}
