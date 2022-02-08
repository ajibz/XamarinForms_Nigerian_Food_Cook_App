using CookApp.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nigerian_Food_Cook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodSelectPage : ContentPage
    {
        
        public FoodSelectPage(Food Food_Selected)
        {
            InitializeComponent();
          
            food_img.Source = Food_Selected.Image;
            foodtype.Text = Food_Selected.FoodType;
            food_direction.Text = Food_Selected.CookDirection;
            food_ingredient.Text = Food_Selected.FoodIngredients;

         
        }
      
           
        
    }
}