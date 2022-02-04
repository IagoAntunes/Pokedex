using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.ViewModel
{
    public class AboutViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imagem { get; set; }
        public string corFundo { get; set; }

        public ListaTiposPokemons[] types { get; set; }
        public AboutViewModel(Pokemon pokemon)
        {
            name = pokemon.name;
            id = pokemon.id;
            imagem = pokemon.imagem;
            corFundo = pokemon.corFundo;
            types = pokemon.types;
        }
    }
}
