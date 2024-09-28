using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
   public class Trainer
    {
        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int Badges { get; set; }

        public List<Pokemon> Pokemons = new List<Pokemon>();

    }
}
