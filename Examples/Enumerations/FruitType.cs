using Meep.Tech.XBam.Configuration;

namespace Meep.Tech.XBam.Examples.Enumerations {
  public class FruitType : Enumeration<FruitType> {

    public static FruitType Apple { get; }
      = new FruitType(nameof(Apple));

    public static FruitType Pear { get; }
      = new FruitType(nameof(Pear));

    public static FruitType Cherry { get; }
      = new FruitType(nameof(Cherry));

    public FruitType(string name) 
      : base(name) {}
  }

  [BuildAllDeclaredEnumValuesOnInitialLoad]
  public static class AdditionalFruitTypes {

    public static FruitType Melon { get; }
      = new FruitType(nameof(Melon));

  }

  public static class LazyAdditionalFruitTypes {

    public static FruitType Banana { get; }
      = new FruitType(nameof(Banana));

  }
}
