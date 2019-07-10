using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class CompanyModel
    {
        public string CompanyName { get; set; }
        public string LastName { get; set; }
    }
}
