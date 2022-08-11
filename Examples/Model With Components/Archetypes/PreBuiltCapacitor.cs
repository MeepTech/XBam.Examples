using System;
using System.Collections.Generic;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {

  public class PreBuiltCapacitor : FluxCapacitor.Type {

    protected override IReadOnlyDictionary<string, IComponent> InitialComponents 
      => base.InitialComponents
        .Append(Components<InfoComponent>.Factory.Make((nameof(InfoComponent.DefaultText),  "Default Info")));

    protected override IReadOnlyDictionary<string, Func<IComponent.IBuilder, IModel.IComponent>> InitialUnlinkedModelComponents 
      => base.InitialUnlinkedModelComponents
        .Append<CapacitorDetector>()
        .Append<DisplayComponent>();

    protected PreBuiltCapacitor() : base(new(nameof(PreBuiltCapacitor))) { }
  }
}
