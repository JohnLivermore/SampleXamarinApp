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
                new Entity() { Name = "abc", Occupation = "ghi"},
                new Entity() { Name = "def", Occupation = "jkl" }
            };
        }

        public List<Entity> Source { get; set; }
    }

    [AddINotifyPropertyChangedInterface]
    public class Entity
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
    }
}
