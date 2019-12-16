using FreshMvvm;
using System;
using System.Collections.Generic;

namespace SampleApp
{
    public class LoginPageModel : FreshBasePageModel
    {
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);

            Animals = new List<Animal>();
            Animals.Add(new Animal() { Name = "Ape" });
            Animals.Add(new Animal() { Name = "Bear" });
            Animals.Add(new Animal() { Name = "Cat" });
        }

        public List<Animal> Animals { get; set; }
    }

    public class Animal
    {
        public string Name { get; set; }
    }
}
