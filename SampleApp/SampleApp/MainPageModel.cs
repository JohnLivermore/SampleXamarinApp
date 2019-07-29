using FreshMvvm;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            Source = new ObservableCollection<Entity>();
        }

        public ObservableCollection<Entity> Source { get; set; }

    }

    public class Entity
    {
        public string Name { get; set; }
    }
}
