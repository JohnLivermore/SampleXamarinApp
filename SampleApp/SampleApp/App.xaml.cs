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

            MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            //MainPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<Main2PageModel>();
        }
    }
}
