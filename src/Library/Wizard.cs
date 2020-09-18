using System;
using System.Collections;

namespace Library
{
    public class Wizard
    {
        public string Name{get; set;}

        public int Health{get; set;}

        public int BasicHealth{get;} = 100;

        public Spellbook ObjectBook{get; set;}

        public WizardStick ObjectStick{get; set;}

        public Wizard(string Name, int Health, Spellbook ObjectBook, WizardStick ObjectStick)
        {
            this.Name = Name;
            this.Health = Health;
            this.ObjectBook = ObjectBook;
            this.ObjectStick = ObjectStick;
        }

        /* Expert:  Posee un objeto, y en base al mismo puede
        calcular el total del daño producido personaje*/
        public int GetTotalDmg()
        {
            return this.ObjectBook.Dmg + this.ObjectStick.Dmg ;
        }

        /* Expert:  Posee un objeto, y en base al mismo puede
        calcular el total de la defensa de un personaje*/
        public int GetTotalArmor()
        {
            return this.ObjectBook.Armor + this.ObjectStick.Armor;
        }

        /* Expert:  Posee el ataque del personaje, y por lo tanto solo necesita la vida del mago indicado*/
        public void MakeDmg(Wizard mage)
        {
            float absorption = (mage.GetTotalArmor()*0.008f)/10;
            float dmg = ((GetTotalDmg()) * (1 - (absorption>0.8f? 0.8f : absorption)));
            
            mage.Health -= Convert.ToInt32(dmg);
        
            Console.WriteLine($"{this.Name} caused {Convert.ToInt32(dmg)} damage to {mage.Name}\n");
        }

        /* Expert:  Conoce la vida inicial y por lo tanto puede hacerlo por si misma*/
        public void RestoreHealth()
        {
            this.Health = this.BasicHealth;
        }
        
        public void GetStick(WizardStick stick)
        {
            this.ObjectStick = stick;
        }

        public void OutStick()
        {
            this.ObjectStick = null;
        }
        public void GetBook(Spellbook spell)
        {
            this.ObjectBook = spell;
        }

        public void OutBook()
        {
            this.ObjectBook = null;
        }
        public string MessageHealth()
        {
            return ($"{this.Name} has {this.Health}Hp\n");
        }
        public string MessageCharacter()
        {
            return ($"Hero: {this.Name} \nHealth: {this.Health} \n_Items_{ObjectBook.Message()}{ObjectStick.Message()}\n");
        }
    }
}