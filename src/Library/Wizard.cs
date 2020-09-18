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
        public int TotalAttack()
        {
            return this.ObjectBook.Attack + this.ObjectStick.Attack ;
        }

        /* Expert:  Posee un objeto, y en base al mismo puede
        calcular el total de la defensa de un personaje*/
        public int TotalDefense()
        {
            return this.ObjectBook.Defense + this.ObjectStick.Defense;
        }

        /* Expert:  Posee el ataque del personaje, y por lo tanto solo necesita la vida del mago indicado*/
        public void ToAttack(Wizard mage)
        {
            mage.Health = mage.Health - this.ObjectBook.Attack - this.ObjectStick.Attack;
        }

        /* Expert:  Conoce la vida inicial y por lo tanto puede hacerlo por si misma*/
        public void ToHeal()
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

    }
}