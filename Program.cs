using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = FirstName();
            string lastName = LastName();
            int age =Age();
        }
        public static string FirstName()
        {
            Console.WriteLine("enter your firstname");
            string firstName = Console.ReadLine();
            return firstName;

        }
        public static string LastName()
        {
            Console.WriteLine("enter your lastname");
            String lastName = Console.ReadLine();
            return lastName;
        }
        public static int Age()
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }

    }
}
