using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : FreshBasePageModel
    {
        public MainPageModel()
        {
            Model = new Model();
        }

        public Model Model { get; set; }
    }

    public class Model : INotifyPropertyChanged
    {
        private int? _length;

        public int? Length
        {
            get { return _length; }
            set { SetProperty(ref _length, value); }
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
