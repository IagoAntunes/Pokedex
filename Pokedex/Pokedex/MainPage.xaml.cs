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
        private void GoAbout(object sender, EventArgs args)
        {
            Frame frameDetalhe = (Frame)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)frameDetalhe.GestureRecognizers[0];
            Pokemon pokemom = tapGest.CommandParameter as Pokemon;
            //Navigation.PushAsync(new Paginas.Detalhes(vaga));

            App.Current.MainPage = new View.PageAbout(pokemom);
        }
    }
}
