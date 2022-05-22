using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class PokemonSpecies
    {
        public PokemonSpeciesText[] flavor_text_entries { get; set; }
        public Genera[] Genera { get; set; }

    }
}
