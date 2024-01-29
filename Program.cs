using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the database
            DataBase db = new DataBase();

            // Add user details
            User user1 = new User
            {
                FirstName = "John",
                LastName = "Doe",
                Zip = "12345",
                City = "New York",
                Address = "123 Main St",
                PhoneNumber = "123-456-7890",
                Email = "john@example.com"
            };

            db.ADD_USER("john_doe", user1);

            // Retrieve and display user details
            string username = "john_doe";
            User userDetails = db.GET_USER_DETAILS(username);

            if (userDetails != null)
            {
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

            Console.ReadLine();
        }
    }
}
