using Android.App;
using Android.Runtime;
using System;

namespace SampleApp.Droid
{
    [Application]
    public class MainApplication : Application
    {
        public override void OnCreate()
        {
            base.OnCreate();
            Shiny.AndroidShinyHost.Init(this, new SampleApp.Startup());
        }
    }
}