using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.DataGrid;
using Xamarin.Forms;

namespace SampleApp
{
    public static class DataGridHelpers
    {
        public static DataGridColumnHeaderStyle NoOptionsHeaderStyle
        {
            get
            {
                // Always return a new instance so that you avoid issues with multiple columns using the same instance.
                var colHeaderStyle = new DataGridColumnHeaderStyle();

                colHeaderStyle.OptionsButtonTextColor = Color.Transparent;
                colHeaderStyle.OptionsButtonFontSize = 0;
                colHeaderStyle.BorderColor = new Color(0xd9, 0xd9, 0xd9);
                colHeaderStyle.BorderThickness = 1;

                return colHeaderStyle;
            }
        }
    }
}
