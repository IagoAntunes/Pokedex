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
        public ObservableCollection<Pokemon> ListaP { get; set; }
        public List<string> listaPo { get; set; }
        public MainPage()
        {
            InitializeComponent();

            listaPo = new List< string>
            {
                "bulbasaur","ivysaur","venusaur","charmander"
            };

            //Pokemon listaPok = Servicos.ServicoConexao.ReceberPokemon();
            //var a = listaPok.results;

            List<Pokemon> lista = Servicos.ServicoConexao.ReceberPokemon(listaPo);
            atribuirValores(lista);
            Iteste.ItemsSource = lista;
            BindingContext = this;
        }
        public void atribuirValores(List<Pokemon> lista)
        {
            lista[0].imagem = "Bulbasaur2P1";
            lista[0].corFundo = "#8BBE8A";
            lista[1].corFundo = "#8BBE8A";
            lista[2].corFundo = "#8BBE8A";
            lista[3].corFundo = "#FFA756";
            lista[3].imagem = "CharmanderP4";
        }
    }
}
