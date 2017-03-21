using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Gym
    {
        public Pokemon pokemon1;
        public Pokemon pokemon2;

        public Gym(string name1, string name2)
        {
            this.pokemon1 =
                pokemoneFactory.Create(name1);
            this.pokemon2 =
                pokemoneFactory.Create(name2);
        }
    }
}