﻿using FreshMvvm;
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

            // register main container navigation
            var mainPage = FreshPageModelResolver.ResolvePageModel<MainPageModel>();
            var mainNavigation = new FreshNavigationContainer(mainPage, "MAIN");

            var authPage = FreshPageModelResolver.ResolvePageModel<LoginPageModel>();
            var authNavigation = new FreshNavigationContainer(authPage, "AUTH");

            MainPage = authNavigation;
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
