namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial struct Capacitor {
    public class Factory : IComponent<Capacitor>.Factory {

      internal Factory() 
        : base(new Identity("Capacitor Builder")) { }

      protected override Capacitor ConfigureModel(IBuilder<Capacitor> builder, Capacitor model) {
        model = base.ConfigureModel(builder, model);
        model.DefaultCapacityValue
          = builder.Get<int>(nameof(DefaultCapacityValue));

        return model;
      }
    }
  }
}
