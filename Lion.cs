using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Lab_5_OOP_Arv
{
    // här ärver lejon från wild 
    internal class Lion : Wild
    {
        // här sparar jag att lejonnet kan se mörker
        private string NightVisionDescription { get; set; } = "night vision!";

        //här sätter jag lejonnets egenskaper när objektet skapas och om jag inte skickar in egna värden så används defaultvärden 
        public Lion(string lionName = "Simba", int lionAge = 7,string lionColour = "Golden brown", string lionSize = "Very Big",string lionFood = "Meat")
        {
            Name = lionName;
            Age = lionAge;
            Colour = lionColour;
            Size = lionSize;
            Food = lionFood;
        }

        // här ersätter jag basklassen ljudmetoden med lejonnets läte 
        public override void makeSound()
        {
            Console.WriteLine($"A powerful roar! {Name} made a powerful sound!");
        }

        // här skriver jag ut att lejonnet har fångat ett svin
        public void Hunt()
        {
            Console.WriteLine($"{Name} caught a warthog!");
        }

        //här skriver jag ut att lejonnet kan se i mörker 
        public void ShowNightVision()
        {
            Console.WriteLine($"{Name} has {NightVisionDescription}");
        }
    }
}
