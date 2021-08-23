using System;

namespace MethodExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Name()} has this {Color()} aura when they see a {Animal()} and this {Color()} aura when they see {Band()}.");
            Console.WriteLine("Enter a positive integer: ");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Subtract(x, y));
            Console.WriteLine(Multiply(x, y));
            Console.WriteLine(Divide(x, y));
            Console.WriteLine(Modulus(x, y));
        }

        public static string Name()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        public static string Color()
        {
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            return color;
        }

        public static string Animal()
        {
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            return animal;
        }

        public static string Band()
        {
            Console.WriteLine("Who is your favorite band?");
            string band = Console.ReadLine();
            return band;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Subtract(int x, int y)
        {
            if (x > y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x , int y)
        {
            if(x > y)
            {
                return x / y;
            }
            else
            {
                return y / x;
            }
        }

        public static int Modulus(int x, int y)
        {
            if(x > y)
            {
                return x % y;
            }
            else
            {
                return y % x;
            }
        }
    }
}
