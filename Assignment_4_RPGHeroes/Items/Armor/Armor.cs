using Assignment_4_RPGHeroes.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_RPGHeroes.Items.Armor
{
    public enum ArmorTypes
    {
        Cloth,
        Leather,
        Mail,
        Plate,
    }

    public class Armor : Item
    {
        public HeroAttribute ArmorAttribute { get; set; }
        public ArmorTypes ArmorType { get; set; }
        public int StrengthValue { get; set; }
        public int DexterityValue { get; set; }
        public int IntelligenceValue { get; set; }


        public Armor()
        {
            ArmorAttribute = new HeroAttribute { Strength = StrengthValue, Dexterity = DexterityValue, Intelligence = IntelligenceValue };
        }
    }
}
