using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunLibrary
{
    public enum PokemonType
    { GRASS, POISSON, FIRE, FLYING, DRAGON, WATER, BUG }

    public class Pokemon
    {
        public int Number;
        public string Name;
        public int HP;
        public int CurrentHP;
        public int CP;
        public double Weight;
        public double Height;
        public List<PokemonType> Type = new List<PokemonType>();
        public int PowerUpCandy;
        public int PowerStardust;
        public int EvolveCandy;

        public string ImageFileName
        {
            get
            {
                if (this.Number < 10)
                    return "00" + this.Number;
                else if (Number >= 10 && Number < 100)
                    return "0" + this.Number;
                else
                    return this.Number.ToString();
            }
        }
    }
}