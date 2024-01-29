using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class DataBase
    {
        public Dictionary<string, string> UserData;

        public DataBase()
        {
            UserData = new Dictionary<string, string>();
        }
        public string ADD_USER(string key, string value)
        {
            return UserData[key] = value;
        }
        public string SHOW_ALL_USERS(string key)
        {
            if (UserData.ContainsKey(key))
            {
                return UserData[key];
            }
            else
            {
                return "User Not found, Either Add a user or check with the case you entered";
            }

        }
    }
}
