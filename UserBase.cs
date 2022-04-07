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
        private Dictionary<string, User>  _users;
        private Dictionary<string, Admin> _admins;
        private Dictionary<string, Setting> _settings;
        private string CurrentUser { get; set; }

        public static UserBase Instance { get; } = new UserBase();

        public void SetUsers()
        {
            var usersJson = File.ReadAllText(@"../../users.json");
            this._users = JsonConvert.DeserializeObject<Dictionary<string, User>>(usersJson);
        }
        public Dictionary<string, User> GetUsers() => this._users;

        public void SetAdmins()
        {
            var adminsJson = File.ReadAllText(@"../../admins.json");
            this._admins = JsonConvert.DeserializeObject<Dictionary<string, Admin>>(adminsJson);
        }
        public Dictionary<string, Admin> GetAdmins() => this._admins;

        public void SetCurrentUser(string currentUser)
        {
            this.CurrentUser = currentUser;
        }

        public string GetCurrentUser() => this.CurrentUser;

        public void SetSettings()
        {
            var settingsJson = File.ReadAllText(@"../../settings.json");
            this._settings = JsonConvert.DeserializeObject<Dictionary<string, Setting>>(settingsJson);
        }

        public Dictionary<string, Setting> GetSettings() => this._settings;

        public void UpdateUserSetting(string username, Setting setting)
        {
            this._settings[username] = setting;
        }

        public void SaveSettings()
        {
            string jsonSettings = JsonConvert.SerializeObject(this._settings, Formatting.Indented);
            File.WriteAllText(@"../../settings.json", jsonSettings);
        }
    }
}