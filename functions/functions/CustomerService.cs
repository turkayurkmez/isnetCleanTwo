namespace functions
{
    //Bir fonksiyon, birim zamanda yalnızca 1 iş yapmalı.
    //MÜMKÜNSE bir satırda yapmalı
    public class CustomerService
    {
        private List<Customer> customers;
        public CustomerService()
        {
            customers = new List<Customer>()
            {
                new(){ Id=1, Name="Türkay Ürkmez", Country="Türkiye", Address=new Address(), EmailAddress="abc@xyz.com", Rating=4.6},

                new(){ Id=2, Name="John Doe", Country="İngiltere", Address=new Address(), EmailAddress="abd@xyz.com", Rating=4.1},

                new(){ Id=3, Name="Jane Doe", Country="Fransa", Address=new Address(), EmailAddress="abe@xyz.com", Rating=4.4},
            };
        }

        public Customer GetCustomerById(int id)
        {
            //kirli:
            Customer existingCustomer = null;
            foreach (var customer in customers)
            {
                if (customer.Id == id)
                {
                    existingCustomer = customer;
                }
            }
            return existingCustomer;
        }

        public Customer GetCustomerByIdWithLinq(int id) => customers.FirstOrDefault(customer => customer.Id == id);


        public int TotalCustomersInCountry(string country) => customers.Count(cust => cust.Country == country);


        /// <summary>
        /// verilen id değerine sahip ürünün olup olmadığını kontrol eder.
        /// </summary>
        /// <param name="id">denetlenecek ürün id'si</param>
        /// <returns></returns>
        public bool ProductIsExist(int id)
        {
            return customers.Any(cust => cust.Id == id);
        }

        public void AddCustomer(string name, Address customerAddress, string email, double rating)
        {

        }

        public void AddCustomer(Customer customer)
        {

        }

        public void ChangeCustomerAddress(int customerId, Address newAddress)
        {
            customers.FirstOrDefault(customer => customer.Id == customerId).Address = newAddress;

        }

        public void AddProductToGallery(Customer customer)
        {
            if (customer.IsInRole("Celler"))
            {
                ///....
            }
        }

        public List<Customer> SearchCustomerByName(string name, bool isCaseSensitive)
        {
            return isCaseSensitive ? customers.Where(cust => cust.Name.Contains(name)).ToList()
                                     :
                                     customers.Where(cust => cust.Name.ToLower().Contains(name.ToLower())).ToList();


        }



    }
}
