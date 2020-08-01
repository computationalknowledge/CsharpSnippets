using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int strength = rand.Next(1, 100);
            Console.WriteLine(strength); 
        }
    }
}
