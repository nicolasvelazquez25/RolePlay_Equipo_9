namespace Library
{
    public class SolarSword
    {
        public SolarSword(string name, int dmg, int armor)
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