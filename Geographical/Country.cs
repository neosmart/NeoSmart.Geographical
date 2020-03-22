using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    // If we ever change this to a class, we need to revisit the comparison operators for null checking
    public struct Country : ICountry, IComparable<Country>, IEquatable<Country>
    {
        private string _fullName;
        public string FullName
        {
            get => _fullName ?? Name;
            set => _fullName = value;
        }

        public string Name { get; set; }
        public string ISOAbbreviation { get; set; }
        public string UNAbbreviation { get; set; }
        public int UNCode { get; set; }
        public string Abbreviation => UNAbbreviation;

        public int Id => UNCode;

        public string ThreeCharacterAbbreviation => UNAbbreviation;
        public string TwoCharacterAbbreviation => ISOAbbreviation;

        public Country(string name, string fullName = null, int unCode = 0, string unAbbreviation = null, string isoAbbreviation = null)
        {
            Name = name;
            _fullName = fullName;
            UNCode = unCode;
            UNAbbreviation = unAbbreviation;
            ISOAbbreviation = isoAbbreviation;
        }

        private static Dictionary<string, Country> ReverseLookup { get; set; } = new Dictionary<string, Country>();

        public Country(string search)
        {
            if (ReverseLookup.Count == 0)
            {
                lock (ReverseLookup)
                {
                    if (ReverseLookup.Count == 0)
                    {
                    }
                }
            }

            var result = ReverseLookup[search];
            _fullName = result._fullName;
            Name = result.Name;
            UNCode = result.UNCode;
            UNAbbreviation = result.UNAbbreviation;
            ISOAbbreviation = result.ISOAbbreviation;
        }

        public int CompareTo(Country other)
        {
            if ((object)this == (object)other)
            {
                return 0;
            }

#if NETSTANDARD1_3
            return string.Compare(Name, other.Name, StringComparison.CurrentCultureIgnoreCase);
#else
            return string.Compare(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
#endif
        }

        public bool Equals(Country other)
        {
            return CompareTo(other) == 0;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Name.ToLowerInvariant().GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator ==(Country a, Country b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Country a, Country b)
        {
            return !a.Equals(b);
        }
    }
}
