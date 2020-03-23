using System;
using System.Collections.Generic;
using System.Reflection;

namespace NeoSmart.Geographical
{
    public readonly struct Country : ICountry, IComparable<Country>, IEquatable<Country>
    {
        private readonly string? _fullName;
        public readonly string FullName
        {
            get => _fullName ?? Name;
        }

        public readonly string Name { get; }
        public readonly string IsoAbbreviation { get; }
        public readonly string UNAbbreviation { get; }
        public readonly int UNCode { get; }
        public readonly string Abbreviation => IsoAbbreviation;

        public readonly int Id => UNCode;

        public readonly string ThreeCharacterAbbreviation => UNAbbreviation;
        public readonly string TwoCharacterAbbreviation => IsoAbbreviation;

        public Country(string name, string? fullName = null, int unCode = 0, string unAbbreviation = "", string isoAbbreviation = "")
        {
            Name = name;
            _fullName = fullName;
            UNCode = unCode;
            UNAbbreviation = unAbbreviation;
            IsoAbbreviation = isoAbbreviation;
        }

        public int CompareTo(Country other)
        {
            if ((object)this == (object)other)
            {
                return 0;
            }

            return string.Compare(Name, other.Name, StringComparison.CurrentCultureIgnoreCase);
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

        public static bool operator <(Country left, Country right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator <=(Country left, Country right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >(Country left, Country right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator >=(Country left, Country right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}
