using static Meep.Tech.XBam.Configuration.Loader.Settings;

namespace Meep.Tech.XBam.Examples.UnloadableArchetypes {
  [DoNotBuildInInitialLoad]
  public class BeefJerkey : LoadableItem.Type {

    public new static Identity Id {
      get;
    } = new Identity("Beef Jerkey");

    public BeefJerkey() 
      : base(Id) {}
  }
}
