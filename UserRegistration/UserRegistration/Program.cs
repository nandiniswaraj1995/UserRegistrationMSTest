using System;
using System.Collections.Generic;

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
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Console.WriteLine(patter.isValidPassword(password));
            List<string> validEmailList = new List<string>()
            { "abc@yahoo.com", "abc-100@yahoo.com" ,"abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net",
                "abc.100@abc.com.au","abc@1.com","abc@gmail.com.com","abc+100@gmail.com"};
                
            foreach (string emails in validEmailList)
                {
                    if (patter.isValidEmail(emails))
                    {
                        Console.WriteLine(true);
                    }
                    else
                    {
                    Console.WriteLine(false) ;
                    }
                }
            
            List<string> invalidEmailList = new List<string>()
            {"abc","abc@.com.my","abc123@gmail.a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com",
             "abc@%*.com","abc..2002@gmail.com}","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au" };

                foreach (string emails in invalidEmailList)
                {
                    if (patter.isValidEmail(emails))
                    {
                        Console.WriteLine(false);
                    }
                    else
                    {
                    Console.WriteLine(false);
                    }
                }
           







        }
    }
}
