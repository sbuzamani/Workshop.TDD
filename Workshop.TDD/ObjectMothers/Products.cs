namespace Workshop.TDD.ObjectMothers
{
    public static class Products
    {
        public static Product DoveSoap()
        {
            return new Product()
            {
                Name = "Dove Soap",
                Price = 39.99

            };
        }
    }
}
