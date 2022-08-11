using System.ComponentModel.DataAnnotations.Schema;

namespace Meep.Tech.XBam.Examples.ModelWithArchetypes {
  public class Item : Model<Item, Item.Type>, IUnique {

    protected Item() {}

    [field: Column(nameof(IUnique.Id))]
    string IUnique.Id {
      get;
      set;
    }

    public abstract class Type : Archetype<Item, Item.Type>.WithAllDefaultModelBuilders {

      protected Type(Archetype.Identity id) 
        : base(id) {}
    }
  }
}
