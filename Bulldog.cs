using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_OOP_Arv
{
    // här ärver bulldog från dog 
    internal class Bulldog : Dog
    {
        // här sparar jag en beskrivning av bulldogs käke 
        private string StrongJaw { get; set; }

        // här skapar jag bulldog med egna värden eller defaultvärden
        public Bulldog(string bulldogName = "Ralf", int bulldogAge = 2, string bulldogColour = "Light grey", string bulldogSize = "Medium",string bulldogFood = "Dog Food", string strongJaw = "strong jaw!")
            : base(bulldogName, bulldogAge, bulldogFood, bulldogColour,bulldogSize)
        {
            // här sätter jag beskrivningen för bulldogs käke 
            StrongJaw = strongJaw;
        }

        // här ersätter jag den ärvda ljudmetoden med bulldogens läte 
        public override void makeSound()
        {
            Console.WriteLine($"Woof, woof! {Name} is barking!");
        }

        //här skriver jag ut att bulldogen har ett starkt bett
        public void StrongBite()
        {
            Console.WriteLine($"{Name} has a strong bite!");
        }

        // här skriver jag ut en beskrivning av bulldogens käke
        public void ShowJaw()
        {
            Console.WriteLine($"{Name} has a {StrongJaw}");
        }
    }
}
