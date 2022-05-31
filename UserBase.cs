using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        private static Dictionary<string, User>  _users = new Dictionary<string, User>();

        private static Dictionary<string, Admin> _admins = new Dictionary<string, Admin>();

        private static Dictionary<string, Setting> _settings = new Dictionary<string, Setting>();
        public static string CurrentUser { get; set; }
        public static bool IsCurrentUserAdmin = false;

        public static UserBase Instance { get; } = new UserBase();

        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H42PN9G;Initial Catalog=OOP-PROJECT;Integrated Security=True");

        // SQL

        //DONE
        private static void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //DONE
        private static void CloseConnection()
        {
            connection.Close();
        }



        //DONE
        public static void SetUsers()
        {
            OpenConnection();
            var query = IsCurrentUserAdmin ? "SELECT * FROM USERS" : $"SELECT * FROM USERS WHERE username='{CurrentUser}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader rd = cmd.ExecuteReader();
            _users.Clear();

            while (rd.HasRows)
            {
                while (rd.Read())
                {
                    User user = new User
                    {
                        UserId = rd.GetInt32(0),
                        Username = Convert.ToString(rd["username"]),
                        Password = Convert.ToString(rd["password"]),
                        NameSurname = Convert.ToString(rd["nameSurname"]),
                        Email = Convert.ToString(rd["email"]),
                        Address = Convert.ToString(rd["address"]),
                        Country = Convert.ToString(rd["country"]),
                        City = Convert.ToString(rd["city"]),
                        PhoneNumber = Convert.ToString(rd["phoneNumber"]),
                        BestScore = rd.GetInt32(9),
                    };
                    _users.Add(user.Username, user);
                }
                rd.NextResult();
            }

            rd.Close();
            CloseConnection();
        }

        //DONE
        public static void SetAdmins()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ADMINS", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            _admins.Clear();

            while (rd.HasRows)
            {
                while (rd.Read())
                {
                    Admin admin = new Admin
                    {
                        AdminId = rd.GetInt32(0),
                        Username = Convert.ToString(rd["adminname"]),
                        Password = Convert.ToString(rd["password"]),
                    };
                    _admins.Add(admin.Username, admin);
                }
                rd.NextResult();
            }

            rd.Close();
            CloseConnection();
        }


        //DONE
        public static void SetSettings()
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM SETTINGS WHERE username='{CurrentUser}'", connection);
            SqlDataReader rd = cmd.ExecuteReader();
            _settings.Clear();

            while (rd.HasRows)
            {
                while (rd.Read())
                {
                    Setting setting = new Setting();
                    setting.UserId = rd.GetInt32(0);
                    setting.DiffLevel = rd.GetInt32(1);
                    setting.Rows = rd.GetInt32(2);
                    setting.Cols = rd.GetInt32(3);
                    var shapes = rd.GetInt32(4);
                    setting.Shapes[2] = shapes % 10;
                    shapes /= 10;
                    setting.Shapes[1] = shapes % 10;
                    shapes /= 10;
                    setting.Shapes[0] = shapes % 10;

                    var colors = rd.GetInt32(5);
                    setting.Colors[2] = colors % 10;
                    colors /= 10;
                    setting.Colors[1] = colors % 10;
                    colors /= 10;
                    setting.Colors[0] = colors % 10;

                    setting.Username = rd.GetString(6);

                    _settings.Add(setting.Username, setting);
                }
                rd.NextResult();
            }

            rd.Close();
            CloseConnection();
        }


        public static Dictionary<string, User> GetUsers() => _users;
        public static Dictionary<string, Admin> GetAdmins() => _admins;
        public static void SetCurrentUser(string currentUser)
        {
            CurrentUser = currentUser;
        }
        public static string GetCurrentUser() => CurrentUser;


        public static Dictionary<string, Setting> GetSettings() => _settings;

        //DONE
        public static void UpdateUserSetting(string username, Setting setting)
        {
            var shapes = setting.Shapes[2];
            shapes += setting.Shapes[1] * 10;
            shapes += setting.Shapes[0] * 100;

            var colors = setting.Shapes[2];
            colors += setting.Shapes[1] * 10;
            colors += setting.Shapes[0] * 100;

            OpenConnection();
            var query = $"UPDATE SETTINGS SET diffLevel='{setting.DiffLevel}', rows='{setting.Rows}', cols='{setting.Cols}', shapes={shapes}, colors='{colors}' WHERE username='{username}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            _settings[username] = setting;
        }

        public static void UpdateUserBestScore(int BestScore, string username)
        {
            OpenConnection();
            var query = $"UPDATE USERS SET bestScore='{BestScore}' WHERE username='{username}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        //DONE
        public static void UpdateUserData(string username, User user)
        {
            OpenConnection();
            var query = $"UPDATE USERS SET password='{user.Password}', nameSurname='{user.NameSurname}', email='{user.Email}', address='{user.Address}', country='{user.Country}', city='{user.City}', phoneNumber='{user.PhoneNumber}', bestScore='{user.BestScore}' WHERE username='{username}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            _users[username] = user;
            CloseConnection();
        }
        //DONE
        public static void AddUserSetting(string username, Setting setting)
        {
            OpenConnection();

            var shapes = setting.Shapes[2];
            shapes += setting.Shapes[1] * 10;
            shapes += setting.Shapes[0] * 100;

            var colors = setting.Shapes[2];
            colors += setting.Shapes[1] * 10;
            colors += setting.Shapes[0] * 100;

            var query = $"INSERT INTO SETTINGS (diffLevel, rows, cols, shapes, colors, username) VALUES ('{setting.DiffLevel}','{setting.Rows}','{setting.Cols}','{shapes}','{colors}','{username}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            _settings.Add(username, setting);

            CloseConnection();
        }
        //DONE
        public static void AddUserToUsers(string username, User user)
        {
            OpenConnection();
            var query = "INSERT INTO USERS (username, password, nameSurname, email, address, country, city, phoneNumber, bestScore)"
                + $"VALUES ('{user.Username}','{user.Password}','{user.NameSurname}','{user.Email}','{user.Address}','{user.Country}','{user.City}','{user.PhoneNumber}', '{user.BestScore}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            _users.Add(username, user);
            CloseConnection();
        }

        //DONE
        public static void DeleteUser(string username)
        {
            OpenConnection();
            var query = $"DELETE FROM USERS WHERE username='{username}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            _users.Remove(username);
            CloseConnection();
        }

        //DONE
        public static void DeleteUserSetting(string username)
        {
            OpenConnection();
            var query = $"DELETE FROM SETTINGS WHERE username='{username}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            _settings.Remove(username);
            CloseConnection();
        }

    }
}