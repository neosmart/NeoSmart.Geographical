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
            isoNumeric: "004",
            isoAlpha2: "AF",
            isoAlpha3: "AFG",
            dialPrefix: "+93"
        );

        [Display(Name = "Albania")]
        public Country Albania => new Country
        (
            "Albania",
            isoNumeric: "008",
            isoAlpha2: "AL",
            isoAlpha3: "ALB",
            dialPrefix: "+355"
        );

        [Display(Name = "Algeria")]
        public Country Algeria => new Country
        (
            "Algeria",
            isoNumeric: "012",
            isoAlpha2: "DZ",
            isoAlpha3: "DZA",
            dialPrefix: "+213"
        );

        [Display(Name = "American Samoa")]
        public Country AmericanSamoa => new Country
        (
            "American Samoa",
            isoNumeric: "016",
            isoAlpha2: "AS",
            isoAlpha3: "ASM",
            dialPrefix: "+1-684"
        );

        [Display(Name = "Andorra")]
        public Country Andorra => new Country
        (
            "Andorra",
            isoNumeric: "020",
            isoAlpha2: "AD",
            isoAlpha3: "AND",
            dialPrefix: "+376"
        );

        [Display(Name = "Angola")]
        public Country Angola => new Country
        (
            "Angola",
            isoNumeric: "024",
            isoAlpha2: "AO",
            isoAlpha3: "AGO",
            dialPrefix: "+244"
        );

        [Display(Name = "Anguilla")]
        public Country Anguilla => new Country
        (
            "Anguilla",
            isoNumeric: "660",
            isoAlpha2: "AI",
            isoAlpha3: "AIA",
            dialPrefix: "+1-264"
        );

        [Display(Name = "Antigua")]
        public Country Antigua => new Country
        (
            "Antigua",
            isoNumeric: "028",
            isoAlpha2: "AG",
            isoAlpha3: "ATG",
            dialPrefix: "+1-268"
        );

        [Display(Name = "Argentina")]
        public Country Argentina => new Country
        (
            "Argentina",
            isoNumeric: "032",
            isoAlpha2: "AR",
            isoAlpha3: "ARG",
            dialPrefix: "+54"
        );

        [Display(Name = "Armenia")]
        public Country Armenia => new Country
        (
            "Armenia",
            isoNumeric: "051",
            isoAlpha2: "AM",
            isoAlpha3: "ARM",
            dialPrefix: "+374"
        );

        [Display(Name = "Aruba")]
        public Country Aruba => new Country
        (
            "Aruba",
            isoNumeric: "533",
            isoAlpha2: "AW",
            isoAlpha3: "ABW",
            dialPrefix: "+297"
        );

        [Display(Name = "Australia")]
        public Country Australia => new Country
        (
            "Australia",
            isoNumeric: "036",
            isoAlpha2: "AU",
            isoAlpha3: "AUS",
            dialPrefix: "+61"
        );

        [Display(Name = "Austria")]
        public Country Austria => new Country
        (
            "Austria",
            isoNumeric: "040",
            isoAlpha2: "AT",
            isoAlpha3: "AUT",
            dialPrefix: "+43"
        );

        [Display(Name = "Azerbaijan")]
        public Country Azerbaijan => new Country
        (
            "Azerbaijan",
            isoNumeric: "031",
            isoAlpha2: "AZ",
            isoAlpha3: "AZE",
            dialPrefix: "+994"
        );

        [Display(Name = "Bahrain")]
        public Country Bahrain => new Country
        (
            "Bahrain",
            isoNumeric: "048",
            isoAlpha2: "BH",
            isoAlpha3: "BHR",
            dialPrefix: "+973"
        );

        [Display(Name = "Bangladesh")]
        public Country Bangladesh => new Country
        (
            "Bangladesh",
            isoNumeric: "050",
            isoAlpha2: "BD",
            isoAlpha3: "BGD",
            dialPrefix: "+880"
        );

        [Display(Name = "Barbados")]
        public Country Barbados => new Country
        (
            "Barbados",
            isoNumeric: "052",
            isoAlpha2: "BB",
            isoAlpha3: "BRB",
            dialPrefix: "+1-246"
        );

        [Display(Name = "Belarus")]
        public Country Belarus => new Country
        (
            "Belarus",
            isoNumeric: "112",
            isoAlpha2: "BY",
            isoAlpha3: "BLR",
            dialPrefix: "+375"
        );

        [Display(Name = "Belgium")]
        public Country Belgium => new Country
        (
            "Belgium",
            isoNumeric: "056",
            isoAlpha2: "BE",
            isoAlpha3: "BEL",
            dialPrefix: "+32"
        );

        [Display(Name = "Belize")]
        public Country Belize => new Country
        (
            "Belize",
            isoNumeric: "084",
            isoAlpha2: "BZ",
            isoAlpha3: "BLZ",
            dialPrefix: "+501"
        );

        [Display(Name = "Benin")]
        public Country Benin => new Country
        (
            "Benin",
            isoNumeric: "204",
            isoAlpha2: "BJ",
            isoAlpha3: "BEN",
            dialPrefix: "+229"
        );

        [Display(Name = "Bermuda")]
        public Country Bermuda => new Country
        (
            "Bermuda",
            isoNumeric: "060",
            isoAlpha2: "BM",
            isoAlpha3: "BMU",
            dialPrefix: "+1-441"
        );

        [Display(Name = "Bhutan")]
        public Country Bhutan => new Country
        (
            "Bhutan",
            isoNumeric: "064",
            isoAlpha2: "BT",
            isoAlpha3: "BTN",
            dialPrefix: "+975"
        );

        [Display(Name = "Bolivia")]
        public Country Bolivia => new Country
        (
            "Bolivia",
            isoNumeric: "068",
            isoAlpha2: "BO",
            isoAlpha3: "BOL",
            dialPrefix: "+591"
        );

        [Display(Name = "Bosnia and Herzegovina")]
        public Country BosniaAndHerzegovina => new Country
        (
            "Bosnia and Herzegovina",
            isoNumeric: "070",
            isoAlpha2: "BA",
            isoAlpha3: "BIH",
            dialPrefix: "+387"
        );

        [Display(Name = "Botswana")]
        public Country Botswana => new Country
        (
            "Botswana",
            isoNumeric: "072",
            isoAlpha2: "BW",
            isoAlpha3: "BWA",
            dialPrefix: "+267"
        );

        [Display(Name = "Brazil")]
        public Country Brazil => new Country
        (
            "Brazil",
            isoNumeric: "076",
            isoAlpha2: "BR",
            isoAlpha3: "BRA",
            dialPrefix: "+55"
        );

        [Display(Name = "British Indian Ocean Territory")]
        public Country BritishIndianOceanTerritory => new Country
        (
            "British Indian Ocean Territory",
            isoNumeric: "086",
            isoAlpha2: "IO",
            isoAlpha3: "IOT",
            dialPrefix: "+246"
        );

        [Display(Name = "British Virgin Islands")]
        public Country BritishVirginIslands => new Country
        (
            "British Virgin Islands",
            isoNumeric: "092",
            isoAlpha2: "VG",
            isoAlpha3: "VGB",
            dialPrefix: "+1-284"
        );

        [Display(Name = "Brunei")]
        public Country Brunei => new Country
        (
            "Brunei",
            isoNumeric: "096",
            isoAlpha2: "BN",
            isoAlpha3: "BRN",
            dialPrefix: "+673"
        );

        [Display(Name = "Bulgaria")]
        public Country Bulgaria => new Country
        (
            "Bulgaria",
            isoNumeric: "100",
            isoAlpha2: "BG",
            isoAlpha3: "BGR",
            dialPrefix: "+359"
        );

        [Display(Name = "Burkina Faso")]
        public Country BurkinaFaso => new Country
        (
            "Burkina Faso",
            isoNumeric: "854",
            isoAlpha2: "BF",
            isoAlpha3: "BFA",
            dialPrefix: "+226"
        );

        [Display(Name = "Burma Myanmar")]
        public Country BurmaMyanmar => new Country
        (
            "Burma Myanmar",
            isoNumeric: "104",
            isoAlpha2: "MM",
            isoAlpha3: "MMR",
            dialPrefix: "+95"
        );

        [Display(Name = "Burundi")]
        public Country Burundi => new Country
        (
            "Burundi",
            isoNumeric: "108",
            isoAlpha2: "BI",
            isoAlpha3: "BDI",
            dialPrefix: "+257"
        );

        [Display(Name = "Cambodia")]
        public Country Cambodia => new Country
        (
            "Cambodia",
            isoNumeric: "116",
            isoAlpha2: "KH",
            isoAlpha3: "KHM",
            dialPrefix: "+855"
        );

        [Display(Name = "Cameroon")]
        public Country Cameroon => new Country
        (
            "Cameroon",
            isoNumeric: "120",
            isoAlpha2: "CM",
            isoAlpha3: "CMR",
            dialPrefix: "+237"
        );

        [Display(Name = "Canada")]
        public Country Canada => new Country
        (
            "Canada",
            isoNumeric: "124",
            isoAlpha2: "CA",
            isoAlpha3: "CAN",
            dialPrefix: "+1"
        );

        [Display(Name = "Cape Verde")]
        public Country CapeVerde => new Country
        (
            "Cape Verde",
            isoNumeric: "132",
            isoAlpha2: "CV",
            isoAlpha3: "CPV",
            dialPrefix: "+238"
        );

        [Display(Name = "Cayman Islands")]
        public Country CaymanIslands => new Country
        (
            "Cayman Islands",
            isoNumeric: "136",
            isoAlpha2: "KY",
            isoAlpha3: "CYM",
            dialPrefix: "+1-345"
        );

        [Display(Name = "Central African Republic")]
        public Country CentralAfricanRepublic => new Country
        (
            "Central African Republic",
            isoNumeric: "140",
            isoAlpha2: "CF",
            isoAlpha3: "CAF",
            dialPrefix: "+236"
        );

        [Display(Name = "Chad")]
        public Country Chad => new Country
        (
            "Chad",
            isoNumeric: "148",
            isoAlpha2: "TD",
            isoAlpha3: "TCD",
            dialPrefix: "+235"
        );

        [Display(Name = "Chile")]
        public Country Chile => new Country
        (
            "Chile",
            isoNumeric: "152",
            isoAlpha2: "CL",
            isoAlpha3: "CHL",
            dialPrefix: "+56"
        );

        [Display(Name = "China")]
        public Country China => new Country
        (
            "China",
            isoNumeric: "156",
            isoAlpha2: "CN",
            isoAlpha3: "CHN",
            dialPrefix: "+86"
        );

        [Display(Name = "Colombia")]
        public Country Colombia => new Country
        (
            "Colombia",
            isoNumeric: "170",
            isoAlpha2: "CO",
            isoAlpha3: "COL",
            dialPrefix: "+57"
        );

        [Display(Name = "Comoros")]
        public Country Comoros => new Country
        (
            "Comoros",
            isoNumeric: "174",
            isoAlpha2: "KM",
            isoAlpha3: "COM",
            dialPrefix: "+269"
        );

        [Display(Name = "Cook Islands")]
        public Country CookIslands => new Country
        (
            "Cook Islands",
            isoNumeric: "184",
            isoAlpha2: "CK",
            isoAlpha3: "COK",
            dialPrefix: "+682"
        );

        [Display(Name = "Costa Rica")]
        public Country CostaRica => new Country
        (
            "Costa Rica",
            isoNumeric: "188",
            isoAlpha2: "CR",
            isoAlpha3: "CRI",
            dialPrefix: "+506"
        );

        [Display(Name = "Côte d'Ivoire")]
        public Country CoteDivoire => new Country
        (
            "Côte d'Ivoire",
            isoNumeric: "384",
            isoAlpha2: "CI",
            isoAlpha3: "CIV",
            dialPrefix: "+225"
        );

        [Display(Name = "Croatia")]
        public Country Croatia => new Country
        (
            "Croatia",
            isoNumeric: "191",
            isoAlpha2: "HR",
            isoAlpha3: "HRV",
            dialPrefix: "+385"
        );

        [Display(Name = "Cuba")]
        public Country Cuba => new Country
        (
            "Cuba",
            isoNumeric: "192",
            isoAlpha2: "CU",
            isoAlpha3: "CUB",
            dialPrefix: "+53"
        );

        [Display(Name = "Cyprus")]
        public Country Cyprus => new Country
        (
            "Cyprus",
            isoNumeric: "196",
            isoAlpha2: "CY",
            isoAlpha3: "CYP",
            dialPrefix: "+357"
        );

        [Display(Name = "Czech Republic")]
        public Country CzechRepublic => new Country
        (
            "Czech Republic",
            isoNumeric: "203",
            isoAlpha2: "CZ",
            isoAlpha3: "CZE",
            dialPrefix: "+420"
        );

        [Display(Name = "Democratic Republic of Congo")]
        public Country DemocraticRepublicOfCongo => new Country
        (
            "Democratic Republic of Congo",
            isoNumeric: "180",
            isoAlpha2: "CD",
            isoAlpha3: "COD",
            dialPrefix: "+243"
        );

        [Display(Name = "Denmark")]
        public Country Denmark => new Country
        (
            "Denmark",
            isoNumeric: "208",
            isoAlpha2: "DK",
            isoAlpha3: "DNK",
            dialPrefix: "+45"
        );

        [Display(Name = "Djibouti")]
        public Country Djibouti => new Country
        (
            "Djibouti",
            isoNumeric: "262",
            isoAlpha2: "DJ",
            isoAlpha3: "DJI",
            dialPrefix: "+253"
        );

        [Display(Name = "Dominica")]
        public Country Dominica => new Country
        (
            "Dominica",
            isoNumeric: "212",
            isoAlpha2: "DM",
            isoAlpha3: "DMA",
            dialPrefix: "+1-767"
        );

        [Display(Name = "Dominican Republic")]
        public Country DominicanRepublic => new Country
        (
            "Dominican Republic",
            isoNumeric: "214",
            isoAlpha2: "DO",
            isoAlpha3: "DOM",
            dialPrefix: "+1-809 and 1-829"
        );

        [Display(Name = "Ecuador")]
        public Country Ecuador => new Country
        (
            "Ecuador",
            isoNumeric: "218",
            isoAlpha2: "EC",
            isoAlpha3: "ECU",
            dialPrefix: "+593"
        );

        [Display(Name = "Egypt")]
        public Country Egypt => new Country
        (
            "Egypt",
            isoNumeric: "818",
            isoAlpha2: "EG",
            isoAlpha3: "EGY",
            dialPrefix: "+20"
        );

        [Display(Name = "El Salvador")]
        public Country ElSalvador => new Country
        (
            "El Salvador",
            isoNumeric: "222",
            isoAlpha2: "SV",
            isoAlpha3: "SLV",
            dialPrefix: "+503"
        );

        [Display(Name = "Equatorial Guinea")]
        public Country EquatorialGuinea => new Country
        (
            "Equatorial Guinea",
            isoNumeric: "226",
            isoAlpha2: "GQ",
            isoAlpha3: "GNQ",
            dialPrefix: "+240"
        );

        [Display(Name = "Eritrea")]
        public Country Eritrea => new Country
        (
            "Eritrea",
            isoNumeric: "232",
            isoAlpha2: "ER",
            isoAlpha3: "ERI",
            dialPrefix: "+291"
        );

        [Display(Name = "Estonia")]
        public Country Estonia => new Country
        (
            "Estonia",
            isoNumeric: "233",
            isoAlpha2: "EE",
            isoAlpha3: "EST",
            dialPrefix: "+372"
        );

        [Display(Name = "Ethiopia")]
        public Country Ethiopia => new Country
        (
            "Ethiopia",
            isoNumeric: "231",
            isoAlpha2: "ET",
            isoAlpha3: "ETH",
            dialPrefix: "+251"
        );

        [Display(Name = "Falkland Islands")]
        public Country FalklandIslands => new Country
        (
            "Falkland Islands",
            isoNumeric: "238",
            isoAlpha2: "FK",
            isoAlpha3: "FLK",
            dialPrefix: "+500"
        );

        [Display(Name = "Faroe Islands")]
        public Country FaroeIslands => new Country
        (
            "Faroe Islands",
            isoNumeric: "234",
            isoAlpha2: "FO",
            isoAlpha3: "FRO",
            dialPrefix: "+298"
        );

        [Display(Name = "Federated States of Micronesia")]
        public Country FederatedStatesOfMicronesia => new Country
        (
            "Federated States of Micronesia",
            isoNumeric: "583",
            isoAlpha2: "FM",
            isoAlpha3: "FSM",
            dialPrefix: "+691"
        );

        [Display(Name = "Fiji")]
        public Country Fiji => new Country
        (
            "Fiji",
            isoNumeric: "242",
            isoAlpha2: "FJ",
            isoAlpha3: "FJI",
            dialPrefix: "+679"
        );

        [Display(Name = "Finland")]
        public Country Finland => new Country
        (
            "Finland",
            isoNumeric: "246",
            isoAlpha2: "FI",
            isoAlpha3: "FIN",
            dialPrefix: "+358"
        );

        [Display(Name = "France")]
        public Country France => new Country
        (
            "France",
            isoNumeric: "250",
            isoAlpha2: "FR",
            isoAlpha3: "FRA",
            dialPrefix: "+33"
        );

        [Display(Name = "French Guiana")]
        public Country FrenchGuiana => new Country
        (
            "French Guiana",
            isoNumeric: "254",
            isoAlpha2: "GF",
            isoAlpha3: "GUF",
            dialPrefix: "+594"
        );

        [Display(Name = "French Polynesia")]
        public Country FrenchPolynesia => new Country
        (
            "French Polynesia",
            isoNumeric: "258",
            isoAlpha2: "PF",
            isoAlpha3: "PYF",
            dialPrefix: "+689"
        );

        [Display(Name = "Gabon")]
        public Country Gabon => new Country
        (
            "Gabon",
            isoNumeric: "266",
            isoAlpha2: "GA",
            isoAlpha3: "GAB",
            dialPrefix: "+241"
        );

        [Display(Name = "Georgia")]
        public Country Georgia => new Country
        (
            "Georgia",
            isoNumeric: "268",
            isoAlpha2: "GE",
            isoAlpha3: "GEO",
            dialPrefix: "+995"
        );

        [Display(Name = "Germany")]
        public Country Germany => new Country
        (
            "Germany",
            isoNumeric: "276",
            isoAlpha2: "DE",
            isoAlpha3: "DEU",
            dialPrefix: "+49"
        );

        [Display(Name = "Ghana")]
        public Country Ghana => new Country
        (
            "Ghana",
            isoNumeric: "288",
            isoAlpha2: "GH",
            isoAlpha3: "GHA",
            dialPrefix: "+233"
        );

        [Display(Name = "Gibraltar")]
        public Country Gibraltar => new Country
        (
            "Gibraltar",
            isoNumeric: "292",
            isoAlpha2: "GI",
            isoAlpha3: "GIB",
            dialPrefix: "+350"
        );

        [Display(Name = "Greece")]
        public Country Greece => new Country
        (
            "Greece",
            isoNumeric: "300",
            isoAlpha2: "GR",
            isoAlpha3: "GRC",
            dialPrefix: "+30"
        );

        [Display(Name = "Greenland")]
        public Country Greenland => new Country
        (
            "Greenland",
            isoNumeric: "304",
            isoAlpha2: "GL",
            isoAlpha3: "GRL",
            dialPrefix: "+299"
        );

        [Display(Name = "Grenada")]
        public Country Grenada => new Country
        (
            "Grenada",
            isoNumeric: "308",
            isoAlpha2: "GD",
            isoAlpha3: "GRD",
            dialPrefix: "+1-473"
        );

        [Display(Name = "Guadeloupe")]
        public Country Guadeloupe => new Country
        (
            "Guadeloupe",
            isoNumeric: "312",
            isoAlpha2: "GP",
            isoAlpha3: "GLP",
            dialPrefix: "+590"
        );

        [Display(Name = "Guam")]
        public Country Guam => new Country
        (
            "Guam",
            isoNumeric: "316",
            isoAlpha2: "GU",
            isoAlpha3: "GUM",
            dialPrefix: "+1-671"
        );

        [Display(Name = "Guatemala")]
        public Country Guatemala => new Country
        (
            "Guatemala",
            isoNumeric: "320",
            isoAlpha2: "GT",
            isoAlpha3: "GTM",
            dialPrefix: "+502"
        );

        [Display(Name = "Guinea")]
        public Country Guinea => new Country
        (
            "Guinea",
            isoNumeric: "324",
            isoAlpha2: "GN",
            isoAlpha3: "GIN",
            dialPrefix: "+224"
        );

        [Display(Name = "Guinea-Bissau")]
        public Country GuineaBissau => new Country
        (
            "Guinea-Bissau",
            isoNumeric: "624",
            isoAlpha2: "GW",
            isoAlpha3: "GNB",
            dialPrefix: "+245"
        );

        [Display(Name = "Guyana")]
        public Country Guyana => new Country
        (
            "Guyana",
            isoNumeric: "328",
            isoAlpha2: "GY",
            isoAlpha3: "GUY",
            dialPrefix: "+592"
        );

        [Display(Name = "Haiti")]
        public Country Haiti => new Country
        (
            "Haiti",
            isoNumeric: "332",
            isoAlpha2: "HT",
            isoAlpha3: "HTI",
            dialPrefix: "+509"
        );

        [Display(Name = "Honduras")]
        public Country Honduras => new Country
        (
            "Honduras",
            isoNumeric: "340",
            isoAlpha2: "HN",
            isoAlpha3: "HND",
            dialPrefix: "+504"
        );

        [Display(Name = "Hong Kong")]
        public Country HongKong => new Country
        (
            "Hong Kong",
            isoNumeric: "344",
            isoAlpha2: "HK",
            isoAlpha3: "HKG",
            dialPrefix: "+852"
        );

        [Display(Name = "Hungary")]
        public Country Hungary => new Country
        (
            "Hungary",
            isoNumeric: "348",
            isoAlpha2: "HU",
            isoAlpha3: "HUN",
            dialPrefix: "+36"
        );

        [Display(Name = "Iceland")]
        public Country Iceland => new Country
        (
            "Iceland",
            isoNumeric: "352",
            isoAlpha2: "IS",
            isoAlpha3: "ISL",
            dialPrefix: "+354"
        );

        [Display(Name = "India")]
        public Country India => new Country
        (
            "India",
            isoNumeric: "356",
            isoAlpha2: "IN",
            isoAlpha3: "IND",
            dialPrefix: "+91"
        );

        [Display(Name = "Indonesia")]
        public Country Indonesia => new Country
        (
            "Indonesia",
            isoNumeric: "360",
            isoAlpha2: "ID",
            isoAlpha3: "IDN",
            dialPrefix: "+62"
        );

        [Display(Name = "Iran")]
        public Country Iran => new Country
        (
            "Iran",
            isoNumeric: "364",
            isoAlpha2: "IR",
            isoAlpha3: "IRN",
            dialPrefix: "+98"
        );

        [Display(Name = "Iraq")]
        public Country Iraq => new Country
        (
            "Iraq",
            isoNumeric: "368",
            isoAlpha2: "IQ",
            isoAlpha3: "IRQ",
            dialPrefix: "+964"
        );

        [Display(Name = "Ireland")]
        public Country Ireland => new Country
        (
            "Ireland",
            isoNumeric: "372",
            isoAlpha2: "IE",
            isoAlpha3: "IRL",
            dialPrefix: "+353"
        );

        [Display(Name = "Israel")]
        public Country Israel => new Country
        (
            "Israel",
            isoNumeric: "376",
            isoAlpha2: "IL",
            isoAlpha3: "ISR",
            dialPrefix: "+972"
        );

        [Display(Name = "Italy")]
        public Country Italy => new Country
        (
            "Italy",
            isoNumeric: "380",
            isoAlpha2: "IT",
            isoAlpha3: "ITA",
            dialPrefix: "+39"
        );

        [Display(Name = "Jamaica")]
        public Country Jamaica => new Country
        (
            "Jamaica",
            isoNumeric: "388",
            isoAlpha2: "JM",
            isoAlpha3: "JAM",
            dialPrefix: "+1-876"
        );

        [Display(Name = "Japan")]
        public Country Japan => new Country
        (
            "Japan",
            isoNumeric: "392",
            isoAlpha2: "JP",
            isoAlpha3: "JPN",
            dialPrefix: "+81"
        );

        [Display(Name = "Jordan")]
        public Country Jordan => new Country
        (
            "Jordan",
            isoNumeric: "400",
            isoAlpha2: "JO",
            isoAlpha3: "JOR",
            dialPrefix: "+962"
        );

        [Display(Name = "Kazakhstan")]
        public Country Kazakhstan => new Country
        (
            "Kazakhstan",
            isoNumeric: "398",
            isoAlpha2: "KZ",
            isoAlpha3: "KAZ",
            dialPrefix: "+7"
        );

        [Display(Name = "Kenya")]
        public Country Kenya => new Country
        (
            "Kenya",
            isoNumeric: "404",
            isoAlpha2: "KE",
            isoAlpha3: "KEN",
            dialPrefix: "+254"
        );

        [Display(Name = "Kiribati")]
        public Country Kiribati => new Country
        (
            "Kiribati",
            isoNumeric: "296",
            isoAlpha2: "KI",
            isoAlpha3: "KIR",
            dialPrefix: "+686"
        );

        [Display(Name = "Kosovo")]
        public Country Kosovo => new Country
        (
            "Kosovo",
            isoAlpha2: "XK",
            isoAlpha3: "XKX",
            dialPrefix: "+"
        );

        [Display(Name = "Kuwait")]
        public Country Kuwait => new Country
        (
            "Kuwait",
            isoNumeric: "414",
            isoAlpha2: "KW",
            isoAlpha3: "KWT",
            dialPrefix: "+965"
        );

        [Display(Name = "Kyrgyzstan")]
        public Country Kyrgyzstan => new Country
        (
            "Kyrgyzstan",
            isoNumeric: "417",
            isoAlpha2: "KG",
            isoAlpha3: "KGZ",
            dialPrefix: "+996"
        );

        [Display(Name = "Laos")]
        public Country Laos => new Country
        (
            "Laos",
            isoNumeric: "418",
            isoAlpha2: "LA",
            isoAlpha3: "LAO",
            dialPrefix: "+856"
        );

        [Display(Name = "Latvia")]
        public Country Latvia => new Country
        (
            "Latvia",
            isoNumeric: "428",
            isoAlpha2: "LV",
            isoAlpha3: "LVA",
            dialPrefix: "+371"
        );

        [Display(Name = "Lebanon")]
        public Country Lebanon => new Country
        (
            "Lebanon",
            isoNumeric: "422",
            isoAlpha2: "LB",
            isoAlpha3: "LBN",
            dialPrefix: "+961"
        );

        [Display(Name = "Lesotho")]
        public Country Lesotho => new Country
        (
            "Lesotho",
            isoNumeric: "426",
            isoAlpha2: "LS",
            isoAlpha3: "LSO",
            dialPrefix: "+266"
        );

        [Display(Name = "Liberia")]
        public Country Liberia => new Country
        (
            "Liberia",
            isoNumeric: "430",
            isoAlpha2: "LR",
            isoAlpha3: "LBR",
            dialPrefix: "+231"
        );

        [Display(Name = "Libya")]
        public Country Libya => new Country
        (
            "Libya",
            isoNumeric: "434",
            isoAlpha2: "LY",
            isoAlpha3: "LBY",
            dialPrefix: "+218"
        );

        [Display(Name = "Liechtenstein")]
        public Country Liechtenstein => new Country
        (
            "Liechtenstein",
            isoNumeric: "438",
            isoAlpha2: "LI",
            isoAlpha3: "LIE",
            dialPrefix: "+423"
        );

        [Display(Name = "Lithuania")]
        public Country Lithuania => new Country
        (
            "Lithuania",
            isoNumeric: "440",
            isoAlpha2: "LT",
            isoAlpha3: "LTU",
            dialPrefix: "+370"
        );

        [Display(Name = "Luxembourg")]
        public Country Luxembourg => new Country
        (
            "Luxembourg",
            isoNumeric: "442",
            isoAlpha2: "LU",
            isoAlpha3: "LUX",
            dialPrefix: "+352"
        );

        [Display(Name = "Macau")]
        public Country Macau => new Country
        (
            "Macau",
            isoNumeric: "446",
            isoAlpha2: "MO",
            isoAlpha3: "MAC",
            dialPrefix: "+853"
        );

        [Display(Name = "Macedonia")]
        public Country Macedonia => new Country
        (
            "Macedonia",
            isoNumeric: "807",
            isoAlpha2: "MK",
            isoAlpha3: "MKD",
            dialPrefix: "+389"
        );

        [Display(Name = "Madagascar")]
        public Country Madagascar => new Country
        (
            "Madagascar",
            isoNumeric: "450",
            isoAlpha2: "MG",
            isoAlpha3: "MDG",
            dialPrefix: "+261"
        );

        [Display(Name = "Malawi")]
        public Country Malawi => new Country
        (
            "Malawi",
            isoNumeric: "454",
            isoAlpha2: "MW",
            isoAlpha3: "MWI",
            dialPrefix: "+265"
        );

        [Display(Name = "Malaysia")]
        public Country Malaysia => new Country
        (
            "Malaysia",
            isoNumeric: "458",
            isoAlpha2: "MY",
            isoAlpha3: "MYS",
            dialPrefix: "+60"
        );

        [Display(Name = "Maldives")]
        public Country Maldives => new Country
        (
            "Maldives",
            isoNumeric: "462",
            isoAlpha2: "MV",
            isoAlpha3: "MDV",
            dialPrefix: "+960"
        );

        [Display(Name = "Mali")]
        public Country Mali => new Country
        (
            "Mali",
            isoNumeric: "466",
            isoAlpha2: "ML",
            isoAlpha3: "MLI",
            dialPrefix: "+223"
        );

        [Display(Name = "Malta")]
        public Country Malta => new Country
        (
            "Malta",
            isoNumeric: "470",
            isoAlpha2: "MT",
            isoAlpha3: "MLT",
            dialPrefix: "+356"
        );

        [Display(Name = "Marshall Islands")]
        public Country MarshallIslands => new Country
        (
            "Marshall Islands",
            isoNumeric: "584",
            isoAlpha2: "MH",
            isoAlpha3: "MHL",
            dialPrefix: "+692"
        );

        [Display(Name = "Martinique")]
        public Country Martinique => new Country
        (
            "Martinique",
            isoNumeric: "474",
            isoAlpha2: "MQ",
            isoAlpha3: "MTQ",
            dialPrefix: "+596"
        );

        [Display(Name = "Mauritania")]
        public Country Mauritania => new Country
        (
            "Mauritania",
            isoNumeric: "478",
            isoAlpha2: "MR",
            isoAlpha3: "MRT",
            dialPrefix: "+222"
        );

        [Display(Name = "Mauritius")]
        public Country Mauritius => new Country
        (
            "Mauritius",
            isoNumeric: "480",
            isoAlpha2: "MU",
            isoAlpha3: "MUS",
            dialPrefix: "+230"
        );

        [Display(Name = "Mayotte")]
        public Country Mayotte => new Country
        (
            "Mayotte",
            isoNumeric: "175",
            isoAlpha2: "YT",
            isoAlpha3: "MYT",
            dialPrefix: "+262"
        );

        [Display(Name = "Mexico")]
        public Country Mexico => new Country
        (
            "Mexico",
            isoNumeric: "484",
            isoAlpha2: "MX",
            isoAlpha3: "MEX",
            dialPrefix: "+52"
        );

        [Display(Name = "Moldova")]
        public Country Moldova => new Country
        (
            "Moldova",
            isoNumeric: "498",
            isoAlpha2: "MD",
            isoAlpha3: "MDA",
            dialPrefix: "+373"
        );

        [Display(Name = "Monaco")]
        public Country Monaco => new Country
        (
            "Monaco",
            isoNumeric: "492",
            isoAlpha2: "MC",
            isoAlpha3: "MCO",
            dialPrefix: "+377"
        );

        [Display(Name = "Mongolia")]
        public Country Mongolia => new Country
        (
            "Mongolia",
            isoNumeric: "496",
            isoAlpha2: "MN",
            isoAlpha3: "MNG",
            dialPrefix: "+976"
        );

        [Display(Name = "Montenegro")]
        public Country Montenegro => new Country
        (
            "Montenegro",
            isoNumeric: "499",
            isoAlpha2: "ME",
            isoAlpha3: "MNE",
            dialPrefix: "+382"
        );

        [Display(Name = "Montserrat")]
        public Country Montserrat => new Country
        (
            "Montserrat",
            isoNumeric: "500",
            isoAlpha2: "MS",
            isoAlpha3: "MSR",
            dialPrefix: "+1-664"
        );

        [Display(Name = "Morocco")]
        public Country Morocco => new Country
        (
            "Morocco",
            isoNumeric: "504",
            isoAlpha2: "MA",
            isoAlpha3: "MAR",
            dialPrefix: "+212"
        );

        [Display(Name = "Mozambique")]
        public Country Mozambique => new Country
        (
            "Mozambique",
            isoNumeric: "508",
            isoAlpha2: "MZ",
            isoAlpha3: "MOZ",
            dialPrefix: "+258"
        );

        [Display(Name = "Namibia")]
        public Country Namibia => new Country
        (
            "Namibia",
            isoNumeric: "516",
            isoAlpha2: "NA",
            isoAlpha3: "NAM",
            dialPrefix: "+264"
        );

        [Display(Name = "Nauru")]
        public Country Nauru => new Country
        (
            "Nauru",
            isoNumeric: "520",
            isoAlpha2: "NR",
            isoAlpha3: "NRU",
            dialPrefix: "+674"
        );

        [Display(Name = "Nepal")]
        public Country Nepal => new Country
        (
            "Nepal",
            isoNumeric: "524",
            isoAlpha2: "NP",
            isoAlpha3: "NPL",
            dialPrefix: "+977"
        );

        [Display(Name = "Netherlands")]
        public Country Netherlands => new Country
        (
            "Netherlands",
            isoNumeric: "528",
            isoAlpha2: "NL",
            isoAlpha3: "NLD",
            dialPrefix: "+31"
        );

        [Display(Name = "Netherlands Antilles")]
        public Country NetherlandsAntilles => new Country
        (
            "Netherlands Antilles",
            isoAlpha2: "AN",
            isoAlpha3: ""
        );

        [Display(Name = "New Caledonia")]
        public Country NewCaledonia => new Country
        (
            "New Caledonia",
            isoNumeric: "540",
            isoAlpha2: "NC",
            isoAlpha3: "NCL",
            dialPrefix: "+687"
        );

        [Display(Name = "New Zealand")]
        public Country NewZealand => new Country
        (
            "New Zealand",
            isoNumeric: "554",
            isoAlpha2: "NZ",
            isoAlpha3: "NZL",
            dialPrefix: "+64"
        );

        [Display(Name = "Nicaragua")]
        public Country Nicaragua => new Country
        (
            "Nicaragua",
            isoNumeric: "558",
            isoAlpha2: "NI",
            isoAlpha3: "NIC",
            dialPrefix: "+505"
        );

        [Display(Name = "Niger")]
        public Country Niger => new Country
        (
            "Niger",
            isoNumeric: "562",
            isoAlpha2: "NE",
            isoAlpha3: "NER",
            dialPrefix: "+227"
        );

        [Display(Name = "Nigeria")]
        public Country Nigeria => new Country
        (
            "Nigeria",
            isoNumeric: "566",
            isoAlpha2: "NG",
            isoAlpha3: "NGA",
            dialPrefix: "+234"
        );

        [Display(Name = "Niue")]
        public Country Niue => new Country
        (
            "Niue",
            isoNumeric: "570",
            isoAlpha2: "NU",
            isoAlpha3: "NIU",
            dialPrefix: "+683"
        );

        [Display(Name = "Norfolk Island")]
        public Country NorfolkIsland => new Country
        (
            "Norfolk Island",
            isoNumeric: "574",
            isoAlpha2: "NF",
            isoAlpha3: "NFK",
            dialPrefix: "+672"
        );

        [Display(Name = "North Korea")]
        public Country NorthKorea => new Country
        (
            "North Korea",
            isoNumeric: "408",
            isoAlpha2: "KP",
            isoAlpha3: "PRK",
            dialPrefix: "+850"
        );

        [Display(Name = "Northern Mariana Islands")]
        public Country NorthernMarianaIslands => new Country
        (
            "Northern Mariana Islands",
            isoNumeric: "580",
            isoAlpha2: "MP",
            isoAlpha3: "MNP",
            dialPrefix: "+1-670"
        );

        [Display(Name = "Norway")]
        public Country Norway => new Country
        (
            "Norway",
            isoNumeric: "578",
            isoAlpha2: "NO",
            isoAlpha3: "NOR",
            dialPrefix: "+47"
        );

        [Display(Name = "Oman")]
        public Country Oman => new Country
        (
            "Oman",
            isoNumeric: "512",
            isoAlpha2: "OM",
            isoAlpha3: "OMN",
            dialPrefix: "+968"
        );

        [Display(Name = "Pakistan")]
        public Country Pakistan => new Country
        (
            "Pakistan",
            isoNumeric: "586",
            isoAlpha2: "PK",
            isoAlpha3: "PAK",
            dialPrefix: "+92"
        );

        [Display(Name = "Palau")]
        public Country Palau => new Country
        (
            "Palau",
            isoNumeric: "585",
            isoAlpha2: "PW",
            isoAlpha3: "PLW",
            dialPrefix: "+680"
        );

        [Display(Name = "Palestine")]
        public Country Palestine => new Country
        (
            "Palestine",
            isoNumeric: "275",
            isoAlpha2: "PS",
            isoAlpha3: "PSE",
            dialPrefix: "+970"
        );

        [Display(Name = "Panama")]
        public Country Panama => new Country
        (
            "Panama",
            isoNumeric: "591",
            isoAlpha2: "PA",
            isoAlpha3: "PAN",
            dialPrefix: "+507"
        );

        [Display(Name = "Papua New Guinea")]
        public Country PapuaNewGuinea => new Country
        (
            "Papua New Guinea",
            isoNumeric: "598",
            isoAlpha2: "PG",
            isoAlpha3: "PNG",
            dialPrefix: "+675"
        );

        [Display(Name = "Paraguay")]
        public Country Paraguay => new Country
        (
            "Paraguay",
            isoNumeric: "600",
            isoAlpha2: "PY",
            isoAlpha3: "PRY",
            dialPrefix: "+595"
        );

        [Display(Name = "Peru")]
        public Country Peru => new Country
        (
            "Peru",
            isoNumeric: "604",
            isoAlpha2: "PE",
            isoAlpha3: "PER",
            dialPrefix: "+51"
        );

        [Display(Name = "Philippines")]
        public Country Philippines => new Country
        (
            "Philippines",
            isoNumeric: "608",
            isoAlpha2: "PH",
            isoAlpha3: "PHL",
            dialPrefix: "+63"
        );

        [Display(Name = "Poland")]
        public Country Poland => new Country
        (
            "Poland",
            isoNumeric: "616",
            isoAlpha2: "PL",
            isoAlpha3: "POL",
            dialPrefix: "+48"
        );

        [Display(Name = "Portugal")]
        public Country Portugal => new Country
        (
            "Portugal",
            isoNumeric: "620",
            isoAlpha2: "PT",
            isoAlpha3: "PRT",
            dialPrefix: "+351"
        );

        [Display(Name = "Puerto Rico")]
        public Country PuertoRico => new Country
        (
            "Puerto Rico",
            isoNumeric: "630",
            isoAlpha2: "PR",
            isoAlpha3: "PRI",
            dialPrefix: "+1-787 and 1-939"
        );

        [Display(Name = "Qatar")]
        public Country Qatar => new Country
        (
            "Qatar",
            isoNumeric: "634",
            isoAlpha2: "QA",
            isoAlpha3: "QAT",
            dialPrefix: "+974"
        );

        [Display(Name = "Republic of the Congo")]
        public Country RepublicOfTheCongo => new Country
        (
            "Republic of the Congo",
            isoNumeric: "178",
            isoAlpha2: "CG",
            isoAlpha3: "COG",
            dialPrefix: "+242"
        );

        [Display(Name = "Réunion")]
        public Country Réunion => new Country
        (
            "Réunion",
            isoNumeric: "638",
            isoAlpha2: "RE",
            isoAlpha3: "REU",
            dialPrefix: "+262"
        );

        [Display(Name = "Romania")]
        public Country Romania => new Country
        (
            "Romania",
            isoNumeric: "642",
            isoAlpha2: "RO",
            isoAlpha3: "ROU",
            dialPrefix: "+40"
        );

        [Display(Name = "Russia")]
        public Country Russia => new Country
        (
            "Russia",
            isoNumeric: "643",
            isoAlpha2: "RU",
            isoAlpha3: "RUS",
            dialPrefix: "+7"
        );

        [Display(Name = "Rwanda")]
        public Country Rwanda => new Country
        (
            "Rwanda",
            isoNumeric: "646",
            isoAlpha2: "RW",
            isoAlpha3: "RWA",
            dialPrefix: "+250"
        );

        [Display(Name = "Saint Barthélemy")]
        public Country SaintBarthélemy => new Country
        (
            "Saint Barthélemy",
            isoNumeric: "652",
            isoAlpha2: "BL",
            isoAlpha3: "BLM",
            dialPrefix: "+590"
        );

        [Display(Name = "Saint Helena")]
        public Country SaintHelena => new Country
        (
            "Saint Helena",
            isoNumeric: "654",
            isoAlpha2: "SH",
            isoAlpha3: "SHN",
            dialPrefix: "+290"
        );

        [Display(Name = "Saint Kitts and Nevis")]
        public Country SaintKittsAndNevis => new Country
        (
            "Saint Kitts and Nevis",
            isoNumeric: "659",
            isoAlpha2: "KN",
            isoAlpha3: "KNA",
            dialPrefix: "+1-869"
        );

        [Display(Name = "Saint Martin")]
        public Country SaintMartin => new Country
        (
            "Saint Martin",
            isoNumeric: "663",
            isoAlpha2: "MF",
            isoAlpha3: "MAF",
            dialPrefix: "+590"
        );

        [Display(Name = "Saint Pierre and Miquelon")]
        public Country SaintPierreAndMiquelon => new Country
        (
            "Saint Pierre and Miquelon",
            isoNumeric: "666",
            isoAlpha2: "PM",
            isoAlpha3: "SPM",
            dialPrefix: "+508"
        );

        [Display(Name = "Saint Vincent and the Grenadines")]
        public Country SaintVincentAndTheGrenadines => new Country
        (
            "Saint Vincent and the Grenadines",
            isoNumeric: "670",
            isoAlpha2: "VC",
            isoAlpha3: "VCT",
            dialPrefix: "+1-784"
        );

        [Display(Name = "Samoa")]
        public Country Samoa => new Country
        (
            "Samoa",
            isoNumeric: "882",
            isoAlpha2: "WS",
            isoAlpha3: "WSM",
            dialPrefix: "+685"
        );

        [Display(Name = "San Marino")]
        public Country SanMarino => new Country
        (
            "San Marino",
            isoNumeric: "674",
            isoAlpha2: "SM",
            isoAlpha3: "SMR",
            dialPrefix: "+378"
        );

        [Display(Name = "Sao Tomé and Príncipe")]
        public Country SaoToméAndPríncipe => new Country
        (
            "Sao Tomé and Príncipe",
            isoNumeric: "678",
            isoAlpha2: "ST",
            isoAlpha3: "STP",
            dialPrefix: "+239"
        );

        [Display(Name = "Saudi Arabia")]
        public Country SaudiArabia => new Country
        (
            "Saudi Arabia",
            isoNumeric: "682",
            isoAlpha2: "SA",
            isoAlpha3: "SAU",
            dialPrefix: "+966"
        );

        [Display(Name = "Senegal")]
        public Country Senegal => new Country
        (
            "Senegal",
            isoNumeric: "686",
            isoAlpha2: "SN",
            isoAlpha3: "SEN",
            dialPrefix: "+221"
        );

        [Display(Name = "Serbia")]
        public Country Serbia => new Country
        (
            "Serbia",
            isoNumeric: "688",
            isoAlpha2: "RS",
            isoAlpha3: "SRB",
            dialPrefix: "+381"
        );

        [Display(Name = "Seychelles")]
        public Country Seychelles => new Country
        (
            "Seychelles",
            isoNumeric: "690",
            isoAlpha2: "SC",
            isoAlpha3: "SYC",
            dialPrefix: "+248"
        );

        [Display(Name = "Sierra Leone")]
        public Country SierraLeone => new Country
        (
            "Sierra Leone",
            isoNumeric: "694",
            isoAlpha2: "SL",
            isoAlpha3: "SLE",
            dialPrefix: "+232"
        );

        [Display(Name = "Singapore")]
        public Country Singapore => new Country
        (
            "Singapore",
            isoNumeric: "702",
            isoAlpha2: "SG",
            isoAlpha3: "SGP",
            dialPrefix: "+65"
        );

        [Display(Name = "Slovakia")]
        public Country Slovakia => new Country
        (
            "Slovakia",
            isoNumeric: "703",
            isoAlpha2: "SK",
            isoAlpha3: "SVK",
            dialPrefix: "+421"
        );

        [Display(Name = "Slovenia")]
        public Country Slovenia => new Country
        (
            "Slovenia",
            isoNumeric: "705",
            isoAlpha2: "SI",
            isoAlpha3: "SVN",
            dialPrefix: "+386"
        );

        [Display(Name = "Solomon Islands")]
        public Country SolomonIslands => new Country
        (
            "Solomon Islands",
            isoNumeric: "090",
            isoAlpha2: "SB",
            isoAlpha3: "SLB",
            dialPrefix: "+677"
        );

        [Display(Name = "Somalia")]
        public Country Somalia => new Country
        (
            "Somalia",
            isoNumeric: "706",
            isoAlpha2: "SO",
            isoAlpha3: "SOM",
            dialPrefix: "+252"
        );

        [Display(Name = "South Africa")]
        public Country SouthAfrica => new Country
        (
            "South Africa",
            isoNumeric: "710",
            isoAlpha2: "ZA",
            isoAlpha3: "ZAF",
            dialPrefix: "+27"
        );

        [Display(Name = "South Korea")]
        public Country SouthKorea => new Country
        (
            "South Korea",
            isoNumeric: "410",
            isoAlpha2: "KR",
            isoAlpha3: "KOR",
            dialPrefix: "+82"
        );

        [Display(Name = "Spain")]
        public Country Spain => new Country
        (
            "Spain",
            isoNumeric: "724",
            isoAlpha2: "ES",
            isoAlpha3: "ESP",
            dialPrefix: "+34"
        );

        [Display(Name = "Sri Lanka")]
        public Country SriLanka => new Country
        (
            "Sri Lanka",
            isoNumeric: "144",
            isoAlpha2: "LK",
            isoAlpha3: "LKA",
            dialPrefix: "+94"
        );

        [Display(Name = "St. Lucia")]
        public Country StLucia => new Country
        (
            "St. Lucia",
            isoNumeric: "662",
            isoAlpha2: "LC",
            isoAlpha3: "LCA",
            dialPrefix: "+1-758"
        );

        [Display(Name = "Sudan")]
        public Country Sudan => new Country
        (
            "Sudan",
            isoNumeric: "729",
            isoAlpha2: "SD",
            isoAlpha3: "SDN",
            dialPrefix: "+249"
        );

        [Display(Name = "Suriname")]
        public Country Suriname => new Country
        (
            "Suriname",
            isoNumeric: "740",
            isoAlpha2: "SR",
            isoAlpha3: "SUR",
            dialPrefix: "+597"
        );

        [Display(Name = "Swaziland")]
        public Country Swaziland => new Country
        (
            "Swaziland",
            isoNumeric: "748",
            isoAlpha2: "SZ",
            isoAlpha3: "SWZ",
            dialPrefix: "+268"
        );

        [Display(Name = "Sweden")]
        public Country Sweden => new Country
        (
            "Sweden",
            isoNumeric: "752",
            isoAlpha2: "SE",
            isoAlpha3: "SWE",
            dialPrefix: "+46"
        );

        [Display(Name = "Switzerland")]
        public Country Switzerland => new Country
        (
            "Switzerland",
            isoNumeric: "756",
            isoAlpha2: "CH",
            isoAlpha3: "CHE",
            dialPrefix: "+41"
        );

        [Display(Name = "Syria")]
        public Country Syria => new Country
        (
            "Syria",
            isoNumeric: "760",
            isoAlpha2: "SY",
            isoAlpha3: "SYR",
            dialPrefix: "+963"
        );

        [Display(Name = "Taiwan")]
        public Country Taiwan => new Country
        (
            "Taiwan",
            isoNumeric: "158",
            isoAlpha2: "TW",
            isoAlpha3: "TWN",
            dialPrefix: "+886"
        );

        [Display(Name = "Tajikistan")]
        public Country Tajikistan => new Country
        (
            "Tajikistan",
            isoNumeric: "762",
            isoAlpha2: "TJ",
            isoAlpha3: "TJK",
            dialPrefix: "+992"
        );

        [Display(Name = "Tanzania")]
        public Country Tanzania => new Country
        (
            "Tanzania",
            isoNumeric: "834",
            isoAlpha2: "TZ",
            isoAlpha3: "TZA",
            dialPrefix: "+255"
        );

        [Display(Name = "Thailand")]
        public Country Thailand => new Country
        (
            "Thailand",
            isoNumeric: "764",
            isoAlpha2: "TH",
            isoAlpha3: "THA",
            dialPrefix: "+66"
        );

        [Display(Name = "The Bahamas")]
        public Country TheBahamas => new Country
        (
            "The Bahamas",
            isoNumeric: "044",
            isoAlpha2: "BS",
            isoAlpha3: "BHS",
            dialPrefix: "+1-242"
        );

        [Display(Name = "The Gambia")]
        public Country TheGambia => new Country
        (
            "The Gambia",
            isoNumeric: "270",
            isoAlpha2: "GM",
            isoAlpha3: "GMB",
            dialPrefix: "+220"
        );

        [Display(Name = "Timor-Leste")]
        public Country TimorLeste => new Country
        (
            "Timor-Leste",
            isoNumeric: "626",
            isoAlpha2: "TL",
            isoAlpha3: "TLS",
            dialPrefix: "+670"
        );

        [Display(Name = "Togo")]
        public Country Togo => new Country
        (
            "Togo",
            isoNumeric: "768",
            isoAlpha2: "TG",
            isoAlpha3: "TGO",
            dialPrefix: "+228"
        );

        [Display(Name = "Tokelau")]
        public Country Tokelau => new Country
        (
            "Tokelau",
            isoNumeric: "772",
            isoAlpha2: "TK",
            isoAlpha3: "TKL",
            dialPrefix: "+690"
        );

        [Display(Name = "Tonga")]
        public Country Tonga => new Country
        (
            "Tonga",
            isoNumeric: "776",
            isoAlpha2: "TO",
            isoAlpha3: "TON",
            dialPrefix: "+676"
        );

        [Display(Name = "Trinidad and Tobago")]
        public Country TrinidadAndTobago => new Country
        (
            "Trinidad and Tobago",
            isoNumeric: "780",
            isoAlpha2: "TT",
            isoAlpha3: "TTO",
            dialPrefix: "+1-868"
        );

        [Display(Name = "Tunisia")]
        public Country Tunisia => new Country
        (
            "Tunisia",
            isoNumeric: "788",
            isoAlpha2: "TN",
            isoAlpha3: "TUN",
            dialPrefix: "+216"
        );

        [Display(Name = "Turkey")]
        public Country Turkey => new Country
        (
            "Turkey",
            isoNumeric: "792",
            isoAlpha2: "TR",
            isoAlpha3: "TUR",
            dialPrefix: "+90"
        );

        [Display(Name = "Turkmenistan")]
        public Country Turkmenistan => new Country
        (
            "Turkmenistan",
            isoNumeric: "795",
            isoAlpha2: "TM",
            isoAlpha3: "TKM",
            dialPrefix: "+993"
        );

        [Display(Name = "Turks and Caicos Islands")]
        public Country TurksAndCaicosIslands => new Country
        (
            "Turks and Caicos Islands",
            isoNumeric: "796",
            isoAlpha2: "TC",
            isoAlpha3: "TCA",
            dialPrefix: "+1-649"
        );

        [Display(Name = "Tuvalu")]
        public Country Tuvalu => new Country
        (
            "Tuvalu",
            isoNumeric: "798",
            isoAlpha2: "TV",
            isoAlpha3: "TUV",
            dialPrefix: "+688"
        );

        [Display(Name = "Uganda")]
        public Country Uganda => new Country
        (
            "Uganda",
            isoNumeric: "800",
            isoAlpha2: "UG",
            isoAlpha3: "UGA",
            dialPrefix: "+256"
        );

        [Display(Name = "Ukraine")]
        public Country Ukraine => new Country
        (
            "Ukraine",
            isoNumeric: "804",
            isoAlpha2: "UA",
            isoAlpha3: "UKR",
            dialPrefix: "+380"
        );

        [Display(Name = "United Arab Emirates")]
        public Country UnitedArabEmirates => new Country
        (
            "United Arab Emirates",
            isoNumeric: "784",
            isoAlpha2: "AE",
            isoAlpha3: "ARE",
            dialPrefix: "+971"
        );

        [Display(Name = "United Kingdom")]
        public Country UnitedKingdom => new Country
        (
            "United Kingdom",
            isoNumeric: "826",
            isoAlpha2: "GB",
            isoAlpha3: "GBR",
            dialPrefix: "+44"
        );

        [Display(Name = "United States")]
        public Country UnitedStates => new Country
        (
            "United States",
            isoNumeric: "840",
            isoAlpha2: "US",
            isoAlpha3: "USA",
            dialPrefix: "+1"
        );

        [Display(Name = "Uruguay")]
        public Country Uruguay => new Country
        (
            "Uruguay",
            isoNumeric: "858",
            isoAlpha2: "UY",
            isoAlpha3: "URY",
            dialPrefix: "+598"
        );

        [Display(Name = "US Virgin Islands")]
        public Country USVirginIslands => new Country
        (
            "US Virgin Islands",
            isoNumeric: "850",
            isoAlpha2: "VI",
            isoAlpha3: "VIR",
            dialPrefix: "+1-340"
        );

        [Display(Name = "Uzbekistan")]
        public Country Uzbekistan => new Country
        (
            "Uzbekistan",
            isoNumeric: "860",
            isoAlpha2: "UZ",
            isoAlpha3: "UZB",
            dialPrefix: "+998"
        );

        [Display(Name = "Vanuatu")]
        public Country Vanuatu => new Country
        (
            "Vanuatu",
            isoNumeric: "548",
            isoAlpha2: "VU",
            isoAlpha3: "VUT",
            dialPrefix: "+678"
        );

        [Display(Name = "Vatican City")]
        public Country VaticanCity => new Country
        (
            "Vatican City",
            isoNumeric: "336",
            isoAlpha2: "VA",
            isoAlpha3: "VAT",
            dialPrefix: "+379"
        );

        [Display(Name = "Venezuela")]
        public Country Venezuela => new Country
        (
            "Venezuela",
            isoNumeric: "862",
            isoAlpha2: "VE",
            isoAlpha3: "VEN",
            dialPrefix: "+58"
        );

        [Display(Name = "Vietnam")]
        public Country Vietnam => new Country
        (
            "Vietnam",
            isoNumeric: "704",
            isoAlpha2: "VN",
            isoAlpha3: "VNM",
            dialPrefix: "+84"
        );

        [Display(Name = "Wallis and Futuna")]
        public Country WallisAndFutuna => new Country
        (
            "Wallis and Futuna",
            isoNumeric: "876",
            isoAlpha2: "WF",
            isoAlpha3: "WLF",
            dialPrefix: "+681"
        );

        [Display(Name = "Yemen")]
        public Country Yemen => new Country
        (
            "Yemen",
            isoNumeric: "887",
            isoAlpha2: "YE",
            isoAlpha3: "YEM",
            dialPrefix: "+967"
        );

        [Display(Name = "Zambia")]
        public Country Zambia => new Country
        (
            "Zambia",
            isoNumeric: "894",
            isoAlpha2: "ZM",
            isoAlpha3: "ZMB",
            dialPrefix: "+260"
        );

        [Display(Name = "Zimbabwe")]
        public Country Zimbabwe => new Country
        (
            "Zimbabwe",
            isoNumeric: "716",
            isoAlpha2: "ZW",
            isoAlpha3: "ZWE",
            dialPrefix: "+263"
        );
    }
}