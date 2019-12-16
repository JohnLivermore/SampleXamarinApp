using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            Members = new List<Member>();
            Members.Add(new Member() { Item = "A" });
            Members.Add(new Member() { Item = "B" });
            Members.Add(new Member() { Item = "C" });

            base.ViewIsAppearing(sender, e);
        }

        public List<Member> Members { get; set; }

        public Command Logout
        {
            get
            {
                return new Command(_ =>
                {
                    CoreMethods.SwitchOutRootNavigation("AUTH");
                });
            }
        }
    }

    public class Member
    {
        public string Item { get; set; }
    }
}
