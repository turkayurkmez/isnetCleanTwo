namespace SRP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            AddProduct(name, price);

        }

        private void AddProduct(string name, decimal price)
        {
            var affectedRows = new ProductService().AddProduct(name, price);
            var message = affectedRows > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);
        }
    }
}