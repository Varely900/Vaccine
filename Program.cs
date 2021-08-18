using System;

namespace Vaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ID");
            Console.WriteLine("Surname");
            Console.WriteLine("First Name");
            Console.WriteLine("Date of Birth");
            Console.WriteLine("Province");

            int ID = Convert.ToInt32(Console.ReadLine());
            string Surname = Console.ReadLine();
            string FirstName = Console.ReadLine();
            string DateofBirth = Console.ReadLine();
            string Province = Console.ReadLine();

            Console.WriteLine("Enter your ID: " + ID);
            Console.WriteLine("Enter your Surname: " + Surname);
            Console.WriteLine("Enter your First Name: " + FirstName);
            Console.WriteLine("Enter your Date of Birth: " + DateofBirth);
            Console.WriteLine("Enter your Province: " + Province);
        }
    }
}
