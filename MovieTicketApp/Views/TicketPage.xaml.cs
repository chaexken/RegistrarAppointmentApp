using MovieTicketApp.Tables;
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
    public partial class TicketPage : ContentPage
    {
       



        public TicketPage()
        {
            InitializeComponent();

            MainPicker.Items.Add("January 9");
            MainPicker.Items.Add("January 10");
            MainPicker.Items.Add("January 11");
            MainPicker.Items.Add("January 12");
            MainPicker.Items.Add("January 13");
            MainPicker.Items.Add("January 14");
            MainPicker.Items.Add("January 15");
            MainPicker.Items.Add("January 16");
            MainPicker.Items.Add("January 17");
            MainPicker.Items.Add("January 18");


            MainPicker2.Items.Add("9:00 am");
            MainPicker2.Items.Add("10:00 am");
            MainPicker2.Items.Add("11:00 am");
            MainPicker2.Items.Add("1:00 pm");
            MainPicker2.Items.Add("2:00 pm");
            MainPicker2.Items.Add("3:00 pm");
            MainPicker2.Items.Add("4:00 pm");
            MainPicker2.Items.Add("5:00 pm");


        }

        private void MainPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = MainPicker.Items[MainPicker.SelectedIndex];

        }

        private void MainPicker2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var quantity = MainPicker2.Items[MainPicker2.SelectedIndex];

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            DisplayAlert("Success", "Your Appointment had been recorded ", "Okay", "Cancel");



        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new HomePage());
        }
    }
}
