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
        public bool DialogVisible { get; set; }

        public ICommand ShowDialog
        {
            get
            {
                return new Command(() =>
                {
                    DialogVisible = true;
                });
            }
        }
    }
}
