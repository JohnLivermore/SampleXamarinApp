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
        public MainPageModel(ParentViewModel parentViewModel)
        {
            ParentViewModel = parentViewModel;
        }

        public ParentViewModel ParentViewModel { get; set; }
    }
}
