namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial struct Capacitor {
    public class Factory : IComponent<Capacitor>.Factory {

      internal Factory(Universe universe) 
        : base(new Identity("Capacitor Builder"), universe) { }

      protected override Capacitor OnModelInitialized(IBuilder<Capacitor> builder, Capacitor model) {
        model = base.OnModelInitialized(builder, model);
        model.DefaultCapacityValue
          = builder.Get<int>(nameof(DefaultCapacityValue));

        return model;
      }
    }
  }
}
