using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = FirstName();
        }
        public static string FirstName()
        {
            Console.WriteLine("enter your firstname");
            string firstName = Console.ReadLine();
            return firstName;

        }
    }
}
