using System.Linq;

namespace DesignPatterns.Builders
{
    public class ShoppingListSectionBuilder : FunctionalBuilder<Section, ShoppingListSectionBuilder>
    {
        public ShoppingListSectionBuilder WithDescription(string description) => AppendAction(group => @group.Description = description);

        public ShoppingListSectionBuilder AppendItem(string name, int amount) =>
            AppendAction(group =>
            {
                var item = @group.Items.FirstOrDefault(existentItem => existentItem.Name == name);
                if (item is null) @group.Items.Add(new Item {Name = name, Amount = amount});
                else item.Amount += amount;
            });
    }
}