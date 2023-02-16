using Assignment_4_RPGHeroes.Attributes;
using Assignment_4_RPGHeroes.Player.HeroClasses;
using Assignment_4_RPGHeroes.PlayerClasses;


namespace RPGHeroesTests
{
    public class HerosTests
    {
        #region Hero creation
        [Fact]
        public void Cunstructor_InitializeHeroMageWithName_ShouldCreateHeroMageWithName()
        {
            // Arrange 
            string heroName = "Filip";
            Mage newMageHero = new Mage(heroName);
            string expected = heroName;

            // Act 
            string actual = newMageHero.Name;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Cunstructor_InitializeHeroMageWithName_ShouldCreateHeroMageWithLevelOne()
        {
            // Arrange 
            string heroName = "Filip";
            Mage newMageHero = new Mage(heroName);
            int expected = 1;

            // Act 
            int actual = newMageHero.Level;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Cunstructor_InitializeHeroMageWithName_ShouldCreateHeroMageWithMageAttributes()
        {
            // Arrange 
            string heroName = "Filip";
            Mage mageHero = new Mage(heroName);
            HeroAttribute heroAttribute = new HeroAttribute() { Strength = 1, Dexterity = 1, Intelligence = 8 };
            HeroAttribute expected = heroAttribute;

            // Act
            HeroAttribute actual = mageHero.LevelAttribtues;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion
    }
}