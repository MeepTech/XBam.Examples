namespace Meep.Tech.XBam.Examples.ModelWithArchetypes {
  public class Apple : Item.Type {

    public new static Item.Type.Identity Id {
      get;
    } = new Archetype<Item, Item.Type>.Identity("Apple");

    public Apple(string test) : base(Id) { }

    Apple() : base(Id) { }
  }
}
