using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Servicos.Model;

namespace Pokedex.Controller
{
    public class ControllerPokemon
    {
        public PokemonSpecies getSpecies(string url)
        {
            return Servicos.ServicoConexao.RecebeEspecies(url);
        }


    }
}
