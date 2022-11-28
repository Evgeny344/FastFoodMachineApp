using FastFoodMachineApp.ProductInfo;

namespace FastFoodMachineApp
{
    public partial class ChoiceDrink : Form
    {
        public ChoiceDrink()
        {
            InitializeComponent();
        }
        private void AddProduct(Product product)
        {
            Order.AddProduct(product);
            AddToDrink form = new AddToDrink(product);
            form.Show();
            Close();
        }

        private void Latte_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Latte);
        }

        private void BlackTea_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.BlackTea);
        }

        private void GreenTea_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.GreenTea);
        }

        private void Cappuccino_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Cappuccino);
        }

        private void Espresso_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Espresso);
        }
    }
}
