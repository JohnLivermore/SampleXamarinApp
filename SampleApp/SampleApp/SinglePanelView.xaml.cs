using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SinglePanelView : ContentView
    {
        public SinglePanelView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty PanelVisibleProperty = BindableProperty.Create(
                            propertyName: nameof(PanelVisible),
                            returnType: typeof(bool),
                            declaringType: typeof(PanelView),
                            defaultBindingMode: BindingMode.TwoWay,
                            defaultValue: false,
                            propertyChanged: (bindable, oldValue, newValue) =>
                            {
                                // this is never called
                            });

        public bool PanelVisible
        {
            get { return (bool)base.GetValue(PanelVisibleProperty); }
            set { base.SetValue(PanelVisibleProperty, value); }
        }
    }
}