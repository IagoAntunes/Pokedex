using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class TiposPokemon
    {
        private string _name;
        public string name { get { return _name; } set { _name = char.ToUpper(value[0]).ToString() + value.Substring(1); } }
        public string url { get; set; }
    }
}
