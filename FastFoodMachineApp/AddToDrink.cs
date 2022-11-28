using FastFoodMachineApp.ProductInfo;

namespace FastFoodMachineApp
{
    public partial class AddToDrink : Form
    {
        public AddToDrink(Product product)
        {
            InitializeComponent();
            Sugar.Visible = ProductConstraint.AllowedToAddSugar(product);
            Syrup.Visible = ProductConstraint.AllowedToAddSyrup(product);
            Milk.Visible = ProductConstraint.AllowedToAddMilk(product);
        }
        private void AddProduct(Product product)
        {
            Order.AddProduct(product);
            Close();
        }

        private void AddToDrink_Load(object sender, EventArgs e)
        {
            
        }

        private void Syrup_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Syrup);
        }

        private void Milk_CheckedChanged(object sender, EventArgs e)
        {
            AddProduct(Product.Milk);
        }

        private void Sugar_CheckedChanged(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.Location = new Point(200, 80);
            listBox.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            Controls.Add(listBox);
            listBox.SelectedIndexChanged += delegate
            {
                var portion = int.Parse(listBox.SelectedItem.ToString());
                for (int i = 0; i < portion; i++)
                {
                    AddProduct(Product.Sugar);
                }
            };
        }
    }
}
