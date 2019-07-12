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
            Items = new List<ViewModel>() {
                new ViewModel(){Name="A"},
                new ViewModel(){Name="B"},
                new ViewModel(){Name="C"},
                new ViewModel(){Name="D"}
            };
        }

        public List<ViewModel> Items { get; set; }
    }

    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public string Name { get; set; }
    }
}
