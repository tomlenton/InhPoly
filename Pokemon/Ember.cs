using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Ember : Move
    {
        public Ember()
            : base("Ember", 40, 25, PokemonType.Fire)
        {

        }

        public override void UseMove(Pokemon currentPokemon, Pokemon opponent)
        {
            double STAB = currentPokemon.Type == Type ? 1.5 : 1;
            double typeModifier = TypeEffectiveness.CalculateEffectiveness(this.Type, opponent.Type);
            int damage = (int)(((((((currentPokemon.Level * 2) / 5.0) + 2) * Power) / 50.0) + 2) * STAB * typeModifier);
            switch (typeModifier)
            {
                case 0.5:
                    Console.WriteLine($"It's not very effective...");
                    break;
                case 2:
                    Console.WriteLine($"It's super effective!");
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{opponent.Nickname} the {opponent.Name} takes {damage} damage.");

            opponent.HP -= damage;
        }
    }
}
