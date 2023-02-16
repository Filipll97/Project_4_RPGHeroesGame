using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.Items.ItemExceptions;

namespace Assignment_4_RPGHeroes.PlayerClasses
{
    public abstract class Hero
    {
        public string Name { get; protected set; }
        public string HeroClass { get; protected set; }
        public int Level { get; protected set; } = 1;
        public HeroAttribute LevelAttributes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; protected set; } = new Dictionary<Slot, Item>
            {
                { Slot.Weapon, null },
                { Slot.Head, null },
                { Slot.Body, null },
                { Slot.Legs, null },
            };
        public List<WeaponTypes> ValidWeaponTypes { get; set; } = new List<WeaponTypes>();
        public List<ArmorTypes> ValidArmorTypes { get; set; } = new List<ArmorTypes>();

        // Public Facing Methods:
        public abstract void LevelUp();

        public void EquipWeapon(Weapon weaponToEquip)
        {
            if (weaponToEquip.RequiredLevel <= Level && ValidWeaponTypes.Contains(weaponToEquip.WeaponType) && weaponToEquip.ItemSlot == Slot.Weapon)
                Equipment[weaponToEquip.ItemSlot] = weaponToEquip; 
            else
                throw new InvalidWeaponException(Level, weaponToEquip.RequiredLevel); 
        }
    
        public void EquipArmor(Armor armorToEquip)
        {
            if (armorToEquip.RequiredLevel <= Level && ValidArmorTypes.Contains(armorToEquip.ArmorType) && armorToEquip.ItemSlot != Slot.Weapon)
                Equipment[armorToEquip.ItemSlot] = armorToEquip;
            else
                throw new InvalidArmorException(Level, armorToEquip.RequiredLevel);
        }
        
        public HeroAttribute TotalAttributes()
        {
            HeroAttribute totalAttributes = new HeroAttribute() { Strength = LevelAttributes.Strength, Dexterity = LevelAttributes.Dexterity, Intelligence = LevelAttributes.Intelligence };

            foreach (var item in Equipment.Values)
            {
                if (item is Armor armor)
                {
                    totalAttributes.Strength += armor.StrengthValue;
                    totalAttributes.Dexterity += armor.DexterityValue;
                    totalAttributes.Intelligence += armor.IntelligenceValue;
                }
            }

            return totalAttributes;
        }
        
        public double Damage()
        {
            Weapon equippedWeapon = Equipment[Slot.Weapon] as Weapon;

            if (equippedWeapon == null)
            {
                equippedWeapon = new Weapon() { WeaponDamage = 1 };
            }

            switch (HeroClass)
            {
                case "Mage":
                    return equippedWeapon.WeaponDamage * (1 + ((double)TotalAttributes().Intelligence / 100));
                case "Ranger":
                    return equippedWeapon.WeaponDamage * (1 + ((double)TotalAttributes().Dexterity / 100));
                case "Rogue":
                    return equippedWeapon.WeaponDamage * (1 + ((double)TotalAttributes().Dexterity / 100));
                case "Warrior":
                    return equippedWeapon.WeaponDamage * (1 + ((double)TotalAttributes().Strength / 100));
                default:
                    return 0;
            }
        }

        public string DisplayHeroInfo()
        {
            string displayHeroInfo = $":----Hero Stats----:\n\bName: {Name} \nClass: {HeroClass}" +
                $"\nLevel: {Level}\nTotal Strength: {TotalAttributes().Strength}" +
                $"\nTotal Dexterity: {TotalAttributes().Dexterity}\n" +
                $"Total Intelligence: {TotalAttributes().Intelligence}\nDamage: {Damage()}\n";

            return displayHeroInfo;
        }
    }
}
