using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CookApp.Model
{
   public class Cook:INotifyPropertyChanged
    {
        private List<Snack> _Snacks;
        public List<Snack> Snacks { get { return _Snacks; } set { _Snacks = value; } }
        private List<Food> _Food;
        public List<Food> Food { get { return _Food; } set { _Food = value; } }
        private List<Juice> _Juice;
        public List<Juice> Juice { get { return _Juice; } set { _Juice = value; } }
        private List<Cake> _Cake;
        public List<Cake> Cake { get { return _Cake; } set { _Cake = value; } }
        private List<Soup> _Soup;
        public List<Soup> Soup { get { return _Soup; } set { _Soup = value; } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }



    public class Snack
    {
        public string BgColor { get; set; }
        public string Image { get; set; }
        public string FoodType { get; set; }
        public string CookDirection { get; set; }
        public string FoodIngredients { get; set; }
    }

    public class Food
    {
        public string BgColor { get; set; }
        public string Image { get; set; }
        public string FoodType { get; set; }
        public string CookDirection { get; set; }
        public string FoodIngredients { get; set; }
    }

    public class Juice
    {
        public string BgColor { get; set; }
        public string Image { get; set; }
        public string FoodType { get; set; }
        public string CookDirection { get; set; }
        public string FoodIngredients { get; set; }
    }

    public class Cake
    {
        public string BgColor { get; set; }
        public string Image { get; set; }
        public string FoodType { get; set; }
        public string CookDirection { get; set; }
        public string FoodIngredients { get; set; }
    }

    public class Soup
    {
        public string BgColor { get; set; }
        public string Image { get; set; }
        public string FoodType { get; set; }
        public string CookDirection { get; set; }
        public string FoodIngredients { get; set; }
    }

    

}
