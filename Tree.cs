using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Lab_5_OOP_Arv
{
    // här ärver trädet från plantan
    internal class Tree : Plant
    {
        //här sparar jag att detta träd ger frukt
        private string FruitProduction { get; set; } = "produces fruit!";
        
        // här sätter jag trädets egenskaper när objektet skapas och om inga egna värden skickas in då används defauktvärden
        public Tree(string treeName = "The Apple tree", int treeAge = 18,
            string treeColour = "Green", string treeSize = "Large",
            string treeFood = "Water and nutrients")
        {
            Name = treeName;
            Age = treeAge;
            Colour = treeColour;
            Size = treeSize;
            Food = treeFood;
        }

        //här ersätter jag basklassen metod med att trädets löv prasslar 
        public override void makeSound()
        {
            Console.WriteLine($"{Name} has leaves rustling in the wind!");
        }

        //här skriver jag att trädet prodcuerar syre 
        public void ProduceOxygen()
        {
            Console.WriteLine($"{Name} is producing oxygen!");
        }

        //här skriver jag ut trädets namn och att det ger frukt 
        public void ShowFruit()
        {
            Console.WriteLine($"{Name} {FruitProduction}");
        }
    }
}
