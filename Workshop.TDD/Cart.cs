using System;
using System.Collections.Generic;

namespace Workshop.TDD
{
    public class Cart
    {
        private List<CartItem> Items { get; set; }
        public int ProductsCount { get; set; }

        private const double VatPercentage = 0.125;

        public Cart()
        {
            Items = new List<CartItem>();
        }

        public void AddItems(Product product, int numberOfItems)
        {
            var cartItem = new CartItem
            {
                ProductName  = product.Name,
                ProductPrice = product.Price,
                Quantity = numberOfItems
            };
            Items.Add(cartItem);
            ProductsCount += cartItem.Quantity;
        }

        public double CalculateTotalBeforeVat()
        {
            var total = 0.00;
            foreach (var item in Items)
            {
                total += (item.ProductPrice * item.Quantity);
                total = Math.Round(total, 2);
            }
            return total;
        }

        public double CalculateVat(double total)
        {
            return Math.Round(total * VatPercentage, 1);
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
                cartItems += $"{item.ProductName} - {item.ProductPrice} Qty: {item.Quantity}";
            }
            return cartItems;
        }
    }
}
