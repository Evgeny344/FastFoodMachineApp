using FastFoodMachineApp.ProductInfo;

namespace FastFoodMachineApp
{
    public partial class ChoiceFood : Form
    {
        public ChoiceFood()
        {
            InitializeComponent();
        }

        private void AddProduct(Product product)
        {
            Order.AddProduct(product);
            if (product != Product.Lunch)
            {
                AddToFood form = new AddToFood(product);
                form.Show();
            }
            Close();
        }

        private void Bread_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Bread);
        }

        private void Sandwich_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Sandwich);
        }

        private void Bun_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Bun);
        }

        private void Lunch_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Lunch);
        }
    }
}
