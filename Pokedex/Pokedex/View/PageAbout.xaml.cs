using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageAbout : ContentPage
    {
        public PageAbout(Pokemon pokemon)
        {
            InitializeComponent();
            BindingContext = new ViewModel.AboutViewModel(pokemon);
        }
        private void ToAbout(object sender,EventArgs args)
        {
            fAbout.IsVisible = true;
            fStats.IsVisible = false;
            fEvolution.IsVisible = false;
        }
        private void ToStats(object sender, EventArgs args)
        {
            fAbout.IsVisible = false;
            fStats.IsVisible = true;
            fEvolution.IsVisible = false;
        }
        private void ToEvolution(object sender, EventArgs args)
        {
            fAbout.IsVisible = false;
            fStats.IsVisible = false;
            fEvolution.IsVisible = true;
        }
    }
}