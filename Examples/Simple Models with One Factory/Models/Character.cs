using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Meep.Tech.XBam.Examples.SimpleModelsWithOneFactory {
  public class Character : Model<Character>.WithComponents, IModel.IUseDefaultUniverse {

    [AutoBuild, Required, NotNull]
    [TestValue("Jim")]
    public string Name {
      get;
      private set;
    }

    static Character() {
      Models<Character>.Factory = new(
        new(nameof(Character) + ".Test"),
        Universe.Default,
        new() {
          Components<TestArchetypeData>.Factory.Make()
        },
        new Func<IBuilder, IModel.IComponent>[] {
          builder => { 
            return Components<TestModelData>.Factory.Make(); 
          }
        }
      ) {};
    }

    Character() { }
  }
}
