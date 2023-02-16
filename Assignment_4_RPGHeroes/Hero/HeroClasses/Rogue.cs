using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;


namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Rogue : Hero
    {
        public Rogue(string name)
        {
            Name = name;
            HeroClass = "Rogue";
            LevelAttribtues = new HeroAttribute { Strength = 2, Dexterity = 6, Intelligence = 1 };

            ValidWeaponTypes.Add(WeaponTypes.Daggers);
            ValidWeaponTypes.Add(WeaponTypes.Swords);
            ValidArmorTypes.Add(ArmorTypes.Leather);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }

        public override void LevelUp()
        {
            Level++;
            LevelAttribtues.IncreaseHeroAttribute(1, 4, 1);
        }
    }
}
