using FastFoodMachineApp.ProductInfo;

namespace FastFoodMachineApp
{
    public partial class AddToFood : Form
    {
        public AddToFood(Product product)
        {
            InitializeComponent();
            Cheese.Visible = ProductConstraint.AllowedToAddCheese(product);
            Ham.Visible = ProductConstraint.AllowedToAddHam(product);
            Jam.Visible = ProductConstraint.AllowedToAddJam(product);
        }

        private void AddProduct(Product product)
        {
            Order.AddProduct(product);
            Close();
        }

        private void Cheese_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Cheese);
        }

        private void Ham_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Ham);
        }

        private void Jam_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Jam);
        }
    }
}
