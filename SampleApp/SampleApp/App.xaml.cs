using Shiny;
using Shiny.Jobs;
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
        }

        protected override async void OnStart()
        {
            var job = new JobInfo
            {
                Identifier = "YourFirstJob",
                Type = typeof(YourFirstJob),

                // these are criteria that must be met in order for your job to run
                BatteryNotLow = false,
                DeviceCharging = false,
                RequiredInternetAccess = InternetAccess.Any,
                Repeat = true //defaults to true, set to false to run once OR set it inside a job to cancel further execution
            };

            //// you can pass variables to your job
            //job.SetValue("Id", 10);


            // lastly, schedule it to go - don't worry about scheduling something more than once, we just update if your job name matches an existing one
            await ShinyHost.Resolve<Shiny.Jobs.IJobManager>().Schedule(job);
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
