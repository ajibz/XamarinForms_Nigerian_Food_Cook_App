using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nigerian_Food_Cook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoupSelectPage : ContentPage
    {
        public SoupSelectPage(CookApp.Model.Soup food_Selected)
        {
            InitializeComponent();


            food_img.Source = food_Selected.Image;
            foodtype.Text = food_Selected.FoodType;
            food_direction.Text = food_Selected.CookDirection;
            food_ingredient.Text = food_Selected.FoodIngredients;
        }
    }
}