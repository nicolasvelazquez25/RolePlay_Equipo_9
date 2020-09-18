using System;
namespace Library
{
    public class DefenderElf1
    {
         public DefenderElf1(string name, int health, SolarSword solarSword, SolarShield solarShield)
        {
            this.Name = name;
            this.Health = health;
            this.SolarSword  = solarSword;
            this.SolarShield = solarShield;
            this.BaseHealth = health;

        }
        public string Name { get; set; }

        public int Health { get; set; }

        public SolarShield SolarShield { get; set; }

        public SolarSword SolarSword { get; set; }
        public int BaseHealth { get; private set; }

        public int GetTotalDmg()
        {
         return this.SolarSword.Dmg + this.SolarShield.Dmg;   
        }
        public int GetTotalArmor()
        {
            return this.SolarSword.Armor + this.SolarShield.Armor;
        }
        public void MakeDmg(DefenderElf1 enemy)
        {
            float absorption = (enemy.GetTotalArmor()*0.008f)/10;
            float dmg = ((GetTotalDmg()) * (1 - (absorption>0.8f? 0.8f : absorption)));
            
            enemy.Health -= Convert.ToInt32(dmg);
        
            Console.WriteLine($"{this.Name} caused {Convert.ToInt32(dmg)} damage to {enemy.Name}\n");
        }   
        public void RestoreHealth()
        {
            this.Health = this.BaseHealth;
        }

        public string MessageHealth()
        {
            return ($"{this.Name} has {this.Health}Hp\n");
        }
        public string MessageCharacter()
        {
            return ($"Hero: {this.Name} \nHealth: {this.Health} \n_Items_{SolarSword.Message()}{SolarShield.Message()}\n");
        }
    }
}