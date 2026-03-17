using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal abstract class Move
    {
        internal string Name { get; set; }
        internal int Power {  get; set; }
        internal int PP { get; set; }
        internal PokemonType Type { get; set; }

        public Move(string name, int power, int pp, PokemonType type)
        {
            Name = name;
            Power = power;
            PP = pp;
            Type = type;
        }

        public abstract void UseMove(Pokemon currentPokemon, Pokemon opponent);
    }
}
