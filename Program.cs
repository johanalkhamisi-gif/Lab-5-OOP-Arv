


namespace Lab_5_OOP_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // här skapar jag djuiren och växterna med konstruktornas defaultvärde 
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


            // här skriver jag ut info om varje djur och växt
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


            // här anropar jag varje djur ljudmetod och växterna skriver ut deras egna ljud
            dog.makeSound();
            Console.WriteLine();

            akita.makeSound();
            Console.WriteLine();

            bulldog.makeSound();
            Console.WriteLine();

            cat.makeSound();
            Console.WriteLine();

            lion.makeSound();
            Console.WriteLine();

            bird.makeSound();
            Console.WriteLine();

            human.makeSound();
            Console.WriteLine();

            snake.makeSound();
            Console.WriteLine();

            flower.makeSound();
            Console.WriteLine();

            tree.makeSound();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // här skriver jag ut vad varje djur äter 
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

            // Här skriver jag ut att djuren sover eller vilar och att växterna vilar
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

            flower.Rest();
            Console.WriteLine();

            tree.Rest();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // här anropar jag metoderna som beskriver vad djuren och växterna gör 
            dog.Bark();
            Console.WriteLine();

            akita.RunFast();
            Console.WriteLine();

            bulldog.StrongBite();
            Console.WriteLine();

            lion.Hunt();
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



            //här skriver jag ut djuren och växterna unika egenskaper

            dog.HappyDog();
            Console.WriteLine();

            akita.ShowFur();
            Console.WriteLine();

            bulldog.ShowJaw();
            Console.WriteLine();

            cat.ShowClaws ();
            Console.WriteLine();

            lion.ShowNightVision();
            Console.WriteLine();

            bird.ShowFly ();
            Console.WriteLine();

            human.ShowHairColour();
            Console.WriteLine();

            snake.ShowVenom();
            Console.WriteLine();

            flower.ShowScent ();
            Console.WriteLine();

            tree.ShowFruit();



        }
       

        
    }
}