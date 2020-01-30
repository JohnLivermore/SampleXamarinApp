using System;
using System.Globalization;
using Xamarin.Forms;

namespace SampleApp
{
    public class StringToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "";
            else
                return ((int)value).ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value as string;

            if (string.IsNullOrWhiteSpace(val))
                return null;
            else
            {
                var result = 0;
                int.TryParse(val, out result);
                return result;
            }
        }
    }
}
