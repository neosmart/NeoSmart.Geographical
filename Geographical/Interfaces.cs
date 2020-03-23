namespace NeoSmart.Geographical
{
    /// <summary>
    /// Types implementing this interface declare one of their members to be the unique id
    /// </summary>
    public interface IHasId<T>
    {
        T Id { get; }
    }

    public interface IAddressComponent
    {
        /// <summary>
        /// The unabridged, formal name of an entity.
        /// </summary>
        string FullName { get; }

        /// <summary>
        /// Represents the "common name" or "display name" for an entity, that may
        /// or may not align with its official, formal name.
        /// </summary>
        string Name { get; }
    }

    public interface IAdministrativeLevel : IAddressComponent
    {
    }

    /// <summary>
    /// This represents the first administrative level of an address, equivalent
    /// to W3C's address-level1. In the United States, this would be a state;
    /// in Canada, a province; in the United Kingdom a post town; in Switzerland,
    /// a canton; etc.
    /// </summary>
    public interface IAdministrativeLevel1 : IAdministrativeLevel, IAbbreviable
    {
    }

    /// <summary>
    /// This is an alias for IAdministrativeLevel1
    /// </summary>
    public interface IState : IAdministrativeLevel1
    {
    }

    /// <summary>
    /// This represents the first administrative level of an address, equivalent
    /// to W3C's address-level1. This is typically a town, city, village, or other
    /// such locality.
    /// </summary>
    public interface IAdministrativeLevel2 : IAdministrativeLevel
    {
    }

    /// <summary>
    /// This is an alias for IAdministrativeLevel2
    /// </summary>
    public interface ICity : IAdministrativeLevel2
    {
    }

    public interface ICountry : IHasId<int>, IAddressComponent, IIsoAbbreviable, IAbbreviable, IThreeCharacterAbbrevation, ITwoCharacterAbbreviation
    {
    }
}