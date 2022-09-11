using System;
using System.Collections.Generic;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {

  public partial class FluxCapacitor {

    /// <summary>
    /// Device base archetype
    /// </summary>
    public new class Type : Device.Type {

      protected override Dictionary<string, object> DefaultTestParams 
        => new Dictionary<string, object> {
          {nameof(FluxCapacitor.FluxLevel), 0 }
        };

      protected override IReadOnlyDictionary<string, IComponent> InitialComponents 
        => base.InitialComponents.Append(
          Components<Capacitor>.Factory.Make()
        );

      protected override Func<IBuilder, IModel> ModelConstructor
        => builder => new FluxCapacitor();

      protected override Device OnModelInitialized(IBuilder<Device> builder, Device model) {
        model = base.OnModelInitialized(builder, model);

        (model as FluxCapacitor).FluxLevel 
          = builder.GetRequired<int>(nameof(FluxCapacitor.FluxLevel));

        return model;
      }

      protected Type(Identity id = null)
        : base(id ?? new FluxCapacitor.Type.Identity("Flux Capacitor")) { }
    }
  }
}
