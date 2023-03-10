using Assignment_4_RPGHeroes.Items;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.Player.HeroClasses;
using Assignment_4_RPGHeroes.PlayerClasses;
using System;
using System.Collections.Concurrent;

public class Program
{
    private static void Main(string[] args)
    {
        Mage mageHero = new Mage("Filip");

        Ranger newRangerHero = new Ranger("Malin");

        Console.WriteLine(mageHero.DisplayHeroInfo());
        mageHero.LevelUp();
        Console.WriteLine(mageHero.DisplayHeroInfo());

        Console.WriteLine(newRangerHero.DisplayHeroInfo());
        newRangerHero.LevelUp();
        newRangerHero.LevelUp();
        Console.WriteLine(newRangerHero.DisplayHeroInfo());


        Weapon staff = new Weapon { Name = "Doom Staff", WeaponType = WeaponTypes.Staffs, ItemSlot = Slot.Weapon,  RequiredLevel = 1, WeaponDamage = 10 };
        mageHero.EquipWeapon(staff);

        Armor helmet = new Armor { Name = "Basic Cloth Helmet", ArmorType = ArmorTypes.Cloth, ItemSlot = Slot.Head, RequiredLevel = 2, StrengthValue = 1, DexterityValue = 1, IntelligenceValue = 4 };
        mageHero.EquipArmor(helmet);


        // Displays items in hero inventory
        foreach (var item in mageHero.Equipment)
        {
            if (item.Value != null)
                Console.WriteLine($"Item Equip: {item.Value.Name} in {item.Key} slot!");
        }

        Console.WriteLine(mageHero.DisplayHeroInfo());
    }
}