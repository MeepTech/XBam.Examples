namespace Meep.Tech.XBam.Examples.ModelWithComponents {
  /// <summary>
  /// Dangerous version, lets you delete things.
  /// </summary>
  public partial class DangerousModularDevice 
    : SafeModularDevice, 
      IWriteableComponentStorage 
  { }
}
