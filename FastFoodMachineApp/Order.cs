using FastFoodMachineApp.ProductInfo;
using System.Text;

namespace FastFoodMachineApp
{
    public static class Order
    {
        private const string currency = "руб";
        private const string costLine = "Общая сумма";
        private const string noticeLine = "Невозможно выполнить заказ, выберете продукты из меню";

        private static int cost;
        private static StringBuilder content = new StringBuilder(100);     
        private static Dictionary<string, int> productsCount = new Dictionary<string, int>();

        static public void AddProduct(Product product)
        {
            var productName = (product == Product.Lunch) ? ProductName.Lunch : product.GetProductInfo<string>(typeof(ProductName));
            var productPrice = (product == Product.Lunch) ? ProductPrice.Lunch : product.GetProductInfo<int>(typeof(ProductPrice));

            if (productsCount.ContainsKey(productName))
                productsCount[productName] += 1;
            else
                productsCount.Add(productName, 1);

            cost += productPrice;
        }

        static public string GetResult()
        {
            if (productsCount.Count == 0)
            {
                return noticeLine;
            }
            foreach (var prod in productsCount)
            {
                content.AppendLine(prod.Key + " x" + prod.Value);
            }
            content.AppendLine(GetCurrentCost());
            return content.ToString();
        }

        static public string GetCurrentCost()
        {
            return costLine + " " + cost.ToString() + " " + currency;
        }

        static public void Clear()
        {
            productsCount.Clear();
            content.Clear();
            cost = default(int);
        }
    }
}
