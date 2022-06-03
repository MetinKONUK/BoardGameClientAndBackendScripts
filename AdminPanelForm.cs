using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace main
{
    public partial class AdminPanelForm : Form
    {
        private readonly Setting _setting = new Setting
                                            {
                                                Rows             = -1,
                                                Cols             = -1,
                                                DiffLevel = 0,
                                                Shapes          = new List<int>() {1, 0, 0},
                                                Colors          = new List<int>() {1, 0, 0}
                                            };
        private User _user;
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        public AdminPanelForm()
        {
            UserBase.SetUsers();
            UserBase.SetSettings();
            InitializeComponent();

            this.Size = new Size(screen.Width * 3 / 5, screen.Height * 3 / 4);
        }

        private void AddUsernamesToUsersComboBox()
        {
            AdminPanel_UsersListComboBox.Items.Clear();
            var usernames = new List<string>(UserBase.GetUsers().Keys);
            foreach (var username in usernames)
            {
                AdminPanel_UsersListComboBox.Items.Add(username);
            }
        }
        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            AddUsernamesToUsersComboBox();
            CountryData.AddCountriesToCountriesComboBox(AdminPanel_CountryComboBox);



            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (var dta in UserBase.GetUsers())
            {
                data.Add(dta.Key, dta.Value.BestScore);
            }
            var ascendingData = from entry in data orderby entry.Value descending select entry;
            foreach (var dta in ascendingData)
            {
                ListViewItem item = new ListViewItem(dta.Key);
                item.SubItems.Add(dta.Value.ToString());
                AdminPanelForm_BestScoresListView.Items.Add(item);
            }

        }

        private void AdminPanelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
        }

        private void UpdateUserInstanceRightPanel()
        {
            _user.NameSurname = AdminPanel_NameSurnameTextBox.Text;
            _user.PhoneNumber = AdminPanel_PhoneNumberTextBox.Text;
            _user.Address     = AdminPanel_AddressTextBox.Text;
            _user.Country     = AdminPanel_CountryComboBox.Text;
            _user.City        = AdminPanel_CityTextBox.Text;
            _user.Email       = AdminPanel_EmailTextBox.Text;
        }

        private User CreateUserInstance()
        {
            var user = new User
                        {
                            Username= AdminPanel_CreateUsernameTextBox.Text,
                            Password = Sha2.Sha256Hash(AdminPanel_CreatePasswordTextBox.Text),
                            NameSurname = AdminPanel_CreateNameSurnameTextBox.Text,
                            PhoneNumber = AdminPanel_CreatePhoneNumberTextBox.Text,
                            Address = AdminPanel_CreateAddressTextBox.Text,
                            Country = AdminPanel_CreateCountryComboBox.Text,
                            City = AdminPanel_CreateCityTextBox.Text,
                            Email = AdminPanel_CreateEmailTextBox.Text
                        };
            return user;
        }


        private void BringSelectedUserData()
        {
            AdminPanel_UsernameLabel.Text      = _user.Username;
            AdminPanel_NameSurnameTextBox.Text = _user.NameSurname;
            AdminPanel_PhoneNumberTextBox.Text = _user.PhoneNumber;
            AdminPanel_AddressTextBox.Text     = _user.Address;
            AdminPanel_CountryComboBox.Text    = _user.Country;
            AdminPanel_CityTextBox.Text        = _user.City;
            AdminPanel_EmailTextBox.Text       = _user.Email;
        }
        private void AdminPanel_UsersListComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AdminPanel_RightPanel.Visible == false)
            {
                AdminPanel_RightPanel.Visible = true;
                AdminPanel_CreateNewUserPanel.Visible = false;
            };
            _user = UserBase.GetUsers()[AdminPanel_UsersListComboBox.Text];
            BringSelectedUserData();
        }

        private void AdminPanel_UpdateUserDataButton_Click(object sender, EventArgs e)
        {
            UpdateUserInstanceRightPanel();
            UserBase.UpdateUserData(_user.Username, _user);
        }

        private void AdminPanel_DeleteUserButton_Click(object sender, EventArgs e)
        {

            const string caption = @"Approve user deletion";
            const string message = @"Are you sure about deleting the user permanently?";

            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            UserBase.DeleteUser(_user.Username);
            UserBase.DeleteUserSetting(_user.Username);
            AdminPanel_RightPanel.Visible = false;
            AddUsernamesToUsersComboBox();
        }

        private void AdminPanel_OpenCreateNewUserComponentsButton_Click(object sender, EventArgs e)
        {
            AdminPanel_CreateNewUserPanel.Visible = true;
            AdminPanel_RightPanel.Visible = false;
            CountryData.AddCountriesToCountriesComboBox(AdminPanel_CreateCountryComboBox);
        }

        private void AdminPanel_CreateUserButton_Click(object sender, EventArgs e)
        {
            var user = CreateUserInstance();
            MessageBox.Show(user.Username);
            UserBase.AddUserToUsers(user.Username, user);

            UserBase.AddUserSetting(user.Username, _setting);

        }

        private void AdminPanelForm_SortByAscendingButton_Click(object sender, EventArgs e)
        {

            AdminPanelForm_BestScoresListView.Items.Clear();
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (var dta in UserBase.GetUsers())
            {
                data.Add(dta.Key, dta.Value.BestScore);
            }
            var ascendingData = from entry in data orderby entry.Value ascending select entry;
            foreach (var dta in ascendingData)
            {
                ListViewItem item = new ListViewItem(dta.Key);
                item.SubItems.Add(dta.Value.ToString());
                AdminPanelForm_BestScoresListView.Items.Add(item);
            }
        }

        private void AdminPanelForm_DescendingButton_Click(object sender, EventArgs e)
        {

            AdminPanelForm_BestScoresListView.Items.Clear();
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (var dta in UserBase.GetUsers())
            {
                data.Add(dta.Key, dta.Value.BestScore);
            }
            var ascendingData = from entry in data orderby entry.Value descending select entry;
            foreach (var dta in ascendingData)
            {
                ListViewItem item = new ListViewItem(dta.Key);
                item.SubItems.Add(dta.Value.ToString());
                AdminPanelForm_BestScoresListView.Items.Add(item);
            }
        }
    }
}
