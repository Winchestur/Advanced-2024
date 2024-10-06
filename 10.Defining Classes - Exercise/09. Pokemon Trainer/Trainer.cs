using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> ColectionOfPokemon { get; set; }

        public Trainer(string name)
        {
            Name = name;
            NumberOfBadges = 0;
            ColectionOfPokemon = new List<Pokemon>();
        }
    }
}
