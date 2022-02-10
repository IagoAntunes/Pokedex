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
        public int height { get; set; }
        public int weight { get; set; }
        public string nameAbility { get; set; }
        public ListaTiposPokemons[] types { get; set; }

        public string mensagem = "";
        public string imagem { get; set; }
        public string corFundo { get; set; }

        public AboutViewModel(Pokemon pokemon)
        {
            name = pokemon.name;
            id = pokemon.id;
            imagem = pokemon.imagem;
            corFundo = pokemon.corFundo;
            types = pokemon.types;
            height = pokemon.Height;
            weight = pokemon.Weight;

            foreach(var item in pokemon.abilities)
            {
                mensagem = mensagem + (char.ToUpper(item.ability.name[0]).ToString() + item.ability.name.Substring(1)) + " - ";
            }
            nameAbility = mensagem;


        }
    }
}
