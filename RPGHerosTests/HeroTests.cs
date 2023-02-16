using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Player.HeroClasses;
using Assignment_4_RPGHeroes.PlayerClasses;


namespace RPGHeroesTests
{
    public class HerosTests
    {
        #region Hero creation
        #region Hero creation Mage
        [Fact]
        public void Cunstructor_InitializeHeroMageWithName_ShouldCreateHeroMageWithName()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newMageHero = new Mage(heroName);
            string expected = heroName;

            // Act 
            string actual = newMageHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Cunstructor_InitializeHeroMageWithName_ShouldCreateHeroMageThatIsLevelOne()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newMageHero = new Mage(heroName);
            int expected = 1;

            // Act 
            int actual = newMageHero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Cunstructor_InitializeHeroMageWithName_ShouldCreateHeroMageWithBaseMageAttributes()
        {
            // Arrange 
            string heroName = "Filip";
            Hero mageHero = new Mage(heroName);
            HeroAttribute heroAttribute = new HeroAttribute() { Strength = 1, Dexterity = 1, Intelligence = 8 };
            HeroAttribute expected = heroAttribute;

            // Act
            HeroAttribute actual = mageHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #region Hero creation Ranger
        [Fact]
        public void Cunstructor_InitializeHeroRangerWithName_ShouldCreateHeroRangerWithName()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newRangerHero = new Ranger(heroName);
            string expected = heroName;

            // Act 
            string actual = newRangerHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Cunstructor_InitializeHeroRangerWithName_ShouldCreateHeroRangerThatIsLevelOne()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newRangerHero = new Ranger(heroName);
            int expected = 1;

            // Act 
            int actual = newRangerHero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Cunstructor_InitializeHeroRangerWithName_ShouldCreateHeroRangerWithBaseMageAttributes()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newRangerHero = new Ranger(heroName);
            HeroAttribute heroAttribute = new HeroAttribute() { Strength = 1, Dexterity = 7, Intelligence = 1 };
            HeroAttribute expected = heroAttribute;

            // Act
            HeroAttribute actual = newRangerHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #region Hero creation Rogue
        [Fact]
        public void Cunstructor_InitializeHeroRogueWithName_ShouldCreateHeroRogueWithName()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newRogueHero = new Rogue(heroName);
            string expected = heroName;

            // Act 
            string actual = newRogueHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Cunstructor_InitializeHeroRogueWithName_ShouldCreateHeroRogueThatIsLevelOne()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newRogueHero = new Rogue(heroName);
            int expected = 1;

            // Act 
            int actual = newRogueHero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Cunstructor_InitializeHeroRogueWithName_ShouldCreateHeroRangerWithBaseRogueAttributes()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newRogueHero = new Rogue(heroName);
            HeroAttribute heroAttribute = new HeroAttribute() { Strength = 2, Dexterity = 6, Intelligence = 1 };
            HeroAttribute expected = heroAttribute;

            // Act
            HeroAttribute actual = newRogueHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #region Hero creation Warrior
        [Fact]
        public void Cunstructor_InitializeHeroWarriorWithName_ShouldCreateHeroWarriorWithName()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newWarriorHero = new Warrior(heroName);
            string expected = heroName;

            // Act 
            string actual = newWarriorHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Cunstructor_InitializeHeroWarriorWithName_ShouldCreateHeroWarriorThatIsLevelOne()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newWarriorHero = new Warrior(heroName);
            int expected = 1;

            // Act 
            int actual = newWarriorHero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Cunstructor_InitializeHeroWarriorWithName_ShouldCreateHeroRangerWithBaseWarriorAttributes()
        {
            // Arrange 
            string heroName = "Filip";
            Hero newWarriorHero = new Warrior(heroName);
            HeroAttribute heroAttribute = new HeroAttribute() { Strength = 5, Dexterity = 2, Intelligence = 1 };
            HeroAttribute expected = heroAttribute;

            // Act
            HeroAttribute actual = newWarriorHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #endregion

        #region Hero Level Up
        #region Hero Mage Level Up
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroMageLevelByOne()
        {
            string heroName = "Filip";
            Hero mageHero = new Mage(heroName);
            int expected = 2;

            // Act
            mageHero.LevelUp();
            int actual = mageHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroMageLevelAttributeByIncreaseAttributeAmount()
        {
            string heroName = "Filip";
            Mage mageHero = new Mage(heroName);
            HeroAttribute heroIncreasedAttribute = new HeroAttribute() { Strength = 2, Dexterity = 2, Intelligence = 13 };
            HeroAttribute expected = heroIncreasedAttribute;

            // Act
            mageHero.LevelUp();
            HeroAttribute actual = mageHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #region Hero Ranger Level Up
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroRangerLevelByOne()
        {
            string heroName = "Filip";
            Hero rangerHero = new Ranger(heroName);
            int expected = 2;

            // Act
            rangerHero.LevelUp();
            int actual = rangerHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroRangerLevelAttributeByIncreaseAttributeAmount()
        {
            string heroName = "Filip";
            Hero rangerHero = new Ranger(heroName);
            HeroAttribute heroIncreasedAttribute = new HeroAttribute() { Strength = 2, Dexterity = 12, Intelligence = 2 };
            HeroAttribute expected = heroIncreasedAttribute;

            // Act
            rangerHero.LevelUp();
            HeroAttribute actual = rangerHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #region Hero Rogue Level Up
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroRogueLevelByOne()
        {
            string heroName = "Filip";
            Hero RogueHero = new Rogue(heroName);
            int expected = 2;

            // Act
            RogueHero.LevelUp();
            int actual = RogueHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroRogueLevelAttributeByIncreaseAttributeAmount()
        {
            string heroName = "Filip";
            Hero RogueHero = new Rogue(heroName);
            HeroAttribute heroIncreasedAttribute = new HeroAttribute() { Strength = 3, Dexterity = 10, Intelligence = 2 };
            HeroAttribute expected = heroIncreasedAttribute;

            // Act
            RogueHero.LevelUp();
            HeroAttribute actual = RogueHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #region Hero Warrior Level Up
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroWarriorLevelByOne()
        {
            string heroName = "Filip";
            Hero WarriorHero = new Warrior(heroName);
            int expected = 2;

            // Act
            WarriorHero.LevelUp();
            int actual = WarriorHero.Level;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void LevelUpHero_ShouldIncreaseHeroWarriorLevelAttributeByIncreaseAttributeAmount()
        {
            string heroName = "Filip";
            Hero WarriorHero = new Warrior(heroName);
            HeroAttribute heroIncreasedAttribute = new HeroAttribute() { Strength = 8, Dexterity = 4, Intelligence = 2 };
            HeroAttribute expected = heroIncreasedAttribute;

            // Act
            WarriorHero.LevelUp();
            HeroAttribute actual = WarriorHero.LevelAttributes;

            // Assert
            Assert.Equivalent(expected, actual);
        }
        #endregion
        #endregion
    }
}