using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            var label = new Label() { Text = "Hello world" };
            label.SetBinding(Label.TextProperty, new Binding(nameof(MainPageModel.Message)));

            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    label
                }
            };
        }
    }
}
