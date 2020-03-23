using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

namespace NeoSmart.Geographical
{
    public static partial class WellKnown
    {
        public static CountryFactory Countries = new CountryFactory();
    }

    public class CountryFactory : WellKnown<Country>
    {
        protected override IEnumerable<Expression<Func<Country, string>>> IndexExpressions =>
            new Expression<Func<Country, string>>[]
            {
                country => country.Name,
                country => country.Abbreviation,
            };

        [Display(Name = "Afghanistan")]
        public Country Afghanistan => new Country
        (
            "Afghanistan",
            isoAbbreviation: "AF"
        );

        [Display(Name = "Albania")]
        public Country Albania => new Country
        (
            "Albania",
            isoAbbreviation: "AL"
        );

        [Display(Name = "Algeria")]
        public Country Algeria => new Country
        (
            "Algeria",
            isoAbbreviation: "DZ"
        );

        [Display(Name = "American Samoa")]
        public Country AmericanSamoa => new Country
        (
            "American Samoa",
            isoAbbreviation: "AS"
        );

        [Display(Name = "Andorra")]
        public Country Andorra => new Country
        (
            "Andorra",
            isoAbbreviation: "AD"
        );

        [Display(Name = "Angola")]
        public Country Angola => new Country
        (
            "Angola",
            isoAbbreviation: "AO"
        );

        [Display(Name = "Anguilla")]
        public Country Anguilla => new Country
        (
            "Anguilla",
            isoAbbreviation: "AI"
        );

        [Display(Name = "Antigua")]
        public Country Antigua => new Country
        (
            "Antigua",
            isoAbbreviation: "AG"
        );

        [Display(Name = "Argentina")]
        public Country Argentina => new Country
        (
            "Argentina",
            isoAbbreviation: "AR"
        );

        [Display(Name = "Armenia")]
        public Country Armenia => new Country
        (
            "Armenia",
            isoAbbreviation: "AM"
        );

        [Display(Name = "Aruba")]
        public Country Aruba => new Country
        (
            "Aruba",
            isoAbbreviation: "AW"
        );

        [Display(Name = "Australia")]
        public Country Australia => new Country
        (
            "Australia",
            isoAbbreviation: "AU"
        );

        [Display(Name = "Austria")]
        public Country Austria => new Country
        (
            "Austria",
            isoAbbreviation: "AT"
        );

        [Display(Name = "Azerbaijan")]
        public Country Azerbaijan => new Country
        (
            "Azerbaijan",
            isoAbbreviation: "AZ"
        );

        [Display(Name = "Bahrain")]
        public Country Bahrain => new Country
        (
            "Bahrain",
            isoAbbreviation: "BH"
        );

        [Display(Name = "Bangladesh")]
        public Country Bangladesh => new Country
        (
            "Bangladesh",
            isoAbbreviation: "BD"
        );

        [Display(Name = "Barbados")]
        public Country Barbados => new Country
        (
            "Barbados",
            isoAbbreviation: "BB"
        );

        [Display(Name = "Belarus")]
        public Country Belarus => new Country
        (
            "Belarus",
            isoAbbreviation: "BY"
        );

        [Display(Name = "Belgium")]
        public Country Belgium => new Country
        (
            "Belgium",
            isoAbbreviation: "BE"
        );

        [Display(Name = "Belize")]
        public Country Belize => new Country
        (
            "Belize",
            isoAbbreviation: "BZ"
        );

        [Display(Name = "Benin")]
        public Country Benin => new Country
        (
            "Benin",
            isoAbbreviation: "BJ"
        );

        [Display(Name = "Bermuda")]
        public Country Bermuda => new Country
        (
            "Bermuda",
            isoAbbreviation: "BM"
        );

        [Display(Name = "Bhutan")]
        public Country Bhutan => new Country
        (
            "Bhutan",
            isoAbbreviation: "BT"
        );

        [Display(Name = "Bolivia")]
        public Country Bolivia => new Country
        (
            "Bolivia",
            isoAbbreviation: "BO"
        );

        [Display(Name = "Bosnia and Herzegovina")]
        public Country BosniaAndHerzegovina => new Country
        (
            "Bosnia and Herzegovina",
            isoAbbreviation: "BA"
        );

        [Display(Name = "Botswana")]
        public Country Botswana => new Country
        (
            "Botswana",
            isoAbbreviation: "BW"
        );

        [Display(Name = "Brazil")]
        public Country Brazil => new Country
        (
            "Brazil",
            isoAbbreviation: "BR"
        );

        [Display(Name = "British Indian Ocean Territory")]
        public Country BritishIndianOceanTerritory => new Country
        (
            "British Indian Ocean Territory",
            isoAbbreviation: "IO"
        );

        [Display(Name = "British Virgin Islands")]
        public Country BritishVirginIslands => new Country
        (
            "British Virgin Islands",
            isoAbbreviation: "VG"
        );

        [Display(Name = "Brunei")]
        public Country Brunei => new Country
        (
            "Brunei",
            isoAbbreviation: "BN"
        );

        [Display(Name = "Bulgaria")]
        public Country Bulgaria => new Country
        (
            "Bulgaria",
            isoAbbreviation: "BG"
        );

        [Display(Name = "Burkina Faso")]
        public Country BurkinaFaso => new Country
        (
            "Burkina Faso",
            isoAbbreviation: "BF"
        );

        [Display(Name = "Burma Myanmar")]
        public Country BurmaMyanmar => new Country
        (
            "Burma Myanmar",
            isoAbbreviation: "MM"
        );

        [Display(Name = "Burundi")]
        public Country Burundi => new Country
        (
            "Burundi",
            isoAbbreviation: "BI"
        );

        [Display(Name = "Cambodia")]
        public Country Cambodia => new Country
        (
            "Cambodia",
            isoAbbreviation: "KH"
        );

        [Display(Name = "Cameroon")]
        public Country Cameroon => new Country
        (
            "Cameroon",
            isoAbbreviation: "CM"
        );

        [Display(Name = "Canada")]
        public Country Canada => new Country
        (
            "Canada",
            isoAbbreviation: "CA"
        );

        [Display(Name = "Cape Verde")]
        public Country CapeVerde => new Country
        (
            "Cape Verde",
            isoAbbreviation: "CV"
        );

        [Display(Name = "Cayman Islands")]
        public Country CaymanIslands => new Country
        (
            "Cayman Islands",
            isoAbbreviation: "KY"
        );

        [Display(Name = "Central African Republic")]
        public Country CentralAfricanRepublic => new Country
        (
            "Central African Republic",
            isoAbbreviation: "CF"
        );

        [Display(Name = "Chad")]
        public Country Chad => new Country
        (
            "Chad",
            isoAbbreviation: "TD"
        );

        [Display(Name = "Chile")]
        public Country Chile => new Country
        (
            "Chile",
            isoAbbreviation: "CL"
        );

        [Display(Name = "China")]
        public Country China => new Country
        (
            "China",
            isoAbbreviation: "CN"
        );

        [Display(Name = "Colombia")]
        public Country Colombia => new Country
        (
            "Colombia",
            isoAbbreviation: "CO"
        );

        [Display(Name = "Comoros")]
        public Country Comoros => new Country
        (
            "Comoros",
            isoAbbreviation: "KM"
        );

        [Display(Name = "Cook Islands")]
        public Country CookIslands => new Country
        (
            "Cook Islands",
            isoAbbreviation: "CK"
        );

        [Display(Name = "Costa Rica")]
        public Country CostaRica => new Country
        (
            "Costa Rica",
            isoAbbreviation: "CR"
        );

        [Display(Name = "Côte d'Ivoire")]
        public Country CôteDIvoire => new Country
        (
            "Côte d'Ivoire",
            isoAbbreviation: "CI"
        );

        [Display(Name = "Croatia")]
        public Country Croatia => new Country
        (
            "Croatia",
            isoAbbreviation: "HR"
        );

        [Display(Name = "Cuba")]
        public Country Cuba => new Country
        (
            "Cuba",
            isoAbbreviation: "CU"
        );

        [Display(Name = "Cyprus")]
        public Country Cyprus => new Country
        (
            "Cyprus",
            isoAbbreviation: "CY"
        );

        [Display(Name = "Czech Republic")]
        public Country CzechRepublic => new Country
        (
            "Czech Republic",
            isoAbbreviation: "CZ"
        );

        [Display(Name = "Democratic Republic of Congo")]
        public Country DemocraticRepublicOfCongo => new Country
        (
            "Democratic Republic of Congo",
            isoAbbreviation: "CD"
        );

        [Display(Name = "Denmark")]
        public Country Denmark => new Country
        (
            "Denmark",
            isoAbbreviation: "DK"
        );

        [Display(Name = "Djibouti")]
        public Country Djibouti => new Country
        (
            "Djibouti",
            isoAbbreviation: "DJ"
        );

        [Display(Name = "Dominica")]
        public Country Dominica => new Country
        (
            "Dominica",
            isoAbbreviation: "DM"
        );

        [Display(Name = "Dominican Republic")]
        public Country DominicanRepublic => new Country
        (
            "Dominican Republic",
            isoAbbreviation: "DO"
        );

        [Display(Name = "Ecuador")]
        public Country Ecuador => new Country
        (
            "Ecuador",
            isoAbbreviation: "EC"
        );

        [Display(Name = "Egypt")]
        public Country Egypt => new Country
        (
            "Egypt",
            isoAbbreviation: "EG"
        );

        [Display(Name = "El Salvador")]
        public Country ElSalvador => new Country
        (
            "El Salvador",
            isoAbbreviation: "SV"
        );

        [Display(Name = "Equatorial Guinea")]
        public Country EquatorialGuinea => new Country
        (
            "Equatorial Guinea",
            isoAbbreviation: "GQ"
        );

        [Display(Name = "Eritrea")]
        public Country Eritrea => new Country
        (
            "Eritrea",
            isoAbbreviation: "ER"
        );

        [Display(Name = "Estonia")]
        public Country Estonia => new Country
        (
            "Estonia",
            isoAbbreviation: "EE"
        );

        [Display(Name = "Ethiopia")]
        public Country Ethiopia => new Country
        (
            "Ethiopia",
            isoAbbreviation: "ET"
        );

        [Display(Name = "Falkland Islands")]
        public Country FalklandIslands => new Country
        (
            "Falkland Islands",
            isoAbbreviation: "FK"
        );

        [Display(Name = "Faroe Islands")]
        public Country FaroeIslands => new Country
        (
            "Faroe Islands",
            isoAbbreviation: "FO"
        );

        [Display(Name = "Federated States of Micronesia")]
        public Country FederatedStatesOfMicronesia => new Country
        (
            "Federated States of Micronesia",
            isoAbbreviation: "FM"
        );

        [Display(Name = "Fiji")]
        public Country Fiji => new Country
        (
            "Fiji",
            isoAbbreviation: "FJ"
        );

        [Display(Name = "Finland")]
        public Country Finland => new Country
        (
            "Finland",
            isoAbbreviation: "FI"
        );

        [Display(Name = "France")]
        public Country France => new Country
        (
            "France",
            isoAbbreviation: "FR"
        );

        [Display(Name = "French Guiana")]
        public Country FrenchGuiana => new Country
        (
            "French Guiana",
            isoAbbreviation: "GF"
        );

        [Display(Name = "French Polynesia")]
        public Country FrenchPolynesia => new Country
        (
            "French Polynesia",
            isoAbbreviation: "PF"
        );

        [Display(Name = "Gabon")]
        public Country Gabon => new Country
        (
            "Gabon",
            isoAbbreviation: "GA"
        );

        [Display(Name = "Georgia")]
        public Country Georgia => new Country
        (
            "Georgia",
            isoAbbreviation: "GE"
        );

        [Display(Name = "Germany")]
        public Country Germany => new Country
        (
            "Germany",
            isoAbbreviation: "DE"
        );

        [Display(Name = "Ghana")]
        public Country Ghana => new Country
        (
            "Ghana",
            isoAbbreviation: "GH"
        );

        [Display(Name = "Gibraltar")]
        public Country Gibraltar => new Country
        (
            "Gibraltar",
            isoAbbreviation: "GI"
        );

        [Display(Name = "Greece")]
        public Country Greece => new Country
        (
            "Greece",
            isoAbbreviation: "GR"
        );

        [Display(Name = "Greenland")]
        public Country Greenland => new Country
        (
            "Greenland",
            isoAbbreviation: "GL"
        );

        [Display(Name = "Grenada")]
        public Country Grenada => new Country
        (
            "Grenada",
            isoAbbreviation: "GD"
        );

        [Display(Name = "Guadeloupe")]
        public Country Guadeloupe => new Country
        (
            "Guadeloupe",
            isoAbbreviation: "GP"
        );

        [Display(Name = "Guam")]
        public Country Guam => new Country
        (
            "Guam",
            isoAbbreviation: "GU"
        );

        [Display(Name = "Guatemala")]
        public Country Guatemala => new Country
        (
            "Guatemala",
            isoAbbreviation: "GT"
        );

        [Display(Name = "Guinea")]
        public Country Guinea => new Country
        (
            "Guinea",
            isoAbbreviation: "GN"
        );

        [Display(Name = "Guinea-Bissau")]
        public Country GuineaBissau => new Country
        (
            "Guinea-Bissau",
            isoAbbreviation: "GW"
        );

        [Display(Name = "Guyana")]
        public Country Guyana => new Country
        (
            "Guyana",
            isoAbbreviation: "GY"
        );

        [Display(Name = "Haiti")]
        public Country Haiti => new Country
        (
            "Haiti",
            isoAbbreviation: "HT"
        );

        [Display(Name = "Honduras")]
        public Country Honduras => new Country
        (
            "Honduras",
            isoAbbreviation: "HN"
        );

        [Display(Name = "Hong Kong")]
        public Country HongKong => new Country
        (
            "Hong Kong",
            isoAbbreviation: "HK"
        );

        [Display(Name = "Hungary")]
        public Country Hungary => new Country
        (
            "Hungary",
            isoAbbreviation: "HU"
        );

        [Display(Name = "Iceland")]
        public Country Iceland => new Country
        (
            "Iceland",
            isoAbbreviation: "IS"
        );

        [Display(Name = "India")]
        public Country India => new Country
        (
            "India",
            isoAbbreviation: "IN"
        );

        [Display(Name = "Indonesia")]
        public Country Indonesia => new Country
        (
            "Indonesia",
            isoAbbreviation: "ID"
        );

        [Display(Name = "Iran")]
        public Country Iran => new Country
        (
            "Iran",
            isoAbbreviation: "IR"
        );

        [Display(Name = "Iraq")]
        public Country Iraq => new Country
        (
            "Iraq",
            isoAbbreviation: "IQ"
        );

        [Display(Name = "Ireland")]
        public Country Ireland => new Country
        (
            "Ireland",
            isoAbbreviation: "IE"
        );

        [Display(Name = "Israel")]
        public Country Israel => new Country
        (
            "Israel",
            isoAbbreviation: "IL"
        );

        [Display(Name = "Italy")]
        public Country Italy => new Country
        (
            "Italy",
            isoAbbreviation: "IT"
        );

        [Display(Name = "Jamaica")]
        public Country Jamaica => new Country
        (
            "Jamaica",
            isoAbbreviation: "JM"
        );

        [Display(Name = "Japan")]
        public Country Japan => new Country
        (
            "Japan",
            isoAbbreviation: "JP"
        );

        [Display(Name = "Jordan")]
        public Country Jordan => new Country
        (
            "Jordan",
            isoAbbreviation: "JO"
        );

        [Display(Name = "Kazakhstan")]
        public Country Kazakhstan => new Country
        (
            "Kazakhstan",
            isoAbbreviation: "KZ"
        );

        [Display(Name = "Kenya")]
        public Country Kenya => new Country
        (
            "Kenya",
            isoAbbreviation: "KE"
        );

        [Display(Name = "Kiribati")]
        public Country Kiribati => new Country
        (
            "Kiribati",
            isoAbbreviation: "KI"
        );

        [Display(Name = "Kosovo")]
        public Country Kosovo => new Country
        (
            "Kosovo",
            isoAbbreviation: "XK"
        );

        [Display(Name = "Kuwait")]
        public Country Kuwait => new Country
        (
            "Kuwait",
            isoAbbreviation: "KW"
        );

        [Display(Name = "Kyrgyzstan")]
        public Country Kyrgyzstan => new Country
        (
            "Kyrgyzstan",
            isoAbbreviation: "KG"
        );

        [Display(Name = "Laos")]
        public Country Laos => new Country
        (
            "Laos",
            isoAbbreviation: "LA"
        );

        [Display(Name = "Latvia")]
        public Country Latvia => new Country
        (
            "Latvia",
            isoAbbreviation: "LV"
        );

        [Display(Name = "Lebanon")]
        public Country Lebanon => new Country
        (
            "Lebanon",
            isoAbbreviation: "LB"
        );

        [Display(Name = "Lesotho")]
        public Country Lesotho => new Country
        (
            "Lesotho",
            isoAbbreviation: "LS"
        );

        [Display(Name = "Liberia")]
        public Country Liberia => new Country
        (
            "Liberia",
            isoAbbreviation: "LR"
        );

        [Display(Name = "Libya")]
        public Country Libya => new Country
        (
            "Libya",
            isoAbbreviation: "LY"
        );

        [Display(Name = "Liechtenstein")]
        public Country Liechtenstein => new Country
        (
            "Liechtenstein",
            isoAbbreviation: "LI"
        );

        [Display(Name = "Lithuania")]
        public Country Lithuania => new Country
        (
            "Lithuania",
            isoAbbreviation: "LT"
        );

        [Display(Name = "Luxembourg")]
        public Country Luxembourg => new Country
        (
            "Luxembourg",
            isoAbbreviation: "LU"
        );

        [Display(Name = "Macau")]
        public Country Macau => new Country
        (
            "Macau",
            isoAbbreviation: "MO"
        );

        [Display(Name = "Macedonia")]
        public Country Macedonia => new Country
        (
            "Macedonia",
            isoAbbreviation: "MK"
        );

        [Display(Name = "Madagascar")]
        public Country Madagascar => new Country
        (
            "Madagascar",
            isoAbbreviation: "MG"
        );

        [Display(Name = "Malawi")]
        public Country Malawi => new Country
        (
            "Malawi",
            isoAbbreviation: "MW"
        );

        [Display(Name = "Malaysia")]
        public Country Malaysia => new Country
        (
            "Malaysia",
            isoAbbreviation: "MY"
        );

        [Display(Name = "Maldives")]
        public Country Maldives => new Country
        (
            "Maldives",
            isoAbbreviation: "MV"
        );

        [Display(Name = "Mali")]
        public Country Mali => new Country
        (
            "Mali",
            isoAbbreviation: "ML"
        );

        [Display(Name = "Malta")]
        public Country Malta => new Country
        (
            "Malta",
            isoAbbreviation: "MT"
        );

        [Display(Name = "Marshall Islands")]
        public Country MarshallIslands => new Country
        (
            "Marshall Islands",
            isoAbbreviation: "MH"
        );

        [Display(Name = "Martinique")]
        public Country Martinique => new Country
        (
            "Martinique",
            isoAbbreviation: "MQ"
        );

        [Display(Name = "Mauritania")]
        public Country Mauritania => new Country
        (
            "Mauritania",
            isoAbbreviation: "MR"
        );

        [Display(Name = "Mauritius")]
        public Country Mauritius => new Country
        (
            "Mauritius",
            isoAbbreviation: "MU"
        );

        [Display(Name = "Mayotte")]
        public Country Mayotte => new Country
        (
            "Mayotte",
            isoAbbreviation: "YT"
        );

        [Display(Name = "Mexico")]
        public Country Mexico => new Country
        (
            "Mexico",
            isoAbbreviation: "MX"
        );

        [Display(Name = "Moldova")]
        public Country Moldova => new Country
        (
            "Moldova",
            isoAbbreviation: "MD"
        );

        [Display(Name = "Monaco")]
        public Country Monaco => new Country
        (
            "Monaco",
            isoAbbreviation: "MC"
        );

        [Display(Name = "Mongolia")]
        public Country Mongolia => new Country
        (
            "Mongolia",
            isoAbbreviation: "MN"
        );

        [Display(Name = "Montenegro")]
        public Country Montenegro => new Country
        (
            "Montenegro",
            isoAbbreviation: "ME"
        );

        [Display(Name = "Montserrat")]
        public Country Montserrat => new Country
        (
            "Montserrat",
            isoAbbreviation: "MS"
        );

        [Display(Name = "Morocco")]
        public Country Morocco => new Country
        (
            "Morocco",
            isoAbbreviation: "MA"
        );

        [Display(Name = "Mozambique")]
        public Country Mozambique => new Country
        (
            "Mozambique",
            isoAbbreviation: "MZ"
        );

        [Display(Name = "Namibia")]
        public Country Namibia => new Country
        (
            "Namibia",
            isoAbbreviation: "NA"
        );

        [Display(Name = "Nauru")]
        public Country Nauru => new Country
        (
            "Nauru",
            isoAbbreviation: "NR"
        );

        [Display(Name = "Nepal")]
        public Country Nepal => new Country
        (
            "Nepal",
            isoAbbreviation: "NP"
        );

        [Display(Name = "Netherlands")]
        public Country Netherlands => new Country
        (
            "Netherlands",
            isoAbbreviation: "NL"
        );

        [Display(Name = "Netherlands Antilles")]
        public Country NetherlandsAntilles => new Country
        (
            "Netherlands Antilles",
            isoAbbreviation: "AN"
        );

        [Display(Name = "New Caledonia")]
        public Country NewCaledonia => new Country
        (
            "New Caledonia",
            isoAbbreviation: "NC"
        );

        [Display(Name = "New Zealand")]
        public Country NewZealand => new Country
        (
            "New Zealand",
            isoAbbreviation: "NZ"
        );

        [Display(Name = "Nicaragua")]
        public Country Nicaragua => new Country
        (
            "Nicaragua",
            isoAbbreviation: "NI"
        );

        [Display(Name = "Niger")]
        public Country Niger => new Country
        (
            "Niger",
            isoAbbreviation: "NE"
        );

        [Display(Name = "Nigeria")]
        public Country Nigeria => new Country
        (
            "Nigeria",
            isoAbbreviation: "NG"
        );

        [Display(Name = "Niue")]
        public Country Niue => new Country
        (
            "Niue",
            isoAbbreviation: "NU"
        );

        [Display(Name = "Norfolk Island")]
        public Country NorfolkIsland => new Country
        (
            "Norfolk Island",
            isoAbbreviation: "NF"
        );

        [Display(Name = "North Korea")]
        public Country NorthKorea => new Country
        (
            "North Korea",
            isoAbbreviation: "KP"
        );

        [Display(Name = "Northern Mariana Islands")]
        public Country NorthernMarianaIslands => new Country
        (
            "Northern Mariana Islands",
            isoAbbreviation: "MP"
        );

        [Display(Name = "Norway")]
        public Country Norway => new Country
        (
            "Norway",
            isoAbbreviation: "NO"
        );

        [Display(Name = "Oman")]
        public Country Oman => new Country
        (
            "Oman",
            isoAbbreviation: "OM"
        );

        [Display(Name = "Pakistan")]
        public Country Pakistan => new Country
        (
            "Pakistan",
            isoAbbreviation: "PK"
        );

        [Display(Name = "Palau")]
        public Country Palau => new Country
        (
            "Palau",
            isoAbbreviation: "PW"
        );

        [Display(Name = "Palestine")]
        public Country Palestine => new Country
        (
            "Palestine",
            isoAbbreviation: "PS"
        );

        [Display(Name = "Panama")]
        public Country Panama => new Country
        (
            "Panama",
            isoAbbreviation: "PA"
        );

        [Display(Name = "Papua New Guinea")]
        public Country PapuaNewGuinea => new Country
        (
            "Papua New Guinea",
            isoAbbreviation: "PG"
        );

        [Display(Name = "Paraguay")]
        public Country Paraguay => new Country
        (
            "Paraguay",
            isoAbbreviation: "PY"
        );

        [Display(Name = "Peru")]
        public Country Peru => new Country
        (
            "Peru",
            isoAbbreviation: "PE"
        );

        [Display(Name = "Philippines")]
        public Country Philippines => new Country
        (
            "Philippines",
            isoAbbreviation: "PH"
        );

        [Display(Name = "Poland")]
        public Country Poland => new Country
        (
            "Poland",
            isoAbbreviation: "PL"
        );

        [Display(Name = "Portugal")]
        public Country Portugal => new Country
        (
            "Portugal",
            isoAbbreviation: "PT"
        );

        [Display(Name = "Puerto Rico")]
        public Country PuertoRico => new Country
        (
            "Puerto Rico",
            isoAbbreviation: "PR"
        );

        [Display(Name = "Qatar")]
        public Country Qatar => new Country
        (
            "Qatar",
            isoAbbreviation: "QA"
        );

        [Display(Name = "Republic of the Congo")]
        public Country RepublicOfTheCongo => new Country
        (
            "Republic of the Congo",
            isoAbbreviation: "CG"
        );

        [Display(Name = "Réunion")]
        public Country Réunion => new Country
        (
            "Réunion",
            isoAbbreviation: "RE"
        );

        [Display(Name = "Romania")]
        public Country Romania => new Country
        (
            "Romania",
            isoAbbreviation: "RO"
        );

        [Display(Name = "Russia")]
        public Country Russia => new Country
        (
            "Russia",
            isoAbbreviation: "RU"
        );

        [Display(Name = "Rwanda")]
        public Country Rwanda => new Country
        (
            "Rwanda",
            isoAbbreviation: "RW"
        );

        [Display(Name = "Saint Barthélemy")]
        public Country SaintBarthélemy => new Country
        (
            "Saint Barthélemy",
            isoAbbreviation: "BL"
        );

        [Display(Name = "Saint Helena")]
        public Country SaintHelena => new Country
        (
            "Saint Helena",
            isoAbbreviation: "SH"
        );

        [Display(Name = "Saint Kitts and Nevis")]
        public Country SaintKittsAndNevis => new Country
        (
            "Saint Kitts and Nevis",
            isoAbbreviation: "KN"
        );

        [Display(Name = "Saint Martin")]
        public Country SaintMartin => new Country
        (
            "Saint Martin",
            isoAbbreviation: "MF"
        );

        [Display(Name = "Saint Pierre and Miquelon")]
        public Country SaintPierreAndMiquelon => new Country
        (
            "Saint Pierre and Miquelon",
            isoAbbreviation: "PM"
        );

        [Display(Name = "Saint Vincent and the Grenadines")]
        public Country SaintVincentAndTheGrenadines => new Country
        (
            "Saint Vincent and the Grenadines",
            isoAbbreviation: "VC"
        );

        [Display(Name = "Samoa")]
        public Country Samoa => new Country
        (
            "Samoa",
            isoAbbreviation: "WS"
        );

        [Display(Name = "San Marino")]
        public Country SanMarino => new Country
        (
            "San Marino",
            isoAbbreviation: "SM"
        );

        [Display(Name = "São Tomé and Príncipe")]
        public Country SãoToméAndPríncipe => new Country
        (
            "São Tomé and Príncipe",
            isoAbbreviation: "ST"
        );

        [Display(Name = "Saudi Arabia")]
        public Country SaudiArabia => new Country
        (
            "Saudi Arabia",
            isoAbbreviation: "SA"
        );

        [Display(Name = "Senegal")]
        public Country Senegal => new Country
        (
            "Senegal",
            isoAbbreviation: "SN"
        );

        [Display(Name = "Serbia")]
        public Country Serbia => new Country
        (
            "Serbia",
            isoAbbreviation: "RS"
        );

        [Display(Name = "Seychelles")]
        public Country Seychelles => new Country
        (
            "Seychelles",
            isoAbbreviation: "SC"
        );

        [Display(Name = "Sierra Leone")]
        public Country SierraLeone => new Country
        (
            "Sierra Leone",
            isoAbbreviation: "SL"
        );

        [Display(Name = "Singapore")]
        public Country Singapore => new Country
        (
            "Singapore",
            isoAbbreviation: "SG"
        );

        [Display(Name = "Slovakia")]
        public Country Slovakia => new Country
        (
            "Slovakia",
            isoAbbreviation: "SK"
        );

        [Display(Name = "Slovenia")]
        public Country Slovenia => new Country
        (
            "Slovenia",
            isoAbbreviation: "SI"
        );

        [Display(Name = "Solomon Islands")]
        public Country SolomonIslands => new Country
        (
            "Solomon Islands",
            isoAbbreviation: "SB"
        );

        [Display(Name = "Somalia")]
        public Country Somalia => new Country
        (
            "Somalia",
            isoAbbreviation: "SO"
        );

        [Display(Name = "South Africa")]
        public Country SouthAfrica => new Country
        (
            "South Africa",
            isoAbbreviation: "ZA"
        );

        [Display(Name = "South Korea")]
        public Country SouthKorea => new Country
        (
            "South Korea",
            isoAbbreviation: "KR"
        );

        [Display(Name = "Spain")]
        public Country Spain => new Country
        (
            "Spain",
            isoAbbreviation: "ES"
        );

        [Display(Name = "Sri Lanka")]
        public Country SriLanka => new Country
        (
            "Sri Lanka",
            isoAbbreviation: "LK"
        );

        [Display(Name = "St. Lucia")]
        public Country StLucia => new Country
        (
            "St. Lucia",
            isoAbbreviation: "LC"
        );

        [Display(Name = "Sudan")]
        public Country Sudan => new Country
        (
            "Sudan",
            isoAbbreviation: "SD"
        );

        [Display(Name = "Suriname")]
        public Country Suriname => new Country
        (
            "Suriname",
            isoAbbreviation: "SR"
        );

        [Display(Name = "Swaziland")]
        public Country Swaziland => new Country
        (
            "Swaziland",
            isoAbbreviation: "SZ"
        );

        [Display(Name = "Sweden")]
        public Country Sweden => new Country
        (
            "Sweden",
            isoAbbreviation: "SE"
        );

        [Display(Name = "Switzerland")]
        public Country Switzerland => new Country
        (
            "Switzerland",
            isoAbbreviation: "CH"
        );

        [Display(Name = "Syria")]
        public Country Syria => new Country
        (
            "Syria",
            isoAbbreviation: "SY"
        );

        [Display(Name = "Taiwan")]
        public Country Taiwan => new Country
        (
            "Taiwan",
            isoAbbreviation: "TW"
        );

        [Display(Name = "Tajikistan")]
        public Country Tajikistan => new Country
        (
            "Tajikistan",
            isoAbbreviation: "TJ"
        );

        [Display(Name = "Tanzania")]
        public Country Tanzania => new Country
        (
            "Tanzania",
            isoAbbreviation: "TZ"
        );

        [Display(Name = "Thailand")]
        public Country Thailand => new Country
        (
            "Thailand",
            isoAbbreviation: "TH"
        );

        [Display(Name = "The Bahamas")]
        public Country TheBahamas => new Country
        (
            "The Bahamas",
            isoAbbreviation: "BS"
        );

        [Display(Name = "The Gambia")]
        public Country TheGambia => new Country
        (
            "The Gambia",
            isoAbbreviation: "GM"
        );

        [Display(Name = "Timor-Leste")]
        public Country TimorLeste => new Country
        (
            "Timor-Leste",
            isoAbbreviation: "TL"
        );

        [Display(Name = "Togo")]
        public Country Togo => new Country
        (
            "Togo",
            isoAbbreviation: "TG"
        );

        [Display(Name = "Tokelau")]
        public Country Tokelau => new Country
        (
            "Tokelau",
            isoAbbreviation: "TK"
        );

        [Display(Name = "Tonga")]
        public Country Tonga => new Country
        (
            "Tonga",
            isoAbbreviation: "TO"
        );

        [Display(Name = "Trinidad and Tobago")]
        public Country TrinidadAndTobago => new Country
        (
            "Trinidad and Tobago",
            isoAbbreviation: "TT"
        );

        [Display(Name = "Tunisia")]
        public Country Tunisia => new Country
        (
            "Tunisia",
            isoAbbreviation: "TN"
        );

        [Display(Name = "Turkey")]
        public Country Turkey => new Country
        (
            "Turkey",
            isoAbbreviation: "TR"
        );

        [Display(Name = "Turkmenistan")]
        public Country Turkmenistan => new Country
        (
            "Turkmenistan",
            isoAbbreviation: "TM"
        );

        [Display(Name = "Turks and Caicos Islands")]
        public Country TurksAndCaicosIslands => new Country
        (
            "Turks and Caicos Islands",
            isoAbbreviation: "TC"
        );

        [Display(Name = "Tuvalu")]
        public Country Tuvalu => new Country
        (
            "Tuvalu",
            isoAbbreviation: "TV"
        );

        [Display(Name = "Uganda")]
        public Country Uganda => new Country
        (
            "Uganda",
            isoAbbreviation: "UG"
        );

        [Display(Name = "Ukraine")]
        public Country Ukraine => new Country
        (
            "Ukraine",
            isoAbbreviation: "UA"
        );

        [Display(Name = "United Arab Emirates")]
        public Country UnitedArabEmirates => new Country
        (
            "United Arab Emirates",
            isoAbbreviation: "AE"
        );

        [Display(Name = "United Kingdom")]
        public Country UnitedKingdom => new Country
        (
            "United Kingdom",
            isoAbbreviation: "GB"
        );

        [Display(Name = "United States")]
        public Country UnitedStates => new Country
        (
            "United States",
            isoAbbreviation: "US"
        );

        [Display(Name = "Uruguay")]
        public Country Uruguay => new Country
        (
            "Uruguay",
            isoAbbreviation: "UY"
        );

        [Display(Name = "US Virgin Islands")]
        public Country USVirginIslands => new Country
        (
            "US Virgin Islands",
            isoAbbreviation: "VI"
        );

        [Display(Name = "Uzbekistan")]
        public Country Uzbekistan => new Country
        (
            "Uzbekistan",
            isoAbbreviation: "UZ"
        );

        [Display(Name = "Vanuatu")]
        public Country Vanuatu => new Country
        (
            "Vanuatu",
            isoAbbreviation: "VU"
        );

        [Display(Name = "Vatican City")]
        public Country VaticanCity => new Country
        (
            "Vatican City",
            isoAbbreviation: "VA"
        );

        [Display(Name = "Venezuela")]
        public Country Venezuela => new Country
        (
            "Venezuela",
            isoAbbreviation: "VE"
        );

        [Display(Name = "Vietnam")]
        public Country Vietnam => new Country
        (
            "Vietnam",
            isoAbbreviation: "VN"
        );

        [Display(Name = "Wallis and Futuna")]
        public Country WallisAndFutuna => new Country
        (
            "Wallis and Futuna",
            isoAbbreviation: "WF"
        );

        [Display(Name = "Yemen")]
        public Country Yemen => new Country
        (
            "Yemen",
            isoAbbreviation: "YE"
        );

        [Display(Name = "Zambia")]
        public Country Zambia => new Country
        (
            "Zambia",
            isoAbbreviation: "ZM"
        );

        [Display(Name = "Zimbabwe")]
        public Country Zimbabwe => new Country
        (
            "Zimbabwe",
            isoAbbreviation: "ZW"
        );
    }
}