using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorLab
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter a valid Name: ");
            string Name = Console.ReadLine();
            NameValidation(Name);
            Console.Write("Please enter a valid Email: ");
            string Email = Console.ReadLine();
            EmailValidation(Email);
            Console.Write("Please enter a valid Phone Number: ");
            string PhoneNumber = Console.ReadLine();
            PhoneNumberValidation(PhoneNumber);
            Console.Write("Please enter a valid Date(dd/mm/yyyy): ");
            string BirthDate = Console.ReadLine();
            BirthDateValidation(BirthDate);

        }
        public static void NameValidation(string Name )
        {
            if (Regex.IsMatch(Name, @"^[A-Z][A-z]{0,29}$"))
            {
                Console.WriteLine("Name is Valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Name is not valid!");
            }
        }
        public static void EmailValidation(string Email)
        {
            if (Regex.IsMatch(Email, @"^[A-z\d]{5,30}[@][A-z/d]{5,10}[.][A-z/d]{2,3}$"))
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Email is not valid!");
            }
        }
        public static void PhoneNumberValidation(string PhoneNumber)
        {
            if (Regex.IsMatch(PhoneNumber, @"^[1-9]{0,3}[-][1-9][0-9]{0,2}[-][0-9]{1,4}$"))
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Phone number is not valid!");
            }
        }
        public static void BirthDateValidation(string BirthDate)
        {
            if (Regex.IsMatch(BirthDate, @"^(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/][0-9]{1,4}$"))
            {
                Console.WriteLine("Birth date is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, Birth date is not valid!");
            }
        }


    }
}
