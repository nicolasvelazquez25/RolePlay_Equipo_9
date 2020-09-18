using Library;
using System.Collections;
using System;

    namespace Library
    {
        public class SwordElve
        {
            public string Name{get; set;}
            public int Dmg{get; set;} 
            public int Armor{get; set;}       
       
        public SwordElve(string Name, int Dmg, int Armor)     
        {
            this.Name = Name; 
            this.Dmg = Dmg;
            this. Armor= Armor;            
        }
        public string Message()
        {
            return ($"\n~ {this.Name} \n    Damage: {this.Dmg} \n    Armour: {this.Armor}");
        }
    }
}