using Assignment_4_RPGHeroes.Items;
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
            Weapon weapon = new Weapon() { Name = weaponName , ItemSlot = Slot.Weapon};
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


        #endregion
    }
}
