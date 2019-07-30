using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }

    public class MyFixedTextColumn : DataGridTextColumn
    {
        public MyFixedTextColumn()
        {
            this.SizeMode = DataGridColumnSizeMode.Fixed;
            this.Width = 20;
        }
    }
}
