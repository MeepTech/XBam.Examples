using System;

namespace Meep.Tech.XBam.Examples.ModelWithComponents {

  public partial class DangerousModularDevice {

    public new class Type : Device.Type {

      protected override Func<IBuilder<Device>, Device> ModelConstructor
        => builder => new DangerousModularDevice();

      protected Type()
        : base(new Identity("Dangerous Modular")) { }
    }
  }
}
