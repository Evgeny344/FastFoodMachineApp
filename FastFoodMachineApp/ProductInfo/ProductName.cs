namespace FastFoodMachineApp.ProductInfo
{
    internal static class ProductName
    {
        [Product(Product.Latte)]
        private const string latte = "Латте(эспрессо + молоко)";
        [Product(Product.BlackTea)]
        private const string blackTea = "Чёрный чай";
        [Product(Product.GreenTea)]
        private const string greenTea = "Зелёный чай";
        [Product(Product.Cappuccino)]
        private const string cappuccino = "Капучино (эспрессо + молоко + молочная пенка)";
        [Product(Product.Espresso)]
        private const string espresso = "Эспрессо";

        [Product(Product.Milk)]
        private const string milk = "Молоко";
        [Product(Product.Syrup)]
        private const string syrup = "Сироп";
        [Product(Product.Sugar)]
        private const string sugar = "Сахар";

        [Product(Product.Bread)]
        private const string bread = "Хлеб";
        [Product(Product.Bun)]
        private const string bun = "Булочка";
        [Product(Product.Sandwich)]
        private const string sandwich = "Бутерброд(хлеб + ветчина + сыр)";

        [Product(Product.Cheese)]
        private const string cheese = "Сыр";
        [Product(Product.Ham)]
        private const string ham = "Ветчина";
        [Product(Product.Jam)]
        private const string jam = "Джем";

        static internal string Lunch => GetLunch(sandwich, blackTea, sugar, jam);
        private static string GetLunch(params string[] products)
        {
            var lunch = "Комплексный обед: ";
            foreach (var product in products)
            {
                lunch += product + ", ";
            }
            return lunch;
        }
    }
}
