namespace FastFoodMachineApp.ProductInfo
{
    internal static class ProductConstraint //прежде, чем добавить один продукт к другому, нужно проверить на совместимость
    {
        internal static bool AllowedToAddMilk(Product product)
        {
            return product.AllowedToProduct(Product.Milk);
        }

        internal static bool AllowedToAddSyrup(Product product)
        {
            return product.AllowedToProduct(Product.Syrup);
        }

        internal static bool AllowedToAddSugar(Product product)
        {
            return product.AllowedToProduct(Product.Sugar);
        }

        internal static bool AllowedToAddCheese(Product product)
        {
            return product.AllowedToProduct(Product.Cheese);
        }

        internal static bool AllowedToAddHam(Product product)
        {
            return product.AllowedToProduct(Product.Ham);
        }

        internal static bool AllowedToAddJam(Product product)
        {
            return product.AllowedToProduct(Product.Jam);
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    internal class ProductConstraintAttribute : Attribute
    {
        internal Product Product { get; }
        public ProductConstraintAttribute(Product product) => Product = product;
    }
}
