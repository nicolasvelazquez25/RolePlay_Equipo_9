using System.Collections;

namespace Library
{
    public class Spellbook
    {
        public string Name{get; set;}

        public int Dmg{get; set;}

        public int Armor{get; set;}

        public Spell Spell{get; set;}

        public Spellbook(string Name,Spell Spell)
        {
            this.Name = Name;
            this.Dmg = Spell.Dmg;
            this.Armor = Spell.Armor;
            this.Spell = Spell;
        }
        public string Message()
        {
            return ($"\n~ {this.Name} \n    Damage: {this.Dmg} \n    Armour: {this.Armor}");
        }
    }
}