using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{

    public partial class RegisterForm : Form
    {
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

        private void Register_LoginLabel_Click(object sender, EventArgs e)
        {
            var loginWindow = new LoginForm();
            this.Hide();
            loginWindow.ShowDialog();
        }
    }
}
