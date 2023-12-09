using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Hometask_1
{
    public class ProductOperations
    {
        private List<Product> _products;

        public ProductOperations(List<Product> products)
        {
            _products = products;
        }

        public int FindIndexById(Guid id)
        {
            return _products.FindIndex(product => product.Id == id);
        }

        public int FindIndexByName(string name)
        {
            return _products.FindIndex(product => product.Name == name);
        }
    }
}
