using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Pokedex.ViewModel
{
    public class HomeViewModel
    {
        public List<Pokemon> listaItens { get; set; }
        public HomeViewModel()
        {

            //Pokemon listaPok = Servicos.ServicoConexao.ReceberPokemon();
            //var a = listaPok.results;

            ListaPokemons lista = Servicos.ServicoConexao.ReceberPokemon();
            listaItens = Servicos.ServicoConexao.ExtraiPokemons(lista);
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
                    //foreach(var pokemon in ListaTipos.ListaPokemons)
                    //{
                    //    if (Pokemon.name.Equals(pokemon.name))
                    //    {
                    //        Pokemon.imagem = pokemon.imagem;
                    //    }
                    //}
                }
            }

        }
    }
}
