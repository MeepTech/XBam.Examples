using Meep.Tech.XBam.Examples.Enumerations;
using System.Linq;
using static Meep.Tech.XBam.Configuration.Loader.Settings;

namespace Meep.Tech.XBam.Examples.SplayedArchetype {

  /// <summary>
  /// The Base Model for all Stickers
  /// </summary>
  public class Sticker : Model<Sticker, Sticker.Type>, IModel.IUseDefaultUniverse {

    /// <summary>
    /// The Base Archetype for Stickers
    /// </summary>
    [DoNotBuildInInitialLoad]
    public class Type 
      : Archetype<Sticker, Sticker.Type>,
        Archetype.ISplayed<FruitType, Type>,
        Archetype.ISplayed<TreeType, Type>
    {

      /// <summary>
      /// Used to make new Child Archetypes for Sticker.Type 
      /// </summary>
      /// <param name="id">The unique identity of the Child Archetype</param>
      protected Type(Identity id, Universe universe)
        : base(id, universe) { }

      FruitType ISplayed<FruitType, Type>.AssociatedEnum {
        get => _enum as FruitType;
        set => _enum = value;
      }

      TreeType ISplayed<TreeType, Type>.AssociatedEnum { 
        get => _enum as TreeType;
        set => _enum = value;
      } Enumeration _enum;

      Type ISplayed<FruitType, Type>.ConstructArchetypeFor(FruitType enumeration, Universe universe) {
        return new Type(
          new Identity(enumeration.ExternalId.ToString().Split('.').Last(),
          keyOverride: enumeration.ExternalId.ToString()),
          universe
        ) {
          _enum = enumeration
        };
      }

      Type ISplayed<TreeType, Type>.ConstructArchetypeFor(TreeType enumeration, Universe universe) {
        return new Type(
          new Identity(enumeration.ExternalId.ToString().Split('.').Last(),
          keyOverride: enumeration.ExternalId.ToString()),
          universe
        ) {
          _enum = enumeration
        };
      }
    }
  }
}
