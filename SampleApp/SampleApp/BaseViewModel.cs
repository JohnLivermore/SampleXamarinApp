using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel
    {
        public bool IsVisible { get; set; }
    }
}
