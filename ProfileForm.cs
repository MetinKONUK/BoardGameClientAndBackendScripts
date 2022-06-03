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
    public partial class ProfileForm : Form
    {
        Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        private readonly User _user = UserBase.GetUsers()[UserBase.GetCurrentUser()];

        public ProfileForm()
        {
            InitializeComponent();
            this.Size = new Size(screen.Width* 7 / 10, screen.Height* 3 / 4);
        }

        private void PlaceCurrentUserDataToProfileWindow()
        {
            Profile_UsernameLabel.Text      = _user.Username;
            Profile_NameSurnameTextBox.Text = _user.NameSurname;
            Profile_PhoneNumberTextBox.Text = _user.PhoneNumber;
            Profile_AddressTextBox.Text     = _user.Address;
            Profile_CountryComboBox.Text    = _user.Country;
            Profile_CityTextBox.Text        = _user.City;
            Profile_EmailTextBox.Text       = _user.Email;
        }

        private User UpdateUserInstance()
        {
            _user.NameSurname = Profile_NameSurnameTextBox.Text;
            _user.PhoneNumber = Profile_PhoneNumberTextBox.Text;
            _user.Address     = Profile_AddressTextBox.Text;
            _user.Country     = Profile_CountryComboBox.Text;
            _user.City        = Profile_CityTextBox.Text;
            _user.Email       = Profile_EmailTextBox.Text;
            return _user;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            PlaceCurrentUserDataToProfileWindow();
            CountryData.AddCountriesToCountriesComboBox(Profile_CountryComboBox);
        }


        private void Profile_UpdateButton_Click(object sender, EventArgs e)
        {
            var password = Sha2.Sha256Hash(Profile_PasswordTextBox.Text);
            if (password != _user.Password)
            {
                MessageBox.Show("Invalid Password!");
                return;
            }
            else
            {
                UserBase.UpdateUserData(UserBase.GetCurrentUser(), UpdateUserInstance());
                MessageBox.Show("Profile Update Succeeded");
            }
        }
    }
}
