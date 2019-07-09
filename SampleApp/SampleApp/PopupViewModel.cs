using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class PopupViewModel
    {
        public bool IsOpen { get; set; }
    }
}
