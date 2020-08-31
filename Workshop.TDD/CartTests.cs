using System;
using Workshop.TDD.ObjectMothers;
using Xunit;

namespace Workshop.TDD
{
    public class CartTests
    {
        public CartTests()
        {

        }
        [Fact]
        public void CalculateTotal_5DoveSoapItemsAddedToCart_ReturnsCorrectTotal()
        {
            //Arrange
            var cart = new Cart();
            var products = Products.DoveSoap();
            var numberOfItems = 5;

            //Act
            cart.AddItems(products, numberOfItems);
            
            var cartTotal = cart.CalculateTotalBeforeVat();

            //Assert
            Assert.Equal(199.95, cartTotal);
        }
        [Fact]
        public void AddItems_5DoveSoapItemsAdded_CorrectNumberOfItemsAdded()
        {
            //Arrange
            var cart = new Cart();
            var products = Products.DoveSoap();
            var numberOfItems = 5;

            //Act
            cart.AddItems(products, numberOfItems);

            //Assert
            //Assert.Single(cart.CartItems);
            Assert.Equal(5, cart.ProductsCount);
        }
        [Fact]
        public void CalculateVAT_OneItemAddedToCart_VATAmountIsCorrectPercentage()
        {
            //Arrange
            var cart = new Cart();
            var product = Products.AxeDeodrant();
            var numberOfItems = 1;

            //Act
            cart.AddItems(product, numberOfItems);
            var total = cart.CalculateTotalBeforeVat();
            var vatAmount = cart.CalculateVat(total);

            //Assert
            Assert.Equal(Math.Round(total * .125,1), vatAmount);
        }
        [Fact]
        public void CalculateTotal_AddedItemsToCart_CorrectTotalIncludingVAT()
        {
            //Arrange
            var cart = new Cart();
            var soap = Products.DoveSoap();
            var deodrant = Products.AxeDeodrant();
            var numberOfItems = 2;

            //Act
            cart.AddItems(soap, numberOfItems);
            cart.AddItems(deodrant, numberOfItems);
            var total = cart.CalculateTotalBeforeVat();
            var vatAmount = cart.CalculateVat(total);
            var totalAfterVat = cart.CalculateTotalAfterVat();
            //Assert
            Assert.Equal(314.96, totalAfterVat);
            Assert.Equal(35, vatAmount);
        }
        [Fact]
        public void DisplayCartItems_ItemsInCartDisplayed()
        {
            //Arrange
            var cart = new Cart();
            var numberOfItems = 2;
            var soap = Products.DoveSoap();

            //Act
            cart.AddItems(soap, numberOfItems);
            var cartItems = cart.DisplayCartItems();

            //Assert
            Assert.Equal("Dove Soap - 39,99 Qty: 2", cartItems);
        }
    }
}
