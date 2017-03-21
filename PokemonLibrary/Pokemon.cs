using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    internal class Pokemon
    {
        public string Name { get; set; }

        public int NationalNo { get; set; }

        public string[] Type { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        public Pokemon(
            string name,
            int nationalNo,
            string[] type,
            float height,
            float weight
            )
        {
            this.Name = name;
            this.NationalNo = nationalNo;
            this.Type = type;
            this.Height = height;
            this.Weight = weight;
        }
    }
}