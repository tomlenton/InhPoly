namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon playerAPokemon;
            Pokemon playerBPokemon;
            Console.WriteLine("Player A: What's the name of your Pokemon?");
            string playerAPokemonName = Console.ReadLine();
            Console.WriteLine("Player B: What's the name of your Pokemon?");
            string playerBPokemonName = Console.ReadLine();

            List<Pokemon> aviliablePokemonsA = new List<Pokemon> { new Charmander(playerAPokemonName), new Squirtle(playerAPokemonName), new Bulbasaur(playerAPokemonName) };
            List<Pokemon> aviliablePokemonsB = new List<Pokemon> { new Charmander(playerBPokemonName), new Squirtle(playerBPokemonName), new Bulbasaur(playerBPokemonName) };
           
            Console.WriteLine("Player A choose your Pokemon:");
            Console.WriteLine("1. Charmander\n2. Squirtle\n3. Bulbsaur");
            playerAPokemon = aviliablePokemonsA[int.Parse(Console.ReadLine()) - 1];
            Console.WriteLine($"Player A chose: {playerAPokemon.Name} called {playerAPokemon.Nickname}");

            Console.WriteLine("Player B choose your Pokemon:");
            Console.WriteLine("1. Charmander\n2. Squirtle\n3. Bulbsaur");
            playerBPokemon = aviliablePokemonsB[int.Parse(Console.ReadLine()) - 1];
            Console.WriteLine($"Player B chose: {playerBPokemon.Name} called {playerBPokemon.Nickname}");

            Battle battle = new Battle(playerAPokemon, playerBPokemon);
            battle.StartBattle();

        }
    }
}
