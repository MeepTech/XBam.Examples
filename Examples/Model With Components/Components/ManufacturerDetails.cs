using System;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial struct ManufacturerDetails
    : IModel.IComponent<ManufacturerDetails>,
      IModel.IComponent.IAmRestrictedTo<Device>,
      IComponent.IUseDefaultUniverse
  {

    [Configuration.OnInitializingInLoader]
    static void _setup(Universe universe) 
      => universe
        .Components
          .SetFactory
            <ManufacturerDetails>
              (new BuilderFactory(universe));

    public string ManufacturerName {
      get;
      private set;
    }

    public DateTime? ManufactureDate {
      get;
      private set;
    }

    public int QuantityProduced {
      get;
      private set;
    }
  }
}
