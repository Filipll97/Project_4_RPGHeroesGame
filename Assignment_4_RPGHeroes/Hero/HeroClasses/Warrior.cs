using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;

namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Warrior : Hero
    {
        // Base Stats
        private int baseStrength = 5;
        private int baseDexterity = 2;
        private int baseIntelligence = 1;

        // Increase stats on level up values 
        private int increaseStrengthValue = 3;
        private int increaseDexterityValue = 2;
        private int increaseIntelligenceValue = 1;

        public Warrior(string name)
        {
            Name = name;
            HeroClass = "Warrior";
            LevelAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };

            ValidWeaponTypes.Add(WeaponTypes.Axes);
            ValidWeaponTypes.Add(WeaponTypes.Hammers);
            ValidWeaponTypes.Add(WeaponTypes.Swords);
            ValidArmorTypes.Add(ArmorTypes.Plate);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }

        public override void LevelUp()
        {
            Level++;
            LevelAttributes.IncreaseHeroAttribute(increaseStrengthValue, increaseDexterityValue, increaseIntelligenceValue);
        }
    }
}
