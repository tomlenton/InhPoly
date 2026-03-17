using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Growl : Move
    {
        public Growl()
            : base("Growl", 0, 40, PokemonType.Normal)
        {

        }

        public override void UseMove(Pokemon currentPokemon, Pokemon opponent)
        {
            opponent.Attack = (int)(opponent.Attack * 0.9);
            Console.WriteLine("Opponent attack severely dropped!");
        }
    }
}
