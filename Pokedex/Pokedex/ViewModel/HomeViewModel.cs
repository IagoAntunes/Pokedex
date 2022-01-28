using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pokedex.ViewModel
{
    public class HomeViewModel
    {
        public ObservableCollection<Pokemon> ListaP { get; set; }
        public List<string> listaNomes { get; set; }
        public List<Pokemon> listaItens { get; set; }
        public HomeViewModel()
        {
            listaNomes = new List<string>
            {
                "bulbasaur","ivysaur","venusaur","charmander"
            };

            //Pokemon listaPok = Servicos.ServicoConexao.ReceberPokemon();
            //var a = listaPok.results;

            listaItens = Servicos.ServicoConexao.ReceberPokemon(listaNomes);
            atribuirValores(listaItens);
        }
        public void atribuirValores(List<Pokemon> lista)
        {
            lista[0].imagem = "BulbasaurP2";
            lista[1].imagem = "Ivysaur";
            lista[2].imagem = "Venusaur";
            lista[3].imagem = "Charmander";

            lista[0].corFundo = "#8BBE8A";
            lista[1].corFundo = "#8BBE8A";
            lista[2].corFundo = "#8BBE8A";
            lista[3].corFundo = "#FFA756";
        }
    }
}
