using System.Collections;

namespace Library
{
    public class Spellbook
    {
        public string Name{get; set;}

        public int Attack{get; set;}

        public int Defense{get; set;}

        public Spell Spell{get; set;}

        public Spellbook(string Name,Spell Spell)
        {
            this.Name = Name;
            this.Attack = Spell.Attack;
            this.Defense = Spell.Defense;
            this.Spell = Spell;
        }
    }
}