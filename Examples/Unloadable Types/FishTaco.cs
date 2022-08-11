namespace Meep.Tech.XBam.Examples.UnloadableArchetypes {
  public class FishTaco : LoadableItem.Type {

    public new static Identity Id {
      get;
    } = new Identity("Fish Taco");

    internal FishTaco() 
      : base(Id) {}
  }
}
