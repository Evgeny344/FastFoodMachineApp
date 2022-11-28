namespace FastFoodMachineApp.ProductInfo
{
    internal static class ProductPrice
    {
        [Product(Product.Latte)]
        private const int latte = 180;
        [Product(Product.BlackTea)]
        private const int blackTea = 40;
        [Product(Product.GreenTea)]
        private const int greenTea = 40;
        [Product(Product.Cappuccino)]
        private const int cappuccino = 190;
        [Product(Product.Espresso)]
        private const int espresso = 150;

        [Product(Product.Milk)]
        private const int milk = 10;
        [Product(Product.Syrup)]
        private const int syrup = 20;
        [Product(Product.Sugar)]
        private const int sugar = 5;

        [Product(Product.Bread)]
        private const int bread = 10;
        [Product(Product.Bun)]
        private const int bun = 20;
        [Product(Product.Sandwich)]

        private const int sandwich = 40;
        [Product(Product.Cheese)]
        private const int cheese = 10;
        [Product(Product.Ham)]
        private const int ham = 15;
        [Product(Product.Jam)]
        private const int jam = 15;

        private const int discountProcents = 15;
        static internal int Lunch => GetLunch(sandwich, blackTea, sugar, jam);
        static int GetLunch(params int[] products)
        {
            return products.Sum()* (100 - discountProcents)/100;
        }
        
    }
}
