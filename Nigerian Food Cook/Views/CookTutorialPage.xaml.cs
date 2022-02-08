using CookApp.Model;
using CookApp.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Nigerian_Food_Cook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CookTutorialPage : TabbedPage
    {
        
        public CookTutorialPage()
        {
            InitializeComponent();

            GetCookAsync();
        }


        public async Task GetCookAsync()
        {
            using (var stream = await FileSystem.OpenAppPackageFileAsync("cook.json"))
            {
                using (var reader = new StreamReader(stream))
                {
                    var fileContents = await reader.ReadToEndAsync();

                    List<Cook> CookList = JsonConvert.DeserializeObject<List<Cook>>(fileContents);
                    
                    foreach(var cooking in CookList)
                    {
                        Cake_List.ItemsSource = cooking.Cake;
                        Soup_List.ItemsSource = cooking.Soup;
                        Snacks_List.ItemsSource = cooking.Snacks;
                        Food_List.ItemsSource = cooking.Food;
                        Juice_List.ItemsSource = cooking.Juice;


                        Food_List.RefreshCommand = new Command(() => {

                          
                            Food_List.ItemsSource = null;
                          
                            Food_List.ItemsSource = cooking.Food;
                            Food_List.IsRefreshing = false;
                          
                        });

                        Cake_List.RefreshCommand = new Command(() => {


                            Cake_List.ItemsSource = null;

                            Cake_List.ItemsSource = cooking.Cake;
                            Cake_List.IsRefreshing = false;

                        });

                        Soup_List.RefreshCommand = new Command(() => {


                            Soup_List.ItemsSource = null;

                            Soup_List.ItemsSource = cooking.Soup;
                            Soup_List.IsRefreshing = false;

                        });

                        Snacks_List.RefreshCommand = new Command(() => {


                            Snacks_List.ItemsSource = null;

                            Snacks_List.ItemsSource = cooking.Snacks;
                            Snacks_List.IsRefreshing = false;

                        });

                        Juice_List.RefreshCommand = new Command(() => {


                            Juice_List.ItemsSource = null;

                            Juice_List.ItemsSource = cooking.Juice;
                            Juice_List.IsRefreshing = false;

                        });




                    }
                  
                }
            }

        }


        private void ImageButton_Clicked(object sender, EventArgs e)
        {
          

        }





        private async void Food_List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var food_select_page = new FoodSelectPage();
           var Food_Selected = e.SelectedItem as Food;
            //food_select_page.BindingContext = Food_Selected;
            await Navigation.PushModalAsync(new FoodSelectPage(Food_Selected));
                 
        }
      

        private async void Cake_List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Food_Selected =  e.Item as Cake;
            await Navigation.PushModalAsync(new CakeSelectPage(Food_Selected));
        }

        private async void Snacks_List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Food_Selected = e.Item as Snack;
            await Navigation.PushModalAsync(new SnacksSelectPage(Food_Selected));
        }

        private async void Juice_List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Food_Selected = e.Item as Juice;
            await Navigation.PushModalAsync(new JuiceSelectPage(Food_Selected));
        }

        private async void Soup_List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Food_Selected = e.Item as Soup;
            await Navigation.PushModalAsync(new SoupSelectPage(Food_Selected));
        }

        private async void Food_List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Food_Selected = e.Item as Food;
            await Navigation.PushModalAsync(new FoodSelectPage(Food_Selected));
        }


        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await DisplayAlert("Alert!", "Do you want to Exit this Application?", "Yes", "No");
                if (result)
                {

                    System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
                    
                }
            });

            return true;
        }


    }
}