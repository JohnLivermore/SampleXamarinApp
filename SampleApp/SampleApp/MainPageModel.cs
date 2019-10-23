using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : INotifyPropertyChanged
    {
        public MainPageModel()
        {
            _Animals = new List<string>() { "Chicken", "Cow" };
        }

        private List<string> _Animals;
        public List<string> Animals
        {
            get { return _Animals; }
            set
            {
                _Animals = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Animals"));
            }
        }

        public Command Upgrade
        {
            get
            {
                return new Command(_ =>
                {
                    Animals = new List<string>() { "Eagle", "Elephant" };
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
