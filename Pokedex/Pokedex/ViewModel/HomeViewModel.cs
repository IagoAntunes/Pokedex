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
            listaItens = Servicos.ServicoConexao.ReceberPokemon();
            atribuirValores(listaItens);
        }
        public void atribuirValores(List<Pokemon> lista)
        {
            foreach(var Pokemon in lista)
            {
                foreach(var tipoPokemon in Pokemon.types)
                {
                    foreach(var categoria in ListaTipos.ListaCategorias)
                    {
                        if (tipoPokemon.type.name.Equals(categoria.Nome))
                        {
                            tipoPokemon.corTipos = categoria.Cor;
                            tipoPokemon.Imagem = categoria.Imagem;
                            if(string.IsNullOrEmpty(Pokemon.corFundo))
                                Pokemon.corFundo = categoria.CorFundo;
                        }
                    }             
                }
            }
        }
    }
}
