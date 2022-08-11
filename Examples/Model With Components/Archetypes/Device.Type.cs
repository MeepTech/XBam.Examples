namespace Meep.Tech.XBam.Examples.ModelWithComponents {

  public partial class Device {
    /// <summary>
    /// Device base archetype
    /// </summary>
    public abstract class Type : Archetype<Device, Type>, Archetype<Device, Type>.IExposeDefaultModelBuilderMakeMethods.Fully {

      protected Type(Identity id) 
        : base(id) {}
    }
  }
}
