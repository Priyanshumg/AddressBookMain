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

            bool exit = false;

            while (!exit)
            {
                // Prompt the user for input
                Console.WriteLine("Enter a command (e.g., 'add', 'remove', 'edit', 'showall', 'show', 'exit'):");
                Console.WriteLine("to perform above operations command FirstName_LastName");
                string input = Console.ReadLine().ToLower();

                // Process the user's command
                string[] parts = input.Split(' ');

                switch (parts[0])
                {
                    case "add":
                        addressBook.AddUser();
                        break;
                    case "remove":
                        // Prompt for username to remove
                        Console.WriteLine("Enter username to remove:");
                        string usernameToRemove = Console.ReadLine();
                        addressBook.DeleteUser(usernameToRemove);
                        break;
                    case "edit":
                        // Prompt for username to edit
                        Console.WriteLine("Enter username to edit:");
                        string usernameToEdit = Console.ReadLine();
                        addressBook.EditUser(usernameToEdit);
                        break;
                    case "showall":
                        addressBook.DisplayAllUsers();
                        break;
                    case "show":
                        if (parts.Length > 1)
                        {
                            string usernameToShow = parts[1];
                            addressBook.DisplayUserData(usernameToShow);
                        }
                        else
                        {
                            Console.WriteLine("Please provide a username.");
                        }
                        break;
                    case "exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }

            Console.WriteLine("Exiting the program. Goodbye!");
        }
    }
}
