using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System;

namespace NeoSmart.Geographical
{
    public static partial class UnitedStates
    {
        public static StateFactory States = new StateFactory();

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

            internal StateFactory()
            {
            }

            [Display(Name = "Alabama")]
            public readonly State Alabama = new State
            (
                "Alabama",
                abbrevation: "AL"
            );

            [Display(Name = "Alaska")]
            public readonly State Alaska = new State
            (
                "Alaska",
                abbrevation: "AK"
            );

            [Display(Name = "Arizona")]
            public readonly State Arizona = new State
            (
                "Arizona",
                abbrevation: "AZ"
            );

            [Display(Name = "Arkansas")]
            public readonly State Arkansas = new State
            (
                "Arkansas",
                abbrevation: "AR"
            );

            [Display(Name = "California")]
            public readonly State California = new State
            (
                "California",
                abbrevation: "CA"
            );

            [Display(Name = "Colorado")]
            public readonly State Colorado = new State
            (
                "Colorado",
                abbrevation: "CO"
            );

            [Display(Name = "Connecticut")]
            public readonly State Connecticut = new State
            (
                "Connecticut",
                abbrevation: "CT"
            );

            [Display(Name = "Delaware")]
            public readonly State Delaware = new State
            (
                "Delaware",
                abbrevation: "DE"
            );

            [Display(Name = "District of Columbia")]
            public readonly State DistrictOfColumbia = new State
            (
                "District of Columbia",
                abbrevation: "DC"
            );

            [Display(Name = "Florida")]
            public readonly State Florida = new State
            (
                "Florida",
                abbrevation: "FL"
            );

            [Display(Name = "Georgia")]
            public readonly State Georgia = new State
            (
                "Georgia",
                abbrevation: "GA"
            );

            [Display(Name = "Hawaii")]
            public readonly State Hawaii = new State
            (
                "Hawaii",
                abbrevation: "HI"
            );

            [Display(Name = "Idaho")]
            public readonly State Idaho = new State
            (
                "Idaho",
                abbrevation: "ID"
            );

            [Display(Name = "Illinois")]
            public readonly State Illinois = new State
            (
                "Illinois",
                abbrevation: "IL"
            );

            [Display(Name = "Indiana")]
            public readonly State Indiana = new State
            (
                "Indiana",
                abbrevation: "IN"
            );

            [Display(Name = "Iowa")]
            public readonly State Iowa = new State
            (
                "Iowa",
                abbrevation: "IA"
            );

            [Display(Name = "Kansa")]
            public readonly State Kansa = new State
            (
                "Kansa",
                abbrevation: "KS"
            );

            [Display(Name = "Kentucky")]
            public readonly State Kentucky = new State
            (
                "Kentucky",
                abbrevation: "KY"
            );

            [Display(Name = "Lousiana")]
            public readonly State Lousiana = new State
            (
                "Lousiana",
                abbrevation: "LA"
            );

            [Display(Name = "Maine")]
            public readonly State Maine = new State
            (
                "Maine",
                abbrevation: "ME"
            );

            [Display(Name = "Maryland")]
            public readonly State Maryland = new State
            (
                "Maryland",
                abbrevation: "MD"
            );

            [Display(Name = "Massachusetts")]
            public readonly State Massachusetts = new State
            (
                "Massachusetts",
                abbrevation: "MA"
            );

            [Display(Name = "Michigan")]
            public readonly State Michigan = new State
            (
                "Michigan",
                abbrevation: "MI"
            );

            [Display(Name = "Minnesota")]
            public readonly State Minnesota = new State
            (
                "Minnesota",
                abbrevation: "MN"
            );

            [Display(Name = "Mississippi")]
            public readonly State Mississippi = new State
            (
                "Mississippi",
                abbrevation: "MS"
            );

            [Display(Name = "Missouri")]
            public readonly State Missouri = new State
            (
                "Missouri",
                abbrevation: "MO"
            );

            [Display(Name = "Montana")]
            public readonly State Montana = new State
            (
                "Montana",
                abbrevation: "MT"
            );

            [Display(Name = "Nebraska")]
            public readonly State Nebraska = new State
            (
                "Nebraska",
                abbrevation: "NE"
            );

            [Display(Name = "Nevada")]
            public readonly State Nevada = new State
            (
                "Nevada",
                abbrevation: "NV"
            );

            [Display(Name = "New Hampshire")]
            public readonly State NewHampshire = new State
            (
                "New Hampshire",
                abbrevation: "NH"
            );

            [Display(Name = "New Jersey")]
            public readonly State NewJersey = new State
            (
                "New Jersey",
                abbrevation: "NJ"
            );

            [Display(Name = "New Mexico")]
            public readonly State NewMexico = new State
            (
                "New Mexico",
                abbrevation: "NM"
            );

            [Display(Name = "New York")]
            public readonly State NewYork = new State
            (
                "New York",
                abbrevation: "NY"
            );

            [Display(Name = "North Carolina")]
            public readonly State NorthCarolina = new State
            (
                "North Carolina",
                abbrevation: "NC"
            );

            [Display(Name = "North Dakota")]
            public readonly State NorthDakota = new State
            (
                "North Dakota",
                abbrevation: "ND"
            );

            [Display(Name = "Ohio")]
            public readonly State Ohio = new State
            (
                "Ohio",
                abbrevation: "OH"
            );

            [Display(Name = "Oklahoma")]
            public readonly State Oklahoma = new State
            (
                "Oklahoma",
                abbrevation: "OK"
            );

            [Display(Name = "Oregon")]
            public readonly State Oregon = new State
            (
                "Oregon",
                abbrevation: "OR"
            );

            [Display(Name = "Pennsylvania")]
            public readonly State Pennsylvania = new State
            (
                "Pennsylvania",
                abbrevation: "PA"
            );

            [Display(Name = "Rhode Island")]
            public readonly State RhodeIsland = new State
            (
                "Rhode Island",
                abbrevation: "RI"
            );

            [Display(Name = "South Carolina")]
            public readonly State SouthCarolina = new State
            (
                "South Carolina",
                abbrevation: "SC"
            );

            [Display(Name = "South Dakota")]
            public readonly State SouthDakota = new State
            (
                "South Dakota",
                abbrevation: "SD"
            );

            [Display(Name = "Tennessee")]
            public readonly State Tennessee = new State
            (
                "Tennessee",
                abbrevation: "TN"
            );

            [Display(Name = "Texas")]
            public readonly State Texas = new State
            (
                "Texas",
                abbrevation: "TX"
            );

            [Display(Name = "Utah")]
            public readonly State Utah = new State
            (
                "Utah",
                abbrevation: "UT"
            );

            [Display(Name = "Vermont")]
            public readonly State Vermont = new State
            (
                "Vermont",
                abbrevation: "VT"
            );

            [Display(Name = "Virginia")]
            public readonly State Virginia = new State
            (
                "Virginia",
                abbrevation: "VA"
            );

            [Display(Name = "Washington")]
            public readonly State Washington = new State
            (
                "Washington",
                abbrevation: "WA"
            );

            [Display(Name = "West Virginia")]
            public readonly State WestVirginia = new State
            (
                "West Virginia",
                abbrevation: "WV"
            );

            [Display(Name = "Wisconsin")]
            public readonly State Wisconsin = new State
            (
                "Wisconsin",
                abbrevation: "WI"
            );

            [Display(Name = "Wyoming")]
            public readonly State Wyoming = new State
            (
                "Wyoming",
                abbrevation: "WY"
            );

        }
    }
}