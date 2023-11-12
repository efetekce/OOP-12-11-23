namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryID = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryID = 3,
                UnitsInStock = 4,
                ProductName = "Kalem",
                UnitPrice = 500,
            };
            // PascalCase in class names
            // camelCase in variable 
            // to create reference types, we must use the new keyword.

            // ProductManager productManager = new ProductManager();
            // productManager.Add(product2);
            // Console.WriteLine(product2.ProductName);

            // int number = 100;
            // productManager.Test(number);
            // Console.WriteLine(number);



        }
    }
}