using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        // template command
        public Command OpenDialog
        {
            get
            {
                return new Command(_ =>
                {
                    CoreMethods.PushPageModel<DialogPageModel>(null, modal: true);
                });
            }
        }

    }
}
