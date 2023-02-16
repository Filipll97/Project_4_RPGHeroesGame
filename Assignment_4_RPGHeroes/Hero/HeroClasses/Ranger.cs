using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;

namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Ranger : Hero
    {
        public Ranger(string name)
        {
            Name = name;
            HeroClass = "Ranger";
            LevelAttribtues = new HeroAttribute { Strength = 1, Dexterity = 7, Intelligence = 1 };

            ValidWeaponTypes.Add(WeaponTypes.Bows);
            ValidArmorTypes.Add(ArmorTypes.Leather);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }

        public override void LevelUp()
        {
            Level++;
            LevelAttribtues.IncreaseHeroAttribute(1, 5, 1); // TODO: Add private fields instead of hard coded values
        }
    }
}
