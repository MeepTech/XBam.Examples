using System;

namespace Meep.Tech.XBam.Examples.SimpleModelsWithOneFactory {
  public class WorldFactory : IModel<World>.Factory {
    internal WorldFactory() 
      : base(
        new(nameof(WorldFactory)),
        null,
        new() {
          Components<TestArchetypeData>.Factory.Make()
        },
        new Func<IBuilder, IModel.IComponent>[] {
          builder => Components<TestModelData>.Factory.Make()
        }
      ) {}
  }
}
