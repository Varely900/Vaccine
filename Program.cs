using System;

namespace Vaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ID Number: " + ID);

            Console.WriteLine("Enter your Surname: ");
            string Surname = Console.ReadLine();
            Console.WriteLine("Surname" + Surname);
           
            Console.WriteLine(" Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("First Name: " + FirstName);

            Console.WriteLine("Enter Date of Birth");
            string DateofBirth = Console.ReadLine();
            Console.WriteLine("Date of Birth: " + DateofBirth);


            Console.WriteLine("Enter the Province");

            string Province = Console.ReadLine();
            Console.WriteLine("Your Province is: " + Province);
        }
    }
}
