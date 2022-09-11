using System;
using System.Collections.Generic;

namespace Meep.Tech.XBam.Examples.Examples.AutoTesting {

  /// <summary>
  /// The Base Model for all Candys
  /// </summary>
  public class Candy : Model<Candy, Candy.Type>, IModel.IUseDefaultUniverse {

    [AutoBuild(IsRequiredAsAParameter = true, NotNull = true)]
    [TestValue("Test")]
    public virtual string Name { get; protected set; }

    [AutoBuild(IsRequiredAsAParameter = true)]
    [TestValue(4)]
    public int QuantityPerPackage { get; private set; }

    [AutoBuild(IsRequiredAsAParameter = true, NotNull = true)]
    [TestValueIsEmptyEnumerable]
    public IEnumerable<string> Flavors { get; private set; }

    [AutoBuild(IsRequiredAsAParameter = true, NotNull = true)]
    [TestValueIsNew]
    public Dictionary<string, object> Qualities { get; private set; }

    [AutoBuild(IsRequiredAsAParameter = true, NotNull = true)]
    [GetTestValueFromMember(nameof(_getTestManufacturerName))]
    public string ManufacturerName { get; private set; }

    [GetTestValueFromMember(nameof(_getTestDateManufacuted))]
    [AutoBuild(IsRequiredAsAParameter = true)]
    public DateTime DateManufactured { get; private set; }

    [GetTestValueFromMember(nameof(_testInternalId))]
    [AutoBuild(IsRequiredAsAParameter = true)]
    public int InternalId { get; private set; }

    [GetTestValueFromMember(nameof(_testCost))]
    [AutoBuild(IsRequiredAsAParameter = true)]
    public int Cost { get; private set; }

    static string _getTestManufacturerName(Archetype a) => $"m-{a.Id.Name}";
    static DateTime _getTestDateManufacuted() => new DateTime(1, 1, 1);

    static int _testInternalId {
      get;
    } = 100;

    readonly static int _testCost = 4;

    protected Candy() { }

    /// <summary>
    /// The Base Archetype for Candys
    /// </summary>
    public abstract class Type : Archetype<Candy, Candy.Type> {

      /// <summary>
      /// Used to make new Child Archetypes for Candy.Type 
      /// </summary>
      /// <param name="id">The unique identity of the Child Archetype</param>
      protected Type(Identity id)
        : base(id) { }
    }
  }

	public class ChocolateBar : Candy.Type {

	  ChocolateBar() 
      : base(new(nameof(ChocolateBar))) {}
	}

	public class Gumdrops : Candy {

		[TestValue("Gum-Test")]
		public override string Name {
      get;
      protected set;
		}

    [AutoBuild(ParameterName = "Sugary", IsRequiredAsAParameter = true)]
    [TestValue(true)]
    public bool IsSugarCoated {
      get;
      private set;
    }

    Gumdrops() : base() { }

		[Branch]
		public new class Type : Candy.Type {
		   Type() 
          : base(new(nameof(Gumdrops))) {}
		}
	}

  public class Jellybean : Candy {

    [AutoBuild(IsRequiredAsAParameter = true)]
    [TestValue(true)]
    public bool IsShiny {
      get;
      private set;
    }

    internal Jellybean() : base() { }
  }

  public class JellybeanType : Candy.Type {

    JellybeanType() 
      : base(new(nameof(Jellybean))) {
        ModelInitializer = _ => new Jellybean();
      }
  }
}
