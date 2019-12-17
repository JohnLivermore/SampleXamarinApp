using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class LoginPageModel : BasePageModel
    {
        public LoginPageModel()
        {
            Animals = new ObservableCollection<Animal>();
            ShowList = false;
        }

        public void Load()
        {
            Animals.Clear();

            Animals.Add(new Animal() { Name = "Ape" });
            Animals.Add(new Animal() { Name = "Bear" });
            Animals.Add(new Animal() { Name = "Cat" });

            ShowList = true;
        }

        public ObservableCollection<Animal> Animals { get; set; }

        private bool _showList;
        public bool ShowList
        {
            get { return _showList; }
            set { SetField(ref _showList, value); }
        }

        public Command Login
        {
            get
            {
                return new Command(_ =>
                {
                    ShowList = false;

                    Xamarin.Forms.Application.Current.MainPage = new MainPage();
                });
            }
        }
    }

    public class Animal
    {
        public string Name { get; set; }
    }
}
