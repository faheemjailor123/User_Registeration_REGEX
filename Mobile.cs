using System;
using System.Collections.Generic;

namespace RegularExpression01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Welcome to User Registration Program");
            Console.WriteLine("\n Please enter user's First Name--");
            string firstName = Console.ReadLine();
            RegularExp.FirstName(firstName);                                 //taking user input and passing it in first name method of regular exp class
            string lastName = Console.ReadLine();
            RegularExp.LastName(lastName);                                  //taking user input and passing it in last name method of regular exp class
            string email = Console.ReadLine();
            RegularExp.Email(email);                                        //email entry
            string mobile = Console.ReadLine();
            RegularExp.Mobile(mobile);                                     //mobile number with country code

            
            
            
        }
    }
}

