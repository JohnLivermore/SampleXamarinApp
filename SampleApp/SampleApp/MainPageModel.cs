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
        public MainPageModel()
        {
            ParentViewModel = new ParentViewModel();
        }

        public ParentViewModel ParentViewModel { get; set; }
    }
}
