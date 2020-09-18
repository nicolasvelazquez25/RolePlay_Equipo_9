namespace Library
{
    public class Spell
    {
        public string Name{get; set;}

        public int Attack{get; set;}

        public int Defense{get; set;}

        public Spell(string Name, int Attack = 0, int Defense = 0)
        {
            this.Name = Name;
            this.Attack = Attack;
            this.Defense = Defense;
        }
    }
}