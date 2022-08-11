namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial struct Capacitor 
    : Archetype.IComponent<Capacitor>, 
      Archetype.IComponent.IAmLinkedTo<CapacitorData>, 
      IComponent.IUseDefaultUniverse
  {

    /// <summary>
    /// You can use this syntax to modify the builder info for a component, while using a new builder factory if you want.
    /// </summary>
    static Capacitor() {
      Components<Capacitor>.Factory = new Factory {
        // builder constructor is directly get/settable for factories as long as it's before archetype loading is done for this universe
        BuildrCtor
          = (type, @params, universe) => new IComponent<Capacitor>.Builder(type, @params, null, universe) {}
      };
    }

    public int DefaultCapacityValue {
      get;
      private set;
    }

    IModel IModel.OnInitialized(Archetype archetype, Universe universe, Meep.Tech.XBam.IBuilder builder) {
      DefaultCapacityValue
        = builder.Get<int>(nameof(DefaultCapacityValue));

      return this;
    }

    /// <summary>
    /// We set this the simplest way we can;
    /// </summary>
    CapacitorData Archetype.IComponent.IAmLinkedTo<CapacitorData>.BuildDefaultModelComponent(
      IComponent.IBuilder builder,
      Universe universe
    ) => new (
      builder.Get<int>("capacitorValue")
    );
  }
}
