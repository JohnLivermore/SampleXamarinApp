using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public bool Dialog1Open { get; set; }
        public bool Dialog2Open { get; set; }

        public ICommand OpenDialog1
        {
            get
            {
                return new Command(() => { Dialog1Open = true; });
            }
        }

        public ICommand OpenDialog2
        {
            get
            {
                return new Command(() => { Dialog2Open = true; });
            }
        }
    }
}
