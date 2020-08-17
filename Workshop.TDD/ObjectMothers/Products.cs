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

        public static Product AxeDeodrant()
        {
            return new Product()
            {
                Name = "Axe Deodrant",
                Price = 99.99
            };
        }
    }
}
