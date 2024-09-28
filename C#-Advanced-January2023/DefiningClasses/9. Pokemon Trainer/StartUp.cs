using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
     public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();
            
            while (input!= "Tournament")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Trainer trainer = trainers.SingleOrDefault(t => t.Name == tokens[0]);

                if (trainer == null)
                {
                    trainer = new Trainer(tokens[0]);
                    trainer.Pokemons.Add(new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3])));
                    trainers.Add(trainer);
                }
                else
                {
                    trainer.Pokemons.Add(new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3])));
                }


                input = Console.ReadLine();
            }
            string command = Console.ReadLine();
            while (command!="End")
            {
                switch (command)
                {
                    case "Fire":                                           
                    case "Water":
                    case "Electricity":
                        foreach (var trainer in trainers)
                        {
                            if (trainer.Pokemons.Any(p=>p.Element==command))
                            {
                                trainer.Badges++;
                            }
                            else
                            {
                                if (trainer.Pokemons.Count>0)
                                {
                                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                                    {
                                        Pokemon currentPokemon = trainer.Pokemons[i];
                                    
                                        currentPokemon.Health -= 10;
                                        if (currentPokemon.Health <= 0)
                                        {
                                            trainer.Pokemons.Remove(currentPokemon);
                                        }
                                    }
                                }
                                
                            }
                        }

                        break;
                }



                command = Console.ReadLine();
            }
            foreach (var trainer in trainers.OrderByDescending(t=>t.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");

            }
        }
    }
}
