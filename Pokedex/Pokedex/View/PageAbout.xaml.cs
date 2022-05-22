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
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new ViewModel.AboutViewModel(pokemon);
        }
        private void ToVoltar(object sender,EventArgs args)
        {
            Navigation.PopAsync();
            //App.Current.MainPage = new MainPage();
        }
        private void ToAbout(object sender,EventArgs args)
        {
            fAbout.IsVisible = true;
            fStats.IsVisible = false;

            lblStats.Opacity =0.7;
            lblAbout.Opacity = 1;
        }
        private void ToStats(object sender, EventArgs args)
        {
            fAbout.IsVisible = false;
            fStats.IsVisible = true;

            lblStats.Opacity = 1;
            lblAbout.Opacity = 0.7;
        }
        private void ToEvolution(object sender, EventArgs args)
        {
            fAbout.IsVisible = false;
            fStats.IsVisible = false;

            lblStats.Opacity = 0.7;
            lblAbout.Opacity = 0.7;
        }
    }
}