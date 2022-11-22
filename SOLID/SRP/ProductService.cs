namespace SRP
{
    public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            //aşağıdaki bağlantı cümlesi; bir Environment Value'da saklanmalı ve oradan okunmalı.
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";
            var commandText = "Insert into Products (ProductName, UnitPrice) values (@name,@price)";

            Dictionary<string, object> commandParams = new Dictionary<string, object>();
            commandParams.Add("@name", name);
            commandParams.Add("@price", price);

            //SqlConnection sqlConnection = new SqlConnection();

            //SqlCommand command = new SqlCommand(, sqlConnection);
            //command.Parameters.AddWithValue("@name", name);
            //command.Parameters.AddWithValue("@price", price);

            //sqlConnection.Open();
            //var affectedRows = command.ExecuteNonQuery();
            //sqlConnection.Close();

            ADOHelper helper = new ADOHelper(connectionString);
            var affectedRows = helper.Execute(commandText, commandParams);

            return affectedRows;
        }
    }
}
