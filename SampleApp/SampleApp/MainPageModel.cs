using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public DateTimeOffset? EndingDateTime { get; set; }

        public Command Check
        {
            get
            {
                return new Command(_ =>
                {
                    var val = EndingDateTime;
                });
            }
        }

    }
}
