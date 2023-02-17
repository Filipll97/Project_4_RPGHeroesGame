# Project_4_RPGHeroesGame
This is a console application project that serves as the backend for a role-playing game (RPG) focused on heroes. It was developed as part of the Experis Academy and was implemented using C# programming language with Visual Studio as the Integrated Development Environment (IDE). The Xunit framework was used for unit testing.

The application involves four unique hero classes - Mage, Ranger, Rogue, and Warrior - who can equip a wide range of items, including weapons and armor. The weapons are available in several types, including Axes, Bows, Daggers, Hammers, Staffs, Swords, and Wands, while the armor is available in Cloth, Leather, Mail, and Plate types. Each hero class have diffrent hero attributes like strength, dexterity, and intelligence that incresses if the hero levels up or equip armor.

The project features several essential functions, including LevelUp(), EquipWeapon(), and EquipArmor(). The LevelUp() method raises the level of the hero and incresses the hero attributes, while EquipWeapon() and EquipArmor() methods equip a weapon or an armor to a specific slot on the hero's equipment property. These functions include conditional statements that check whether the item can be equipped based on the hero's level and the item's type. If the conditions are not met, the methods throw an exception.

Other functions include TotalAttributes(), which returns a HeroAttribute object that represents the hero's total strength, dexterity, and intelligence, including the attributes of any equipped armor. The Damage() method calculates the damage that the hero can deal based on its equipped weapon, strength, dexterity, and intelligence. The DisplayHeroInfo() method creates a string that contains information about the hero's name, class, level, attributes, and damage.

The program's unit testing covers various aspects of the application, including hero creation and leveling, weapon and armor equipping, attribute and damage calculation, and hero state display. The tests feature clear and appropriate names and follow the Arrange-Act-Assert (AAA) structure.

This project was created by Filip Lindell.
