using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Items;
using Assignment_4_RPGHeroes.Items.Armor;
using Assignment_4_RPGHeroes.Items.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGHerosTests
{
    public class ItemTests
    {
        //Weapon staff = new Weapon { Name = "Doom Staff", WeaponType = WeaponTypes.Staffs, RequiredLevel = 1, WeaponDamage = 10 };
        #region Creation Items
            #region Creation Item Weapon
            [Fact]
            public void Cunstructor_InitializeWeaponWithName_ShouldCreateWeaponWithName()
            {
                // Arrange
                string weaponName = "Doom Staff";
                Weapon weapon = new Weapon() { Name = weaponName};
                string expected = weaponName;
            
                // Act
                string actual = weapon.Name;

                // Assert 
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Cunstructor_InitializeWeaponWithWeaponType_ShouldCreateWeaponWithWeaponType()
            {
                // Arrange
                WeaponTypes weaponType = WeaponTypes.Staffs;
                Weapon weapon = new Weapon() { WeaponType = weaponType };
                WeaponTypes expected = weaponType;

                // Act
                WeaponTypes actual = weapon.WeaponType;

                // Assert 
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void Cunstructor_InitializeWeaponWithRequiredLevel_ShouldCreateWeaponWithRequiredLevel()
            {
                // Arrange
                int requiredLevel = 1;
                Weapon weapon = new Weapon() { RequiredLevel = requiredLevel };
                int expected = requiredLevel;

                // Act
                int actual = weapon.RequiredLevel;

                // Assert 
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Cunstructor_InitializeWeaponWithNameAndSlot_ShouldCreateWeaponWithThatNameInCorrectSlot()
            {
                // Arrange
                string weaponName = "Doom Hammer";
                Slot weaponSlot = Slot.Weapon;
                Weapon weapon = new Weapon() { Name = weaponName , ItemSlot = weaponSlot};
                Slot expected = weaponSlot;

                // Act
                Slot actual = weapon.ItemSlot;

                // Assert 
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Cunstructor_InitializeWeaponWithNameAndWeaponDamage_ShouldCreateWeaponWithThatNameAndWithCorrectWeaponDamage()
            {
                // Arrange
                string weaponName = "Doom Hammer";
                int weaponDamage = 22;
                Weapon weapon = new Weapon() { Name = weaponName, WeaponDamage = 22 };
                int expected = weaponDamage;

                // Act
                int actual = weapon.WeaponDamage;

                // Assert 
                Assert.Equal(expected, actual);
            }
            #endregion
            #region Creation Item Armor
            [Fact]
            public void Cunstructor_InitializeArmorWithName_ShouldCreateArmorWithName()
            {
                // Arrange
                string armorName = "Basic Helmet";
                Armor newArmor = new Armor() { Name = armorName };
                string expected = armorName;

                // Act
                string actual = newArmor.Name;

                // Assert 
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Cunstructor_InitializeArmorWithArmorType_ShouldCreateArmorWithArmorType()
            {
                // Arrange
                ArmorTypes armorType = ArmorTypes.Leather;
                Armor newArmor = new Armor() { ArmorType = armorType };
                ArmorTypes expected = armorType;

                // Act
                ArmorTypes actual = newArmor.ArmorType;

                // Assert 
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void Cunstructor_InitializeArmorWithRequiredLevel_ShouldCreateArmorWithRequiredLevel()
            {
                // Arrange
                int requiredLevel = 2;
                Armor newArmor = new Armor() { RequiredLevel = requiredLevel };
                int expected = requiredLevel;

                // Act
                int actual = newArmor.RequiredLevel;

                // Assert 
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Cunstructor_InitializeArmorWithNameAndSlot_ShouldCreateArmorWithThatNameInCorrectSlot()
            {
                // Arrange
                string armorName = "Basic Helmet";
                Slot armorSlot = Slot.Head;
                Armor newArmor = new Armor() { Name = armorName, ItemSlot = armorSlot };
                Slot expected = armorSlot;

                // Act
                Slot actual = newArmor.ItemSlot;

                // Assert 
                Assert.Equal(expected, actual);
            }

            [Fact]
            public void Cunstructor_InitializeArmorWithNameAndArmorAttributes_ShouldCreateArmorWithThatNameAndWithCorrectArmorAttributes()
            {
                // Arrange
                string armorName = "Basic Helmet";
                HeroAttribute armorAttributes = new HeroAttribute() { Strength = 1, Intelligence = 2, Dexterity = 3};
                Armor newArmor = new Armor() { Name = armorName, ArmorAttribute = armorAttributes };
                HeroAttribute expected = armorAttributes;

                // Act
                HeroAttribute actual = newArmor.ArmorAttribute;

                // Assert 
                Assert.Equivalent(expected, actual);
            }
            #endregion
        #endregion
    }
}
