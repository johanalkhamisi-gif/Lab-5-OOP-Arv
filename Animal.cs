using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    //här skapar jag basklassen med egenskaper och metoder som djuren delar
    internal class Animal
    {
        // protected gör att subklasserna kan använda dessa egenskaper. Värdena efter  = används till konstruktor sätter andra värden
        
        //här sparar jag djurets namn
        protected string Name { get; set; } = "Unknown";

        // här sparar jag djurets ålder
        protected int Age { get; set; } = 0;
        
        // här sparar jag djurets färg
        protected string Colour { get; set; } = "Unknown";

        // här sparar jag djurets storlek
        protected string Size { get; set; } = "Medium";

        //här sparar jag vad djuret äter
        protected string Food { get; set; } = "Food";

        // här skriver jag ut djurets information och gettype.name visar klassnamnet.
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} is a {GetType().Name} | Age: {Age} | Colour: {Colour} | Size: {Size} | Food: {Food}");
        }

        // här skriver jag ut djurets namn och vad den äter
        public void EatFood()
        {
            Console.WriteLine($"{Name} is eating {Food}!");
        }

        // här kontrollerar jag djurets klassnamn och skriver ut en text för när djuret sover eller vilar
        public void Sleep()
        {
            string animalType = GetType().Name;

            if (animalType == "Dog" || animalType == "Akita" || animalType == "Bulldog")
            {
                Console.WriteLine($"Snoring sound, SHHH, {Name} is sleeping!");
            }
            else if (animalType == "Cat")
            {
                Console.WriteLine($"Purring sound, SHHH, {Name} is sleeping!");
            }
            else if (animalType == "Bird")
            {
                Console.WriteLine($"Chirping sound, SHHH, {Name} is sleeping!");
            }
            else if (animalType == "Human")
            {
                Console.WriteLine($"Snoring sound, SHHH, {Name} is sleeping!");
            }
            else if (animalType == "Lion")
            {
                Console.WriteLine($"Low growling sound, SHHH, {Name} is sleeping!");
            }
            else if (animalType == "Snake")
            {
                Console.WriteLine($"SHHH, {Name} is resting!");
            }
        }

        // virtual gör att subklasserna kan ersätta metoden med override
        public virtual void makeSound()
        {
            Console.WriteLine("The animal makes a sound!");
        }
    }
}
