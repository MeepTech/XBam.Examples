using System;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial class ModularFluxCapacitor {

    /// <summary>
    /// Device base archetype
    /// </summary>
    public new class Type : FluxCapacitor.Type {

      protected override Func<IBuilder, IModel> ModelConstructor
        => builder => new ModularFluxCapacitor();

      protected Type()
        : base(new Identity("Unsafe Modular Flux Capacitor")) { }
    }
  }
}
