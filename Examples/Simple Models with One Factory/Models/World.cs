namespace Meep.Tech.XBam.Examples.SimpleModelsWithOneFactory {
  public class World : Model<World>.WithComponents, IModel.IUseDefaultUniverse {
    static World() {
      Models<World>.Factory = new WorldFactory();
    }

    World() { }
  }
}
