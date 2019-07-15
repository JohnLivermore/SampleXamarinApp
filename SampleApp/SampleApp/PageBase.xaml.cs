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
    public partial class PageBase : ContentPage
    {
        public PageBase ()
        {
            InitializeComponent ();
        }

        public static readonly BindableProperty LabelTextProperty = BindableProperty.Create("LabelText", 
                                                                                            typeof(string), 
                                                                                            typeof(PageBase), 
                                                                                            "Control Template Demo App");
        public string LabelText
        {
            get { return (string)base.GetValue(LabelTextProperty); }
            set { base.SetValue(LabelTextProperty, value); }
        }
    }
}