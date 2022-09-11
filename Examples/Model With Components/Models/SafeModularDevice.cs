namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  public partial class SafeModularDevice : Device {

    protected SafeModularDevice() 
      : base() {}

    /// <summary>
    /// Allow this device to add any type of component made for any device.
    /// </summary>
    public void AddComponent(IModel.IComponent.IAmRestrictedTo<Device> component) {
      base.AddComponent(component);
    }
  }
}
