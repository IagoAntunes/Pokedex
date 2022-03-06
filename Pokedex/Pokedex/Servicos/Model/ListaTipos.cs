using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class ListaTipos
    {
        public static List<Categorias> ListaCategorias = new List<Categorias>()
        {
            new Categorias{Nome="Fire",Cor="#FD7D24",Imagem="iconFireNew",CorFundo="#FFA756"},
            new Categorias{Nome="Grass",Cor="#62B957",Imagem="iconGrassNew2",CorFundo="#8BBE8A"},
            new Categorias{Nome="Poison",Cor="#A552CC",Imagem="IconPoisonNew2",CorFundo="#A566C7"}
        };
        public static List<Pokemon> ListaPokemons = new List<Pokemon>()
       {
           new Pokemon{name = "Bulbasaur"},
           new Pokemon{name = "Ivysaur"},
           new Pokemon{name = "Venusaur"},
           new Pokemon{name = "Charmander"}
       };
    }
}
