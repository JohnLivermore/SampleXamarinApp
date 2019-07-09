using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class ParentViewModel
    {
        public ParentViewModel()
        {
            PopupViewModel = new PopupViewModel();
        }

        public PopupViewModel PopupViewModel { get; set; }

        public Command OpenChild
        {
            get
            {
                return new Command(() =>
                {
                    PopupViewModel.IsOpen = true;
                });
            }
        }
    }
}
