﻿using System;

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


        }
    }
}