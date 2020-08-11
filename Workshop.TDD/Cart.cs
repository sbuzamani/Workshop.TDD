using System;
using System.Collections.Generic;

namespace Workshop.TDD
{
    public class Cart
    {
        public List<IProduct> Items { get; set; }
        public Cart()
        {
            Items = new List<IProduct>();
        }

        public void AddItems(IProduct products, int numberOfItems)
        {
            for (int i = 0; i < numberOfItems; i++)
            {
                Items.Add(products);
            }
        }

        public double CalculateTotal()
        {
            var total = 0.00;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return Math.Round(total,2);
        }
    }
}
