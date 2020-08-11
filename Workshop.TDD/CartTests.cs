using System;
using Workshop.TDD.ObjectMothers;
using Xunit;

namespace Workshop.TDD
{
    public class CartTests
    {
        /*
         Consider an e-commerce system. Suppose a Dove Soap costs 39.99. Add 5 Dove Soaps to an empty cart, and the cart total should equal 199.95.
        */

        public CartTests()
        {

        }
        [Fact]
        public void Total_5ItemsAddedToCart_ReutrnsCorrectTotal()
        {
            //Arrange
            var cart = new Cart();
            var products = Products.DoveSoap();
            var numberOfItems = 5;

            //Act
            cart.AddItems(products, numberOfItems);
            var cartTotal = cart.CalculateTotal();

            //Assert
            Assert.Equal(5, cart.Items.Count);
            Assert.Equal(199.95, cartTotal);
        }
    }
}
