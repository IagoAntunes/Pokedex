using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Controller;

namespace Pokedex.Servicos.Model
{
    public class Species
    {
        public string name { get; set; }
        public string url { get; set; }
        public string genera { get; set; }

        public string texto { get; set; }
        PokemonSpecies pokemonEsp;

        public Species(string name,string url)
        {
            this.name = name;
            this.url = url;
            var controller = new ControllerPokemon();
            pokemonEsp = controller.getSpecies(url);
            texto = pokemonEsp.flavor_text_entries[10].flavor_text;
            genera = pokemonEsp.Genera[7].genus;
        }
    }
}
