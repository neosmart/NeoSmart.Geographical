using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System;

namespace NeoSmart.Geographical
{
    public static partial class UnitedStates
    {
        public static StateFactory States => new StateFactory();

        public readonly struct State : IState, IComparable<State>, IEquatable<State>
        {
            public readonly string FullName => Name;
            public readonly string Name { get; }
            public readonly string Abbreviation { get; }

            public State(string name, string abbreviation = "")
            {
                Name = name;
                Abbreviation = abbreviation;
            }

            public int CompareTo(State other)
            {
                return FullName.CompareTo(other.FullName);
            }

            public bool Equals(State other)
            {
                return string.Compare(FullName, other.FullName, true) == 0;
            }

            public override bool Equals(object obj)
            {
                return obj is State state && Equals(state);
            }

            public override int GetHashCode()
            {
                return FullName.ToLowerInvariant().GetHashCode();
            }

            public static bool operator ==(State left, State right)
            {
                return left.Equals(right);
            }

            public static bool operator !=(State left, State right)
            {
                return !(left == right);
            }
        }

        public class StateFactory : WellKnown<State>
        {
            protected override IEnumerable<Func<State, string>> Indexers =>
                new Func<State, string>[]
                {
                    state => state.Name,
                    state => state.Abbreviation,
                };

            [Display(Name = "Alabama")]
            public State Alabama => new State
            (
                "Alabama",
                abbreviation: "AL"
            );

            [Display(Name = "Alaska")]
            public State Alaska => new State
            (
                "Alaska",
                abbreviation: "AK"
            );

            [Display(Name = "Arizona")]
            public State Arizona => new State
            (
                "Arizona",
                abbreviation: "AZ"
            );

            [Display(Name = "Arkansas")]
            public State Arkansas => new State
            (
                "Arkansas",
                abbreviation: "AR"
            );

            [Display(Name = "California")]
            public State California => new State
            (
                "California",
                abbreviation: "CA"
            );

            [Display(Name = "Colorado")]
            public State Colorado => new State
            (
                "Colorado",
                abbreviation: "CO"
            );

            [Display(Name = "Connecticut")]
            public State Connecticut => new State
            (
                "Connecticut",
                abbreviation: "CT"
            );

            [Display(Name = "Delaware")]
            public State Delaware => new State
            (
                "Delaware",
                abbreviation: "DE"
            );

            [Display(Name = "District of Columbia")]
            public State DistrictOfColumbia => new State
            (
                "District of Columbia",
                abbreviation: "DC"
            );

            [Display(Name = "Florida")]
            public State Florida => new State
            (
                "Florida",
                abbreviation: "FL"
            );

            [Display(Name = "Georgia")]
            public State Georgia => new State
            (
                "Georgia",
                abbreviation: "GA"
            );

            [Display(Name = "Hawaii")]
            public State Hawaii => new State
            (
                "Hawaii",
                abbreviation: "HI"
            );

            [Display(Name = "Idaho")]
            public State Idaho => new State
            (
                "Idaho",
                abbreviation: "ID"
            );

            [Display(Name = "Illinois")]
            public State Illinois => new State
            (
                "Illinois",
                abbreviation: "IL"
            );

            [Display(Name = "Indiana")]
            public State Indiana => new State
            (
                "Indiana",
                abbreviation: "IN"
            );

            [Display(Name = "Iowa")]
            public State Iowa => new State
            (
                "Iowa",
                abbreviation: "IA"
            );

            [Display(Name = "Kansa")]
            public State Kansa => new State
            (
                "Kansa",
                abbreviation: "KS"
            );

            [Display(Name = "Kentucky")]
            public State Kentucky => new State
            (
                "Kentucky",
                abbreviation: "KY"
            );

            [Display(Name = "Louisiana")]
            public State Louisiana => new State
            (
                "Louisiana",
                abbreviation: "LA"
            );

            [Display(Name = "Maine")]
            public State Maine => new State
            (
                "Maine",
                abbreviation: "ME"
            );

            [Display(Name = "Maryland")]
            public State Maryland => new State
            (
                "Maryland",
                abbreviation: "MD"
            );

            [Display(Name = "Massachusetts")]
            public State Massachusetts => new State
            (
                "Massachusetts",
                abbreviation: "MA"
            );

            [Display(Name = "Michigan")]
            public State Michigan => new State
            (
                "Michigan",
                abbreviation: "MI"
            );

            [Display(Name = "Minnesota")]
            public State Minnesota => new State
            (
                "Minnesota",
                abbreviation: "MN"
            );

            [Display(Name = "Mississippi")]
            public State Mississippi => new State
            (
                "Mississippi",
                abbreviation: "MS"
            );

            [Display(Name = "Missouri")]
            public State Missouri => new State
            (
                "Missouri",
                abbreviation: "MO"
            );

            [Display(Name = "Montana")]
            public State Montana => new State
            (
                "Montana",
                abbreviation: "MT"
            );

            [Display(Name = "Nebraska")]
            public State Nebraska => new State
            (
                "Nebraska",
                abbreviation: "NE"
            );

            [Display(Name = "Nevada")]
            public State Nevada => new State
            (
                "Nevada",
                abbreviation: "NV"
            );

            [Display(Name = "New Hampshire")]
            public State NewHampshire => new State
            (
                "New Hampshire",
                abbreviation: "NH"
            );

            [Display(Name = "New Jersey")]
            public State NewJersey => new State
            (
                "New Jersey",
                abbreviation: "NJ"
            );

            [Display(Name = "New Mexico")]
            public State NewMexico => new State
            (
                "New Mexico",
                abbreviation: "NM"
            );

            [Display(Name = "New York")]
            public State NewYork => new State
            (
                "New York",
                abbreviation: "NY"
            );

            [Display(Name = "North Carolina")]
            public State NorthCarolina => new State
            (
                "North Carolina",
                abbreviation: "NC"
            );

            [Display(Name = "North Dakota")]
            public State NorthDakota => new State
            (
                "North Dakota",
                abbreviation: "ND"
            );

            [Display(Name = "Ohio")]
            public State Ohio => new State
            (
                "Ohio",
                abbreviation: "OH"
            );

            [Display(Name = "Oklahoma")]
            public State Oklahoma => new State
            (
                "Oklahoma",
                abbreviation: "OK"
            );

            [Display(Name = "Oregon")]
            public State Oregon => new State
            (
                "Oregon",
                abbreviation: "OR"
            );

            [Display(Name = "Pennsylvania")]
            public State Pennsylvania => new State
            (
                "Pennsylvania",
                abbreviation: "PA"
            );

            [Display(Name = "Rhode Island")]
            public State RhodeIsland => new State
            (
                "Rhode Island",
                abbreviation: "RI"
            );

            [Display(Name = "South Carolina")]
            public State SouthCarolina => new State
            (
                "South Carolina",
                abbreviation: "SC"
            );

            [Display(Name = "South Dakota")]
            public State SouthDakota => new State
            (
                "South Dakota",
                abbreviation: "SD"
            );

            [Display(Name = "Tennessee")]
            public State Tennessee => new State
            (
                "Tennessee",
                abbreviation: "TN"
            );

            [Display(Name = "Texas")]
            public State Texas => new State
            (
                "Texas",
                abbreviation: "TX"
            );

            [Display(Name = "Utah")]
            public State Utah => new State
            (
                "Utah",
                abbreviation: "UT"
            );

            [Display(Name = "Vermont")]
            public State Vermont => new State
            (
                "Vermont",
                abbreviation: "VT"
            );

            [Display(Name = "Virginia")]
            public State Virginia => new State
            (
                "Virginia",
                abbreviation: "VA"
            );

            [Display(Name = "Washington")]
            public State Washington => new State
            (
                "Washington",
                abbreviation: "WA"
            );

            [Display(Name = "West Virginia")]
            public State WestVirginia => new State
            (
                "West Virginia",
                abbreviation: "WV"
            );

            [Display(Name = "Wisconsin")]
            public State Wisconsin => new State
            (
                "Wisconsin",
                abbreviation: "WI"
            );

            [Display(Name = "Wyoming")]
            public State Wyoming => new State
            (
                "Wyoming",
                abbreviation: "WY"
            );


            // Begin US Territories

            [Display(Name = "American Samoa")]
            public State AmericanSamoa => new State
            (
                "American Samoa",
                abbreviation: "AS"
            );

            [Display(Name = "Guam")]
            public State Guam => new State
            (
                "Guam",
                abbreviation: "GU"
            );

            [Display(Name = "Northern Mariana Islands")]
            public State NorthernMarianaIslands => new State
            (
                "Northern Mariana Islands",
                abbreviation: "MP"
            );

            [Display(Name = "Puerto Rico")]
            public State PuertoRico => new State
            (
                "Puerto Rico",
                abbreviation: "PR"
            );

            [Display(Name = "US Virgin Islands")]
            public State UsVirginIslands => new State
            (
                "US Virgin Islands",
                abbreviation: "VI"
            );
        }
    }
}
