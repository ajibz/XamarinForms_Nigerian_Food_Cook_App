using CookApp.Model;
using CookApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CookApp.ViewModel
{
   public  class CookViewModel:INotifyPropertyChanged
    {
        JsonService jsonservice = new JsonService();
       

        private List<NewCook> _AfriCook;
        public List<NewCook> AfriCook { get { return _AfriCook; } set { _AfriCook = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }




        public async Task<List<NewCook>> GetCook()
        {
            //AfriCook = await jsonservice.GetCookAsync();
            return AfriCook;
        }




        public CookViewModel()
        {
            GetCook();
            

        }
    }
}
