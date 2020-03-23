using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeoSmart.Geographical
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await CountriesAsync();
            States();
        }

        public static string MakeId(string name)
        {
            var sb = new StringBuilder(name.Length);
            bool capitalizeNext = true;
            bool lowercaseNext = false;
            foreach (char c in name)
            {
                if (c == ' ' || c == '-' || c == '.')
                {
                    capitalizeNext = true;
                    continue;
                }
                if (c == '\'')
                {
                    lowercaseNext = true;
                    continue;
                }

                if (capitalizeNext)
                {
                    sb.Append(char.ToUpper(c));
                    capitalizeNext = false;
                }
                else if (lowercaseNext)
                {
                    sb.Append(char.ToLower(c));
                    lowercaseNext = false;
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        static async Task CountriesAsync()
        {
            List<Country> results = new List<Country>();

            var currencyJson = await new HttpClient().GetStringAsync("http://country.io/currency.json");
            var currencies = JsonConvert.DeserializeObject<JObject>(currencyJson);

            var prefixesJson = await new HttpClient().GetStringAsync("http://country.io/phone.json");
            var prefixes = JsonConvert.DeserializeObject<JObject>(prefixesJson);

            var iso3Json = await new HttpClient().GetStringAsync("http://country.io/iso3.json");
            var iso3s = JsonConvert.DeserializeObject<JObject>(iso3Json);

            var numericJson = await new HttpClient().GetStringAsync("https://raw.githubusercontent.com/lukes/ISO-3166-Countries-with-Regional-Codes/master/all/all.json");
            var numerics = JsonConvert.DeserializeObject<JObject[]>(numericJson);

            foreach (var country in WellKnown.Countries)
            {
                string currencyCode = country.CurrencyCode;
                if (currencies.TryGetValue(country.TwoCharacterAbbreviation, out var jCurrency))
                {
                    currencyCode = jCurrency.ToString();
                }
                string dialPrefix = country.DialPrefix;
                if (prefixes.TryGetValue(country.TwoCharacterAbbreviation, out var jPrefix))
                {
                    dialPrefix = "+" + jPrefix.ToString().Trim('+');
                }
                string threeLetterCode = country.ThreeCharacterAbbreviation;
                if (iso3s.TryGetValue(country.TwoCharacterAbbreviation, out var jIso3))
                {
                    threeLetterCode = jIso3.ToString();
                }
                string isoNumeric = country.IsoNumeric;
                var numericObject = numerics.Where(jObject => jObject.TryGetValue("alpha-2", out var alpha2) && alpha2.ToString() == country.TwoCharacterAbbreviation);
                if (numericObject.Count() > 0)
                {
                    numericObject.First().TryGetValue("country-code", out var countryCode);
                    isoNumeric = countryCode.ToString();
                }

                results.Add(new Country(country.Name, country.FullName,
                    isoAlpha2: country.TwoCharacterAbbreviation, isoAlpha3: threeLetterCode,
                    isoNumeric: isoNumeric,
                    currencyCode: currencyCode, dialPrefix: dialPrefix));
            }

            var sb = new StringBuilder();
            sb.AppendLine("public class WellKnown");
            sb.AppendLine("{");
            foreach (var country in results)
            {
                sb.AppendLine($@"    [Display(Name = ""{country.Name}"")]");
                sb.AppendLine($@"    public Country {MakeId(country.Name)} => new Country");
                sb.AppendLine($@"    (");
                sb.AppendLine($@"        ""{ country.Name}"",");
                if (country.FullName != country.Name)
                {
                    sb.AppendLine($@"        fullname: ""{country.FullName}"",");
                }
                if (!string.IsNullOrEmpty(country.IsoNumeric)
                    && country.IsoNumeric != "000")
                {
                    sb.AppendLine($@"        isoNumeric: ""{country.IsoNumeric}"",");
                }
                sb.AppendLine($@"        isoAlpha2: ""{country.IsoAlpha2}"",");
                sb.AppendLine($@"        isoAlpha3: ""{country.IsoAlpha3}"",");
                if (!string.IsNullOrEmpty(country.DialPrefix))
                {
                    sb.AppendLine($@"        dialPrefix: ""{country.DialPrefix}"",");
                }

                if (sb[sb.Length - 3] == ',')
                {
                    sb.Remove(sb.Length - 3, 1);
                }

                sb.AppendLine("    );");
                sb.AppendLine("");
            }
            sb.AppendLine("}");

            //File.WriteAllText("C:/users/mqudsi/Downloads/Countries.cs", sb.ToString());

            //var zimbabwe = Countries.Find(c => c.ISOAbbreviation, "ZW");
            //zimbabwe = Countries.Find(c => c.ISOAbbreviation, "ZW");
            //zimbabwe = Countries.Find(c => c.FullName, "Zimbabwe");

            Console.WriteLine(sb.ToString());
        }

        static void States()
        {
            var sb = new StringBuilder();
            sb.AppendLine("public abstract class States");
            sb.AppendLine("{");

            //foreach (NeoSmart.Geographical.UnitedStates.WellKnown.State s in Enum.GetValues(typeof(NeoSmart.Geographical.UnitedStates.WellKnown.State)))
            //{
            //    var id = Enum.GetName(typeof(NeoSmart.Geographical.UnitedStates.WellKnown.State), s);

            //    var state = new State(s);
            foreach (var state in UnitedStates.States)
            {
                sb.AppendLine($"\t[Display(Name = \"{state.Name}\")]");
                sb.AppendLine($"\tpublic static readonly State {state.Name} = new State {{");
                sb.AppendLine($"\t\tName = \"{state.Name}\",");
                sb.AppendLine($"\t\tAbbreviation = \"{state.Abbreviation}\",");
                sb.AppendLine($"\t}};");
                sb.AppendLine();
            }
            sb.AppendLine("}");

            //File.WriteAllText("C:/users/mqudsi/downloads/States.cs", sb.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}
