using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class PokemonSpecies
    {
        public PokemonSpeciesText[] flavor_text_entries { get; set; }
        public Genera[] genera { get; set; }
        public Catch catch_rate { get; set; }
        public Growth growth_Rate { get; set; }
        public Habitat habitat { get; set; }
    }
}
