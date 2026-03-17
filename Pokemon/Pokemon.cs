using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon {
    internal class Pokemon
    {
        internal string Name { get; set; }
        internal string Nickname { get; set; }
        internal PokemonType Type { get; set; }
        internal int HP { get; set; }
        internal int Level { get; set; } = 1;
        internal int XP { get; set; } = 0;

        internal int Attack { get; set; }

        internal int Defence { get; set; }

        internal int Speed { get; set; }
        internal List<Move> Moves { get; set; }

        public Pokemon(string name, string nickname, PokemonType type, int hp, int attack, int defence, int speed, List<Move> moves) 
        { 
            Name = name;
            Nickname = nickname;
            Type = type;
            HP = hp;
            Attack = attack; 
            Defence = defence;
            Moves = moves;
        }

        internal void LearnMove(Move move)
        {
            Moves.Add(move);
        }

        internal void AddXP(int xp)
        {
            // add xp and level up
        }

        internal void UseMove(int option, Pokemon currentPokemon, Pokemon opponent)
        {
            Moves[option].UseMove(currentPokemon, opponent);
        }
    }
}
