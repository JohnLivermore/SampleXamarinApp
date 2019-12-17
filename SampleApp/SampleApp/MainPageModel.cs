using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SampleApp
{
    public class MainPageModel : BasePageModel
    {
        public MainPageModel()
        {
            Members = new ObservableCollection<Member>();
        }

        public void Load()
        {
            Members.Add(new Member() { Item = "A" });
            Members.Add(new Member() { Item = "B" });
            Members.Add(new Member() { Item = "C" });
        }

        public ObservableCollection<Member> Members { get; set; }
    }

    public class Member
    {
        public string Item { get; set; }
    }
}
