using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;

namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Warrior : Hero
    {
        public Warrior(string name)
        {
            Name = name;
            HeroClass = "Warrior";
            LevelAttributes = new HeroAttribute { Strength = 5, Dexterity = 2, Intelligence = 1 };

            ValidWeaponTypes.Add(WeaponTypes.Axes);
            ValidWeaponTypes.Add(WeaponTypes.Hammers);
            ValidWeaponTypes.Add(WeaponTypes.Swords);
            ValidArmorTypes.Add(ArmorTypes.Plate);
            ValidArmorTypes.Add(ArmorTypes.Mail);
        }

        public override void LevelUp()
        {
            Level++;
            LevelAttributes.IncreaseHeroAttribute(3, 2, 1);
        }
    }
}
