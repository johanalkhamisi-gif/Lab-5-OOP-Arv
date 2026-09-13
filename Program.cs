
using System.Drawing;
using System.Runtime.InteropServices;

namespace Lab_5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Akita akita = new Akita();
            Bulldog bulldog = new Bulldog();
            Cat cat = new Cat();
            Lion lion = new Lion ();
            Bird bird = new Bird();
            Human human = new Human();
            Snake snake = new Snake();
            Flower flower = new Flower();
            Tree tree = new Tree();

            // Visar info 
            dog.ShowInfo();
            Console.WriteLine();

            akita.ShowInfo();
            Console.WriteLine();

            bulldog.ShowInfo();
            Console.WriteLine();

            lion.ShowInfo();
            Console.WriteLine();

            cat.ShowInfo();
            Console.WriteLine();

            bird.ShowInfo();
            Console.WriteLine();

            human.ShowInfo();
            Console.WriteLine();

            snake.ShowInfo();
            Console.WriteLine();

            flower.ShowInfo();
            Console.WriteLine();

            tree.ShowInfo();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Gör ljud
            dog.MakeSound();
            Console.WriteLine();

            akita.MakeSound();
            Console.WriteLine();

            bulldog.MakeSound();
            Console.WriteLine();

            cat.MakeSound();
            Console.WriteLine();

            lion.MakeSound();
            Console.WriteLine();

            bird.MakeSound();
            Console.WriteLine();

            human.MakeSound();
            Console.WriteLine();

            snake.MakeSound();
            Console.WriteLine();

            flower.MakeSound();
            Console.WriteLine();

            tree.MakeSound();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Äter
            dog.EatFood();
            Console.WriteLine();

            akita.EatFood();
            Console.WriteLine();

            bulldog.EatFood();
            Console.WriteLine();

            cat.EatFood();
            Console.WriteLine();

            lion.EatFood();
            Console.WriteLine();

            bird.EatFood();
            Console.WriteLine();

            human.EatFood();
            Console.WriteLine();

            snake.EatFood();
            


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Sover
            dog.Sleep();
            Console.WriteLine();

            akita.Sleep();
            Console.WriteLine();

            bulldog.Sleep();
            Console.WriteLine();

            cat.Sleep();
            Console.WriteLine();

            lion.Sleep();
            Console.WriteLine();

            bird.Sleep();
            Console.WriteLine();

            human.Sleep();
            Console.WriteLine();

            snake.Sleep();
            Console.WriteLine();

            flower.Sleep();
            Console.WriteLine();

            tree.Sleep();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Speciella egenskaper
            dog.Bark();
            Console.WriteLine();

            akita.RunFast();
            Console.WriteLine();

            bulldog.StrongBite();
            Console.WriteLine();

            lion.Hunting();
            Console.WriteLine();

            cat.Climb();
            Console.WriteLine();

            bird.Fly();
            Console.WriteLine();

            human.Jump();
            Console.WriteLine();

            snake.Crawl();
            Console.WriteLine();

            flower.Grow ();
            Console.WriteLine();

            tree.ProduceOxygen();
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            //unika egenskaper

            dog.HappyDog();
            Console.WriteLine();

            akita.ShowFur();
            Console.WriteLine();

            bulldog.ShowJaw();
            Console.WriteLine();

            cat.ShowClaws ();
            Console.WriteLine();

            lion.ShowHasNightVision ();
            Console.WriteLine();

            bird.ShowFly ();
            Console.WriteLine();

            human.ShowsHairColour();
            Console.WriteLine();

            snake.ShowVenom();
            Console.WriteLine();

            flower.ShowScent ();
            Console.WriteLine();

            tree.ShowFruit();



        }
       

        class Animal 
        {

            protected string Name { get; set; } = "Unknown";
            protected int Age { get; set; } = 0;
            protected string Colour { get; set; } = "Unknown";
            protected string Size { get; set; } = "Medium";
            protected string Food { get; set; } = "Food";

            public void ShowInfo()
            {
                Console.WriteLine($"{Name} is a {GetType().Name} | Age: {Age} | Colour: {Colour} | Size: {Size} | Food: {Food}");
            }

            public void EatFood()
            {
                Console.WriteLine($"Crunchy Sound, {Name} is eating {Food}!");
            }

            

            public void Sleep()
            {
                string AnimalType = GetType().Name;

                if (AnimalType == "Dog" || AnimalType == "Akita" || AnimalType == "Bulldog")
                {
                    Console.WriteLine($"Snoring sound, SHHH, {Name} is sleeping!" );
                }
                else if (AnimalType == "Cat")
                {
                    Console.WriteLine($"Purring sound, SHHH, {Name} is sleeping!");
                }
                else if (AnimalType == "Bird")
                {
                    Console.WriteLine($"Chirping sound, SHHH, {Name} is sleeping!");
                }
                else if (AnimalType == "Human")
                {
                    Console.WriteLine($"Snoring sound, SHHH, {Name} is sleeping!");
                }
                else if (AnimalType == "Lion")
                {
                    Console.WriteLine($"Low growling sound, SHHH, {Name} is sleeping!");
                }
                else if (AnimalType == "Snake")
                {
                    Console.WriteLine($"Hissing sound, SHHH, {Name} is resting!");
                }
                
                

            }


            public virtual void MakeSound()
            {
                Console.WriteLine("The animal makes a sound!");
            }
        }


        class Mammal : Animal
        {
        }


        class Domestic : Mammal
        {
        }


        class Dog : Domestic
        {
            private string Happydog = "licking you and wiggeling his tail!";

            public Dog( string DogName = "Rickard", int DogAge = 3, string DogFood = "Dog Food", string DogColour = "Light brwon", string DogSize = "Smal")
            {
                Name = DogName;
                Age = DogAge;
                Food = DogFood;
                Colour = DogColour;
                Size = DogSize;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"Woof, woof! {Name} is barking!");
            }


            public void Bark()
            {
                Console.WriteLine(
                    "The dog is barking!"
                );
            }
            
            public void HappyDog ()
            {
                Console.WriteLine($"{Name} is so happy that he is {Happydog}");
            }
        }


        class Akita : Dog
        {
            private string FurType { get; set; } = "Long";


            public Akita(string AkitaName = "Hugo",int AkitaAge = 3,string AkitaColour = "Light brown",string AkitaSize = "Big",string AkitaFood = "Dog Food")
                : base(AkitaName, AkitaAge, AkitaFood)
            {
                Colour = AkitaColour;
                Age = AkitaAge;
                Size = AkitaSize;




            }


            public override void MakeSound()
            {
                Console.WriteLine($"Woof, woof! {Name} is barking!");
            }


            public void RunFast()
            {
                Console.WriteLine($"{Name} is running fast!");
            }

            public void ShowFur ()
            {
                Console.WriteLine($"{Name} has {FurType} fur!");
            }
        }


        class Bulldog : Dog
        {

            private string StrongJaw = "strong jaw!";

            public Bulldog(string BulldogName = "Ralf",int BulldogAge = 2,string BulldogColour = "Light grey",string BulldogSize = "Medium", string BulldogFood = "Dog Food") 
                : base(BulldogName, BulldogAge, BulldogFood)
            {
                Colour = BulldogColour;
                Size = BulldogSize;
                Age = BulldogAge;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"Woof, woof! {Name} is barking!");
            }


            public void StrongBite()
            {
                Console.WriteLine( $"{Name} has a strong bite!");
            }

            public void ShowJaw()
            {
                Console.WriteLine($"{Name} has a {StrongJaw}");
            }
                
        }


        class Cat : Domestic
        {

            private string BigClaws = "big claws!";

            public Cat(string CatName = "Gloria", int CatAge = 2, string CatColour = "Light Orange", string CatSize = "Small", string CatFood = "Cat Food")
            {
                Name = CatName;
                Age = CatAge;
                Colour = CatColour;
                Size = CatSize;
                Food = CatFood;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"Meow, meow! {Name} is meowing!");
            }


            public void Climb()
            {
                Console.WriteLine($"{Name} is climbing!");
            }

            public void ShowClaws ()
            {
                Console.WriteLine($"{Name} has {BigClaws}");
            }
        }


        class Wild : Mammal
        {
        }


        class Lion : Wild
        {

            private string NightVision = "night vision!";

            public Lion(string LionName = "Simba",int LionAge = 7,string LionColour = "Golden brown",string LionSize = "Very Big",string LionFood = "Meat")
            {
                Name = LionName;
                Age = LionAge;
                Colour = LionColour;
                Size = LionSize;
                Food = LionFood;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"A powerful roar! {Name} made a powerful sound!");
            }


            public void Hunting()
            {
                Console.WriteLine($"{Name} caught a warthog!");
            }

            public void ShowHasNightVision ()
            {
                Console.WriteLine($"{Name} has {NightVision}");
            }
        }


        class Bird : Animal
        {

            private string CanFly = "can fly!";

            public Bird(string BirdName = "Kalle",int BirdAge = 2,string BirdColour = "Yellow",string BirdSize = "Small",string BirdFood = "Seeds")
            {
                Name = BirdName;
                Age = BirdAge;
                Colour = BirdColour;
                Size = BirdSize;
                Food = BirdFood;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"Chirp, chirp! {Name} is chirping!"
);
            }


            public void Fly()
            {
                Console.WriteLine($"{Name} is flying!");
            }

            public void ShowFly ()
            {
                Console.WriteLine($"{Name} {CanFly}");
            }
        }


        class Human : Animal
        {

            private string Hair = "black hair colour!";

            public Human( string HumanName = "Johan", int HumanAge = 21, string HumanFood = "Burger", string HumanColour = "Middle eastern colour")
            {
                Name = HumanName;
                Age = HumanAge;
                Food = HumanFood;
                Colour = HumanColour;
            }


            public override void MakeSound()
            {
                Console.WriteLine( $"Hello! {Name} is talking with a beautiful voice!");
            }


            public void Jump()
            {
                Console.WriteLine( $"{Name} is jumping high like Michael Jordan!");
            }

            public void ShowsHairColour ()
            {
                Console.WriteLine($"{Name} has {Hair}");
            }
        }


        class Reptile : Animal
        {
        }


        class Snake : Reptile
        {

            private string HasVenoum = "is venomous!";

            public Snake(string SnakeName = "Nisse", int SnakeAge = 4, string SnakeFood = "Mice", string SnakeColour = "Green", string SnakeSize = "Smal")
            {
                Name = SnakeName;
                Age = SnakeAge;
                Food = SnakeFood;
                Colour = SnakeColour;
                Size = SnakeSize;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"Hissing sound! {Name} is hissing!");
            }


            public void Crawl()
            {
                Console.WriteLine($"{Name} is crawling!");
            }

            public void ShowVenom ()
            {
                Console.WriteLine($"{Name} {HasVenoum}!");
            }
        }


        class Plant 
        {
            protected string Name { get; set; } = "Unknown";
            protected int Age { get; set; } = 0;
            protected string Colour { get; set; } = "Medium";
            protected string Size { get; set; } = "Medium";
            protected string Food { get; set; } = "Water and nutrients";

            public void ShowInfo ()
            {
                Console.WriteLine($"{Name} is a {GetType().Name} | Age: {Age} | Colour: {Colour} | Size: {Size} | Food: {Food}");
            }

            public virtual void MakeSound()
            {
                Console.WriteLine($"{Name} makes no sound.");
            }
            public virtual void Sleep ()
            {
                Console.WriteLine($"{Name} is resting!");
            }
        }


        class Flower : Plant
        {
            private string Scent { get; set; } = "Complex, sweet, and floral smell!";


            public Flower(string FlowerName = "The Rose", int FlowerAge = 15, string FlowerColour = "Red", string FlowerSize = "Small" ,  string FlowerFood = "Water and nutrients")
            {
                Name = FlowerName;
                Age = FlowerAge;
                Colour = FlowerColour;
                Size = FlowerSize;
                Food = FlowerFood;
            }



            public override void MakeSound()
            {
                Console.WriteLine($"{Name} makes no sound!");
            }

            public void Grow()
            {
                Console.WriteLine($"{Name} is Growing!");
            }

            public void ShowScent ()
            {
                Console.WriteLine($"The flower has a {Scent}");
            }
        }


        class Tree : Plant
        {
           


            public Tree(string TreeName = "The Apple tree",int TreeAge = 18,string TreeColour = "Green",string TreeSize = "Large",string TreeFood = "Water and nutrients")
            {
                Name = TreeName;
                Age = TreeAge;
                Colour = TreeColour;
                Size = TreeSize;
                Food = TreeFood;
            }


            public override void MakeSound()
            {
                Console.WriteLine($"{Name} is rustling in the wild!");
            }


            public void ProduceOxygen()
            {
                Console.WriteLine($"{Name} is Producing oxygen!");
            }

            public void ShowFruit ()
            {
                Console.WriteLine($"The Apple tree produces fruit!");
            }
        }
    }
}