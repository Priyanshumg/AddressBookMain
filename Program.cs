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
            Console.WriteLine("Enter a command (e.g., 'show username' or 'showall'):");
            string input = Console.ReadLine();

            // Process the user's command
            addressBook.ReadCommand(input);

            // Display details of all users
            addressBook.DisplayAllUsers();

            Console.ReadLine();
        }
    }
}
