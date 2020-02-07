using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public DateTime StartDateTime { get; set; }
        public DateTimeOffset? EndingDateTime { get; set; }
    }
}
