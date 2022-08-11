namespace Meep.Tech.XBam.Examples.ModelWithArchetypes {
  public class Sword : Weapon.Type {

    public new static Weapon.Type.Id Id {
      get;
    } = new Id("Sword");

    Sword() 
      : base(Id, defaultDamagePerHit: 10) {}
  }
}
