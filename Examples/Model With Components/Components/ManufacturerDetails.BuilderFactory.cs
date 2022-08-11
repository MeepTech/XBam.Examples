using System;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial struct ManufacturerDetails {
    /// <summary>
    /// You can also make the builder and just provide it yourself in the static ctor
    /// </summary>
    public class BuilderFactory : IComponent<ManufacturerDetails>.Factory {

      public static new Identity Id {
        get;
      } = new Identity("Capacitor Builder");

      internal BuilderFactory() 
        : base(Id) { }

      protected override ManufacturerDetails ConfigureModel(IBuilder<ManufacturerDetails> builder, ManufacturerDetails model) {
        model = base.ConfigureModel(builder, model);
        model.ManufacturerName = builder.Get<string>(nameof(ManufacturerName));
        model.ManufactureDate = builder.Get(nameof(ManufactureDate), DateTime.Now);
        model.QuantityProduced = builder.Get<int>(nameof(QuantityProduced));

        return model;
      }
    }
  }
}
