using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_RPGHeroes.Items
{
    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs,
    }
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }
        public Slot ItemSlot { get; set; }
    }
}
