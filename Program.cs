using System;

public class ValidationException : Exception
{
    public ValidationException(string message) : base(message)
    {
    }
}

public class UserRegistrationSystem
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("User Registration System");

            // Prompt the user to enter their name, email, and password
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            // Validate the user input
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                throw new ValidationException("All fields are required.");
            }

            if (name.Length < 6)
            {
                throw new ValidationException("Name must have at least 6 characters.");
            }

            if (password.Length < 8)
            {
                throw new ValidationException("Password must have at least 8 characters.");
            }

            // If input is valid, display success message
            Console.WriteLine("Registration successful!");
        }
        catch (ValidationException ex)
        {
            // Catch and display the validation exception
            Console.WriteLine("Validation Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Catch any other exception and display the error message to the user
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}

