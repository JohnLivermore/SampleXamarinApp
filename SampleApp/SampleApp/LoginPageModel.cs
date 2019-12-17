using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class LoginPageModel : FreshBasePageModel
    {
        public LoginPageModel()
        {
            Animals = new ObservableCollection<Animal>();
            ShowList = false;
        }

        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            Animals.Clear();

            Animals.Add(new Animal() { Name = "Ape" });
            Animals.Add(new Animal() { Name = "Bear" });
            Animals.Add(new Animal() { Name = "Cat" });

            ShowList = true;
        }

        public ObservableCollection<Animal> Animals { get; set; }

        public bool ShowList { get; set; }

        public Command Login
        {
            get
            {
                return new Command(_ =>
                {
                    ShowList = false;

                    CoreMethods.SwitchOutRootNavigation("MAIN");
                });
            }
        }
    }

    public class Animal
    {
        public string Name { get; set; }
    }
}
