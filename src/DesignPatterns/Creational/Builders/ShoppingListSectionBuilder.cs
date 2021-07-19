using System.Linq;

namespace DesignPatterns.Creational.Builders
{
    public class ShoppingListSectionBuilder : FunctionalBuilder<Section, ShoppingListSectionBuilder>
    {
        public ShoppingListSectionBuilder WithDescription(string description) => AppendAction(group => @group.Description = description);

        public ShoppingListSectionBuilder AppendItem(string name, int quantity) =>
            AppendAction(group =>
            {
                var item = @group.Items.FirstOrDefault(existentItem => existentItem.Name == name);
                if (item is null) @group.Items.Add(new Item {Name = name, Quantity = quantity});
                else item.Quantity += quantity;
            });
    }
}