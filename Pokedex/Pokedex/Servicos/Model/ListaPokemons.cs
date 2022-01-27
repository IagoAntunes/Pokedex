using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class ListaPokemons
    {
        public int count { get; set; }
        public Pokemon[] results { get; set; }
    }
}
