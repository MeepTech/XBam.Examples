namespace Meep.Tech.XBam.Examples.ModelWithComponents {

  /// <summary>
  /// A device with lots of moving parts
  /// </summary>
  public partial class Device 
    : Model<Device, Device.Type>.WithComponents 
  {

    protected Device()
      : base() { }
  }
}