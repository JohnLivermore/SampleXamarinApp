using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            PanelAViewModel = new PanelAViewModel() { IsVisible = true };
            PanelBViewModel = new PanelBViewModel();
        }

        public PanelAViewModel PanelAViewModel { get; set; }
        public PanelBViewModel PanelBViewModel { get; set; }

        public Command Toggle
        {
            get
            {
                return new Command(() =>
                {
                    PanelAViewModel.IsVisible = !PanelAViewModel.IsVisible;
                    PanelBViewModel.IsVisible = !PanelBViewModel.IsVisible;
                });
            }
        }

        public bool IsVisible { get; set; }

    }
}
