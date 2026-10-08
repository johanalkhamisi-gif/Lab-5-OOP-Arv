using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    //här ärver akita från dog
    internal class Akita : Dog
    {
        // här sparar jag akitans pälstyp
        private string FurType { get; set; }

        // här skapar jag akitan med egna värden eller defaultvärden 
        public Akita(string akitaName = "Hugo", int akitaAge = 3, string akitaColour = "Light brown", string akitaSize = "Big", string akitaFood = "Dog Food", string furType = "Long")
            : base(akitaName, akitaAge, akitaFood, akitaColour, akitaSize)
        {
            //här sätter jag akita egen pälstyp
            FurType = furType;
        }
        

        // här ersätter jag den ärvda ljudmetoden med akitas läte 
        public override void makeSound()
        {
            Console.WriteLine($"Woof, woof! {Name} is barking!");
        }

        // här skriver jag ut att aktian springer snabbt 
        public void RunFast()
        {
            Console.WriteLine($"{Name} is running fast!");
        }

        // här skriver jag ut akitans pälstyp
        public void ShowFur()
        {
            Console.WriteLine($"{Name} has {FurType} fur!");
        }
    }
}
