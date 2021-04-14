using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanCode._8.ComplexConditions
{
    // RATING: STRONGLY RECOMMENDED/ESSENTIAL
    public class What : IRunnable
    {
        private readonly Item _item = new("Lord of Rings", "product", "in_stock");

        private readonly List<Item> _items = new()
        {
            new Item("Lord of Rings", "product", "in_stock"),
            new Item("What am I doing here?", "post", "in_stock")
        };

        public void Run()
        {
            // things start off with good intentions
            if (_item.Type == "product")
            {
                //do something
            }
    
            var productsForSale = _items.Where(x => x.Type == "product").ToList();

            Console.WriteLine($"There are {productsForSale.Count} products for sale");
        }

        public void Main2()
        {
            // then things start to happen
            if (_item.Type == "product" && (_item.Availability == "in_stock" || _item.Availability == "pre_order"))
            {
                //do something
            }


            var productsForSale = _items
                .Where(x => x.Type == "product" && (x.Availability == "in_stock" || x.Availability == "pre_order"))
                .ToList();

            Console.WriteLine($"There are {productsForSale.Count} products for sale");
            // this is just a mess, even if you ignore the "Magic Strings"
        }

        public void Main3()
        {
            if (CanPurchaseItem(_item))
            {
                //do something
            }

            var productsForSale = _items.Where(CanPurchaseItem).ToList();

            Console.WriteLine($"There are {productsForSale.Count} products for sale");
        }

        public bool CanPurchaseItem(Item item)
        {
            return item.Type == "product"
                   && (item.Availability == "in_stock" || item.Availability == "pre_order");
        }
    }

    public record Item(string Name, string Type, string Availability);
}