using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : INotifyPropertyChanged
    {
        public MainPageModel()
        {
            LengthString = "";
        }

        private int? _length;
        public string _lengthString;

        public int? Length
        {
            get { return _length; }
            set { SetProperty(ref _length, value); }
        }
        public string LengthString
        {
            get { return _lengthString; }
            set { SetProperty(ref _lengthString, value); }
        }

        // template command
        public Command Process
        {
            get
            {
                return new Command(_ =>
                {
                    LengthString = Length.ToString();
                });
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
            {
                return false;
            }
            storage = value;
            OnPropertyChanged(propertyName);

            return true;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
