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
            PanelAViewModel = new PanelAViewModel();
            PanelBViewModel = new PanelBViewModel();
        }

        public PanelAViewModel PanelAViewModel { get; set; }
        public PanelBViewModel PanelBViewModel { get; set; }

        public Command ToggleA
        {
            get
            {
                return new Command(() =>
                {
                    PanelAViewModel.IsVisible = !PanelAViewModel.IsVisible;
                });
            }
        }

        public Command ToggleB
        {
            get
            {
                return new Command(() =>
                {
                    PanelBViewModel.IsVisible = !PanelBViewModel.IsVisible;
                });
            }
        }
    }
}
