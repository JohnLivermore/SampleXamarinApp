using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            Items = new List<string>();

            Items.Add("Apple");
            Items.Add("Banana");
            Items.Add("Pear");
        }

        public Command Delete
        {
            get
            {
                return new Command(_ =>
                {
                });
            }
        }

        public List<string> Items { get; set; }
    }
}
