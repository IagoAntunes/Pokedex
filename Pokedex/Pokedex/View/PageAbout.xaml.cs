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

            lblStats.Opacity =0.7;
            lblEvolution.Opacity = 0.7;
            lblAbout.Opacity = 1;
        }
        private void ToStats(object sender, EventArgs args)
        {
            lblAbout.IsVisible = false;
            lblStats.IsVisible = true;
            lblEvolution.IsVisible = false;

            lblStats.Opacity = 1;
            lblEvolution.Opacity = 0.7;
            lblAbout.Opacity = 0.7;
        }
        private void ToEvolution(object sender, EventArgs args)
        {
            fAbout.IsVisible = false;
            fStats.IsVisible = false;
            fEvolution.IsVisible = true;

            fStats.Opacity = 0.7;
            fEvolution.Opacity = 1;
            fAbout.Opacity = 0.7;
        }
    }
}