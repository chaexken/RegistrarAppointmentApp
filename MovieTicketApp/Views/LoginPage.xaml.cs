using MovieTicketApp.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieTicketApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

   
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new RegistrationPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);

            var myquery = db.Table<RegisterUserTable>().Where(u => u.Username.Equals(EntryUsername.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();
            if (myquery != null)
            {

                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed Username or password", "Yes", "Cancel");

                    if (result)
                        App.Current.MainPage = new NavigationPage(new LoginPage());
                    else
                    {
                        App.Current.MainPage = new NavigationPage(new LoginPage());
                    }
                });
            }
        }
    }
}

