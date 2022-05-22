using Newtonsoft.Json;
using Pokedex.Servicos.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Pokedex.Servicos
{
    public class ServicoConexao
    {
        public static List<Pokemon> ReceberPokemon()
        {
            string url = "https://pokeapi.co/api/v2/pokemon?limit=10&offset=0";
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(url);//Recebe dados do site

            ListaPokemons resultados = JsonConvert.DeserializeObject<ListaPokemons>(conteudo);//Converter JSON para objeto

            return ExtraiPokemons(resultados);
        }
        public static List<Pokemon> ExtraiPokemons(ListaPokemons lista)
        {
            List<Pokemon> Pokemons = new List<Pokemon>();
            WebClient wc = new WebClient();
            foreach (var result in lista.results)
            {
                string conteudo = wc.DownloadString(result.url);//Recebe dados do site
                var end = JsonConvert.DeserializeObject<Pokemon>(conteudo);//Converter JSON para objeto
                Pokemons.Add(end);
            }
            return Pokemons;
        }
    
        public static PokemonSpecies RecebeEspecies(string url)
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(url);//Recebe dados do site

            PokemonSpecies resultados = JsonConvert.DeserializeObject<PokemonSpecies>(conteudo);//Converter JSON para objeto

            return resultados;
        }
    
    }
}

