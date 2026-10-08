using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Lab_5_OOP_Arv
{
    // här ärver orm från reptil 
    internal class Snake : Reptile
    {
        // här sparar jag att denna orm är giftig
        private string VenomStatus { get; set; } = "is venomous!";

        // här sätter jag ormens egenskaper när objektet skapas, om inte egna värden skickas in då används defaultvärden
        public Snake(string snakeName = "Nisse", int snakeAge = 4,
            string snakeFood = "Mice", string snakeColour = "Green",
            string snakeSize = "Smal")
        {
            Name = snakeName;
            Age = snakeAge;
            Food = snakeFood;
            Colour = snakeColour;
            Size = snakeSize;
        }

        //här ersätter jag basklassen ljudmetod med ormens läte 
        public override void makeSound()
        {
            Console.WriteLine($"Hissing sound! {Name} is hissing!");
        }

        // här skriver jag attt ormen kryper 
        public void Crawl()
        {
            Console.WriteLine($"{Name} is crawling!");
        }

        //här skriver jag ut beskrivning av ormens gitighet
        public void ShowVenom()
        {
            Console.WriteLine($"{Name} {VenomStatus}");
        }
    }
}
