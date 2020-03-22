using System;
using System.ComponentModel.DataAnnotations;

namespace NeoSmart.Data.Geographical
{
    public partial class UnitedStates
    {
        public struct State : IState, IComparable<State>, IEquatable<State>
        {
            public string FullName => Name;
            public string Name { get; set; }
            public string Abbreviation { get; set; }

            public int CompareTo(State other)
            {
                return Name.CompareTo(other.Name);
            }

            public bool Equals(State other)
            {
                return string.Compare(FullName, other.FullName, true) == 0;
            }
        }

        public static StateFactory States = new StateFactory();

        public class StateFactory : WellKnown<State>
        {
            internal StateFactory()
            {
            }

            [Display(Name = "Alabama")]
            public readonly State Alabama = new State
            {
                Name = "Alabama",
                Abbreviation = "AL",
            };

            [Display(Name = "Alaska")]
            public readonly State Alaska = new State
            {
                Name = "Alaska",
                Abbreviation = "AK",
            };

            [Display(Name = "Arizona")]
            public readonly State Arizona = new State
            {
                Name = "Arizona",
                Abbreviation = "AZ",
            };

            [Display(Name = "Arkansas")]
            public readonly State Arkansas = new State
            {
                Name = "Arkansas",
                Abbreviation = "AR",
            };

            [Display(Name = "California")]
            public readonly State California = new State
            {
                Name = "California",
                Abbreviation = "CA",
            };

            [Display(Name = "Colorado")]
            public readonly State Colorado = new State
            {
                Name = "Colorado",
                Abbreviation = "CO",
            };

            [Display(Name = "Connecticut")]
            public readonly State Connecticut = new State
            {
                Name = "Connecticut",
                Abbreviation = "CT",
            };

            [Display(Name = "Delaware")]
            public readonly State Delaware = new State
            {
                Name = "Delaware",
                Abbreviation = "DE",
            };

            [Display(Name = "District of Columbia")]
            public readonly State DistrictOfColumbia = new State
            {
                Name = "District of Columbia",
                Abbreviation = "DC",
            };

            [Display(Name = "Florida")]
            public readonly State Florida = new State
            {
                Name = "Florida",
                Abbreviation = "FL",
            };

            [Display(Name = "Georgia")]
            public readonly State Georgia = new State
            {
                Name = "Georgia",
                Abbreviation = "GA",
            };

            [Display(Name = "Hawaii")]
            public readonly State Hawaii = new State
            {
                Name = "Hawaii",
                Abbreviation = "HI",
            };

            [Display(Name = "Idaho")]
            public readonly State Idaho = new State
            {
                Name = "Idaho",
                Abbreviation = "ID",
            };

            [Display(Name = "Illinois")]
            public readonly State Illinois = new State
            {
                Name = "Illinois",
                Abbreviation = "IL",
            };

            [Display(Name = "Indiana")]
            public readonly State Indiana = new State
            {
                Name = "Indiana",
                Abbreviation = "IN",
            };

            [Display(Name = "Iowa")]
            public readonly State Iowa = new State
            {
                Name = "Iowa",
                Abbreviation = "IA",
            };

            [Display(Name = "Kansa")]
            public readonly State Kansa = new State
            {
                Name = "Kansa",
                Abbreviation = "KS",
            };

            [Display(Name = "Kentucky")]
            public readonly State Kentucky = new State
            {
                Name = "Kentucky",
                Abbreviation = "KY",
            };

            [Display(Name = "Lousiana")]
            public readonly State Lousiana = new State
            {
                Name = "Lousiana",
                Abbreviation = "LA",
            };

            [Display(Name = "Maine")]
            public readonly State Maine = new State
            {
                Name = "Maine",
                Abbreviation = "ME",
            };

            [Display(Name = "Maryland")]
            public readonly State Maryland = new State
            {
                Name = "Maryland",
                Abbreviation = "MD",
            };

            [Display(Name = "Massachusetts")]
            public readonly State Massachusetts = new State
            {
                Name = "Massachusetts",
                Abbreviation = "MA",
            };

            [Display(Name = "Michigan")]
            public readonly State Michigan = new State
            {
                Name = "Michigan",
                Abbreviation = "MI",
            };

            [Display(Name = "Minnesota")]
            public readonly State Minnesota = new State
            {
                Name = "Minnesota",
                Abbreviation = "MN",
            };

            [Display(Name = "Mississippi")]
            public readonly State Mississippi = new State
            {
                Name = "Mississippi",
                Abbreviation = "MS",
            };

            [Display(Name = "Missouri")]
            public readonly State Missouri = new State
            {
                Name = "Missouri",
                Abbreviation = "MO",
            };

            [Display(Name = "Montana")]
            public readonly State Montana = new State
            {
                Name = "Montana",
                Abbreviation = "MT",
            };

            [Display(Name = "Nebraska")]
            public readonly State Nebraska = new State
            {
                Name = "Nebraska",
                Abbreviation = "NE",
            };

            [Display(Name = "Nevada")]
            public readonly State Nevada = new State
            {
                Name = "Nevada",
                Abbreviation = "NV",
            };

            [Display(Name = "New Hampshire")]
            public readonly State NewHampshire = new State
            {
                Name = "New Hampshire",
                Abbreviation = "NH",
            };

            [Display(Name = "New Jersey")]
            public readonly State NewJersey = new State
            {
                Name = "New Jersey",
                Abbreviation = "NJ",
            };

            [Display(Name = "New Mexico")]
            public readonly State NewMexico = new State
            {
                Name = "New Mexico",
                Abbreviation = "NM",
            };

            [Display(Name = "New York")]
            public readonly State NewYork = new State
            {
                Name = "New York",
                Abbreviation = "NY",
            };

            [Display(Name = "North Carolina")]
            public readonly State NorthCarolina = new State
            {
                Name = "North Carolina",
                Abbreviation = "NC",
            };

            [Display(Name = "North Dakota")]
            public readonly State NorthDakota = new State
            {
                Name = "North Dakota",
                Abbreviation = "ND",
            };

            [Display(Name = "Ohio")]
            public readonly State Ohio = new State
            {
                Name = "Ohio",
                Abbreviation = "OH",
            };

            [Display(Name = "Oklahoma")]
            public readonly State Oklahoma = new State
            {
                Name = "Oklahoma",
                Abbreviation = "OK",
            };

            [Display(Name = "Oregon")]
            public readonly State Oregon = new State
            {
                Name = "Oregon",
                Abbreviation = "OR",
            };

            [Display(Name = "Pennsylvania")]
            public readonly State Pennsylvania = new State
            {
                Name = "Pennsylvania",
                Abbreviation = "PA",
            };

            [Display(Name = "Rhode Island")]
            public readonly State RhodeIsland = new State
            {
                Name = "Rhode Island",
                Abbreviation = "RI",
            };

            [Display(Name = "South Carolina")]
            public readonly State SouthCarolina = new State
            {
                Name = "South Carolina",
                Abbreviation = "SC",
            };

            [Display(Name = "South Dakota")]
            public readonly State SouthDakota = new State
            {
                Name = "South Dakota",
                Abbreviation = "SD",
            };

            [Display(Name = "Tennessee")]
            public readonly State Tennessee = new State
            {
                Name = "Tennessee",
                Abbreviation = "TN",
            };

            [Display(Name = "Texas")]
            public readonly State Texas = new State
            {
                Name = "Texas",
                Abbreviation = "TX",
            };

            [Display(Name = "Utah")]
            public readonly State Utah = new State
            {
                Name = "Utah",
                Abbreviation = "UT",
            };

            [Display(Name = "Vermont")]
            public readonly State Vermont = new State
            {
                Name = "Vermont",
                Abbreviation = "VT",
            };

            [Display(Name = "Virginia")]
            public readonly State Virginia = new State
            {
                Name = "Virginia",
                Abbreviation = "VA",
            };

            [Display(Name = "Washington")]
            public readonly State Washington = new State
            {
                Name = "Washington",
                Abbreviation = "WA",
            };

            [Display(Name = "West Virginia")]
            public readonly State WestVirginia = new State
            {
                Name = "West Virginia",
                Abbreviation = "WV",
            };

            [Display(Name = "Wisconsin")]
            public readonly State Wisconsin = new State
            {
                Name = "Wisconsin",
                Abbreviation = "WI",
            };

            [Display(Name = "Wyoming")]
            public readonly State Wyoming = new State
            {
                Name = "Wyoming",
                Abbreviation = "WY",
            };

        }
    }
}