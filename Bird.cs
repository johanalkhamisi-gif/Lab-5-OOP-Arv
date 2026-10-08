using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    // här ärver fågel animal
    internal class Bird : Animal
    {
        // här sparar jag att fågel kan flyga
        private string CanFly { get; set; } = "can fly!";

        // här sätter jag fågelns egenskaper när objektet skapas och om inga egna värden skickas in då används defaultvärden
        public Bird(string birdName = "Kalle", int birdAge = 2,string birdColour = "Yellow", string birdSize = "Small",string birdFood = "Seeds")
        {
            Name = birdName;
            Age = birdAge;
            Colour = birdColour;
            Size = birdSize;
            Food = birdFood;
        }

        //här ersätter jag basklassens ljudmetod med fågelns ljud
        public override void makeSound()
        {
            Console.WriteLine($"Chirp, chirp! {Name} is chirping!");
        }

        // här skriver jag ut att fågeln flyger 
        public void Fly()
        {
            Console.WriteLine($"{Name} is flying!");
        }

        // här skriver jag ut fågelns flygförmåga 
        public void ShowFly()
        {
            Console.WriteLine($"{Name} {CanFly}");
        }
    }
}
