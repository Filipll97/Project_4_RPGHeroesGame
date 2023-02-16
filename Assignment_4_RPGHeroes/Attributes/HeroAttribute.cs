using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_RPGHeroes.Attributes
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }


        // Increase player stats 
        public void IncreaseHeroAttribute(int strength, int dexterity, int intelligence)
        {
            Strength += strength;
            Dexterity += dexterity;
            Intelligence += intelligence;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is HeroAttribute))
            {
                return false;
            }
            return Strength == this.Strength && Dexterity == this.Dexterity && Intelligence == this.Intelligence;
        }
    }
}
