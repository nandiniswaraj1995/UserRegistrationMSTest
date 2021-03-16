using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern patter = new Pattern();
            Console.WriteLine("Enter First_Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine(patter.isValidFirstName(firstName));
            Console.WriteLine("Enter Last_Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine(patter.isValidLastName(lastName));
            Console.WriteLine("Enter Email_Id:");
            string email = Console.ReadLine();
            Console.WriteLine(patter.isValidEmail(email));
            Console.WriteLine("Enter Mobile_Number:");
            string mobile = Console.ReadLine();
            Console.WriteLine(patter.isValidMobileNumber(mobile));






        }
    }
}
