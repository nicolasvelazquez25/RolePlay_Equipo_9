using System;

    namespace Library
    {
        public class Elves
        {
            public string Name{get; set;}
            public int Health{get; set;} 
            public ShieldElve Shield{get; set;} 
            public SwordElve Sword{get; set;} 
            public int BaseHealth{get; set;}         
       
        public Elves(String Name, int Health, ShieldElve Shield, SwordElve Sword)        
        {
            this.Name = Name; 
            this.Health = Health;
            this.Shield = Shield;
            this.Sword = Sword; 
            this.BaseHealth =  Health;      
        }

        public int GetTotalDmg()
        {
            return this.Shield.Dmg + this.Sword.Dmg;
        }

        public int GetTotalArmor()
        {
            return this.Shield.Armor + this.Sword.Armor;   
        }

        public void Armor(Elves elve)
        {
            elve.Health = elve.Health - this.Shield.Armor - this.Sword.Armor;
        }

        public void RestoreHealth()
        {
            this.Health = this.BaseHealth;
        }
        public void MakeDmg(Elves enemy)
        {
            float absorption = (enemy.GetTotalArmor()*0.008f)/10;
            float dmg = ((GetTotalDmg()) * (1 - (absorption>0.8f? 0.8f : absorption)));
            
            enemy.Health -= Convert.ToInt32(dmg);
        
            Console.WriteLine($"{this.Name} caused {Convert.ToInt32(dmg)} damage to {enemy.Name}\n");
        } 

        public void GetShield(ShieldElve shield)
        {
            this.Shield = shield;
        }

        public void OutShield()
        {
            this.Shield = null;
        }
        public void GetSword(SwordElve sword)
        {
            this.Sword = sword;
        }

        public void OutSword()
        {
            this.Sword = null;
        }
        public string MessageHealth()
        {
            return ($"{this.Name} has {this.Health}Hp\n");
        }
        public string MessageCharacter()
        {
            return ($"Hero: {this.Name} \nHealth: {this.Health} \n_Items_{Sword.Message()}{Shield.Message()}\n");
        }  
    }
}


            