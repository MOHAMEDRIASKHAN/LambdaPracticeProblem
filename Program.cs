// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text.RegularExpressions;

namespace LamdaPracticeProblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Lambda Practice Problem");

             string Regex_FirstName = "^[A-Z]{5}$";  //RIYAS

             string Regex_LastName = "^[A-Z]{4}";   //KHAN

             string Regex_MobileNumber = "^([0-9]{2}[ ])?[0-9]{10}$";  //91 9876543210

             string Regex_Password = @"^([A-Z]{1}[a-z]{4}[@][0-9]{4]$";  //Riyas@1234

             string Regex_Email = "^[a-z]{9}[@][a-z]{5}[.][a-z]{3}?$";   //riyaskhan@gmail.com

            
            
                Console.WriteLine("=====================================================User Registration===============================================");
                Console.Write("\nPlease enter user details\n");

                Console.Write("First Name:     ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name:     ");
                string lastName = Console.ReadLine();

                Console.Write("Email:     ");
                string email = Console.ReadLine();

                Console.Write("Mobile Number:     ");
                string mobile = Console.ReadLine();

                Console.Write("Password:     ");
                string password = Console.ReadLine();

                Func<string, bool> isValidName = s => Regex.IsMatch(s, Regex_FirstName);
                Func<string, bool> isValidMobileNumber = s => Regex.IsMatch(s, Regex_MobileNumber);
                Func<string, bool> isValidPassword = s => Regex.IsMatch(s, Regex_Password);
                Func<string, bool> isValidEmail = s => Regex.IsMatch(s, Regex_Email);

            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}\n{4} ",
                              (isValidName(firstName)) ? "First name is valid" : "First name is invalid",
                              (isValidName(lastName)) ? "Last name is valid" : "Last name is invalid",
                              (isValidEmail(email)) ? "Email address is valid" : "Email address is invalid",
                              (isValidMobileNumber(mobile)) ? "Mobile number is valid" : "Mobile number is invalid",
                              (isValidPassword(password)) ? "Password is valid" : "Password is invalid");
                

            }
        }
    }



            
    