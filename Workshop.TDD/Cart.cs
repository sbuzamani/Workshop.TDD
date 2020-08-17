using System;
using System.Collections.Generic;
using System.Linq;

namespace Workshop.TDD
{
    public class Cart
    {
        public List<CartItem> Items { get; set; }
        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItems(Product product, int numberOfItems)
        {
            var cartItem = new CartItem
            {
                Product  = product,
                Quantity = numberOfItems
            };
                Items.Add(cartItem);
        }

        public double CalculateTotalBeforeVat()
        {
            var total = 0.00;
            foreach (var item in Items)
            {
                total += (item.Product.Price * item.Quantity);
            }
            return Math.Round(total, 2);
        }

        public double CalculateVat(double total)
        {
            return Math.Round(total * 0.125, 1);
        }

        public double CalculateTotalAfterVat()
        {
            var total = CalculateTotalBeforeVat();
            var totalAfterVat = total + CalculateVat(total);
            return Math.Round(totalAfterVat,2);
        }

        public string  DisplayCartItems()
        {
            var cartItems = string.Empty;

            foreach (var item in Items)
            {
                cartItems += $"{item.Product.Name} - {item.Product.Price} Qty: {item.Quantity}";
            }
            return cartItems;
        }
    }
}
