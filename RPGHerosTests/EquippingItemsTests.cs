using Assignment_4_RPGHeroes.Items;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.ItemExceptions;
using Assignment_4_RPGHeroes.Items.Weapons;
using Assignment_4_RPGHeroes.Player.HeroClasses;
using Assignment_4_RPGHeroes.PlayerClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHerosTests
{
    public class EquippingItemsTests
    {
        #region Equipping Items
            #region Equipping Items Weapons
            [Fact]
            public void InitializeHeroAndWeaponWithToHighRequiredLevel_ShouldCreateHeroWithAWeaponEquiptAndThrowInvalidWeaponException()
            {
                // Arrange
                string heroName = "Filip";
                Hero newWarriorHero = new Warrior(heroName);
                Weapon weapon = new Weapon() { Name = "Doom Hammer", RequiredLevel = 2, WeaponType = WeaponTypes.Hammers, ItemSlot = Slot.Weapon};

                // Act & Assert
                Assert.Throws<InvalidWeaponException>(() => newWarriorHero.EquipWeapon(weapon));
            }
            [Fact]
            public void InitializeHeroAndWeaponWithInvalidWeaponTypeForHero_ShouldCreateHeroWithAWeaponEquiptAndThrowInvalidWeaponException()
            {
                // Arrange
                string heroName = "Filip";
                Hero newWarriorHero = new Warrior(heroName);
                Weapon weapon = new Weapon() { Name = "Doom Staff", RequiredLevel = 1, WeaponType = WeaponTypes.Staffs, ItemSlot = Slot.Weapon };

                // Act & Assert
                Assert.Throws<InvalidWeaponException>(() => newWarriorHero.EquipWeapon(weapon));
            }
            #endregion
            #region Equipping Items Armor
            [Fact]
            public void InitializeHeroAndArmorWithToHighRequiredLevel_ShouldCreateHeroWithArmorEquiptAndThrowInvalidArmorException()
            {
                // Arrange
                string heroName = "Filip";
                Hero newWarriorHero = new Warrior(heroName);
                Armor armor = new Armor() { Name = "Basic Chest plate", RequiredLevel = 2, ArmorType = ArmorTypes.Mail, ItemSlot = Slot.Body };

                // Act & Assert
                Assert.Throws<InvalidArmorException>(() => newWarriorHero.EquipArmor(armor));
            }
            [Fact]
            public void InitializeHeroAndArmorWithInvalidArmorTypeForHero_ShouldCreateHeroWithArmorEquiptAndThrowInvalidArmorException()
            {
                // Arrange
                string heroName = "Filip";
                Hero newWarriorHero = new Warrior(heroName);
                Armor armor = new Armor() { Name = "Basic Chest plate", RequiredLevel = 1, ArmorType = ArmorTypes.Cloth, ItemSlot = Slot.Body };

                // Act & Assert
                Assert.Throws<InvalidArmorException>(() => newWarriorHero.EquipArmor(armor));
            }
            #endregion
        #endregion
    }
}
