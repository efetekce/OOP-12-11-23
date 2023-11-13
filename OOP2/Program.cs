namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Name = "Efe";
            //customer1.LastName = "Tekce";
            //customer1.Id = 1;
            //customer1.TCKN = "22222222222222";
            //customer1.CompanyName = "?";

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.CustomerNumber = "12345";
            customer1.Name = "Hasan";
            customer1.LastName = "Hasanov";
            customer1.TCKN = "12312344";
            customer1.Id = 1;

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "123456789";
            customer2.CompanyName = "TEKCE AS";
            customer2.TaxID = "444444";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer4);
            customerManager.Add(customer3);


        }
    }
}