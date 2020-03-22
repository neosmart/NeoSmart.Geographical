using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    public partial class WellKnown
    {
        public static CountryFactory Countries = new CountryFactory();

        public class CountryFactory : WellKnown<Country>
        {
            internal CountryFactory()
            {
            }

            [Display(Name = "Afghanistan")]
            public readonly Country Afghanistan = new Country
            {
                Name = "Afghanistan",
                ISOAbbreviation = "AF",
            };

            [Display(Name = "Albania")]
            public readonly Country Albania = new Country
            {
                Name = "Albania",
                ISOAbbreviation = "AL",
            };

            [Display(Name = "Algeria")]
            public readonly Country Algeria = new Country
            {
                Name = "Algeria",
                ISOAbbreviation = "DZ",
            };

            [Display(Name = "American Samoa")]
            public readonly Country AmericanSamoa = new Country
            {
                Name = "American Samoa",
                ISOAbbreviation = "AS",
            };

            [Display(Name = "Andorra")]
            public readonly Country Andorra = new Country
            {
                Name = "Andorra",
                ISOAbbreviation = "AD",
            };

            [Display(Name = "Angola")]
            public readonly Country Angola = new Country
            {
                Name = "Angola",
                ISOAbbreviation = "AO",
            };

            [Display(Name = "Anguilla")]
            public readonly Country Anguilla = new Country
            {
                Name = "Anguilla",
                ISOAbbreviation = "AI",
            };

            [Display(Name = "Antigua")]
            public readonly Country Antigua = new Country
            {
                Name = "Antigua",
                ISOAbbreviation = "AG",
            };

            [Display(Name = "Argentina")]
            public readonly Country Argentina = new Country
            {
                Name = "Argentina",
                ISOAbbreviation = "AR",
            };

            [Display(Name = "Armenia")]
            public readonly Country Armenia = new Country
            {
                Name = "Armenia",
                ISOAbbreviation = "AM",
            };

            [Display(Name = "Aruba")]
            public readonly Country Aruba = new Country
            {
                Name = "Aruba",
                ISOAbbreviation = "AW",
            };

            [Display(Name = "Australia")]
            public readonly Country Australia = new Country
            {
                Name = "Australia",
                ISOAbbreviation = "AU",
            };

            [Display(Name = "Austria")]
            public readonly Country Austria = new Country
            {
                Name = "Austria",
                ISOAbbreviation = "AT",
            };

            [Display(Name = "Azerbaijan")]
            public readonly Country Azerbaijan = new Country
            {
                Name = "Azerbaijan",
                ISOAbbreviation = "AZ",
            };

            [Display(Name = "Bahrain")]
            public readonly Country Bahrain = new Country
            {
                Name = "Bahrain",
                ISOAbbreviation = "BH",
            };

            [Display(Name = "Bangladesh")]
            public readonly Country Bangladesh = new Country
            {
                Name = "Bangladesh",
                ISOAbbreviation = "BD",
            };

            [Display(Name = "Barbados")]
            public readonly Country Barbados = new Country
            {
                Name = "Barbados",
                ISOAbbreviation = "BB",
            };

            [Display(Name = "Belarus")]
            public readonly Country Belarus = new Country
            {
                Name = "Belarus",
                ISOAbbreviation = "BY",
            };

            [Display(Name = "Belgium")]
            public readonly Country Belgium = new Country
            {
                Name = "Belgium",
                ISOAbbreviation = "BE",
            };

            [Display(Name = "Belize")]
            public readonly Country Belize = new Country
            {
                Name = "Belize",
                ISOAbbreviation = "BZ",
            };

            [Display(Name = "Benin")]
            public readonly Country Benin = new Country
            {
                Name = "Benin",
                ISOAbbreviation = "BJ",
            };

            [Display(Name = "Bermuda")]
            public readonly Country Bermuda = new Country
            {
                Name = "Bermuda",
                ISOAbbreviation = "BM",
            };

            [Display(Name = "Bhutan")]
            public readonly Country Bhutan = new Country
            {
                Name = "Bhutan",
                ISOAbbreviation = "BT",
            };

            [Display(Name = "Bolivia")]
            public readonly Country Bolivia = new Country
            {
                Name = "Bolivia",
                ISOAbbreviation = "BO",
            };

            [Display(Name = "Bosnia and Herzegovina")]
            public readonly Country BosniaAndHerzegovina = new Country
            {
                Name = "Bosnia and Herzegovina",
                ISOAbbreviation = "BA",
            };

            [Display(Name = "Botswana")]
            public readonly Country Botswana = new Country
            {
                Name = "Botswana",
                ISOAbbreviation = "BW",
            };

            [Display(Name = "Brazil")]
            public readonly Country Brazil = new Country
            {
                Name = "Brazil",
                ISOAbbreviation = "BR",
            };

            [Display(Name = "British Indian Ocean Territory")]
            public readonly Country BritishIndianOceanTerritory = new Country
            {
                Name = "British Indian Ocean Territory",
                ISOAbbreviation = "IO",
            };

            [Display(Name = "British Virgin Islands")]
            public readonly Country BritishVirginIslands = new Country
            {
                Name = "British Virgin Islands",
                ISOAbbreviation = "VG",
            };

            [Display(Name = "Brunei")]
            public readonly Country Brunei = new Country
            {
                Name = "Brunei",
                ISOAbbreviation = "BN",
            };

            [Display(Name = "Bulgaria")]
            public readonly Country Bulgaria = new Country
            {
                Name = "Bulgaria",
                ISOAbbreviation = "BG",
            };

            [Display(Name = "Burkina Faso")]
            public readonly Country BurkinaFaso = new Country
            {
                Name = "Burkina Faso",
                ISOAbbreviation = "BF",
            };

            [Display(Name = "Burma Myanmar")]
            public readonly Country BurmaMyanmar = new Country
            {
                Name = "Burma Myanmar",
                ISOAbbreviation = "MM",
            };

            [Display(Name = "Burundi")]
            public readonly Country Burundi = new Country
            {
                Name = "Burundi",
                ISOAbbreviation = "BI",
            };

            [Display(Name = "Cambodia")]
            public readonly Country Cambodia = new Country
            {
                Name = "Cambodia",
                ISOAbbreviation = "KH",
            };

            [Display(Name = "Cameroon")]
            public readonly Country Cameroon = new Country
            {
                Name = "Cameroon",
                ISOAbbreviation = "CM",
            };

            [Display(Name = "Canada")]
            public readonly Country Canada = new Country
            {
                Name = "Canada",
                ISOAbbreviation = "CA",
            };

            [Display(Name = "Cape Verde")]
            public readonly Country CapeVerde = new Country
            {
                Name = "Cape Verde",
                ISOAbbreviation = "CV",
            };

            [Display(Name = "Cayman Islands")]
            public readonly Country CaymanIslands = new Country
            {
                Name = "Cayman Islands",
                ISOAbbreviation = "KY",
            };

            [Display(Name = "Central African Republic")]
            public readonly Country CentralAfricanRepublic = new Country
            {
                Name = "Central African Republic",
                ISOAbbreviation = "CF",
            };

            [Display(Name = "Chad")]
            public readonly Country Chad = new Country
            {
                Name = "Chad",
                ISOAbbreviation = "TD",
            };

            [Display(Name = "Chile")]
            public readonly Country Chile = new Country
            {
                Name = "Chile",
                ISOAbbreviation = "CL",
            };

            [Display(Name = "China")]
            public readonly Country China = new Country
            {
                Name = "China",
                ISOAbbreviation = "CN",
            };

            [Display(Name = "Colombia")]
            public readonly Country Colombia = new Country
            {
                Name = "Colombia",
                ISOAbbreviation = "CO",
            };

            [Display(Name = "Comoros")]
            public readonly Country Comoros = new Country
            {
                Name = "Comoros",
                ISOAbbreviation = "KM",
            };

            [Display(Name = "Cook Islands")]
            public readonly Country CookIslands = new Country
            {
                Name = "Cook Islands",
                ISOAbbreviation = "CK",
            };

            [Display(Name = "Costa Rica")]
            public readonly Country CostaRica = new Country
            {
                Name = "Costa Rica",
                ISOAbbreviation = "CR",
            };

            [Display(Name = "Côte d'Ivoire")]
            public readonly Country CôteDIvoire = new Country
            {
                Name = "Côte d'Ivoire",
                ISOAbbreviation = "CI",
            };

            [Display(Name = "Croatia")]
            public readonly Country Croatia = new Country
            {
                Name = "Croatia",
                ISOAbbreviation = "HR",
            };

            [Display(Name = "Cuba")]
            public readonly Country Cuba = new Country
            {
                Name = "Cuba",
                ISOAbbreviation = "CU",
            };

            [Display(Name = "Cyprus")]
            public readonly Country Cyprus = new Country
            {
                Name = "Cyprus",
                ISOAbbreviation = "CY",
            };

            [Display(Name = "Czech Republic")]
            public readonly Country CzechRepublic = new Country
            {
                Name = "Czech Republic",
                ISOAbbreviation = "CZ",
            };

            [Display(Name = "Democratic Republic of Congo")]
            public readonly Country DemocraticRepublicOfCongo = new Country
            {
                Name = "Democratic Republic of Congo",
                ISOAbbreviation = "CD",
            };

            [Display(Name = "Denmark")]
            public readonly Country Denmark = new Country
            {
                Name = "Denmark",
                ISOAbbreviation = "DK",
            };

            [Display(Name = "Djibouti")]
            public readonly Country Djibouti = new Country
            {
                Name = "Djibouti",
                ISOAbbreviation = "DJ",
            };

            [Display(Name = "Dominica")]
            public readonly Country Dominica = new Country
            {
                Name = "Dominica",
                ISOAbbreviation = "DM",
            };

            [Display(Name = "Dominican Republic")]
            public readonly Country DominicanRepublic = new Country
            {
                Name = "Dominican Republic",
                ISOAbbreviation = "DO",
            };

            [Display(Name = "Ecuador")]
            public readonly Country Ecuador = new Country
            {
                Name = "Ecuador",
                ISOAbbreviation = "EC",
            };

            [Display(Name = "Egypt")]
            public readonly Country Egypt = new Country
            {
                Name = "Egypt",
                ISOAbbreviation = "EG",
            };

            [Display(Name = "El Salvador")]
            public readonly Country ElSalvador = new Country
            {
                Name = "El Salvador",
                ISOAbbreviation = "SV",
            };

            [Display(Name = "Equatorial Guinea")]
            public readonly Country EquatorialGuinea = new Country
            {
                Name = "Equatorial Guinea",
                ISOAbbreviation = "GQ",
            };

            [Display(Name = "Eritrea")]
            public readonly Country Eritrea = new Country
            {
                Name = "Eritrea",
                ISOAbbreviation = "ER",
            };

            [Display(Name = "Estonia")]
            public readonly Country Estonia = new Country
            {
                Name = "Estonia",
                ISOAbbreviation = "EE",
            };

            [Display(Name = "Ethiopia")]
            public readonly Country Ethiopia = new Country
            {
                Name = "Ethiopia",
                ISOAbbreviation = "ET",
            };

            [Display(Name = "Falkland Islands")]
            public readonly Country FalklandIslands = new Country
            {
                Name = "Falkland Islands",
                ISOAbbreviation = "FK",
            };

            [Display(Name = "Faroe Islands")]
            public readonly Country FaroeIslands = new Country
            {
                Name = "Faroe Islands",
                ISOAbbreviation = "FO",
            };

            [Display(Name = "Federated States of Micronesia")]
            public readonly Country FederatedStatesOfMicronesia = new Country
            {
                Name = "Federated States of Micronesia",
                ISOAbbreviation = "FM",
            };

            [Display(Name = "Fiji")]
            public readonly Country Fiji = new Country
            {
                Name = "Fiji",
                ISOAbbreviation = "FJ",
            };

            [Display(Name = "Finland")]
            public readonly Country Finland = new Country
            {
                Name = "Finland",
                ISOAbbreviation = "FI",
            };

            [Display(Name = "France")]
            public readonly Country France = new Country
            {
                Name = "France",
                ISOAbbreviation = "FR",
            };

            [Display(Name = "French Guiana")]
            public readonly Country FrenchGuiana = new Country
            {
                Name = "French Guiana",
                ISOAbbreviation = "GF",
            };

            [Display(Name = "French Polynesia")]
            public readonly Country FrenchPolynesia = new Country
            {
                Name = "French Polynesia",
                ISOAbbreviation = "PF",
            };

            [Display(Name = "Gabon")]
            public readonly Country Gabon = new Country
            {
                Name = "Gabon",
                ISOAbbreviation = "GA",
            };

            [Display(Name = "Georgia")]
            public readonly Country Georgia = new Country
            {
                Name = "Georgia",
                ISOAbbreviation = "GE",
            };

            [Display(Name = "Germany")]
            public readonly Country Germany = new Country
            {
                Name = "Germany",
                ISOAbbreviation = "DE",
            };

            [Display(Name = "Ghana")]
            public readonly Country Ghana = new Country
            {
                Name = "Ghana",
                ISOAbbreviation = "GH",
            };

            [Display(Name = "Gibraltar")]
            public readonly Country Gibraltar = new Country
            {
                Name = "Gibraltar",
                ISOAbbreviation = "GI",
            };

            [Display(Name = "Greece")]
            public readonly Country Greece = new Country
            {
                Name = "Greece",
                ISOAbbreviation = "GR",
            };

            [Display(Name = "Greenland")]
            public readonly Country Greenland = new Country
            {
                Name = "Greenland",
                ISOAbbreviation = "GL",
            };

            [Display(Name = "Grenada")]
            public readonly Country Grenada = new Country
            {
                Name = "Grenada",
                ISOAbbreviation = "GD",
            };

            [Display(Name = "Guadeloupe")]
            public readonly Country Guadeloupe = new Country
            {
                Name = "Guadeloupe",
                ISOAbbreviation = "GP",
            };

            [Display(Name = "Guam")]
            public readonly Country Guam = new Country
            {
                Name = "Guam",
                ISOAbbreviation = "GU",
            };

            [Display(Name = "Guatemala")]
            public readonly Country Guatemala = new Country
            {
                Name = "Guatemala",
                ISOAbbreviation = "GT",
            };

            [Display(Name = "Guinea")]
            public readonly Country Guinea = new Country
            {
                Name = "Guinea",
                ISOAbbreviation = "GN",
            };

            [Display(Name = "Guinea-Bissau")]
            public readonly Country GuineaBissau = new Country
            {
                Name = "Guinea-Bissau",
                ISOAbbreviation = "GW",
            };

            [Display(Name = "Guyana")]
            public readonly Country Guyana = new Country
            {
                Name = "Guyana",
                ISOAbbreviation = "GY",
            };

            [Display(Name = "Haiti")]
            public readonly Country Haiti = new Country
            {
                Name = "Haiti",
                ISOAbbreviation = "HT",
            };

            [Display(Name = "Honduras")]
            public readonly Country Honduras = new Country
            {
                Name = "Honduras",
                ISOAbbreviation = "HN",
            };

            [Display(Name = "Hong Kong")]
            public readonly Country HongKong = new Country
            {
                Name = "Hong Kong",
                ISOAbbreviation = "HK",
            };

            [Display(Name = "Hungary")]
            public readonly Country Hungary = new Country
            {
                Name = "Hungary",
                ISOAbbreviation = "HU",
            };

            [Display(Name = "Iceland")]
            public readonly Country Iceland = new Country
            {
                Name = "Iceland",
                ISOAbbreviation = "IS",
            };

            [Display(Name = "India")]
            public readonly Country India = new Country
            {
                Name = "India",
                ISOAbbreviation = "IN",
            };

            [Display(Name = "Indonesia")]
            public readonly Country Indonesia = new Country
            {
                Name = "Indonesia",
                ISOAbbreviation = "ID",
            };

            [Display(Name = "Iran")]
            public readonly Country Iran = new Country
            {
                Name = "Iran",
                ISOAbbreviation = "IR",
            };

            [Display(Name = "Iraq")]
            public readonly Country Iraq = new Country
            {
                Name = "Iraq",
                ISOAbbreviation = "IQ",
            };

            [Display(Name = "Ireland")]
            public readonly Country Ireland = new Country
            {
                Name = "Ireland",
                ISOAbbreviation = "IE",
            };

            [Display(Name = "Israel")]
            public readonly Country Israel = new Country
            {
                Name = "Israel",
                ISOAbbreviation = "IL",
            };

            [Display(Name = "Italy")]
            public readonly Country Italy = new Country
            {
                Name = "Italy",
                ISOAbbreviation = "IT",
            };

            [Display(Name = "Jamaica")]
            public readonly Country Jamaica = new Country
            {
                Name = "Jamaica",
                ISOAbbreviation = "JM",
            };

            [Display(Name = "Japan")]
            public readonly Country Japan = new Country
            {
                Name = "Japan",
                ISOAbbreviation = "JP",
            };

            [Display(Name = "Jordan")]
            public readonly Country Jordan = new Country
            {
                Name = "Jordan",
                ISOAbbreviation = "JO",
            };

            [Display(Name = "Kazakhstan")]
            public readonly Country Kazakhstan = new Country
            {
                Name = "Kazakhstan",
                ISOAbbreviation = "KZ",
            };

            [Display(Name = "Kenya")]
            public readonly Country Kenya = new Country
            {
                Name = "Kenya",
                ISOAbbreviation = "KE",
            };

            [Display(Name = "Kiribati")]
            public readonly Country Kiribati = new Country
            {
                Name = "Kiribati",
                ISOAbbreviation = "KI",
            };

            [Display(Name = "Kosovo")]
            public readonly Country Kosovo = new Country
            {
                Name = "Kosovo",
                ISOAbbreviation = "XK",
            };

            [Display(Name = "Kuwait")]
            public readonly Country Kuwait = new Country
            {
                Name = "Kuwait",
                ISOAbbreviation = "KW",
            };

            [Display(Name = "Kyrgyzstan")]
            public readonly Country Kyrgyzstan = new Country
            {
                Name = "Kyrgyzstan",
                ISOAbbreviation = "KG",
            };

            [Display(Name = "Laos")]
            public readonly Country Laos = new Country
            {
                Name = "Laos",
                ISOAbbreviation = "LA",
            };

            [Display(Name = "Latvia")]
            public readonly Country Latvia = new Country
            {
                Name = "Latvia",
                ISOAbbreviation = "LV",
            };

            [Display(Name = "Lebanon")]
            public readonly Country Lebanon = new Country
            {
                Name = "Lebanon",
                ISOAbbreviation = "LB",
            };

            [Display(Name = "Lesotho")]
            public readonly Country Lesotho = new Country
            {
                Name = "Lesotho",
                ISOAbbreviation = "LS",
            };

            [Display(Name = "Liberia")]
            public readonly Country Liberia = new Country
            {
                Name = "Liberia",
                ISOAbbreviation = "LR",
            };

            [Display(Name = "Libya")]
            public readonly Country Libya = new Country
            {
                Name = "Libya",
                ISOAbbreviation = "LY",
            };

            [Display(Name = "Liechtenstein")]
            public readonly Country Liechtenstein = new Country
            {
                Name = "Liechtenstein",
                ISOAbbreviation = "LI",
            };

            [Display(Name = "Lithuania")]
            public readonly Country Lithuania = new Country
            {
                Name = "Lithuania",
                ISOAbbreviation = "LT",
            };

            [Display(Name = "Luxembourg")]
            public readonly Country Luxembourg = new Country
            {
                Name = "Luxembourg",
                ISOAbbreviation = "LU",
            };

            [Display(Name = "Macau")]
            public readonly Country Macau = new Country
            {
                Name = "Macau",
                ISOAbbreviation = "MO",
            };

            [Display(Name = "Macedonia")]
            public readonly Country Macedonia = new Country
            {
                Name = "Macedonia",
                ISOAbbreviation = "MK",
            };

            [Display(Name = "Madagascar")]
            public readonly Country Madagascar = new Country
            {
                Name = "Madagascar",
                ISOAbbreviation = "MG",
            };

            [Display(Name = "Malawi")]
            public readonly Country Malawi = new Country
            {
                Name = "Malawi",
                ISOAbbreviation = "MW",
            };

            [Display(Name = "Malaysia")]
            public readonly Country Malaysia = new Country
            {
                Name = "Malaysia",
                ISOAbbreviation = "MY",
            };

            [Display(Name = "Maldives")]
            public readonly Country Maldives = new Country
            {
                Name = "Maldives",
                ISOAbbreviation = "MV",
            };

            [Display(Name = "Mali")]
            public readonly Country Mali = new Country
            {
                Name = "Mali",
                ISOAbbreviation = "ML",
            };

            [Display(Name = "Malta")]
            public readonly Country Malta = new Country
            {
                Name = "Malta",
                ISOAbbreviation = "MT",
            };

            [Display(Name = "Marshall Islands")]
            public readonly Country MarshallIslands = new Country
            {
                Name = "Marshall Islands",
                ISOAbbreviation = "MH",
            };

            [Display(Name = "Martinique")]
            public readonly Country Martinique = new Country
            {
                Name = "Martinique",
                ISOAbbreviation = "MQ",
            };

            [Display(Name = "Mauritania")]
            public readonly Country Mauritania = new Country
            {
                Name = "Mauritania",
                ISOAbbreviation = "MR",
            };

            [Display(Name = "Mauritius")]
            public readonly Country Mauritius = new Country
            {
                Name = "Mauritius",
                ISOAbbreviation = "MU",
            };

            [Display(Name = "Mayotte")]
            public readonly Country Mayotte = new Country
            {
                Name = "Mayotte",
                ISOAbbreviation = "YT",
            };

            [Display(Name = "Mexico")]
            public readonly Country Mexico = new Country
            {
                Name = "Mexico",
                ISOAbbreviation = "MX",
            };

            [Display(Name = "Moldova")]
            public readonly Country Moldova = new Country
            {
                Name = "Moldova",
                ISOAbbreviation = "MD",
            };

            [Display(Name = "Monaco")]
            public readonly Country Monaco = new Country
            {
                Name = "Monaco",
                ISOAbbreviation = "MC",
            };

            [Display(Name = "Mongolia")]
            public readonly Country Mongolia = new Country
            {
                Name = "Mongolia",
                ISOAbbreviation = "MN",
            };

            [Display(Name = "Montenegro")]
            public readonly Country Montenegro = new Country
            {
                Name = "Montenegro",
                ISOAbbreviation = "ME",
            };

            [Display(Name = "Montserrat")]
            public readonly Country Montserrat = new Country
            {
                Name = "Montserrat",
                ISOAbbreviation = "MS",
            };

            [Display(Name = "Morocco")]
            public readonly Country Morocco = new Country
            {
                Name = "Morocco",
                ISOAbbreviation = "MA",
            };

            [Display(Name = "Mozambique")]
            public readonly Country Mozambique = new Country
            {
                Name = "Mozambique",
                ISOAbbreviation = "MZ",
            };

            [Display(Name = "Namibia")]
            public readonly Country Namibia = new Country
            {
                Name = "Namibia",
                ISOAbbreviation = "NA",
            };

            [Display(Name = "Nauru")]
            public readonly Country Nauru = new Country
            {
                Name = "Nauru",
                ISOAbbreviation = "NR",
            };

            [Display(Name = "Nepal")]
            public readonly Country Nepal = new Country
            {
                Name = "Nepal",
                ISOAbbreviation = "NP",
            };

            [Display(Name = "Netherlands")]
            public readonly Country Netherlands = new Country
            {
                Name = "Netherlands",
                ISOAbbreviation = "NL",
            };

            [Display(Name = "Netherlands Antilles")]
            public readonly Country NetherlandsAntilles = new Country
            {
                Name = "Netherlands Antilles",
                ISOAbbreviation = "AN",
            };

            [Display(Name = "New Caledonia")]
            public readonly Country NewCaledonia = new Country
            {
                Name = "New Caledonia",
                ISOAbbreviation = "NC",
            };

            [Display(Name = "New Zealand")]
            public readonly Country NewZealand = new Country
            {
                Name = "New Zealand",
                ISOAbbreviation = "NZ",
            };

            [Display(Name = "Nicaragua")]
            public readonly Country Nicaragua = new Country
            {
                Name = "Nicaragua",
                ISOAbbreviation = "NI",
            };

            [Display(Name = "Niger")]
            public readonly Country Niger = new Country
            {
                Name = "Niger",
                ISOAbbreviation = "NE",
            };

            [Display(Name = "Nigeria")]
            public readonly Country Nigeria = new Country
            {
                Name = "Nigeria",
                ISOAbbreviation = "NG",
            };

            [Display(Name = "Niue")]
            public readonly Country Niue = new Country
            {
                Name = "Niue",
                ISOAbbreviation = "NU",
            };

            [Display(Name = "Norfolk Island")]
            public readonly Country NorfolkIsland = new Country
            {
                Name = "Norfolk Island",
                ISOAbbreviation = "NF",
            };

            [Display(Name = "North Korea")]
            public readonly Country NorthKorea = new Country
            {
                Name = "North Korea",
                ISOAbbreviation = "KP",
            };

            [Display(Name = "Northern Mariana Islands")]
            public readonly Country NorthernMarianaIslands = new Country
            {
                Name = "Northern Mariana Islands",
                ISOAbbreviation = "MP",
            };

            [Display(Name = "Norway")]
            public readonly Country Norway = new Country
            {
                Name = "Norway",
                ISOAbbreviation = "NO",
            };

            [Display(Name = "Oman")]
            public readonly Country Oman = new Country
            {
                Name = "Oman",
                ISOAbbreviation = "OM",
            };

            [Display(Name = "Pakistan")]
            public readonly Country Pakistan = new Country
            {
                Name = "Pakistan",
                ISOAbbreviation = "PK",
            };

            [Display(Name = "Palau")]
            public readonly Country Palau = new Country
            {
                Name = "Palau",
                ISOAbbreviation = "PW",
            };

            [Display(Name = "Palestine")]
            public readonly Country Palestine = new Country
            {
                Name = "Palestine",
                ISOAbbreviation = "PS",
            };

            [Display(Name = "Panama")]
            public readonly Country Panama = new Country
            {
                Name = "Panama",
                ISOAbbreviation = "PA",
            };

            [Display(Name = "Papua New Guinea")]
            public readonly Country PapuaNewGuinea = new Country
            {
                Name = "Papua New Guinea",
                ISOAbbreviation = "PG",
            };

            [Display(Name = "Paraguay")]
            public readonly Country Paraguay = new Country
            {
                Name = "Paraguay",
                ISOAbbreviation = "PY",
            };

            [Display(Name = "Peru")]
            public readonly Country Peru = new Country
            {
                Name = "Peru",
                ISOAbbreviation = "PE",
            };

            [Display(Name = "Philippines")]
            public readonly Country Philippines = new Country
            {
                Name = "Philippines",
                ISOAbbreviation = "PH",
            };

            [Display(Name = "Poland")]
            public readonly Country Poland = new Country
            {
                Name = "Poland",
                ISOAbbreviation = "PL",
            };

            [Display(Name = "Portugal")]
            public readonly Country Portugal = new Country
            {
                Name = "Portugal",
                ISOAbbreviation = "PT",
            };

            [Display(Name = "Puerto Rico")]
            public readonly Country PuertoRico = new Country
            {
                Name = "Puerto Rico",
                ISOAbbreviation = "PR",
            };

            [Display(Name = "Qatar")]
            public readonly Country Qatar = new Country
            {
                Name = "Qatar",
                ISOAbbreviation = "QA",
            };

            [Display(Name = "Republic of the Congo")]
            public readonly Country RepublicOfTheCongo = new Country
            {
                Name = "Republic of the Congo",
                ISOAbbreviation = "CG",
            };

            [Display(Name = "Réunion")]
            public readonly Country Réunion = new Country
            {
                Name = "Réunion",
                ISOAbbreviation = "RE",
            };

            [Display(Name = "Romania")]
            public readonly Country Romania = new Country
            {
                Name = "Romania",
                ISOAbbreviation = "RO",
            };

            [Display(Name = "Russia")]
            public readonly Country Russia = new Country
            {
                Name = "Russia",
                ISOAbbreviation = "RU",
            };

            [Display(Name = "Rwanda")]
            public readonly Country Rwanda = new Country
            {
                Name = "Rwanda",
                ISOAbbreviation = "RW",
            };

            [Display(Name = "Saint Barthélemy")]
            public readonly Country SaintBarthélemy = new Country
            {
                Name = "Saint Barthélemy",
                ISOAbbreviation = "BL",
            };

            [Display(Name = "Saint Helena")]
            public readonly Country SaintHelena = new Country
            {
                Name = "Saint Helena",
                ISOAbbreviation = "SH",
            };

            [Display(Name = "Saint Kitts and Nevis")]
            public readonly Country SaintKittsAndNevis = new Country
            {
                Name = "Saint Kitts and Nevis",
                ISOAbbreviation = "KN",
            };

            [Display(Name = "Saint Martin")]
            public readonly Country SaintMartin = new Country
            {
                Name = "Saint Martin",
                ISOAbbreviation = "MF",
            };

            [Display(Name = "Saint Pierre and Miquelon")]
            public readonly Country SaintPierreAndMiquelon = new Country
            {
                Name = "Saint Pierre and Miquelon",
                ISOAbbreviation = "PM",
            };

            [Display(Name = "Saint Vincent and the Grenadines")]
            public readonly Country SaintVincentAndTheGrenadines = new Country
            {
                Name = "Saint Vincent and the Grenadines",
                ISOAbbreviation = "VC",
            };

            [Display(Name = "Samoa")]
            public readonly Country Samoa = new Country
            {
                Name = "Samoa",
                ISOAbbreviation = "WS",
            };

            [Display(Name = "San Marino")]
            public readonly Country SanMarino = new Country
            {
                Name = "San Marino",
                ISOAbbreviation = "SM",
            };

            [Display(Name = "São Tomé and Príncipe")]
            public readonly Country SãoToméAndPríncipe = new Country
            {
                Name = "São Tomé and Príncipe",
                ISOAbbreviation = "ST",
            };

            [Display(Name = "Saudi Arabia")]
            public readonly Country SaudiArabia = new Country
            {
                Name = "Saudi Arabia",
                ISOAbbreviation = "SA",
            };

            [Display(Name = "Senegal")]
            public readonly Country Senegal = new Country
            {
                Name = "Senegal",
                ISOAbbreviation = "SN",
            };

            [Display(Name = "Serbia")]
            public readonly Country Serbia = new Country
            {
                Name = "Serbia",
                ISOAbbreviation = "RS",
            };

            [Display(Name = "Seychelles")]
            public readonly Country Seychelles = new Country
            {
                Name = "Seychelles",
                ISOAbbreviation = "SC",
            };

            [Display(Name = "Sierra Leone")]
            public readonly Country SierraLeone = new Country
            {
                Name = "Sierra Leone",
                ISOAbbreviation = "SL",
            };

            [Display(Name = "Singapore")]
            public readonly Country Singapore = new Country
            {
                Name = "Singapore",
                ISOAbbreviation = "SG",
            };

            [Display(Name = "Slovakia")]
            public readonly Country Slovakia = new Country
            {
                Name = "Slovakia",
                ISOAbbreviation = "SK",
            };

            [Display(Name = "Slovenia")]
            public readonly Country Slovenia = new Country
            {
                Name = "Slovenia",
                ISOAbbreviation = "SI",
            };

            [Display(Name = "Solomon Islands")]
            public readonly Country SolomonIslands = new Country
            {
                Name = "Solomon Islands",
                ISOAbbreviation = "SB",
            };

            [Display(Name = "Somalia")]
            public readonly Country Somalia = new Country
            {
                Name = "Somalia",
                ISOAbbreviation = "SO",
            };

            [Display(Name = "South Africa")]
            public readonly Country SouthAfrica = new Country
            {
                Name = "South Africa",
                ISOAbbreviation = "ZA",
            };

            [Display(Name = "South Korea")]
            public readonly Country SouthKorea = new Country
            {
                Name = "South Korea",
                ISOAbbreviation = "KR",
            };

            [Display(Name = "Spain")]
            public readonly Country Spain = new Country
            {
                Name = "Spain",
                ISOAbbreviation = "ES",
            };

            [Display(Name = "Sri Lanka")]
            public readonly Country SriLanka = new Country
            {
                Name = "Sri Lanka",
                ISOAbbreviation = "LK",
            };

            [Display(Name = "St. Lucia")]
            public readonly Country StLucia = new Country
            {
                Name = "St. Lucia",
                ISOAbbreviation = "LC",
            };

            [Display(Name = "Sudan")]
            public readonly Country Sudan = new Country
            {
                Name = "Sudan",
                ISOAbbreviation = "SD",
            };

            [Display(Name = "Suriname")]
            public readonly Country Suriname = new Country
            {
                Name = "Suriname",
                ISOAbbreviation = "SR",
            };

            [Display(Name = "Swaziland")]
            public readonly Country Swaziland = new Country
            {
                Name = "Swaziland",
                ISOAbbreviation = "SZ",
            };

            [Display(Name = "Sweden")]
            public readonly Country Sweden = new Country
            {
                Name = "Sweden",
                ISOAbbreviation = "SE",
            };

            [Display(Name = "Switzerland")]
            public readonly Country Switzerland = new Country
            {
                Name = "Switzerland",
                ISOAbbreviation = "CH",
            };

            [Display(Name = "Syria")]
            public readonly Country Syria = new Country
            {
                Name = "Syria",
                ISOAbbreviation = "SY",
            };

            [Display(Name = "Taiwan")]
            public readonly Country Taiwan = new Country
            {
                Name = "Taiwan",
                ISOAbbreviation = "TW",
            };

            [Display(Name = "Tajikistan")]
            public readonly Country Tajikistan = new Country
            {
                Name = "Tajikistan",
                ISOAbbreviation = "TJ",
            };

            [Display(Name = "Tanzania")]
            public readonly Country Tanzania = new Country
            {
                Name = "Tanzania",
                ISOAbbreviation = "TZ",
            };

            [Display(Name = "Thailand")]
            public readonly Country Thailand = new Country
            {
                Name = "Thailand",
                ISOAbbreviation = "TH",
            };

            [Display(Name = "The Bahamas")]
            public readonly Country TheBahamas = new Country
            {
                Name = "The Bahamas",
                ISOAbbreviation = "BS",
            };

            [Display(Name = "The Gambia")]
            public readonly Country TheGambia = new Country
            {
                Name = "The Gambia",
                ISOAbbreviation = "GM",
            };

            [Display(Name = "Timor-Leste")]
            public readonly Country TimorLeste = new Country
            {
                Name = "Timor-Leste",
                ISOAbbreviation = "TL",
            };

            [Display(Name = "Togo")]
            public readonly Country Togo = new Country
            {
                Name = "Togo",
                ISOAbbreviation = "TG",
            };

            [Display(Name = "Tokelau")]
            public readonly Country Tokelau = new Country
            {
                Name = "Tokelau",
                ISOAbbreviation = "TK",
            };

            [Display(Name = "Tonga")]
            public readonly Country Tonga = new Country
            {
                Name = "Tonga",
                ISOAbbreviation = "TO",
            };

            [Display(Name = "Trinidad and Tobago")]
            public readonly Country TrinidadAndTobago = new Country
            {
                Name = "Trinidad and Tobago",
                ISOAbbreviation = "TT",
            };

            [Display(Name = "Tunisia")]
            public readonly Country Tunisia = new Country
            {
                Name = "Tunisia",
                ISOAbbreviation = "TN",
            };

            [Display(Name = "Turkey")]
            public readonly Country Turkey = new Country
            {
                Name = "Turkey",
                ISOAbbreviation = "TR",
            };

            [Display(Name = "Turkmenistan")]
            public readonly Country Turkmenistan = new Country
            {
                Name = "Turkmenistan",
                ISOAbbreviation = "TM",
            };

            [Display(Name = "Turks and Caicos Islands")]
            public readonly Country TurksAndCaicosIslands = new Country
            {
                Name = "Turks and Caicos Islands",
                ISOAbbreviation = "TC",
            };

            [Display(Name = "Tuvalu")]
            public readonly Country Tuvalu = new Country
            {
                Name = "Tuvalu",
                ISOAbbreviation = "TV",
            };

            [Display(Name = "Uganda")]
            public readonly Country Uganda = new Country
            {
                Name = "Uganda",
                ISOAbbreviation = "UG",
            };

            [Display(Name = "Ukraine")]
            public readonly Country Ukraine = new Country
            {
                Name = "Ukraine",
                ISOAbbreviation = "UA",
            };

            [Display(Name = "United Arab Emirates")]
            public readonly Country UnitedArabEmirates = new Country
            {
                Name = "United Arab Emirates",
                ISOAbbreviation = "AE",
            };

            [Display(Name = "United Kingdom")]
            public readonly Country UnitedKingdom = new Country
            {
                Name = "United Kingdom",
                ISOAbbreviation = "GB",
            };

            [Display(Name = "United States")]
            public readonly Country UnitedStates = new Country
            {
                Name = "United States",
                ISOAbbreviation = "US",
            };

            [Display(Name = "Uruguay")]
            public readonly Country Uruguay = new Country
            {
                Name = "Uruguay",
                ISOAbbreviation = "UY",
            };

            [Display(Name = "US Virgin Islands")]
            public readonly Country USVirginIslands = new Country
            {
                Name = "US Virgin Islands",
                ISOAbbreviation = "VI",
            };

            [Display(Name = "Uzbekistan")]
            public readonly Country Uzbekistan = new Country
            {
                Name = "Uzbekistan",
                ISOAbbreviation = "UZ",
            };

            [Display(Name = "Vanuatu")]
            public readonly Country Vanuatu = new Country
            {
                Name = "Vanuatu",
                ISOAbbreviation = "VU",
            };

            [Display(Name = "Vatican City")]
            public readonly Country VaticanCity = new Country
            {
                Name = "Vatican City",
                ISOAbbreviation = "VA",
            };

            [Display(Name = "Venezuela")]
            public readonly Country Venezuela = new Country
            {
                Name = "Venezuela",
                ISOAbbreviation = "VE",
            };

            [Display(Name = "Vietnam")]
            public readonly Country Vietnam = new Country
            {
                Name = "Vietnam",
                ISOAbbreviation = "VN",
            };

            [Display(Name = "Wallis and Futuna")]
            public readonly Country WallisAndFutuna = new Country
            {
                Name = "Wallis and Futuna",
                ISOAbbreviation = "WF",
            };

            [Display(Name = "Yemen")]
            public readonly Country Yemen = new Country
            {
                Name = "Yemen",
                ISOAbbreviation = "YE",
            };

            [Display(Name = "Zambia")]
            public readonly Country Zambia = new Country
            {
                Name = "Zambia",
                ISOAbbreviation = "ZM",
            };

            [Display(Name = "Zimbabwe")]
            public readonly Country Zimbabwe = new Country
            {
                Name = "Zimbabwe",
                ISOAbbreviation = "ZW",
            };
        }
    }
}