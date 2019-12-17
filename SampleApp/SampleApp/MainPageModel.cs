using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            Members = new ObservableCollection<Member>();

            ShowList = false;
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            
            Members.Clear();

            Members.Add(new Member() { Item = "A" });
            Members.Add(new Member() { Item = "B" });
            Members.Add(new Member() { Item = "C" });

            ShowList = true;
        }

        public ObservableCollection<Member> Members { get; set; }

        public bool ShowList { get; set; }

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
