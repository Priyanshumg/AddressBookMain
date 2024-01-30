using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        private DataBase db = new DataBase();
        private List<User> userList = new List<User>(); // List to store multiple users

        public static void Greet()
        {
            Console.WriteLine("Hello User");
            Console.WriteLine("Welcome to AddressBookMain");
        }

        public void AddUser()
        {
            bool addAnotherUser = true;

            while (addAnotherUser)
            {
                Console.WriteLine("Enter User Details:");

                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Zip: ");
                string zip = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                // Create a new User object
                User newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Zip = zip,
                    City = city,
                    Address = address,
                    PhoneNumber = phoneNumber,
                    Email = email
                };

                // Generate a username based on the first name and last name (or any other method you prefer)
                string username = GenerateUsername(firstName, lastName);

                // Add the user to the database
                db.ADD_USER(username, newUser);
                userList.Add(newUser);

                Console.WriteLine("User added successfully");

                // Ask if user wants to add another user
                Console.WriteLine("Do you want to add another user? (yes/no)");
                string response = Console.ReadLine().ToLower();

                // Check user response
                if (response != "yes")
                {
                    addAnotherUser = false;
                }
            }
        }

        public void EditUser(string username)
        {
            // Retrieve user details from the database
            User userDetails = db.GET_USER_DETAILS(username);

            // Check if user exists
            if (userDetails != null)
            {
                // Display current user details
                Console.WriteLine($"Current User Details for {username}:");
                Console.WriteLine($"First Name: {userDetails.FirstName}");
                Console.WriteLine($"Last Name: {userDetails.LastName}");
                Console.WriteLine($"Zip: {userDetails.Zip}");
                Console.WriteLine($"City: {userDetails.City}");
                Console.WriteLine($"Address: {userDetails.Address}");
                Console.WriteLine($"Phone Number: {userDetails.PhoneNumber}");
                Console.WriteLine($"Email: {userDetails.Email}");

                // Prompt user for new details
                Console.WriteLine($"Enter new details for {username}:");
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Zip: ");
                string zip = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Phone Number: ");
                string phoneNumber = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                // Update user details
                userDetails.FirstName = firstName;
                userDetails.LastName = lastName;
                userDetails.Zip = zip;
                userDetails.City = city;
                userDetails.Address = address;
                userDetails.PhoneNumber = phoneNumber;
                userDetails.Email = email;

                // Update user details in the database
                db.ADD_USER(username, userDetails);

                Console.WriteLine($"User details for {username} updated successfully");
            }
            else
            {
                Console.WriteLine($"User {username} not found.");
            }
        }

        public void DeleteUser(string username)
        {
            // Retrieve user details from the database
            User userDetails = db.GET_USER_DETAILS(username);

            // Check if user exists
            if (userDetails != null)
            {
                // Display current user details
                Console.WriteLine($"User Details for {username}:");
                Console.WriteLine($"First Name: {userDetails.FirstName}");
                Console.WriteLine($"Last Name: {userDetails.LastName}");
                Console.WriteLine($"Zip: {userDetails.Zip}");
                Console.WriteLine($"City: {userDetails.City}");
                Console.WriteLine($"Address: {userDetails.Address}");
                Console.WriteLine($"Phone Number: {userDetails.PhoneNumber}");
                Console.WriteLine($"Email: {userDetails.Email}");

                // Prompt user for confirmation
                Console.WriteLine($"Are you sure you want to delete user {username}? (yes/no)");
                string response = Console.ReadLine().ToLower();

                if (response == "yes")
                {
                    // Delete user from the database
                    db.UserData.Remove(username);
                    Console.WriteLine($"User {username} deleted successfully");
                }
                else
                {
                    Console.WriteLine("Delete operation cancelled.");
                }
            }
            else
            {
                Console.WriteLine($"User {username} not found.");
            }
        }


        public void ReadCommand(string command)
        {
            // Split into parts
            string[] parts = command.Split(' ');

            // Check if the command starts with "show", also converting to lower cases
            if (parts.Length > 1 && parts[0].ToLower() == "show")
            {
                // Get the username from the command
                string username = parts[1];

                // Show user details
                DisplayUserData(username);
            }
            else if (command.ToLower() == "showall") // New command to display all users
            {
                DisplayAllUsers();
            }
        }

        public void DisplayUserData(string username)
        {
            User userDetails = db.GET_USER_DETAILS(username);

            // Check if user exists
            if (userDetails != null)
            {
                // Display user details
                Console.WriteLine($"User Details for {username}:");
                Console.WriteLine($"First Name: {userDetails.FirstName}");
                Console.WriteLine($"Last Name: {userDetails.LastName}");
                Console.WriteLine($"Zip: {userDetails.Zip}");
                Console.WriteLine($"City: {userDetails.City}");
                Console.WriteLine($"Address: {userDetails.Address}");
                Console.WriteLine($"Phone Number: {userDetails.PhoneNumber}");
                Console.WriteLine($"Email: {userDetails.Email}");
            }
            else
            {
                Console.WriteLine($"User {username} not found.");
            }

        }

        public void DisplayAllUsers()
        {
            if (userList.Count > 0)
            {
                Console.WriteLine("User Details for all users:");
                foreach (var user in userList)
                {
                    Console.WriteLine($"First Name: {user.FirstName}");
                    Console.WriteLine($"Last Name: {user.LastName}");
                    Console.WriteLine($"Zip: {user.Zip}");
                    Console.WriteLine($"City: {user.City}");
                    Console.WriteLine($"Address: {user.Address}");
                    Console.WriteLine($"Phone Number: {user.PhoneNumber}");
                    Console.WriteLine($"Email: {user.Email}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No users found.");
            }
        }

        private string GenerateUsername(string firstName, string lastName)
        {
            // Example: Concatenate first name and last name and convert to lowercase
            return $"{firstName.ToLower()}_{lastName.ToLower()}";
        }
    }
}
