using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class Main2PageModel : FreshBasePageModel
    {
        public Main2PageModel() : base()
        {
            Models = new List<Model>();

            for (var index = 1; index <= 5; index++)
            {
                Models.Add(new Model()
                {
                    Description = $"Model {index}"
                });
            }
        }

        public List<Model> Models { get; set; }

        public Command DoSomethingInteresting
        {
            get
            {
                return new Command((e) =>
                {
                    Debug.WriteLine("doing something interesting here");
                });
            }
        }
    }
}
