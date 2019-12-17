using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : BasePageModel
    {
        public MainPageModel()
        {
            Members = new ObservableCollection<Member>();

            ShowList = false;
        }

        public void Load()
        {
            Members.Add(new Member() { Item = "A" });
            Members.Add(new Member() { Item = "B" });
            Members.Add(new Member() { Item = "C" });

            ShowList = true;
        }

        public ObservableCollection<Member> Members { get; set; }

        private bool _showList;
        public bool ShowList
        {
            get { return _showList; }
            set { SetField(ref _showList, value); }
        }

        public Command Logout
        {
            get
            {
                return new Command(_ =>
                {
                    ShowList = false;
                    Xamarin.Forms.Application.Current.MainPage = new LoginPage();
                });
            }
        }
    }

    public class Member
    {
        public string Item { get; set; }
    }
}
