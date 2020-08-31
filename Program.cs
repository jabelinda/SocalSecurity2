using System;
using System.Globalization;
using System.Net.NetworkInformation;

namespace SocalSecurity2
{
    class Program
    {
        static void Main(string[] args)

        {
            
            string socialSecurityNumber=SocialSecurityNumber();

            string genderNumberString = socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1);

            int genderNumber = int.Parse(genderNumberString);

            bool isFemale = genderNumber % 2 == 0;

            string gender = isFemale ? "Female" : "Male";
            /*if (isFemale)
            {
                Console.WriteLine("Female");
            }
            else
            {
                Console.WriteLine("Male");
            }*/

            string birthDateString = socialSecurityNumber.Substring(0, 6);

            DateTime birthDate = DateTime.ParseExact(birthDateString, "yyMMdd", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;// DateTime.Today.Year

            if (birthDate.Month > DateTime.Today.Month || birthDate.Month == DateTime.Today.Month && birthDate.Day > DateTime.Now.Day)
            {
                age--;//age = age - 1;
            }
            Console.WriteLine($"{gender},{age}");
        }

        public static string SocialSecurityNumber()
        {
            Console.WriteLine("Please enter Social Security Number (YYMMDD--XXXX)");
            string socialSecurityNumber = Console.ReadLine();
            return socialSecurityNumber;
        }
        public static string SocialSecurityNumber (string socialSecurityNumber)
        {
            return socialSecurityNumber;  

           
        }

    }
}


namespace SocialSecurityNumber_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string socialSecurityNumber;

            // Input
            if (args.Length > 0)
            {
                // if input from terminal is already done
                Console.WriteLine($"You provided: {args[0]}");
                socialSecurityNumber = args[0];
            }
            else

            {   // Ask for input
                Console.WriteLine("Please input your Social security number YYMMDD-XXXX");
                socialSecurityNumber = Console.ReadLine();
            }


            // Gender
            string genderNumberString = socialSecurityNumber.Substring(socialSecurityNumber.Length - 2, 1);

            int genderNumber = int.Parse(genderNumberString);

            string gender;

            if (genderNumber % 2 == 0) // True/false  (Boolean)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            // Age
            string birthDateString = socialSecurityNumber.Substring(0, 6);

            DateTime birthDate = DateTime.ParseExact(birthDateString, "yyMMdd", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;

            if (birthDate.Month > DateTime.Today.Month || birthDate.Month == DateTime.Now.Month && birthDate.Day > DateTime.Now.Day)
            {
                age = age - 1;
            }


            // Result presentation
            Console.WriteLine($"This is a: {gender}, with age: {age}");
        }
    }
}
