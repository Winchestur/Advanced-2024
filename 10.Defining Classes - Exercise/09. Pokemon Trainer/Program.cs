namespace _09.PokemonTrainer;

public class Program
{
    public static void Main()
    {
        List<string> list = Console.ReadLine().Split(" ",
            StringSplitOptions.RemoveEmptyEntries).ToList();

        Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

        while (list[0] != "Tournament")
        {
            string name = list[0];
            string pokemonName = list[1];
            string element = list[2];
            int health = int.Parse(list[3]);

            if (!trainers.ContainsKey(name))
            {
                Trainer trainer = new Trainer(name);
                trainers.Add(name, trainer);
            }

            Pokemon pokemon = new Pokemon(pokemonName, element, health);

            trainers[name].ColectionOfPokemon.Add(pokemon);

            list = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        string command = Console.ReadLine();

        while (command != "End")
        {

            foreach (var (name, item) in trainers)
            {
                bool doesTrainerHavePokemonElement = item.ColectionOfPokemon.Any(x =>x.Element == command);

                if (doesTrainerHavePokemonElement)
                {
                    item.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in item.ColectionOfPokemon)
                    {
                        pokemon.Health -= 10;
                    }

                    item.ColectionOfPokemon.RemoveAll(x => x.Health <= 0);
                }
            }

            command = Console.ReadLine();
        }

        foreach (var item in trainers.OrderByDescending(x=>x.Value.NumberOfBadges))
        {
            Console.WriteLine($"{item.Value.Name} {item.Value.NumberOfBadges} {item.Value.ColectionOfPokemon.Count}");
        }
    }
}