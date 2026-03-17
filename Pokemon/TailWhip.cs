using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class TailWhip : Move
    {
        public TailWhip()
            : base("Tail Whip", 0, 30, PokemonType.Normal)
        {

        }

        public override void UseMove(Pokemon currentPokemon, Pokemon opponent)
        {
            opponent.Defence = (int)(opponent.Defence * 0.9);
            Console.WriteLine("Opponent Defence severely dropped!");
        }
    }
}
