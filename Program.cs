using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the AddressBook
            AddressBook addressBook = new AddressBook();

            // Greet the user
            AddressBook.Greet();

            // Add a user
            addressBook.AddUser();

            // Prompt the user for input
            Console.WriteLine("Enter a command (e.g., 'show FirstName_LastName' or 'showall' or 'edit FirstName_LastName'):");
            string input = Console.ReadLine();

            // Process the user's command
            string[] parts = input.Split(' ');
            if (parts.Length > 1 && parts[0].ToLower() == "edit")
            {
                string username = parts[1];
                addressBook.EditUser(username);
            }

            // Display details of all users
            addressBook.DisplayAllUsers();

            Console.ReadLine();
        }
    }
}
