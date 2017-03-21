using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Bulbasaur : GrassTypePokemon
    {
        public int GrassTypePowerUpCandy { get; set; }

        public int GrassTypePowerUpStarDust { get; set; }

        public Bulbasaur(
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
            this.name = "妙蛙種子";
            this.nationalNo = 001;
            this.type = "Grass";
            this.height = 0.71m;
            this.weight = 6.9 kg;
            this.PowerUpCandy["this.Name"] = 3;
            this.PowerUpStardust["this.Name"] = 3000;
        }
    }
}