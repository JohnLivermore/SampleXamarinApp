using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class LoginPage : ContentPage
    {
        public LoginPageModel Model { get; set; }

        public LoginPage()
        {
            InitializeComponent();

            Model = new LoginPageModel();

            BindingContext = Model;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Model.Load();
        }
    }
}
