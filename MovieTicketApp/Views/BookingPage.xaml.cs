using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieTicketApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingPage : ContentPage
    {
        public BookingPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TicketPage());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TicketPage());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TicketPage());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TicketPage());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TicketPage());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TicketPage());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new HomePage());
        }
    }
}