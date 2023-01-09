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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            SetValue(NavigationPage.HasBackButtonProperty,false);
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);

            db.CreateTable<RegisterUserTable>();

            var item = new RegisterUserTable()
            {
                Username = EntryUserName.Text,
                Password = EntryPassword.Text,
                YrLvl = EntryYrLvl.Text,
                PatronType = EntryPatronType.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Congratulation", "User Recognition Successful ", "Yes", "Cancel");

                if (result)
                    App.Current.MainPage = new NavigationPage(new LoginPage());
            });
        }
    }
}