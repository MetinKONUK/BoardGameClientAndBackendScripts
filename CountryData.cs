using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public sealed class CountryData
    {
        public CountryData() { }
        public static CountryData Instance { get; } = new CountryData();
        public static void AddCountriesToCountriesComboBox(ComboBox comboBox)
        {
            var countryList = new List<string>();
            var countries   = CultureInfo.GetCultures(CultureTypes.SpecificCultures);


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
                comboBox.Items.Add(country);
            }

            comboBox.AutoCompleteMode   = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
    }
}
