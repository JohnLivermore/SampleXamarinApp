using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class LoginPageModel : FreshBasePageModel
    {
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            Animals = new List<Animal>();
            Animals.Add(new Animal() { Name = "Ape" });
            Animals.Add(new Animal() { Name = "Bear" });
            Animals.Add(new Animal() { Name = "Cat" });

            base.ViewIsAppearing(sender, e);
        }

        public List<Animal> Animals { get; set; }

        public Command Login
        {
            get
            {
                return new Command(_ =>
                {
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
