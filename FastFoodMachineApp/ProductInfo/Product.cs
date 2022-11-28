using System.Reflection;

namespace FastFoodMachineApp.ProductInfo
{
    public enum Product
    {
        [ProductConstraint(Milk)]
        Latte,
        BlackTea,
        GreenTea,
        [ProductConstraint(Milk)]
        Cappuccino,
        Espresso,

        Milk,
        Syrup,
        Sugar,

        Bread,
        Bun,
        [ProductConstraint(Cheese)]
        [ProductConstraint(Ham)]
        Sandwich,

        Cheese,
        Ham,
        Jam,

        Lunch
    }

    internal static class ProductExtension
    {
        internal static bool AllowedToProduct(this Product product, Product addedProduct)
        {
            var type = product.GetType();
            var member = type.GetMember(product.ToString()).Single();
            var attributes = member.GetCustomAttributes(typeof(ProductConstraintAttribute), false);
            foreach (var attribute in attributes)
            {
                var productConstraint = (ProductConstraintAttribute)attribute;
                if (productConstraint.Product == addedProduct)
                    return false;
            }
            return true;
        }

        internal static T GetProductInfo<T>(this Product product, Type typeProductInfo)
        {
            var info = default(T);
            var fields = typeProductInfo.GetRuntimeFields();
            foreach (var field in fields)
            {
                try
                {
                    var productAttribute = (ProductAttribute)field.GetCustomAttribute(typeof(ProductAttribute));
                    if (productAttribute != null && productAttribute.Product == product)
                    {
                        info = (T)field.GetValue(null);
                        break;
                    }
                }
                catch (AmbiguousMatchException)
                {
                    throw new ProductInfoException($"Элемент {field.Name} типа {typeProductInfo} имеет несколько атрибутов {typeof(ProductAttribute).Name}");
                }
            }
            if (info.Equals(default(T)))
            {
                throw new ProductInfoException($"Ни один из элементов типа {typeProductInfo} не имеет атрибут {typeof(ProductAttribute).Name} c указанием {product}");
            }
            return info;
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    internal class ProductAttribute : Attribute
    {
        internal Product Product { get; }
        public ProductAttribute(Product product) => Product = product;
    }

    class ProductInfoException : Exception
    {
        public ProductInfoException(string message)
            : base(message)
        { }
    }
}
