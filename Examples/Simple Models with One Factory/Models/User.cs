using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Meep.Tech.XBam.Examples.SimpleModelsWithOneFactory {
  public class User : Model<User>, IModel.IUseDefaultUniverse {

    [AutoBuild, Required, NotNull]
    [TestValue("Jim")]
    public string Name {
      get;
      private set;
    }

    User() { }

    protected override Model<User> OnInitialized(IBuilder<User> builder) {
      if (Name == "harold") {
        Name = "was-harold";
      }

      return this;
    }
  }
}
