using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ContactsApp.ViewModels
{
    public class AddContactViewModel
    {
        string name = "Gonzalo Lucero";
        string website = "https://github.com/LuceroGonzalo/CorvelDemo";
        bool bestFriend;
        bool isBusy;

        public bool BestFriend
        {
            get { return bestFriend; }
            set { bestFriend = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string DisplayMessage
        {
            get
            {
                return $"Your new friend is named {Name} and " +
                       $"{(bestFriend ? "is" : "is not")} your best friend.";
            }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; }
        }

        void LaunchWebsite()
        {
            try
            {
                Launcher.OpenAsync(new Uri(website));
            }
            catch
            {

            }
        }

        async Task SaveContact()
        {
            IsBusy = true;
            await Task.Delay(4000);

            IsBusy = false;

            await Application.Current.MainPage.DisplayAlert("Save", "Contact has been saved", "OK");
        }
    }
}
