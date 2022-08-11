using System.Collections.Generic;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {

  public class MiniBuiltCapacitor : FluxCapacitor {

    [Branch]
    public new class Type : FluxCapacitor.Type {

      protected override IReadOnlyDictionary<string, IComponent> InitialComponents
        => base.InitialComponents
          .Append(Components<InfoComponent>.Factory.Make((nameof(InfoComponent.DefaultText), "Default Info")));

      protected Type() 
        : base(new(nameof(MiniBuiltCapacitor))) { }
    }
  }
}