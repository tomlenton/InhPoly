using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Battle
    {
        bool IsPlayerATurn = false;
        Pokemon PokemonA;
        Pokemon PokemonB;
        public Battle(Pokemon pokemonA, Pokemon pokemonB) 
        { 
            PokemonA = pokemonA;
            PokemonB = pokemonB;
        }

        internal void StartBattle()
        {
            Console.WriteLine("Let the battle begin!");
            if (PokemonA.Speed > PokemonB.Speed)
            {
                IsPlayerATurn = true;
            }
            else
            {
                IsPlayerATurn = false;
            }

            while (PokemonA.HP > 0 && PokemonB.HP > 0)
            {
                if (IsPlayerATurn)
                {
                    Console.WriteLine("Player A Turn:");
                    Console.WriteLine("Choose a move:");
                    for (int i = 0; i < PokemonA.Moves.Count; i++)
                    {
                        Console.WriteLine($"{i+1}: {PokemonA.Moves[i].Name}");
                    }
                    int option = int.Parse(Console.ReadLine()) - 1;
                    PokemonA.UseMove(option, PokemonA, PokemonB);
                    Console.WriteLine($"{PokemonA.Nickname} the {PokemonA.Name} uses the {PokemonA.Moves[option].Name}!");
                }
                else
                {
                    Console.WriteLine("Player B Turn:");
                    Console.WriteLine("Choose a move:");
                    for (int i = 0; i < PokemonB.Moves.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {PokemonB.Moves[i].Name}");
                    }
                    int option = int.Parse(Console.ReadLine()) - 1;
                    PokemonB.UseMove(option, PokemonB, PokemonA);
                    Console.WriteLine($"{PokemonB.Nickname} the {PokemonB.Name} uses the {PokemonB.Moves[option].Name}!");
                }
                Console.WriteLine($"{PokemonA.Nickname} the {PokemonA.Name} has {PokemonA.HP} HP left.");
                Console.WriteLine($"{PokemonB.Nickname} the {PokemonB.Name} has {PokemonB.HP} HP left.");
                IsPlayerATurn = !IsPlayerATurn;
            }

            if (PokemonA.HP <= 0)
            {
                Console.WriteLine("Player B wins!");
            }
            else
            {
                Console.WriteLine("Player A wins!");
            }
        }




    }
}
