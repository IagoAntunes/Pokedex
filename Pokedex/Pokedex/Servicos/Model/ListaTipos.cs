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
            new Categorias{Nome="Poison",Cor="#A552CC",Imagem="IconPoisonNew2",CorFundo="#A566C7"},
            new Categorias{Nome="Water",Cor="#4592C4",Imagem="IconPoisonNew2",CorFundo="#65B2F7"},
            new Categorias{Nome="Bug",Cor="#79c462",Imagem="IconPoisonNew2",CorFundo="#8BD674"},
            new Categorias{Nome="Flying",Cor="#748FC9",Imagem="IconPoisonNew2",CorFundo="#B5B9C4"},
            new Categorias{Nome="Eletric",Cor="#F2CB55",Imagem="IconPoisonNew2",CorFundo="#F2CB55"},
        };
    }
}
