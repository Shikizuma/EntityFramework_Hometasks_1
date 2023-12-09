using Microsoft.IdentityModel.Tokens;

namespace EntityFramework_Hometask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            using (AppContext context = new AppContext())
            {
                products = context.Products.ToList();
            }

            if (products.IsNullOrEmpty())
            {
                ProductFactory factory = new ProductFactory();
                for (int i = 1; i <= 10; i++)
                {
                    products.Add(factory.CreateProduct(i));
                }

                using (AppContext context = new AppContext())
                {
                    context.Products.AddRange(products);
                    context.SaveChanges();
                }
            }
           
            ProductOperations operations = new ProductOperations(products);

            int indexId1 = operations.FindIndexById(Guid.Parse("bddcf2cf-4ba2-422f-8f5c-273f79a3d178"));
            int indexId5 = operations.FindIndexById(Guid.Parse("c4bfd94c-67da-4086-8f68-9ab8f38ed75e"));

            Console.WriteLine($"Index by Id: {indexId1}");
            Console.WriteLine($"Index by Id: {indexId5}");

            int indexName0 = operations.FindIndexByName("Product3");
            int indexName7 = operations.FindIndexByName("Product1");

            Console.WriteLine($"Index by Name: {indexName0}");
            Console.WriteLine($"Index by Name: {indexName7}");

        }
    }
}