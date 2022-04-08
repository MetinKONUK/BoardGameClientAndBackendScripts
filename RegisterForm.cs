using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{

    public partial class RegisterForm : Form
    {
        private readonly Sha2 _sha2 = Sha2.Instance;

        private readonly Setting _setting = new Setting
                                   {
                                       Row             = -1,
                                       Col             = -1,
                                       DifficultyLevel = 0,
                                       Shapes          = new List<int>() { 1, 0, 0 },
                                       Colors          = new List<int>() { 1, 0, 0 }
                                   };
        private readonly User _user = new User
                                      {
                                      };
        private readonly UserBase _userBase = UserBase.Instance;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddCountriesToCountriesComboBox()
        {
            var  countryList = new List<string>();
            var countries = CultureInfo.GetCultures(CultureTypes.SpecificCultures);


            foreach (var country in countries)
            {
                var region = new RegionInfo(country.LCID);

                if (!(countryList.Contains(region.EnglishName)))
                {
                    countryList.Add(region.EnglishName);
                }
            }
            countryList.Sort();
            foreach (var country in countryList)
            {
                Register_CountryComboBox.Items.Add(country);
            }

            Register_CountryComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            Register_CountryComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            AddCountriesToCountriesComboBox();
        }


        private void OpenLoginForm()
        {
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
        }
        private void Register_LoginLabel_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }


        private void Register_RegisterButton_Click(object sender, EventArgs e)
        {
            var username = Register_UsernameTextBox.Text;
            var password = Register_PasswordTextBox.Text;
            var nameSurname = Register_NameSurnameTextBox.Text;
            var phoneNumber = Register_PhoneNumberTextBox.Text;
            var address = Register_AddressTextBox.Text;
            var city = Register_CityTextBox.Text;
            var country = Register_CountryComboBox.Text;
            var eMail = Register_EmailTextBox.Text;

            _user.Username = username;
            _user.Password = _sha2.Sha256Hash(password);
            _user.NameSurname = nameSurname;
            _user.PhoneNumber = phoneNumber;
            _user.Address = address;
            _user.City = city;
            _user.Country = country;
            _user.Email = eMail;
            const string userNameIsTaken = "Username is Taken!";

            UserBase.SetUsers();
            if (UserBase.GetUsers().ContainsKey(_user.Username))
            {
                MessageBox.Show(userNameIsTaken);
                return;
            }
            UserBase.AddUserToUsers(_user.Username, _user);
            UserBase.SaveUsers();

            UserBase.SetSettings();
            UserBase.AddUserSetting(_user.Username, _setting);
            UserBase.SaveSettings();

            OpenLoginForm();

        }
    }
}
