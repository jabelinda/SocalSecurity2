using System;
using System.Globalization;

namespace SocalSecurity2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Social Security Number (YYMMDD--XXXX)");

            string socialSecurityNumber = Console.ReadLine();

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

            DateTime birthDate = DateTime.ParseExact(birthDateString, "YYMMDD", CultureInfo.InvariantCulture);

            int age = DateTime.Now.Year - birthDate.Year;// DateTime.Today.Year

            if (birthDate.Month > DateTime.Today.Month || birthDate.Month==DateTime.Today.Month&& birthDate.Day>DateTime.Now.Day) 
            {
                age--;//age = age - 1;
            }
            Console.WriteLine($"{gender},{age}");
        }
    }
}
