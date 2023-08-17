//System.Linq namespace for more array methods

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numery = { 3, 4, 3, -5, 543, 66, 77, 32, 5, 7, 8, 9, 10, 7, 45 };
            Console.WriteLine("Max value found in the array: " + numery.Max());
            Console.WriteLine("Min value found in the array: " + numery.Min());
            Console.WriteLine("Sum of all the numbers found in the array: " + numery.Sum());

            Console.WriteLine();
            //multidemensional arrays
            string[,] animals = { { "pomeranian", "husky" }, { "main coon", "norwegian forest cat" } };
            Console.WriteLine("Dog breeds: ");
            for (int i = 0; i < animals.GetLength(0); i++)
            {
                Console.WriteLine(animals[0, i]);
            }
            Console.WriteLine();
            Console.WriteLine("Cat breeds: ");
            for (int i = 0; i < animals.GetLength(1); i++)
            {
                Console.WriteLine(animals[1, i]);
            }
            Console.WriteLine();
            Console.WriteLine("All animals: ");
            for (int i = 0; i < animals.GetLength(0); i++)
            {
                for (int j = 0; j < animals.GetLength(1); j++)
                {
                    Console.WriteLine(animals[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Changed dog breeds: ");
            //changing the value of an element in a 2D array
            animals[0, 1] = "yorkie";
            for (int i = 0; i < animals.GetLength(0); i++)
            {
                Console.WriteLine(animals[0, i]);
            }
            Console.WriteLine();
            Console.WriteLine("All of the animals: ");
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            Console.WriteLine("Enter your name: \n");
            string name = Console.ReadLine();
            Console.WriteLine("\nHow old are you " + name + "?\n");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            FirstMethod(name, age);
            Console.WriteLine();
            FirstMethod();
            Console.WriteLine("\nWe are going to be adding two integer numbers to eachother\n" );
            Console.WriteLine("Enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The outcome: "+Adder(a,b));
            Console.WriteLine("What's your favourite dessert? ");
            string favourite = Console.ReadLine();
            Console.WriteLine("What's the name of something sweet you've had to eat but weren't the biggest fan of? ");
            string mid = Console.ReadLine();
            Console.WriteLine("What's the worst sweet thing you've ever had to eat: ");
            string bad = Console.ReadLine();
            Sweets(favourite: favourite, bad: bad, mid: mid);
            Console.WriteLine("\nWe are going to be adding two floating point numbers to eachother\n");
            Console.WriteLine("Enter 1st number: ");
            double ad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            double bd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The outcome: " + Adder(ad, bd));

        }

        //creating and calling methods in C#
        static void FirstMethod(string name = "Raphael", int age = 18)
        {
            Console.WriteLine(name + ",I hope you're happy to be " + age + " years old");
        }
        //a method returning the outcome
        static int Adder (int a, int b)
        {
            int z = a + b;
            return z;
        }
        static void Sweets(string bad, string mid, string favourite)
        {
            Console.WriteLine("\n"+favourite + " is the best of all sweets, WHILE " + mid + " is not so good and " + bad + " is the worst");

        }
        //overloading methods
        static double Adder (double a, double b)
        {
            return a + b;
        }

       
    }
}


