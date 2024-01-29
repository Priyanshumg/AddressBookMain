using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

    public class DataBase
    {
        public Dictionary<string, User> UserData;

        public DataBase()
        {
            UserData = new Dictionary<string, User>();
        }

        // Method to add user details
        public void ADD_USER(string username, User user)
        {
            UserData[username] = user;
        }

        // Method to retrieve user details
        public User GET_USER_DETAILS(string username)
        {
            if (UserData.ContainsKey(username))
            {
                return UserData[username];
            }
            else
            {
                return null; // User not found
            }
        }
    }
}
