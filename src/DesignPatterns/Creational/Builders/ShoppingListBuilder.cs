using System;

namespace DesignPatterns.Creational.Builders
{
    public class ShoppingListBuilder : FunctionalBuilder<ShoppingList, ShoppingListBuilder>
    {
        private readonly ShoppingListSectionBuilder _shoppingListSectionBuilder;

        public ShoppingListBuilder(ShoppingListSectionBuilder shoppingListSectionBuilder = default) 
        {
            _shoppingListSectionBuilder = shoppingListSectionBuilder ?? new ShoppingListSectionBuilder();
        }

        public ShoppingListBuilder WithTitle(string title) => AppendAction(statement => statement.Title = title);

        public ShoppingListBuilder AppendGroup(Func<ShoppingListSectionBuilder, ShoppingListSectionBuilder> builderFunction)
        {
            var group = builderFunction.Invoke(_shoppingListSectionBuilder).Build();

            AppendAction(statement => statement.Sections.Add(group));

            _shoppingListSectionBuilder.Clear();

            return this;
        }

        public sealed override void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposing) return;
            
            _shoppingListSectionBuilder?.Dispose();

            base.Dispose(true);
        }
    }
}