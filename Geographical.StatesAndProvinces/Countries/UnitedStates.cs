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

            public State(string name, string abbrevation = "")
            {
                Name = name;
                Abbreviation = abbrevation;
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
            protected override IEnumerable<Expression<Func<State, string>>> IndexExpressions =>
                new Expression<Func<State, string>>[]
                {
                    state => state.Name,
                    state => state.Abbreviation,
                };

            [Display(Name = "Alabama")]
            public State Alabama => new State
            (
                "Alabama",
                abbrevation: "AL"
            );

            [Display(Name = "Alaska")]
            public State Alaska => new State
            (
                "Alaska",
                abbrevation: "AK"
            );

            [Display(Name = "Arizona")]
            public State Arizona => new State
            (
                "Arizona",
                abbrevation: "AZ"
            );

            [Display(Name = "Arkansas")]
            public State Arkansas => new State
            (
                "Arkansas",
                abbrevation: "AR"
            );

            [Display(Name = "California")]
            public State California => new State
            (
                "California",
                abbrevation: "CA"
            );

            [Display(Name = "Colorado")]
            public State Colorado => new State
            (
                "Colorado",
                abbrevation: "CO"
            );

            [Display(Name = "Connecticut")]
            public State Connecticut => new State
            (
                "Connecticut",
                abbrevation: "CT"
            );

            [Display(Name = "Delaware")]
            public State Delaware => new State
            (
                "Delaware",
                abbrevation: "DE"
            );

            [Display(Name = "District of Columbia")]
            public State DistrictOfColumbia => new State
            (
                "District of Columbia",
                abbrevation: "DC"
            );

            [Display(Name = "Florida")]
            public State Florida => new State
            (
                "Florida",
                abbrevation: "FL"
            );

            [Display(Name = "Georgia")]
            public State Georgia => new State
            (
                "Georgia",
                abbrevation: "GA"
            );

            [Display(Name = "Hawaii")]
            public State Hawaii => new State
            (
                "Hawaii",
                abbrevation: "HI"
            );

            [Display(Name = "Idaho")]
            public State Idaho => new State
            (
                "Idaho",
                abbrevation: "ID"
            );

            [Display(Name = "Illinois")]
            public State Illinois => new State
            (
                "Illinois",
                abbrevation: "IL"
            );

            [Display(Name = "Indiana")]
            public State Indiana => new State
            (
                "Indiana",
                abbrevation: "IN"
            );

            [Display(Name = "Iowa")]
            public State Iowa => new State
            (
                "Iowa",
                abbrevation: "IA"
            );

            [Display(Name = "Kansa")]
            public State Kansa => new State
            (
                "Kansa",
                abbrevation: "KS"
            );

            [Display(Name = "Kentucky")]
            public State Kentucky => new State
            (
                "Kentucky",
                abbrevation: "KY"
            );

            [Display(Name = "Lousiana")]
            public State Lousiana => new State
            (
                "Lousiana",
                abbrevation: "LA"
            );

            [Display(Name = "Maine")]
            public State Maine => new State
            (
                "Maine",
                abbrevation: "ME"
            );

            [Display(Name = "Maryland")]
            public State Maryland => new State
            (
                "Maryland",
                abbrevation: "MD"
            );

            [Display(Name = "Massachusetts")]
            public State Massachusetts => new State
            (
                "Massachusetts",
                abbrevation: "MA"
            );

            [Display(Name = "Michigan")]
            public State Michigan => new State
            (
                "Michigan",
                abbrevation: "MI"
            );

            [Display(Name = "Minnesota")]
            public State Minnesota => new State
            (
                "Minnesota",
                abbrevation: "MN"
            );

            [Display(Name = "Mississippi")]
            public State Mississippi => new State
            (
                "Mississippi",
                abbrevation: "MS"
            );

            [Display(Name = "Missouri")]
            public State Missouri => new State
            (
                "Missouri",
                abbrevation: "MO"
            );

            [Display(Name = "Montana")]
            public State Montana => new State
            (
                "Montana",
                abbrevation: "MT"
            );

            [Display(Name = "Nebraska")]
            public State Nebraska => new State
            (
                "Nebraska",
                abbrevation: "NE"
            );

            [Display(Name = "Nevada")]
            public State Nevada => new State
            (
                "Nevada",
                abbrevation: "NV"
            );

            [Display(Name = "New Hampshire")]
            public State NewHampshire => new State
            (
                "New Hampshire",
                abbrevation: "NH"
            );

            [Display(Name = "New Jersey")]
            public State NewJersey => new State
            (
                "New Jersey",
                abbrevation: "NJ"
            );

            [Display(Name = "New Mexico")]
            public State NewMexico => new State
            (
                "New Mexico",
                abbrevation: "NM"
            );

            [Display(Name = "New York")]
            public State NewYork => new State
            (
                "New York",
                abbrevation: "NY"
            );

            [Display(Name = "North Carolina")]
            public State NorthCarolina => new State
            (
                "North Carolina",
                abbrevation: "NC"
            );

            [Display(Name = "North Dakota")]
            public State NorthDakota => new State
            (
                "North Dakota",
                abbrevation: "ND"
            );

            [Display(Name = "Ohio")]
            public State Ohio => new State
            (
                "Ohio",
                abbrevation: "OH"
            );

            [Display(Name = "Oklahoma")]
            public State Oklahoma => new State
            (
                "Oklahoma",
                abbrevation: "OK"
            );

            [Display(Name = "Oregon")]
            public State Oregon => new State
            (
                "Oregon",
                abbrevation: "OR"
            );

            [Display(Name = "Pennsylvania")]
            public State Pennsylvania => new State
            (
                "Pennsylvania",
                abbrevation: "PA"
            );

            [Display(Name = "Rhode Island")]
            public State RhodeIsland => new State
            (
                "Rhode Island",
                abbrevation: "RI"
            );

            [Display(Name = "South Carolina")]
            public State SouthCarolina => new State
            (
                "South Carolina",
                abbrevation: "SC"
            );

            [Display(Name = "South Dakota")]
            public State SouthDakota => new State
            (
                "South Dakota",
                abbrevation: "SD"
            );

            [Display(Name = "Tennessee")]
            public State Tennessee => new State
            (
                "Tennessee",
                abbrevation: "TN"
            );

            [Display(Name = "Texas")]
            public State Texas => new State
            (
                "Texas",
                abbrevation: "TX"
            );

            [Display(Name = "Utah")]
            public State Utah => new State
            (
                "Utah",
                abbrevation: "UT"
            );

            [Display(Name = "Vermont")]
            public State Vermont => new State
            (
                "Vermont",
                abbrevation: "VT"
            );

            [Display(Name = "Virginia")]
            public State Virginia => new State
            (
                "Virginia",
                abbrevation: "VA"
            );

            [Display(Name = "Washington")]
            public State Washington => new State
            (
                "Washington",
                abbrevation: "WA"
            );

            [Display(Name = "West Virginia")]
            public State WestVirginia => new State
            (
                "West Virginia",
                abbrevation: "WV"
            );

            [Display(Name = "Wisconsin")]
            public State Wisconsin => new State
            (
                "Wisconsin",
                abbrevation: "WI"
            );

            [Display(Name = "Wyoming")]
            public State Wyoming => new State
            (
                "Wyoming",
                abbrevation: "WY"
            );

        }
    }
}