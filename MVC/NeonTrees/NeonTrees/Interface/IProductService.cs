using NeonTrees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeonTrees.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(Product product);
        public IEnumerable<Product> FilterProduct(string product_category);
    }
}
