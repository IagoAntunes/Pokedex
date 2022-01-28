using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class ListaTipos
    {
        public static List<Categorias> ListaCategorias = new List<Categorias>()
        {
            new Categorias{Nome="Fire",Cor="#FFA152",Imagem="IconFire",CorFundo="#FFA756"},
            new Categorias{Nome="Grass",Cor="#35C04A",Imagem="IconGrass",CorFundo="#8BBE8A"},
            new Categorias{Nome="Poison",Cor="#B97FC9",Imagem="IconPoison"}
        };
        public static List<Pokemon> ListaPokemons = new List<Pokemon>()
       {
           new Pokemon{name = "Bulbasaur",imagem="BulbasaurP2"},
           new Pokemon{name = "Ivysaur",imagem="Ivysaur"},
           new Pokemon{name = "Venusaur",imagem="Venusaur"},
           new Pokemon{name = "Charmander",imagem="Charmander"}
       };
    }
}
