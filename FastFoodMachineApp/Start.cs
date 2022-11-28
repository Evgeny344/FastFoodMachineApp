namespace FastFoodMachineApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void ChoiceFood_Click(object sender, EventArgs e)
        {
            ChoiceFood form = new ChoiceFood();
            form.Show();
        }

        private void ChoiceDrinks_Click(object sender, EventArgs e)
        {
            ChoiceDrink form = new ChoiceDrink();
            form.Show();
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            Order.Clear();
        }

        private void GetCost_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Order.GetCurrentCost(), "Общая стоимость", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void ToOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Order.GetResult(), "Заказ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            Order.Clear();
        }
    }
}