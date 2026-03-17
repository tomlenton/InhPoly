using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur(string nickname)
            : base("Bulbasaur", nickname, PokemonType.Grass, 45, 49, 49, 45, new List<Move> { new Tackle(), new Growl() })
        {

        }



    }
}
