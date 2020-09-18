using System.Collections;
using System;
namespace Library
{
    public class Dagger
    {
        public Dagger(string name, int dmg = 0, int armor = 0)
        {
            this.Name = name;
            this.Dmg = dmg;
            this.Armor = armor;
        }
        public string Name { get; set; }
        public int Dmg { get; set; }
        public int Armor{ get; set; }

        public string Message()
        {
            return ($"\n~ {this.Name} \n    Damage: {this.Dmg} \n    Armour: {this.Armor}");
        }
    }
}