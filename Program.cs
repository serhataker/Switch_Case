using System;
namespace Switch_Case
{

    class Switch_Case
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ruya frutirer!");
            Console.WriteLine("Apple = 2 TL");
            Console.WriteLine("Pear = 3 TL");
            Console.WriteLine("Strawberry = 2 TL");
            Console.WriteLine("Banana = 3 TL");
            Console.WriteLine("Others all fruit = 4 TL");

            Console.Write($"Which fruit do you want to buy?:(Apple/Pear/Strawberry/Banana/Others)");
            string m = Console.ReadLine();
            m = m.ToLower();// When you inputed the section (switch/case option) at the program small charcter or mix it is will be all big charcter
           // m = m.ToUpper();// when you inputed the section (switch/case option) at the program samll charcter or mix it is will be all big charcter
            switch (m)

            {
                case "apple":
                    Console.WriteLine("Will You Want to Buy Fruit= 2 TL");
                    break;
                case "pear":
                    Console.WriteLine("Will You Want to Buy Fruit= 3 TL");
                    break;
                case "strawberry":
                    Console.WriteLine("Will You Want to Buy Fruit= 2 TL");
                    break;
                case "banana":
                    Console.WriteLine("Will You Want to Buy Fruit= 3 TL");
                    break;
                case "others":
                    Console.WriteLine("Will You Want to Buy Fruit= 3 TL");
                    break;
                default:
                    Console.WriteLine("Mistake input program closed...");
                    Environment.Exit(0);
                    break;
            }

            if (m=="apple") //If you want to if state you must the much many if statment that is not correct for the programming if you use the switch-case it is will be more good. i prefer the switch-case.
            {

                Console.WriteLine("Will You Want to Buy Fruit= 2 TL");
            }
            else if (m== "pear")
            {
                Console.WriteLine("Will You Want to Buy Fruit = 3 TL");
            } 
            
            else if (m== "strawberry")
            {
                Console.WriteLine("Will You Want to Buy Fruit = 2 TL");
            }
            else if (m== "banana")
            {
                Console.WriteLine("Will You Want to Buy Fruit = 3 TL");
            }
             else if (m== "others")
            {
                Console.WriteLine("Will You Want to Buy Fruit = 3 TL");
            }
            else
            {
                Console.WriteLine("Mistake input program closed...");
            }
        }
        enum Fruits
        {
            Apple,
            Pear,
            Strawberry,
            Banana,
            Others,
        }
    }
}