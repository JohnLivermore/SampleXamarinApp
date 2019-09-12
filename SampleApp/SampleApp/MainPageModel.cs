using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel() : base()
        {
            GaugeSites = new List<GaugeSite>();

            for (var index = 1; index <= 5; index++)
            {
                GaugeSites.Add(new GaugeSite()
                {
                    Description = $"Gauge Site {index}"
                });
            }
        }

        public List<GaugeSite> GaugeSites { get; set; }

        public Command DoSomethingInteresting
        {
            get
            {
                return new Command(() =>
                {

                });
            }
        }
    }

    public class GaugeSite
    {
        public string Description { get; set; }
    }
}
