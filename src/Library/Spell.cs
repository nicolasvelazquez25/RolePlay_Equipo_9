namespace Library
{
    public class Spell
    {
        public string Name{get; set;}

        public int Dmg{get; set;}

        public int Armor{get; set;}

        public Spell(string Name, int Dmg = 0, int Armor = 0)
        {
            this.Name = Name;
            this.Dmg = Dmg;
            this.Armor = Armor;
        }
    }
}