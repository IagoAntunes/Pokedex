using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pokedex.ViewModel
{
    public class HomeViewModel
    {
        public List<string> listaNomes { get; set; }
        public List<Pokemon> listaItens { get; set; }

        public HomeViewModel()
        {
            listaNomes = new List<string>
            {
                "bulbasaur","ivysaur","venusaur","charmander"
            };

            //Pokemon listaPok = Servicos.ServicoConexao.ReceberPokemon();
            //var a = listaPok.results;

            listaItens = Servicos.ServicoConexao.ReceberPokemon(listaNomes);
            atribuirValores(listaItens);
        }
        public void atribuirValores(List<Pokemon> lista)
        {
            foreach(var Pokemon in lista)
            {
                foreach(var tiposPokemon in Pokemon.types)
                {
                    foreach(var categoria in ListaTipos.ListaCategorias)
                    {
                        if (tiposPokemon.type.name.Equals(categoria.Nome))
                        {
                            tiposPokemon.corTipos = categoria.Cor;
                            tiposPokemon.Imagem = categoria.Imagem;
                            if(string.IsNullOrEmpty(Pokemon.corFundo))
                                Pokemon.corFundo = categoria.CorFundo;
                        }
                    }
                    foreach(var pokemon in ListaTipos.ListaPokemons)
                    {
                        if (Pokemon.name.Equals(pokemon.name))
                        {
                            Pokemon.imagem = pokemon.imagem;
                        }
                    }
                }
            }

        }
    }
}
