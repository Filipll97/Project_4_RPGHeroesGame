using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;

namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Mage : Hero
    {
        // Base Stats
        private int baseStrength = 1;
        private int baseDexterity = 1;
        private int baseIntelligence = 8;

        // Increase stats on level up values 
        private int increaseStrengthValue = 1;
        private int increaseDexterityValue = 1;
        private int increaseIntelligenceValue = 5;

        public Mage(string name)
        {
            Name = name;
            HeroClass = "Mage";
            LevelAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };

            ValidWeaponTypes.Add(WeaponTypes.Staffs);
            ValidWeaponTypes.Add(WeaponTypes.Wands);
            ValidArmorTypes.Add(ArmorTypes.Cloth);
        }

        public override void LevelUp()
        {
            Level++;
            LevelAttributes.IncreaseHeroAttribute(increaseStrengthValue, increaseDexterityValue, increaseIntelligenceValue);
        }


    }
}