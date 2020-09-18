using System.Collections;
using System;
namespace Library
{
    public class Witch
    {
         public Witch(string name, int health, Dagger dagger, IronNails ironNails)
        {
            this.Name = name;
            this.Health = health;
            this.Dagger  = dagger;
            this.IronNails = ironNails;
            this.BaseHealth = health;

        }
        public string Name { get; set; }

        public int Health { get; set; }

        public IronNails IronNails { get; set; }

        public Dagger Dagger { get; set; }
        public int BaseHealth { get; private set; }

        public int GetTotalDmg()
        {
         return this.Dagger.Dmg + this.IronNails.Dmg;   
        }
        public int GetTotalArmor()
        {
            return this.Dagger.Armor + this.IronNails.Armor;
        }
        public void MakeDmg(Witch enemy)
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
            return ($"Hero: {this.Name} \nHealth: {this.Health} \n_Items_{Dagger.Message()}{IronNails.Message()}\n");
        }
        public void GetDagger(Dagger dagger)
        {
            this.Dagger = dagger;
        }

        public void OutStick()
        {
            this.Dagger = null;
        }
        public void GetIronNails(IronNails ironNails)
        {
            this.IronNails = ironNails;
        }

        public void OutIronNails()
        {
            this.IronNails = null;
        }
    }
}