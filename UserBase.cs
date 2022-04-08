using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace main
{
    public sealed class UserBase
    {
        public UserBase() { }

        private static Dictionary<string, User>  _users;

        private static Dictionary<string, Admin> _admins;

        private static Dictionary<string, Setting> _settings;
        private static string CurrentUser { get; set; }

        public static UserBase Instance { get; } = new UserBase();

        public static void SetUsers()
        {
            var usersJson = File.ReadAllText(@"../../users.json");
            _users = JsonConvert.DeserializeObject<Dictionary<string, User>>(usersJson);
        }

        public static Dictionary<string, User> GetUsers() => _users;

        public static void SetAdmins()
        {
            var adminsJson = File.ReadAllText(@"../../admins.json");
            _admins = JsonConvert.DeserializeObject<Dictionary<string, Admin>>(adminsJson);
        }

        public static Dictionary<string, Admin> GetAdmins() => _admins;

        public static void SetCurrentUser(string currentUser)
        {
            CurrentUser = currentUser;
        }

        public static string GetCurrentUser() => CurrentUser;


        // Read Settings Data From "settings.json" And Write It Into Settings Dictionary
        public static void SetSettings()
        {
            var settingsJson = File.ReadAllText(@"../../settings.json");
            _settings = JsonConvert.DeserializeObject<Dictionary<string, Setting>>(settingsJson);
        }

        // Return The Settings Dictionary Which Holds Settings Data
        public static Dictionary<string, Setting> GetSettings() => _settings;

        // Update Particular User's Setting Object
        public static void UpdateUserSetting(string username, Setting setting)
        {
            _settings[username] = setting;
        }

        public static void AddUserSetting(string username, Setting setting)
        {
            _settings.Add(username, setting);
        }

        // Write Settings Dictionary Data Into "settings.json" File
        public static void SaveSettings()
        {
            var jsonSettings = JsonConvert.SerializeObject(_settings, Formatting.Indented);
            File.WriteAllText(@"../../settings.json", jsonSettings);
        }

        public static void AddUserToUsers(string username, User user)
        {
            _users.Add(username, user);
        }

        public static void SaveUsers()
        {
            var jsonUsers = JsonConvert.SerializeObject(_users, Formatting.Indented);
            File.WriteAllText(@"../../users.json", jsonUsers);
        }


    }
}