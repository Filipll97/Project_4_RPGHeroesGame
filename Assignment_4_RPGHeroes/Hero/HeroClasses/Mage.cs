using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.PlayerClasses;

namespace Assignment_4_RPGHeroes.Player.HeroClasses
{
    public class Mage : Hero
    {
        public Mage(string name)
        {
            Name = name;
            HeroClass = "Mage";
            LevelAttributes = new HeroAttribute { Strength = 1, Dexterity = 1, Intelligence = 8 };

            ValidWeaponTypes.Add(WeaponTypes.Staffs);
            ValidWeaponTypes.Add(WeaponTypes.Wands);
            ValidArmorTypes.Add(ArmorTypes.Cloth);

        }

        public override void LevelUp()
        {
            Level++;
            LevelAttributes.IncreaseHeroAttribute(1, 1, 5);
        }


    }
}
