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
        public readonly string DialPrefix { get; }
        public readonly string CurrencyCode { get; }
        public readonly string IsoAlpha2 { get; }
        public readonly string IsoAlpha3 { get; }
        public readonly string IsoNumeric { get; }
        public readonly string Abbreviation => IsoAlpha2;

        public readonly int Id => int.Parse(IsoNumeric);

        public readonly string ThreeCharacterAbbreviation => IsoAlpha3;
        public readonly string TwoCharacterAbbreviation => IsoAlpha2;

        public Country(string name, string? fullName = null,
            string isoNumeric = "000", string isoAlpha3 = "", string isoAlpha2 = "",
            string dialPrefix = "", string currencyCode = "")
        {
            Name = name;
            _fullName = fullName;
            IsoNumeric = isoNumeric;
            IsoAlpha3 = isoAlpha3;
            IsoAlpha2 = isoAlpha2;
            CurrencyCode = currencyCode;
            DialPrefix = dialPrefix;
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
