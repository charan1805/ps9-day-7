using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ps_9
{
    internal class Program
    {
        
        
            

public class ValidationException : Exception
        {
            public ValidationException(string message) : base(message)
            {
            }
        }

        public class UserRegistrationSystem
        {
            public static void Main(string[] args)
            {
                try
                {
                    
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();

                    
                    Console.Write("Enter your email: ");
                    string email = Console.ReadLine();

                   
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();

                    ValidateInput(name, email, password);

                   
                    Console.WriteLine("User registration successful!");
                }
                catch (ValidationException ex)
                {
                    
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            private static void ValidateInput(string name, string email, string password)
            {
                
                if (string.IsNullOrEmpty(name))
                {
                    throw new ValidationException("Name is required.");
                }

                if (string.IsNullOrEmpty(email))
                {
                    throw new ValidationException("Email is required.");
                }

                if (string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("Password is required.");
                }

                
                if (name.Length < 6)
                {
                    throw new ValidationException("Name must have at least 6 characters.");
                }

                if (password.Length < 8)
                {
                    throw new ValidationException("Password must have at least 8 characters.");
                }

                
            }
        }
    }
    }

