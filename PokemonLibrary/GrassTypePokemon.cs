using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class GrassTypePokemon : Pokemon
    {
        public int GrassTypePowerUpCandy { get; set; }

        public int GrassTypePowerUpStarDust { get; set; }

        public GrassTypePokemon(
            string name,
            int nationalNo,
            string[] type,
            float height,
            float weight,
            int grassTypePowerUpCandy,
            int grassTypePowerUpStarDust
        )
            : base(
                  name,
                  nationalNo,
                  type,
                  height,
                  weight
                 )
        {
            this.GrassTypePowerUpCandy = grassTypePowerUpCandy;
            this.GrassTypePowerUpStarDust = grassTypePowerUpStarDust;
        }
    }
}