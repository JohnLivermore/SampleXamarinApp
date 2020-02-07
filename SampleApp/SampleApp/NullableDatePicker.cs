using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    public class NullableDatePicker : DatePicker
    {
        private string _format = null;

        public static readonly BindableProperty NullableDateProperty = BindableProperty.Create(
                                propertyName: nameof(NullableDate),
                                returnType: typeof(DateTime),
                                declaringType: typeof(NullableDatePicker));

        public DateTimeOffset? NullableDate
        {
            get
            {
                var nullableDate = GetValue(NullableDateProperty) as DateTime?;

                if (nullableDate == null) return null;

                return new DateTimeOffset(nullableDate.Value);
            }
            set
            {
                if (value.HasValue)
                {
                    SetValue(NullableDateProperty, new DateTime(value.Value.Ticks));
                }
                else
                {
                    SetValue(NullableDateProperty, null);
                }
                UpdateDate();
            }
        }

        private void UpdateDate()
        {
            if (NullableDate.HasValue && NullableDate.Value.Date != DateTime.MinValue)
            {
                if (null != _format)
                {
                    Format = _format;
                }

                Date = new DateTime(NullableDate.Value.Ticks);
            }
            else
            {
                _format = Format;
                Format = "pick ...";
            }
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            UpdateDate();
        }

        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName == "Date") NullableDate = Date;
        }
    }
}
