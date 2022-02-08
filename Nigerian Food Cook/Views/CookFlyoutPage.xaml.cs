using CookApp.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nigerian_Food_Cook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookFlyoutPage : FlyoutPage
    {
        public CookFlyoutPage()
        {
            InitializeComponent(); 
        }

        private void Learn_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new CookTutorialPage());
            IsPresented = false;

        }

      
    }
}