using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {

            DataBase db = new DataBase();

            // Greet Function
            AddressBook.Greet();

            // Basic Declaration 
            string userName = "Name";

            // Adding User for testing 
            db.ADD_USER(userName, "Priyanshu");
            string UserDetails = db.SHOW_ALL_USERS(userName);
            Console.WriteLine($"User Details: {UserDetails}");

            Console.ReadLine();
        }
    }
}
