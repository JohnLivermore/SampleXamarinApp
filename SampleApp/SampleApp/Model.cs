using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class Model
    {
        public string Description { get; set; }
    }
}
