using System.Globalization;
using System;

namespace Library
{

    public class Dwarves
    {
        //Las clases se crearon siguiendo el criterio de partron expert ya que re presentan una entidad del juego y manejan/conocen todos los aspectos de la misma
        public Dwarves(string name, int health, Hammer h, MagicRing m)
        {
            this.Name = name;
            this.Health = health;
            this.Hammer  = h;
            this.BaseHealth = health;
            this.MagicRing = m;
        }
        public string Name { get; set; }


        public int Health { get; set; }

        public MagicRing MagicRing { get; set; }

        public Hammer Hammer { get; set; }
        public int BaseHealth { get; private set; }

        public int GetTotalDmg(){
         return this.Hammer.Dmg + this.MagicRing.Dmg;   
        }
        public int GetTotalArmor(){
            return this.Hammer.Armor + this.MagicRing.Armor;
        }


         public void MakeDmg(Dwarves enemy)
        {
            float absorption = (enemy.GetTotalArmor()*0.008f)/10;
            float dmg = ((GetTotalDmg()) * (1 - (absorption>0.8f? 0.8f : absorption)));
            
            enemy.Health -= Convert.ToInt32(dmg);
        
            Console.WriteLine($"{this.Name} caused {Convert.ToInt32(dmg)} damage to {enemy.Name}\n");
        }        


        public void RestoreHealth(){
            this.Health = this.BaseHealth;
        }
        public string MessageHealth()
        {
            return ($"{this.Name} has {this.Health}Hp\n");
        }
        public string MessageCharacter()
        {
            return ($"Hero: {this.Name} \nHealth: {this.Health} \n_Items_{Hammer.Message()}{MagicRing.Message()}\n");
        }
          public void OutMagicRing()
        {
            this.MagicRing = null;
        }
        public void GetMagicRing(MagicRing magicRing)
        {
            this.MagicRing = magicRing;
        }
        public void GetHammer(Hammer hammer)
        {
            this.Hammer = hammer;
        }

        public void OutHammer()
        {
            this.Hammer = null;
        }
    }
}