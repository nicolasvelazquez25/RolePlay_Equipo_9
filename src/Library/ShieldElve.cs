using System;
using System.Collections;
using Library; 



    namespace Library
    {
        public class ShieldElve
        {
            public string Name{get; set;}
            public int Dmg{get; set;} 
            public int Armor{get; set;} 

        public ShieldElve(string Name, int Dmg=0, int Armor=0)     
        {
            this.Name = Name; 
            this.Dmg = Dmg;
            this.Armor = Armor;        
            
        }
        public string Message()
        {
            return ($"\n~ {this.Name} \n    Damage: {this.Dmg} \n    Armour: {this.Armor}");
        }
    }
}