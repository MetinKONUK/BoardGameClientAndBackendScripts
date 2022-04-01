using System;
using System.Collections.Generic;

namespace main
{
    public class Users
    {
        public Users()
        {
            users.Add("admin", "admin");
            users.Add("user", "user");
        }
        public Dictionary<string, string> users = new Dictionary<string, string>();
    }
}