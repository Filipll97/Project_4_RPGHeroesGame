using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_RPGHeroes.Items.ItemExceptions
{
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(int heroLevel, int requiredArmorLevel) :
            base(heroLevel < requiredArmorLevel ? "Hero level to low to equip armor!" : "Invalid armor type!")
        {

        }
    }
}