using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_RPGHeroes.Items.Weapons
{
    public enum WeaponTypes
    {
        Axes,
        Bows,
        Daggers,
        Hammers,
        Staffs,
        Swords,
        Wands,
    }
    public class Weapon : Item
    {
        public int WeaponDamage { get; set; }
        public WeaponTypes WeaponType { get; set; }

    }
}
