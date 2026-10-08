using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Lab_5_OOP_Arv
{
    // här ärver blomma från planta
    internal class Flower : Plant
    {
        // här sparar jag en beskrivning av blommans doft
        private string Scent { get; set; } = "complex, sweet, and floral smell!";

        //här sätter jag blommans egenskaper när objektet skapas och inga egna värden skickas används defaultvärden 
        public Flower(string flowerName = "The Rose", int flowerAge = 15,string flowerColour = "Red", string flowerSize = "Small",string flowerFood = "Water and nutrients")
        {
            Name = flowerName;
            Age = flowerAge;
            Colour = flowerColour;
            Size = flowerSize;
            Food = flowerFood;
        }

        //här ersätterjag basklassens metod med att blomman inte gör något ljud
        public override void makeSound()
        {
            Console.WriteLine($"{Name} makes no sound!");
        }

        // här skriver jag ut att blomman växer
        public void Grow()
        {
            Console.WriteLine($"{Name} is growing!");
        }

        // här skriver jag ut blommans doft
        public void ShowScent()
        {
            Console.WriteLine($"{Name} has a {Scent}");
        }
    }
}
