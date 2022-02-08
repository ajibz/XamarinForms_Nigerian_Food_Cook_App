
using Nigerian_Food_Cook.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nigerian_Food_Cook
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new CookFlyoutPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
