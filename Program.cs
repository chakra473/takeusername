using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = FirstName();
            string lastName = LastName();
            int age = Age();
            string city = City();
            Console.WriteLine("Hi " + firstName + " " + lastName + " your age is " + age + " your city is " + city);
            Console.WriteLine("enter the year");
            int year = int.Parse(Console.ReadLine());
            bool Year = leapYear(year);
            Console.WriteLine(Year);

            coin();
           
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
        public static string City()
        {
            Console.WriteLine("enter your city");
            string city = Console.ReadLine();
            return city;
        }
        public static bool leapYear(int year)
        {
            if(year%400==0||year%100!=0&&year%4==0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static void coin()
        {
            int head = 0;
            int tail = 0;
            Random rand = new Random();
            
            int i = 1;
            while(i<=100)
            {
                int random = rand.Next(0, 2);
                if (random==0)
                {
                    head++;
                   
                }
                else
                {
                     tail++;
                  
                }
                i++;

            }
            Console.WriteLine("number of heads :" + head);
            Console.WriteLine("number of tails :" + tail);





        }

    }
}
