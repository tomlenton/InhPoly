using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Charmander : Pokemon
    {
        public Charmander(string nickname) 
            : base("Charmander", nickname, PokemonType.Fire, 39, 52, 43, 65, new List<Move> { new Tackle(), new Growl()}) 
        {

        }



    }
}
