using System;
using System.Collections.Generic;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    public interface IAbbreviable
    {
        /// <summary>
        /// This returns the preferred, unique abbrevation for an entity if
        /// no specific abbreviation format (e.g. ISO or UN) is requested.
        /// </summary>
        string Abbreviation { get; }
    }

    public interface IThreeCharacterAbbrevation
    {
        string ThreeCharacterAbbreviation { get; }
    }

    public interface ITwoCharacterAbbreviation
    {
        string TwoCharacterAbbreviation { get; }
    }

    /// <summary>
    /// Represents an entity with a formal ISO-assigned abbreviation.
    /// </summary>
    public interface IISOAbbreviable
    {
        /// <summary>
        /// Returns the ISO-assigned abbreviation/code for an entity.
        /// </summary>
        string ISOAbbreviation { get; }
    }

    /// <summary>
    /// Represents an entity with a UN-assigned abbrevation/code.
    /// </summary>
    public interface IUNAbbreviable
    {
        string UNAbbreviation { get; }
        int UNCode { get; }
    }
}
