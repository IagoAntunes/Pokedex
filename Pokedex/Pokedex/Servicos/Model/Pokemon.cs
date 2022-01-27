using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Servicos.Model;
namespace Pokedex.Servicos.Model
{
    public class Pokemon
    {
        public int id { get; set; }
        private string _name;
        public string name { get { return _name; } set { _name = char.ToUpper(value[0]).ToString() + value.Substring(1); } }
        public string url { get; set; }
        public ListaTiposPokemons[] types { get; set; }
        public string imagem { get; set; }
        public string corFundo { get; set; }
      
    }
}
