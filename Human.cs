using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    // här ärver människa från däggdjur 

    internal class Human : Mammal
    {
        // här spaarar jag männsikans hårfärg
        private string HairColour { get; set; } = "black hair colour!";

        // här sätter jag männsikans egenskaper när objektet skapas och om inga egna värden skickas in då används defaultvärden
        public Human(string humanName = "Johan", int humanAge = 21,string humanFood = "Burger",string humanColour = "Middle eastern colour")
        {
            Name = humanName;
            Age = humanAge;
            Food = humanFood;
            Colour = humanColour;
        }

        // här ersätter jag basklassens ljudmetod med männsikans tal 
        public override void makeSound()
        {
            Console.WriteLine($"Hello! {Name} is talking with a beautiful voice!");
        }

        // här skriver jag ut att människan hoppar
        public void Jump()
        {
            Console.WriteLine($"{Name} is jumping high like Michael Jordan!");
        }

        //här skriver jag ut människans hårfärg 
        public void ShowHairColour()
        {
            Console.WriteLine($"{Name} has {HairColour}");
        }
    }
}
