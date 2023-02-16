using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;


namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Rogue : Hero
    {
        // Base Stats
        private int baseStrength = 2;
        private int baseDexterity = 6;
        private int baseIntelligence = 1;

        // Increase stats on level up values 
        private int increaseStrengthValue = 1;
        private int increaseDexterityValue = 4;
        private int increaseIntelligenceValue = 1;

        public Rogue(string name)
        {
            Name = name;
            HeroClass = "Rogue";
            LevelAttributes = new HeroAttribute { Strength = baseStrength, Dexterity = baseDexterity, Intelligence = baseIntelligence };

            ValidWeaponTypes.Add(WeaponTypes.Daggers);
            ValidWeaponTypes.Add(WeaponTypes.Swords);
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
