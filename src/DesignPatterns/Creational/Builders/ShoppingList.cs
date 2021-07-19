using System.Collections.Generic;

namespace DesignPatterns.Creational.Builders
{
    public class ShoppingList
    {
        public string Title { get; set; }

        public List<Section> Sections { get; set; } = new ();
    }

    public class Section  
    {
        public string Description { get; set; }

        public List<Item> Items { get; set; } = new ();
    }

    public class Item
    {
        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}