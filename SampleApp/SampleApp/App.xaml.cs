using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // ********************************
            // ********************************
            // change this flag to run the different pages
            var runPageThatHasError = true;
            // ********************************
            // ********************************

            if (runPageThatHasError)
            {
                // this page uses a base page and throws an exception stating it can't find the control
                MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            }
            else
            {
                // this page doesn't use a base page and works fine
                MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<Main2PageModel>();
            }
        }
    }
}
