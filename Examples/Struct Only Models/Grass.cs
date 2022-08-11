namespace Meep.Tech.XBam.Examples.StructOnlyModels {

  /// <summary>
  /// Grass tile
  /// </summary>
  public class Grass : Tile.Type {

    public new static Identity Id {
      get;
    } = new Identity("Grass");

    Grass() 
      : base(Id) {}
  }
}
