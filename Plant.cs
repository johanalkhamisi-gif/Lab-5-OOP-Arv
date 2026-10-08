using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    // här skapar jag en egen basklass för växterna 
    internal class Plant
    {
        // protected gör att subklasserna kan avända dessa egenskaper och dessa värden används till konstruktor sätter egna värden
        // här sparar jag växtens namn 
        protected string Name { get; set; } = "Unknown";

        // här sparar jag växtens ålder 
        protected int Age { get; set; } = 0;

        // här sparar jag växtens färg 
        protected string Colour { get; set; } = "Unknown";

        //här sparar jag växtens storlek
        protected string Size { get; set; } = "Medium";

        // här sparar jag vattnet och näring som växten behöver
        protected string Food { get; set; } = "Water and nutrients";

        //här skriver jag ut växtens info och getype.name visar klassnamnet 
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} is a {GetType().Name} | Age: {Age} | Colour: {Colour} | Size: {Size} | Needs: {Food}");
        }
        
        // virtual gör att subklasserna kan ersätta metoden med override
        public virtual void makeSound()
        {
            Console.WriteLine($"{Name} makes no sound.");
        }

        // här skriver jag ut att växten vilar 
        public virtual void Rest()
        {
            Console.WriteLine($"{Name} is resting!");
        }
    }
}
