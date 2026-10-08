using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace Lab_5_OOP_Arv
{
    // dog ärver från domestic och får även metoder och egenskaper från animal
    internal class Dog : Domestic
    {
        // här sparar jag hur hunden visar att den är glad
        private string HappyBehaviour { get; set; } = "licking you and wiggeling his tail!";

        // här sätter jag hundens egenskaper när objektet skapas och om jag inte skickar in egna värden anväds default värdena
        public Dog(string dogName = "Rickard", int dogAge = 3,
            string dogFood = "Dog Food", string dogColour = "Light brwon",
            string dogSize = "Smal")
        {
            Name = dogName;
            Age = dogAge;
            Food = dogFood;
            Colour = dogColour;
            Size = dogSize;
        }

        // här ersätter jag basklassens ljudmetod med hundens egna läte
        public override void makeSound()
        {
            Console.WriteLine($"Woof, woof! {Name} is barking!");
        }

        // här skriver jag ut hunden skäller
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking!");
        }

        // här skriver jag ut hur hunden visar att den är glad
        public void HappyDog()
        {
            Console.WriteLine($"{Name} is so happy that he is {HappyBehaviour}");
        }
    }
}
