using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Squirtle : Pokemon
    {
        public Squirtle(string nickname)
            : base("Squirtle", nickname, PokemonType.Water, 44, 48, 65, 43, new List<Move> { new Tackle(), new TailWhip() })
        {

        }
    }
}
