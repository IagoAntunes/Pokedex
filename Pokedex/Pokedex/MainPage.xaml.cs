using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pokedex
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ViewModel.HomeViewModel();
           
        }
        public void GoAbout(object sender,EventArgs args)
        {
            App.Current.MainPage = new View.PageAbout();
        }
   
    }
}
