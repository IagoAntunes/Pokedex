using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pokedex.Servicos.Model
{
    public class Outro
    {
        [JsonProperty("official-artwork")]
        public ArteOficial officialartwork { get; set; }
        public Home home { get; set; }
    }
}
