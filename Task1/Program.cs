using EntityFramework_Hometask_1;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            ProductFactory factory = new ProductFactory();

            for (int i = 1; i <= 10; i++)
            {
                products.Add(factory.CreateProduct(i));
            }

            ProductOperations operations = new ProductOperations(products);

            int indexId1 = operations.FindIndexById(products[1].Id);
            int indexId5 = operations.FindIndexById(products[5].Id);

            Console.WriteLine($"Index by Id: {indexId1}");
            Console.WriteLine($"Index by Id: {indexId5}");

            int indexName0 = operations.FindIndexByName("Product1");
            int indexName7 = operations.FindIndexByName("Product8");

            Console.WriteLine($"Index by Name: {indexName0}");
            Console.WriteLine($"Index by Name: {indexName7}");
        }
    }
}