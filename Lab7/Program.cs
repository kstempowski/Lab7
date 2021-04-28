using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string input1 = Console.ReadLine();
            UserName(input1);


            Console.WriteLine("Enter an email address");
            string input2 = Console.ReadLine();
            EmailAddress(input2);
                
                
            Console.WriteLine("Input a phone number using the following format ###-###-####");
            string input3 = Console.ReadLine();
            PhoneNumber(input3);


            Console.WriteLine("Input a date of birth using the following format dd/mm/yyyy");
            string input4 = Console.ReadLine();
            DateOfBirth(input4);
        }

        public static string UserName(string name)
        {
            //The first letter of the name must be a capital letter, and all other letters must be lower case
            //ranging from 1 to 30 characters.
            string reg1 = "^([A-Z][a-z]{1,30})";
            if (Regex.IsMatch(name, reg1))
            {
                Console.WriteLine($"{name} is a valid name");
            }
            else
            {
                Console.WriteLine($"{name} is not a valid input");
            }       
            return name;  
        }


        public static string EmailAddress(string email)
        {
            //This may take in upper, or lower case letters. The main address must be at least 5 characters, but
            //no more than 30. The domain must be at least 5 characters, but no more than 10.
            //The end must be at least 2 characters, but no more than 3.
            string reg2 = "([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})";

            if (Regex.IsMatch(email, reg2))
            {
                Console.WriteLine($"{email} is a valid email address");
            }
            else
            {
                Console.WriteLine($"{email} is not a valid input");
            }
            return email;
        }


        public static string PhoneNumber(string phone)
        {
            //The phone number must be 3 digits (0-9, followed by "-", three digits followed by "-",
            //and then 4 digits.
            string reg3 = "([0-9]{3})-([0-9]{3})-([0-9]{4})";

            if(Regex.IsMatch(phone, reg3))
            {
                Console.WriteLine($"{phone} is a valid phone number");
            }
            else
            {
                Console.WriteLine($"{phone} is not a valid phone number.");
            }
            return phone;
        }


        public static string DateOfBirth(string age)
        {
            //The date of birth is in the format date/month/year. There are 2 numbers allowed for the date, 
            //2 numbers allowed for the month, and 4 numbers for the year. Each part must be separated by 
            //a "/" resulting in dd/mm/yyyy.
            string reg4 = "([0-31]{2})/([0-12]{2})/([0-9]{4})";

            if (Regex.IsMatch(age, reg4))
            {
                Console.WriteLine($"{age} is a valid date of birth");
            }
            else
            {
                Console.WriteLine($"{age} is not a valid date of birth.");
            }
            return age;
        }
    }

}
