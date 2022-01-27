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
        private static string EnderecoURL = "https://pokeapi.co/api/v2/pokemon?offset=300&limit=10";

        //public static ListaPokemons ReceberListaPokemons()
        //{

        //    WebClient wc = new WebClient();
        //    string conteudo = wc.DownloadString(EnderecoURL);//Recebe dados do site

        //    ListaPokemons end = JsonConvert.DeserializeObject<ListaPokemons>(conteudo);//Converter JSON para objeto
        //    for(int i=0;i<9;i++)
        //    {
        //        end.results[i] = BuscarInfoPokemon(end.results[i].url);
        //    }
            
        //    return end;
        //}
        public static List<Pokemon> ReceberPokemon(List<string> ListaPo)
        {
            List<Pokemon> Pokemons = new List<Pokemon>();
            string url = "https://pokeapi.co/api/v2/pokemon/";
            WebClient wc = new WebClient();
            foreach (var item in ListaPo)
            {
                url = url + item;
                string conteudo = wc.DownloadString(url);//Recebe dados do site
                Pokemon end = JsonConvert.DeserializeObject<Pokemon>(conteudo);//Converter JSON para objeto
                Pokemons.Add(end);
                url = "https://pokeapi.co/api/v2/pokemon/";
            }
            return Pokemons;
        }
        //public static Pokemon BuscarInfoPokemon(string url)
        //{
        //    string endereco = url;
        //    WebClient wc = new WebClient();
        //    string conteudo = wc.DownloadString(endereco);//Recebe dados do site

        //    Pokemon end = JsonConvert.DeserializeObject<Pokemon>(conteudo);//Converter JSON para objeto
        //    return end;
        //}
    }
}

