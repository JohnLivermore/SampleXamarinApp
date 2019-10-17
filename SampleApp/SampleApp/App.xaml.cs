using FreshMvvm;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            var mainPage = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var mainNavigation = new FreshNavigationContainer(mainPage);
            mainNavigation.BarBackgroundColor = Color.FromRgb(0, 69, 140);
            mainNavigation.BarTextColor = Color.White;

            MainPage = mainNavigation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
