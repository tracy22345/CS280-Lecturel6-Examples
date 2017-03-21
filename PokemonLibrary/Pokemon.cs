using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Pokemon
    {
        public string Name { get; set; }

        public int NationalNo { get; set; }

        public string[] Type { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

        public Dictionary<string, int> PowerUpCandy { get; set; }

        public Dictionary<string, int> PowerUpStardust { get; set; }

        public Dictionary<string, int> EvolveCandy { get; set; }

        public Pokemon()//空的就會產生物件 這行是規則
        {
        }

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
            this.Weight = weight;
            this.Height = height;
            this.PowerUpCandy = new Dictionary<string, int>();
            this.PowerUpStardust = new Dictionary<string, int>();
            this.EvolveCandy = new Dictionary<string, int>();
        }

        public virtual void Attack()
        {
            Console.WriteLine("我要發動攻擊了");
        }
    }
}