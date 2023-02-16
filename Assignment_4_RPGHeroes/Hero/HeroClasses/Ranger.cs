using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;

namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Ranger : Hero
    {
        // Base Stats
        private int baseStrength = 1;
        private int baseDexterity = 7;
        private int baseIntelligence = 1;

        // Increase stats on level up values 
        private int increaseStrengthValue = 1;
        private int increaseDexterityValue = 5;
        private int increaseIntelligenceValue = 1;

        public Ranger(string name)
        {
            Name = name;
            HeroClass = "Ranger";
            LevelAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };

            ValidWeaponTypes.Add(WeaponTypes.Bows);
            ValidArmorTypes.Add(ArmorTypes.Leather);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }

        public override void LevelUp()
        {
            Level++;
            LevelAttributes.IncreaseHeroAttribute(increaseStrengthValue, increaseDexterityValue, increaseIntelligenceValue);
        }
    }
}