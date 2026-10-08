using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Lab_5_OOP_Arv
{
    // här ärver cat från domestic 
    internal class Cat : Domestic
    {
        // här sparar jag en beskrivning av kattens klor 
        private string ClawDescription { get; set; } = "big claws!";

        // här sätter jag kattens egenskaper när objektet skapas och om inga egna värden skickas in så används defaultvärden.
        public Cat(string catName = "Gloria", int catAge = 2,string catColour = "Light Orange", string catSize = "Small",string catFood = "Cat Food")
        {
            Name = catName;
            Age = catAge;
            Colour = catColour;
            Size = catSize;
            Food = catFood;
        }

        // här ersätter jag basklassen ljudmetod med kattens läte 
        public override void makeSound()
        {
            Console.WriteLine($"Meow, meow! {Name} is meowing!");
        }

        // här skriver jag ut att katten klättrar 
        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing!");
        }

        // här skriver jag ut en beskrivnign av kattens klor
        public void ShowClaws()
        {
            Console.WriteLine($"{Name} has {ClawDescription}");
        }
    }
}
