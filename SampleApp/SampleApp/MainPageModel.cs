using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            Source = new List<Entity>()
            {
                new Entity() { Name = "abc" },
                new Entity() { Name = "def" }
            };
        }

        public List<Entity> Source { get; set; }
    }

    [AddINotifyPropertyChangedInterface]
    public class Entity
    {
        public string Name { get; set; }
    }
}
