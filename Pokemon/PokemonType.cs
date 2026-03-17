using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal enum PokemonType
    {
        Normal,
        Fire,
        Water,
        Grass
    }

    internal class TypeEffectiveness
    {
        internal static double CalculateEffectiveness(PokemonType typeMove, PokemonType typeOpponent)
        {
            double[,] lookUpTable = new double[4,4] { { 1, 1, 1, 1 }, { 1, 0.5, 0.5, 2}, { 1, 2, 0.5, 0.5}, { 1, 0.5, 2, 0.5} };
            Console.WriteLine($"Move Type: {typeMove}, Opponent Type: {typeOpponent}, Type Modifier: {lookUpTable[(int)typeMove, (int)typeOpponent]}");
            return lookUpTable[(int)typeMove, (int)typeOpponent];
        }
    }
}
